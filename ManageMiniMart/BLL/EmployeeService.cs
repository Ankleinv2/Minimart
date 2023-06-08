using ManageMiniMart.DAL;
using ManageMiniMart.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Principal;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace ManageMiniMart.BLL
{
    public class EmployeeService
    {
        private Manage_MinimartEntities db;
        private UserService userService;
        private RoleService roleService;
        public EmployeeService()
        {
            db = new Manage_MinimartEntities();
            userService = new UserService();
            roleService = new RoleService();
        }
        // Get
        public List<PersonView> getAllEmployeeView()
        {
            db = null;
            db = new Manage_MinimartEntities();
            List<PersonView> list = new List<PersonView>();

            foreach (var person in db.People.ToList())
            {
                Account account = userService.getAccountByPersonId(person.person_id);
                list.Add(new PersonView
                {
                    person_id = person.person_id,
                    person_name = person.person_name,
                    birthdate = String.Format("{0:dd/MM/yyyy}", person.birthdate),
                    address = person.address,
                    phone_number = person.phone_number,
                    salary = Double.Parse(person.salary.ToString()).ToString("#,## VNĐ").Replace(',', '.'),
                    email = person.email,
                    role = account != null ? account.Role.role_name : ""
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
            return db.People.Where(p => p.person_name.Contains(name) && p.Account != null).ToList();
        }
        public List<PersonView> getListEmployeeByNamePersonView(string name)
        {
            List<PersonView> result = new List<PersonView>();
            var peoples = db.People.Where(p => p.person_name.Contains(name)).ToList();
            foreach(Person person in peoples)
            {
                result.Add(new PersonView
                {
                    person_id = person.person_id,
                    person_name = person.person_name,
                    birthdate = String.Format("{0:dd/MM/yyyy}", person.birthdate),
                    address = person.address,
                    phone_number = person.phone_number,
                    salary = Double.Parse(person.salary.ToString()).ToString("#,## VNĐ").Replace(',', '.'),
                    email = person.email,
                    role = person.Account != null ? person.Account.Role.role_name : ""
                });
            }
            return result;

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
        public void saveEmployee(bool IdState, string Id, string Name, DateTime Birthdate, string Address, string Email, string Salary, string PhoneNumber)
        {
            //validate value 
            if (IdState == true && Id == "") throw new Exception("Employee ID cannot be empty");
            if (IdState == true && checkEmployeeID_Exist(Id) == true) throw new Exception("Employee ID cannot be the same as the existing Employee ID");
            if (Name == "") throw new Exception("Employee name cannot be empty");
            if (DateTime.Compare(Birthdate, DateTime.Now) > 0) throw new Exception("Start Time shoule be Smaller Than or Equal to current date");
            if (PhoneNumber != "" && PhoneNumber.Length != 10) throw new Exception("Phone number length must be equal to 10");
            try
            {
                Convert.ToDouble(Salary);
            }
            catch (Exception)
            {
                throw new Exception("Salary must be a interger number");
            }
            if (Convert.ToDouble(Salary) < 0) throw new Exception("Salary can not be a negative number");

            string employeeId = Id;
            string employeeName = Name;
            DateTime dateTimeConverter = Birthdate;
            string address = Address;
            string email = Email;
            string phoneNumber = PhoneNumber;
            double salary = Convert.ToDouble(Salary);
            Person person = new Person
            {
                person_id = employeeId,
                person_name = employeeName,
                phone_number = phoneNumber,
                birthdate = dateTimeConverter,
                email = email,
                salary = salary,
                address = address
            };
            db.People.AddOrUpdate(person);
            db.SaveChanges();
        }
    }
}
