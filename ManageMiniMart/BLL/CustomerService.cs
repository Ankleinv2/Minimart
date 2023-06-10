using ManageMiniMart.Custom;
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
                    BirthDate = customer.birthdate.ToString("dd/MM/yyyy")
                });
            }
            return result;
        }
        // Get
        public List<CustomerView> getAllCustomerView()
        {
            db = null;
            db = new Manage_MinimartEntities();
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
            db = null;
            db = new Manage_MinimartEntities();
            Customer customer = getCustomerById(id);
            return Convert.ToInt32(customer.point);
        }
        public List<CustomerView> getListCustomerViewByName(string name)
        {
            var p = db.Customers.Where(c => c.customer_name.Contains(name)).ToList();
            List<CustomerView> customerViews = convertToCustomerView(p);
            return customerViews;
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
        public void saveCustomer(bool IdState, string Id, string Name, DateTime Birthdate, string Address, string Email)
        {
            //validate value 
            if (IdState == true && Id == "") throw new Exception("CustomerID cannot be empty");
            if (IdState == true && checkCustomerID_Exist(Id) == true) throw new Exception("Customer ID cannot be the same as the existing Customer ID");
            if (Name == "" || !Validate.ValidateVietnameseName(Name)) throw new Exception("Customer name cannot be empty or contain special character");
            if (DateTime.Compare(Birthdate, DateTime.Now) > 0) throw new Exception("Birthdate shoule be Smaller Than or Equal to current date");
            if (!Validate.ValidateEmail(Email)) throw new Exception("Email is not valid");
            Customer customerOld = getCustomerById(Id);             // lấy Customer    -> Để đưa createTime vào
            if (customerOld == null)                                                // Add Customer
            {
                Customer customer = new Customer
                {
                    customer_id = Id,
                    customer_name = Name,
                    birthdate = Birthdate,
                    created_time = DateTime.Now,
                    address = Address,
                    point = 0,
                    email = Email,
                };
                db.Customers.AddOrUpdate(customer);
                MyMessageBox myMessage = new MyMessageBox();
                myMessage.show("Add customer successful !", "Nofitication", MyMessageBox.TypeMessage.CONFIRM, MyMessageBox.TypeIcon.INFO);

            }
            else                                                                  // Edit Customer
            {
                Customer customer = new Customer
                {
                    customer_id = Id,
                    customer_name = Name,
                    birthdate = Birthdate,
                    created_time = customerOld.created_time,
                    address = Address,
                    point = customerOld.point,
                    email = Email,
                };
                db.Customers.AddOrUpdate(customer);
                MyMessageBox myMessage = new MyMessageBox();
                myMessage.show("Edit customer successful !", "Nofitication", MyMessageBox.TypeMessage.CONFIRM, MyMessageBox.TypeIcon.INFO);
            }
            db.SaveChanges();
        }

    }
}
