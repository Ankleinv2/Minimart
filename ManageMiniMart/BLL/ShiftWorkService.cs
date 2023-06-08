using ManageMiniMart.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Entity.Migrations;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace ManageMiniMart.BLL
{
    internal class ShiftWorkService
    {
        private Manage_MinimartEntities db;
        public ShiftWorkService()
        {
            db = new Manage_MinimartEntities();
        }
        public List<string> getAllPersonID_By_ShiftDetailID(int shiftId)                // Lấy list id Person để truyền vào form AddShiftWork
        {
            List<string> personIds = db.Shift_work.Where(s => s.shift_id == shiftId).Select(p => p.person_id).ToList();
            return personIds;
        }
        // Add or Update
        public void saveShift_work(Shift_work shift_Work)
        {
            db.Shift_work.AddOrUpdate(shift_Work);
            db.SaveChanges();
        }
        // Delete
        public void deleteShiftworkByShiftWorkId(int shiftWorkId)                // Xoá nhiều bản ghi trong table ShiftWork
        {
            List<Shift_work> works = db.Shift_work.Where(s => s.shift_id == shiftWorkId).ToList();
            if(works.Count > 0)
            {
                db.Shift_work.RemoveRange(works);
                db.SaveChanges();
            } 
        }
    }
}
