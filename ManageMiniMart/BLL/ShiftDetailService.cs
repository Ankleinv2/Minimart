using ManageMiniMart.Custom;
using ManageMiniMart.DAL;
using ManageMiniMart.DTO;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents.DocumentStructures;
using System.Windows.Forms;

namespace ManageMiniMart.BLL
{
    public class ShiftDetailService
    {
        public Int32 shiftIdAdded;
        private Manage_MinimartEntities db;
        private ShiftWorkService shiftWorkService;
        public ShiftDetailService()
        {
            db = new Manage_MinimartEntities();
            shiftWorkService = new ShiftWorkService();
        }
        public List<CBBItem> getCBBShiftDetail()
        {
            List<CBBItem> list = new List<CBBItem>();
            foreach (var item in db.Shift_detail)
            {
                list.Add(new CBBItem
                {
                    Value = item.shift_id,
                    Text = item.shift_name,
                });
            }
            return list;
        }
        public List<ShiftDetailView> convertToShiftDetailView(List<Shift_detail> shift_Details)
        {
            List<ShiftDetailView> shiftDetailViews = new List<ShiftDetailView>();
            foreach (var shift in shift_Details)
            {
                string employees = "";
                foreach (var employee in shift.Shift_work)
                {
                    employees += employee.Account.Person.person_name + ", ";
                }
                shiftDetailViews.Add(new ShiftDetailView
                {
                    ShiftId = shift.shift_id,
                    ShiftName = shift.shift_name.ToString(),
                    ShiftDate = shift.shift_date.ToString("dd/MM/yyyy"),
                    StartTime = shift.start_time.ToString(),
                    EndTime = shift.end_time.ToString(),
                    Employees = employees
                });
            }
            return shiftDetailViews;
        }
        // Get
        public List<ShiftDetailView> getAllShiftDetailView()
        {
            return convertToShiftDetailView(db.Shift_detail.ToList());
        }

        public bool verifyTimeLogin(string id)
        {
            DateTime currentTime = DateTime.Parse(DateTime.Now.ToShortTimeString());
            DateTime currentDay = DateTime.Now.Date;

            List<Shift_work> shift_work = db.Shift_work.Where(p => p.Shift_detail.shift_date == currentDay).ToList();
            foreach (var shift in shift_work)
            {
                if (shift.person_id == id && (TimeSpan.Compare(currentTime.TimeOfDay, shift.Shift_detail.start_time) >= 0 && TimeSpan.Compare(currentTime.TimeOfDay, shift.Shift_detail.end_time) <= 0))
                {
                    return true;
                }
            }
            return false;
        }

        public Shift_detail getShift_detailById(int shiftId)
        {
            return db.Shift_detail.Find(shiftId);
        }
        public List<ShiftDetailView> getListShiftViewByShiftDate(DateTime shift_date)
        {
            db = null;
            db = new Manage_MinimartEntities();
            List<ShiftDetailView> list = new List<ShiftDetailView>();

            var s = db.Shift_detail.Where(p => p.shift_date == shift_date.Date).ToList();
            list = convertToShiftDetailView(s);
            return list;
        }
        // Check
        public bool checkShiftDetailExist(DateTime shift_date, TimeSpan start_time, TimeSpan end_time)
        {
            bool check = false;
            foreach (var item in db.Shift_detail)
            {
                if (shift_date == item.shift_date)
                {
                    int check1 = TimeSpan.Compare(start_time, item.start_time);
                    int check2 = TimeSpan.Compare(end_time, item.start_time);

                    int check3 = TimeSpan.Compare(start_time, item.end_time);
                    int check4 = TimeSpan.Compare(end_time, item.end_time);
                    if (check1 == 0 || check2 == 0 || check3 == 0 || check4 == 0)
                    {
                        check = true;
                        break;
                    }
                    if (check1 < 0 && check2 > 0)
                    {
                        check = true;
                        break;
                    }
                    if (check1 > 0 && check3 < 0)
                    {
                        check = true;
                        break;
                    }
                }
                else
                {
                    check = false;
                }
            }
            return check;
        }
        // Add or Update
        public void saveShift_detail(Shift_detail shift)
        {
            db.Shift_detail.AddOrUpdate(shift);
            db.SaveChanges();
            shiftIdAdded = shift.shift_id;
        }
        // Delete
        public void deleteShiftDetailbyID(int shiftID)
        {
            var shiftWork = db.Shift_work.Where(x => x.shift_id == shiftID).ToList();
            db.Shift_work.RemoveRange(shiftWork);

            var shiftDetail = db.Shift_detail.Where(p => p.shift_id == shiftID).ToList();
            db.Shift_detail.RemoveRange(shiftDetail);

            db.SaveChanges();
        }
        public void deleteShiftDetailbyListShiftID(List<int> listShiftID)
        {
            foreach (var shiftID in listShiftID)
            {
                var shiftWork = db.Shift_work.Where(x => x.shift_id == shiftID).ToList();
                db.Shift_work.RemoveRange(shiftWork);

                var shiftDetail = db.Shift_detail.Where(p => p.shift_id == shiftID).ToList();
                db.Shift_detail.RemoveRange(shiftDetail);
            }
            db.SaveChanges();
        }

        public void AddShiftWorkForm_Save(string lblShiftId, string shiftName, DateTime shiftDate, TimeSpan startTime, TimeSpan endTime, List<Person> employeeList)
        {
            if (shiftName == "") throw new Exception("Shift name is not empty");
            if (TimeSpan.Compare(startTime, endTime) >= 0) throw new Exception("End time must be Greater than Start Time");

            if (lblShiftId == "")                          // Add
            {
                bool checkShiftDetailExit = checkShiftDetailExist(shiftDate, startTime, endTime);
                if (checkShiftDetailExit == true) throw new Exception("The time of this shift must be different from the time of the existing shift");
                Shift_detail shift_Detail = new Shift_detail
                {
                    shift_name = shiftName,
                    shift_date = shiftDate,
                    start_time = startTime,
                    end_time = endTime,
                };
                saveShift_detail(shift_Detail);

                int shiftId = shiftIdAdded;                  // shiftIdAdded bên shiftDetailService
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
                int shiftId = Convert.ToInt32(lblShiftId);
                Shift_detail shift_Detail = new Shift_detail
                {
                    shift_id = shiftId,
                    shift_name = shiftName,
                    shift_date = shiftDate,
                    start_time = startTime,
                    end_time = endTime,
                };
                saveShift_detail(shift_Detail);
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
        }

    }
}