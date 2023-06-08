using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageMiniMart.DTO
{
    public class BillView
    {
        private int _Id;
        private string _CustomerName;
        private string _EmployeeName;
        private string _CreatedTime;
        private string _Total;

        public int Id { get => _Id; set => _Id = value; }
        public string CustomerName { get => _CustomerName; set => _CustomerName = value; }
        public string EmployeeName { get => _EmployeeName; set => _EmployeeName = value; }
        public string CreatedTime { get => _CreatedTime; set => _CreatedTime = value; }
        public string Total { get => _Total; set => _Total = value; }
    }
}
