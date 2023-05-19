using ManageMiniMart.DAL;
using ManageMiniMart.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageMiniMart.BLL
{

    public class UserService
    {
        private Manage_MinimartEntities db;
        public UserService() {
            db = new Manage_MinimartEntities();
        }
        // Get
        public Account getAccountByPersonId(string personId)
        {
            return db.Accounts.Where(p => p.person_id == personId).FirstOrDefault();
        }
        public Account getAccount(string username, string password)
        {
            return db.Accounts.Where(user => user.person_id.Equals(username) && user.password.Equals(password)).FirstOrDefault();
        }
        // Check
        public bool checkUserExits(string employeeId)
        {
            bool check = false;
            var account = db.Accounts.Where(p => p.person_id == employeeId).FirstOrDefault();
            if (account != null) {
                check= true;
            }
            return check;
        }
        // Add or Update
        public void saveAccount(Account account)
        {
            db.Accounts.AddOrUpdate(account);
            db.SaveChanges();
        }
        public void resetPassword(string personID)
        {
            Account account = getAccountByPersonId(personID);
            account.password = account.person_id.ToString();
            db.Accounts.AddOrUpdate(account);
            db.SaveChanges();
        }
    }
}
