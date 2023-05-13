using ManageMiniMart.DAL;
using ManageMiniMart.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace ManageMiniMart.BLL
{
    public class EmployeeService
    {
        private Manage_MinimartEntities db;
        public EmployeeService()
        {
            db = new Manage_MinimartEntities();
        }
        // Get
        public List<Person> getAllEmployee()
        {
            return db.People.ToList();
        }
        public List<PersonView> getAllEmployeeView()
        {
            db = null;
            db = new Manage_MinimartEntities();
            List<PersonView> list = new List<PersonView>();
            foreach (var person in db.People.ToList())
            {
                list.Add(new PersonView
                {
                    person_id = person.person_id,
                    person_name = person.person_name,
                    birthdate = String.Format("{0:dd/MM/yyyy}", person.birthdate),
                    address=person.address,
                    phone_number=person.phone_number,
                    salary=Double.Parse(person.salary.ToString()).ToString("#,## VNĐ").Replace(',','.'),
                    email=person.email,
                }); 
            }
            return list;
        }
        public Person getEmployeeById(string id)
        {
            return db.People.SingleOrDefault(p => p.person_id == id);
        }
        public List<Person> getListEmployeeByName(string name)
        {
            return db.People.Where(p => p.person_name.Contains(name)).ToList();
        }
        // Check EmployeeID (dùng khi thêm mới Employee)
        public bool checkEmployeeID_Exist(string id)
        {
            bool check = false;
            foreach(var item in db.People)
            {
                if(item.person_id == id)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        // Add or Update
        public void saveEmployee(Person person)
        {
            db.People.AddOrUpdate(person);
            db.SaveChanges();
        }

    }
}
