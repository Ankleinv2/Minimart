using ManageMiniMart.DAL;
using ManageMiniMart.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography;
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
            db = null;
            db = new Manage_MinimartEntities();
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
        public void removeAccount(List<Account> accounts, Account current)
        {
            bool isRemove = false;
            List<Account> accountsToRemove = new List<Account>();
            foreach (Account account in accounts)
            {
                if (account.person_id != current.person_id)
                {
                    var shiftWork = db.Shift_work.Where(p => p.person_id == account.person_id).ToList();
                    db.Shift_work.RemoveRange(shiftWork);
                    accountsToRemove.Add(account);
                    isRemove = true;
                }
            }
            db.Accounts.RemoveRange(accountsToRemove);
            db.SaveChanges();
            if (!isRemove) throw new Exception("Nothing to remove or you cannot remove your own account");
        }
        public void resetPassword(List<Account> accounts)   
        {
            if (accounts.Count == 0) throw new Exception("Nothing to reset");
            foreach (Account account in accounts)
            {
                account.password = encryption(account.person_id.ToString());
                db.Accounts.AddOrUpdate(account);
            }
            db.SaveChanges();
        }
        public string encryption(string password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encode = new UTF8Encoding();
            encrypt = md5.ComputeHash(encode.GetBytes(password));
            StringBuilder encryptdata = new StringBuilder();
            for (int i = 0; i < encrypt.Length; i++)
            {
                encryptdata.Append(encrypt[i].ToString());
            }
            return encryptdata.ToString();
        }
    }
}
