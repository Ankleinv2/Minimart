using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageMiniMart.DTO
{
    public class ShiftDetailView
    {
        private int _ShiftId;
        private string _ShiftName;
        private string _ShiftDate;
        private string _StartTime;
        private string _EndTime;
        private string _Employees;

        public int ShiftId { get => _ShiftId; set => _ShiftId = value; }
        public string ShiftName { get => _ShiftName; set => _ShiftName = value; }
        public string ShiftDate { get => _ShiftDate; set => _ShiftDate=value; }
        public string StartTime { get => _StartTime; set => _StartTime = value; }
        public string EndTime { get => _EndTime; set => _EndTime = value; }
        public string Employees { get => _Employees; set => _Employees = value; }
    }
}
