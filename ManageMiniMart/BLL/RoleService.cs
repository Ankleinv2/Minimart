using ManageMiniMart.DAL;
using ManageMiniMart.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageMiniMart.BLL
{
    internal class RoleService
    {
        private Manage_MinimartEntities db;
        public RoleService() {
            db = new Manage_MinimartEntities();
        }
        public List<CBBItem> getCBBRole()
        {
            List<CBBItem> list = new List<CBBItem>();
            var p = db.Roles.Select(o => new { o.role_id, o.role_name }).ToList();
            foreach(var r in p)
            {
                list.Add(new CBBItem 
                {   Text= r.role_name,
                    Value = r.role_id 
                });
            }
            return list;
        }
    }
}
