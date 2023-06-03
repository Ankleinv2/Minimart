using ManageMiniMart.DAL;
using ManageMiniMart.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
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
        private Bill_ProductService bill_ProductService;
        private ProductService productService;
        private EmployeeService employeeService;
        public StatisticalService()
        {
            db = new Manage_MinimartEntities();
            billService = new BillService();
            bill_ProductService = new Bill_ProductService();
            productService = new ProductService();
            employeeService = new EmployeeService();
        }

        public double getRevenueByDate(DateTime dateTime)
        {
            double total = 0;
            var bills = db.Bills.Where(b => DbFunctions.TruncateTime(b.created_time) == dateTime.Date).ToList();
            foreach (var b in bills)
            {
                total += billService.getTotalByBill(b.bill_id);
            }
            return total;
        }
        public int getCountCustomerByDate(DateTime dateTime)
        {
            var l = db.Bills.Where(b => DbFunctions.TruncateTime(b.created_time) == dateTime.Date && b.customer_id != null)
                .Select(x => x.customer_id)
                .Distinct()
                .ToList();

            return l.Count();
        }
        public int getCountCustomerByMonth(DateTime dateTime)
        {
            var l = db.Bills.Where(b => DbFunctions.TruncateTime(b.created_time) == dateTime.Date && b.customer_id != null)
                .Select(x => x.customer_id)
                .Distinct()
                .ToList();

            return l.Count();
        }

        public ObjectDTO getElementExist(List<ObjectDTO> list, string element)
        {
            foreach (var b in list)
            {
                if (b.Text.Equals(element))
                {
                    return b;
                }
            }
            return null;
        }

        // Bill
        public List<object> getListBillByStartDateAndEndDate(DateTime startDate, DateTime endDate)
        {
            var result = db.Bills
                    .ToList()
                    .OrderBy(p => p.created_time.Date)
                    .Where(p => p.created_time.Date >= startDate.Date && p.created_time.Date <= endDate.Date)
                    .GroupBy(b => b.created_time.Date)
                    .Select(g => new
                    {
                        Date = g.Key.ToString("dd/MM/yyyy"),
                        Value = g.Count()
                    })

                    .ToList<object>();
            return result;
        }

        public List<object> getListBillByMonth(DateTime startDate, DateTime endDate)
        {
            var result = db.Bills
                    .ToList()
                    .OrderBy(p => p.created_time.Date)
                    .Where(p => p.created_time.Date >= startDate.Date && p.created_time.Date <= endDate.Date)
                    .GroupBy(p => new { p.created_time.Year, p.created_time.Month })
                    .Select(p => new
                    {
                        Date = p.Key.Month + "/" + p.Key.Year,
                        //Date=new DateTime(p.Key.Year,p.Key.Month,1),
                        Value = p.Count()
                    })
                    .ToList<object>();
            return result;

        }
        public List<object> getListBillByYear(DateTime startDate, DateTime endDate)
        {
            var result = db.Bills
                    .ToList()
                    .OrderBy(p => p.created_time.Date)
                    .Where(p => p.created_time.Date >= startDate.Date && p.created_time.Date <= endDate.Date)
                    .GroupBy(p => new { p.created_time.Year })
                    .Select(p => new
                    {
                        Date = p.Key.Year.ToString(),
                        //Date = new DateTime(p.Key.Year, 1, 1),
                        Value = p.Count()
                    })
                    .ToList<object>();
            return result;

        }

        //Product
        public List<ObjectDTO> getListProductByStartDateAndEndDate(DateTime startDate, DateTime endDate)
        {
            List<ObjectDTO> list = new List<ObjectDTO>();
            var bills = db.Bills.Where(b => DbFunctions.TruncateTime(b.created_time) >= startDate.Date && DbFunctions.TruncateTime(b.created_time) <= endDate.Date).ToList();
            if (bills != null)
            {
                foreach (var x in bills)
                {
                    List<Bill_Product> bill_Product = bill_ProductService.getBill_ProductByBillId(x.bill_id);
                    foreach (var b in bill_Product)
                    {
                        string productName = productService.getProductById(b.product_id).product_name;
                        int quantity = b.quantity;

                        ObjectDTO p = getElementExist(list, productName);
                        if (p == null)
                        {
                            list.Add(new ObjectDTO
                            {
                                Text = productName,
                                Value = quantity,
                            });
                        }
                        else
                        {
                            p.Value += b.quantity;
                        }
                    }
                }
                return list;
            }
            return null;

        }
        public List<object> getListProductByStartDateAndEndDate2(DateTime startDate, DateTime endDate)
        {
            var result = (from b in db.Bills.ToList()
                          join bp in db.Bill_Product.ToList() on b.bill_id equals bp.bill_id
                          join p in db.Products.ToList() on bp.product_id equals p.product_id
                          where b.created_time.Date >= startDate.Date && b.created_time.Date <= endDate.Date
                          orderby (b.created_time.Date)
                          group bp by new
                          {
                              bp.product_id,
                              p.product_name
                          } into g

                          select new
                          {
                              ProductName = g.Key.product_name,
                              Value = g.Sum(x => x.quantity)
                          }
                        )
                        .OrderByDescending(g => g.Value)
                        .Take(5)
                        .ToList<object>();

            return result;
        }
        // Revenue
        public List<ObjectDTO> getListRevenueByStartDateAndEndDate(DateTime startDate, DateTime endDate)
        {
            List<ObjectDTO> list = new List<ObjectDTO>();
            var bills = db.Bills.Where(b => DbFunctions.TruncateTime(b.created_time) >= startDate.Date && DbFunctions.TruncateTime(b.created_time) <= endDate.Date)
                .OrderBy(u => u.created_time)
                .ToList();
            if (bills != null)
            {
                foreach (var x in bills)
                {
                    ObjectDTO p = getElementExist(list, x.created_time.Date.ToString("dd/MM/yyyy"));
                    if (p == null)
                    {
                        double total = getRevenueByDate(x.created_time.Date);
                        list.Add(new ObjectDTO
                        {
                            Text = x.created_time.Date.ToString("dd/MM/yyyy"),
                            Value = total,
                        });
                    }
                }
                return list;
            }
            return null;
        }
        public List<ObjectDTO> getListRevenueByStartDateAndEndDate3(DateTime startDate, DateTime endDate)
        {
            List<ObjectDTO> list = new List<ObjectDTO>();
            var dates = new List<string>();

            for (var dt = startDate.Date; dt <= endDate.Date; dt = dt.AddDays(1))
            {
                dates.Add(dt.ToString("dd/MM/yyyy"));
            }

            var dateDB = db.Bills
                .ToList()
                .Where(b => b.created_time.Date >= startDate.Date && b.created_time.Date <= endDate.Date)
                .OrderBy(u => u.created_time)
                .GroupBy(p => p.created_time.Date)
                .Select(x => x.Key)
                .ToList();
            foreach (var date in dates)
            {
                list.Add(new ObjectDTO
                {
                    Text = date,
                    Value = 0
                });
            }
            foreach (var date in dateDB)
            {
                ObjectDTO p = getElementExist(list, date.ToString("dd/MM/yyyy"));
                if (p != null)
                {
                    double total = getRevenueByDate(date.Date);
                    p.Value = total;
                }
            }
            return list;
        }
        public List<ObjectDTO> getListRevenueByMonth(DateTime startDate, DateTime endDate)
        {
            List<ObjectDTO> result = new List<ObjectDTO>();
            List<ObjectDTO> list = getListRevenueByStartDateAndEndDate(startDate, endDate);
            foreach (var x in list)
            {
                string dateString = x.Text;
                DateTime date = DateTime.ParseExact(dateString, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                string month = date.ToString("MM/yyyy");
                ObjectDTO p = getElementExist(result, month);

                if (p != null)
                {
                    p.Value += x.Value;
                }
                else
                {
                    result.Add(new ObjectDTO
                    {
                        Text = month,
                        Value = x.Value,
                    });
                }
            }
            return result;
        }
        public List<ObjectDTO> getListRevenueByMonth2(DateTime startDate, DateTime endDate)
        {
            List<ObjectDTO> list = new List<ObjectDTO>();
            var dates = new List<string>();

            for (var dt = startDate.Date; dt <= endDate.Date; dt = dt.AddDays(1))
            {
                string x = dt.ToString("MM/yyyy");
                if (!dates.Contains(x))
                {
                    dates.Add(x);
                }
            }
            foreach (var x in dates)
            {
                list.Add(new ObjectDTO
                {
                    Text = x,
                    Value = 0
                });
            }
            List<ObjectDTO> listRevenue = getListRevenueByMonth(startDate, endDate);
            foreach (var x in listRevenue)
            {
                ObjectDTO p = getElementExist(list, x.Text);
                if (p != null)
                {
                    p.Value = x.Value;
                }
            }
            return list;
        }
        public List<ObjectDTO> getListRevenueByYear(DateTime startDate, DateTime endDate)
        {
            List<ObjectDTO> result = new List<ObjectDTO>();
            List<ObjectDTO> list = getListRevenueByMonth(startDate, endDate);
            foreach (var x in list)
            {
                string dateString = x.Text;
                DateTime date = DateTime.ParseExact(dateString, "MM/yyyy", CultureInfo.InvariantCulture);

                string year = date.ToString("yyyy");
                ObjectDTO p = getElementExist(result, year);

                if (p != null)
                {
                    p.Value += x.Value;
                }
                else
                {
                    result.Add(new ObjectDTO
                    {
                        Text = year,
                        Value = x.Value,
                    });
                }
            }
            return result;
        }
        public List<ObjectDTO> getListRevenueByYear2(DateTime startDate, DateTime endDate)
        {
            List<ObjectDTO> list = new List<ObjectDTO>();
            var dates = new List<string>();

            for (var dt = startDate.Date; dt <= endDate.Date; dt = dt.AddDays(1))
            {
                string x = dt.ToString("yyyy");
                if (!dates.Contains(x))
                {
                    dates.Add(x);
                }
            }
            foreach (var x in dates)
            {
                list.Add(new ObjectDTO
                {
                    Text = x,
                    Value = 0
                });
            }
            List<ObjectDTO> listRevenue = getListRevenueByYear(startDate, endDate);
            foreach (var x in listRevenue)
            {
                ObjectDTO p = getElementExist(list, x.Text);
                if (p != null)
                {
                    p.Value = x.Value;
                }
            }
            return list;
        }
        // Customer
        public List<ObjectDTO> getListCustomerByStartDateAndEndDate(DateTime startDate, DateTime endDate)
        {
            List<ObjectDTO> list = new List<ObjectDTO>();
            var bills = db.Bills.Where(b => DbFunctions.TruncateTime(b.created_time) >= startDate.Date && DbFunctions.TruncateTime(b.created_time) <= endDate.Date && b.customer_id != null).ToList();
            if (bills != null)
            {
                foreach (var x in bills)
                {
                    ObjectDTO p = getElementExist(list, x.created_time.Date.ToString("dd/MM/yyyy"));
                    if (p == null)
                    {
                        int countCustomer = getCountCustomerByDate(x.created_time.Date);
                        list.Add(new ObjectDTO
                        {
                            Text = x.created_time.Date.ToString("dd/MM/yyyy"),
                            Value = countCustomer,
                        });
                    }
                }
                return list;
            }

            return null;

        }
        public List<object> getListCustomerByStartDateAndEndDate2(DateTime startDate, DateTime endDate)
        {
            var result = db.Bills
                    .ToList()
                    .OrderBy(p => p.created_time.Date)
                    .Where(p => p.created_time.Date >= startDate.Date && p.created_time.Date <= endDate.Date && p.customer_id != null)
                    .GroupBy(b => b.created_time.Date)
                    .Select(g => new
                    {
                        Date = g.Key.ToString("dd/MM/yyyy"),
                        Value = g.Select(b => b.customer_id).Distinct().Count()
                    })
                    .ToList<object>();
            return result;

        }
        public List<object> getListCustomerByMonth(DateTime startDate, DateTime endDate)
        {
            var result = db.Bills
                    .ToList()
                    .OrderBy(p => p.created_time.Date)
                    .Where(p => p.created_time.Date >= startDate.Date && p.created_time.Date <= endDate.Date && p.customer_id != null)
                    .GroupBy(b => b.created_time.Month)
                    .Select(g => new
                    {
                        Date = g.Key.ToString(),
                        Value = g.Select(b => b.customer_id).Distinct().Count()
                    })
                    .ToList<object>();
            return result;

        }
    }
}
