using ManageMiniMart.DAL;
using ManageMiniMart.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageMiniMart.BLL
{
    internal class CategoryService
    {
        private Manage_MinimartEntities db;
        public CategoryService()
        {
            db = new Manage_MinimartEntities();    
        }
        public List<CBBItem> getCBBCategory(bool checkAddForm=false)               // combobox Category
        {
            List<CBBItem> cBBItems= new List<CBBItem>();
            var p = db.Categories.ToList();
            cBBItems.Add(new CBBItem
            {
                Text = "All",
                Value = 0
            });
            foreach(var a in p)
            {
                cBBItems.Add(new CBBItem
                {
                    Text = a.category_name,
                    Value = a.category_id
                });
            }
            if (checkAddForm) cBBItems.RemoveAt(0);
            return cBBItems;
        }
    }
}
