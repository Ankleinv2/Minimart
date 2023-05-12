using ManageMiniMart.BLL;
using ManageMiniMart.Custom;
using ManageMiniMart.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace ManageMiniMart.View
{
    public partial class FormShiftWork : Form
    {
        private ShiftDetailService shiftDetailService;
        private ShiftWorkService shiftWorkService;
        public FormShiftWork(bool checkLoadFormShiftWorkEmployeeOrManager)
        {
            InitializeComponent();
            shiftDetailService = new ShiftDetailService();
            shiftWorkService = new ShiftWorkService();
            loadShiftView();
            if (checkLoadFormShiftWorkEmployeeOrManager == false)
            {
                btnAdd.Visible = false;
                btnEdit.Visible = false;
                btnDelete.Visible = false;
            }
            dtpShiftDate.Value=DateTime.Now;
        }
        // Load
        public void loadShiftView()
        {
            dgvShift.DataSource = null;
            var s = shiftDetailService.getListShiftViewByShiftDate(dtpShiftDate.Value.Date);
            dgvShift.DataSource = s.ToList();
        }
        // btnAdd
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddShiftWorkForm addShiftWork = new AddShiftWorkForm();
            addShiftWork.ShowDialog();
            loadShiftView();
        }
        // btnEdit
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int shift_id = Convert.ToInt32(dgvShift.SelectedRows[0].Cells[0].Value.ToString());
            AddShiftWorkForm shiftWork= new AddShiftWorkForm();
            shiftWork.setFormAddShift(shift_id);
            shiftWork.ShowDialog();
            loadShiftView();
        }
        // btnDelete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<int> listShiftID=new List<int>();
            for(int i = 0; i < dgvShift.SelectedRows.Count; i++)
            {
                int shift_id = Convert.ToInt32(dgvShift.SelectedRows[i].Cells[0].Value);
                listShiftID.Add(shift_id);
                //shiftDetailService.deleteShiftDetailbyID(shift_id);
            }
            MyMessageBox messageBox = new MyMessageBox();
            DialogResult rs = messageBox.show("Are you sure delete?", "Confirm delete", MyMessageBox.TypeMessage.YESNO, MyMessageBox.TypeIcon.QUESTION);
            if (rs == DialogResult.Yes)
            {
                shiftDetailService.deleteShiftDetailbyListShiftID(listShiftID);
            }
            loadShiftView();
        }
        // datetimepicker value changed
        private void dtpShiftDate_ValueChanged(object sender, EventArgs e)
        {
            var s=shiftDetailService.getListShiftViewByShiftDate(dtpShiftDate.Value.Date);
            dgvShift.DataSource = s.ToList();
        }
    }
}
