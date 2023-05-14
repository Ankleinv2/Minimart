using ManageMiniMart.BLL;
using ManageMiniMart.Custom;
using ManageMiniMart.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace ManageMiniMart.View
{
    public delegate void EmployeeDelegate(string personId);
    public partial class AddShiftWorkForm : Form
    {
        private EmployeeService employeeService;
        private ShiftDetailService shiftDetailService;
        private ShiftWorkService shiftWorkService;
        private List<Person> employeeList;

        public AddShiftWorkForm()
        {
            InitializeComponent();
            employeeService = new EmployeeService();
            shiftDetailService = new ShiftDetailService();
            shiftWorkService = new ShiftWorkService();
            employeeList = new List<Person>();
            lblShiftId.Text = "";
            dtpShiftDate.Value = DateTime.Now;
            dtpStartTime.Value =DateTime.Parse( DateTime.Now.ToShortTimeString());
            dtpEndTime.Value= DateTime.Parse(DateTime.Now.ToShortTimeString());
        }

        public void reloadDgvEmployee()                             // Đưa employeeList vào dgvEmployee
        {
            dgvEmloyee.DataSource = null;
            dgvEmloyee.DataSource = employeeList;
        }
        public bool checkEmployeeExist(string personId)
        {
            bool check = false;
            foreach (Person person in employeeList)
            {
                if (person.person_id.Equals(personId))
                {
                    check = true;
                }
            }
            return check;
        }
        public void addEmployee(string personId)
        {
            Person person = employeeService.getEmployeeById(personId);
            if (person != null && !checkEmployeeExist(personId))                // tìm ra person và employeeList chưa có person
            {
                employeeList.Add(person);                                   // thì Add person vào employeeList
            }
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            string employeeName = txtEmployeeName.Text;
            SelectEmployeeForm selectEmployeeForm = new SelectEmployeeForm(addEmployee);
            selectEmployeeForm.setEmployeeByName(employeeName);
            selectEmployeeForm.ShowDialog();
            reloadDgvEmployee();
        }
        public void setFormAddShift(int shift)                      // Để edit
        {
            Shift_detail shift_Detail = shiftDetailService.getShift_detailById(shift);
            List<string> personIds = shiftWorkService.getAllPersonID_By_ShiftDetailID(shift);
            foreach (string personId in personIds)
            {
                addEmployee(personId);
            }
            txtShiftName.Text = shift_Detail.shift_name;
            dtpShiftDate.Value = shift_Detail.shift_date;
            dtpStartTime.Value = DateTime.Parse(shift_Detail.start_time.ToString());
            dtpEndTime.Value = DateTime.Parse(shift_Detail.end_time.ToString());

            lblShiftId.Text = shift.ToString();                     // shiftID
            reloadDgvEmployee();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtShiftName.Text == "") throw new Exception("Shift name is not empty");
            if (TimeSpan.Compare(dtpStartTime.Value.TimeOfDay, dtpEndTime.Value.TimeOfDay) >= 0) throw new Exception("End time must be Greater than Start Time");

            if (lblShiftId.Text == "")                          // Add
            { 
                bool checkShiftDetailExit = shiftDetailService.checkShiftDetailExist(dtpShiftDate.Value.Date,dtpStartTime.Value.TimeOfDay, dtpEndTime.Value.TimeOfDay);
                if (checkShiftDetailExit == true) throw new Exception("The time of this shift must be different from the time of the existing shift");
                string shiftName = txtShiftName.Text;
                DateTime shiftDate=dtpShiftDate.Value.Date;
                TimeSpan startTime = dtpStartTime.Value.TimeOfDay;
                TimeSpan endTime = dtpEndTime.Value.TimeOfDay;
                
                
                Shift_detail shift_Detail = new Shift_detail
                {
                    shift_name = shiftName,
                    shift_date = shiftDate,
                    start_time = startTime,
                    end_time = endTime,
                };
                shiftDetailService.saveShift_detail(shift_Detail);

                int shiftId = shiftDetailService.shiftIdAdded;                  // shiftIdAdded bên shiftDetailService
                foreach (Person person in employeeList)
                {
                    string personId = person.person_id;
                    Shift_work shift_Work = new Shift_work
                    {
                        shift_id = shiftId,
                        person_id = personId,
                    };
                    shiftWorkService.saveShift_work(shift_Work);
                }
                MyMessageBox myMessageBox = new MyMessageBox();
                myMessageBox.show("Add shift work successful!", "Notification");
            }
            else                                             // Edit Shift_detail
            {
                int shiftId = Convert.ToInt32(lblShiftId.Text);
                string shiftName = txtShiftName.Text;
                DateTime shiftDate = dtpShiftDate.Value.Date;
                TimeSpan startTime = dtpStartTime.Value.TimeOfDay;
                TimeSpan endTime = dtpEndTime.Value.TimeOfDay;
                Shift_detail shift_Detail = new Shift_detail
                {
                    shift_id = shiftId,
                    shift_name = shiftName,
                    shift_date = shiftDate,
                    start_time = startTime,
                    end_time = endTime,
                };
                shiftDetailService.saveShift_detail(shift_Detail);
                //                                      Edit Shift_Work
                shiftWorkService.deleteShiftworkByShiftWorkId(shiftId);          // Delete ShiftWork
                foreach (Person person in employeeList)
                {
                    string personId = person.person_id;
                    Shift_work shift_Work = new Shift_work
                    {
                        shift_id = shiftId,
                        person_id = personId,
                    };
                    shiftWorkService.saveShift_work(shift_Work);

                }
                MyMessageBox myMessageBox = new MyMessageBox();
                myMessageBox.show("Edit shift work successful!", "Notification");
            }

            Dispose();
        }
        // Remove employee khỏi dgvEmployee
        private void dgvEmloyee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmloyee.Columns[e.ColumnIndex].Name == "Remove")
            {
                string personId = dgvEmloyee.SelectedRows[0].Cells[0].Value.ToString();
                Person person = employeeService.getEmployeeById(personId);
                employeeList.Remove(person);
                reloadDgvEmployee();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {

            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }
        // Drag from
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int Param);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    }
}
