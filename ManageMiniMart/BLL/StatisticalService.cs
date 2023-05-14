using ManageMiniMart.DAL;
using ManageMiniMart.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageMiniMart.BLL
{
    internal class StatisticalService
    {
        private Manage_MinimartEntities db;
        private BillService billService;
        public StatisticalService()
        {
            db = new Manage_MinimartEntities();
            billService = new BillService();
        }

        public List<int> getAllYear()
        {
            List<int> result = new List<int>();
            var p = db.Bills.Select(b => b.created_time.Year).Distinct().ToList();
            foreach (var b in p)
            {
                result.Add(b);
            }
            return result;
        }

        public Revenue getAllRevenue(int year, int month)
        {
            // Total money bill in month,year
            double total = 0;
            var bills = db.Bills.Where(b => b.created_time.Year == year && b.created_time.Month == month).ToList();
            foreach (var b in bills)
            {
                total += billService.getTotalByBill(b.bill_id);
            }

            return new Revenue
            {
                Month = month,
                Year = year,
                Value = total
            };
        }
        public double getAllRevenueInDate(DateTime date)
        {
            double total = 0;
            var BillsEnum = db.Bills.AsEnumerable();
            List<Bill> billInDate = BillsEnum.Where(b => b.created_time.Date == date.Date).ToList();
            foreach (Bill bill in billInDate)
            {
                total += billService.getTotalByBill(bill.bill_id);
            }
            return total;
        }
        public double getAllRevenueInYear(int year)
        {
            double total = 0;
            var bills = db.Bills.Where(b => b.created_time.Year == year).ToList();
            foreach (var bill in bills)
            {
                total += billService.getTotalByBill(bill.bill_id);
            }
            return total;
        }
    }
}
