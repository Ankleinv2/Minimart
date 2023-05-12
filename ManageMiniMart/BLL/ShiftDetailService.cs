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
        public ShiftDetailService()
        {
            db = new Manage_MinimartEntities();
        }
        public List<CBBItem> getCBBShiftDetail()
        {
            List<CBBItem> list = new List<CBBItem>();
            foreach(var item in db.Shift_detail)
            {
                list.Add(new CBBItem
                {
                    Value=item.shift_id,
                    Text=item.shift_name,
                });
            }
            return list;
        }
        public List<ShiftDetailView> convertToShiftDetailView(List<Shift_detail> shift_Details)
        {
            List<ShiftDetailView> shiftDetailViews= new List<ShiftDetailView>();
            foreach(var shift in shift_Details)
            {
                string employees = "";
                foreach(var employee in shift.Shift_work)
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
            foreach(var shift in shift_work)
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
            
            var s=db.Shift_detail.Where(p=> p.shift_date == shift_date.Date).ToList();
            list = convertToShiftDetailView(s);
            return list;
        }
        // Check
        public bool checkShiftDetailExist(DateTime shift_date,TimeSpan start_time,TimeSpan end_time)
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
            var shiftWork=db.Shift_work.Where(x=>x.shift_id==shiftID).ToList();
            db.Shift_work.RemoveRange(shiftWork);

            var shiftDetail = db.Shift_detail.Where(p=>p.shift_id == shiftID).ToList();
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
        
    }
}
