using ManageMiniMart.DAL;
using ManageMiniMart.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace ManageMiniMart.BLL
{
    internal class CustomerService
    {
        private Manage_MinimartEntities db;
        public CustomerService()
        {
            db = new Manage_MinimartEntities();
        }
        public List<CustomerView> convertToCustomerView(List<Customer> customers) {
            List<CustomerView> result = new List<CustomerView>();
            foreach (Customer customer in customers)
            {
                result.Add(new CustomerView
                {
                    Id = customer.customer_id,
                    Name = customer.customer_name,
                    Address = customer.address,
                    Email = customer.email,
                    Point = (int)customer.point,
                    BirthDate = customer.birthdate.ToString()
                });
            }
            return result;
        }
        // Get
        public List<CustomerView> getAllCustomerView()
        {
            var c = db.Customers.ToList();
            List<CustomerView> customerViews = convertToCustomerView(c);
            return customerViews;
        }
        public Customer getCustomerById(string id)
        {
            return db.Customers.Find(id);
        }
        public int getCustomerPoint(string id)
        {
            Customer customer = getCustomerById(id);
            return Convert.ToInt32(customer.point);
        }
        public List<CustomerView> getListCustomerViewByName(string name)
        {
            var p = db.Customers.Where(c => c.customer_name.Contains(name)).ToList();
            List<CustomerView> customerViews = convertToCustomerView(p);
            return customerViews;
        }
        public List<int> getAllYear()
        {
            List<int> years = new List<int>();
            var yearsInCustomer = db.Customers.OrderBy(C => C.created_time).Select(c => new { c.created_time.Year }).ToList().Distinct();
            foreach (var year in yearsInCustomer)
            {
                years.Add(year.Year);
            }
            return years;
        }
        public int getAmountInMonthAndYear(int month, int year)
        {
            int result = 0;
            result = db.Customers.Count(s => s.created_time.Month == month && s.created_time.Year == year);
            return result;
        }
        public int getAmountCustomerInSystem()
        {
            return db.Customers.Count();
        }
        // Check customerID (dùng khi thêm mới Customer)
        public bool checkCustomerID_Exist(string id)
        {
            bool check = false;
            foreach(var item in db.Customers)
            {
                if(item.customer_id == id)
                {
                    check = true; 
                    break;
                }
            }
            return check;
        }
        // Add or Update
        public void saveCustomer(Customer customer)
        {
            db.Customers.AddOrUpdate(customer);
            db.SaveChanges();
        }

    }
}
