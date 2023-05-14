using ManageMiniMart.BLL;
using ManageMiniMart.Custom;
using ManageMiniMart.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace ManageMiniMart.View
{
    public partial class FormDiscount : Form
    {
        private DiscountService discountService;
        public FormDiscount()
        {
            InitializeComponent();
            discountService= new DiscountService();
            loadAllDiscountView();
        }
        public void loadAllDiscountView()
        {
            dgvDiscount.DataSource = null;
            dgvDiscount.DataSource = discountService.getAllDiscountView();
            dgvDiscount.Refresh();
        }
        // btnAdd
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddDiscountForm addDiscount = new AddDiscountForm();
            addDiscount.ShowDialog();
            loadAllDiscountView();
        }

        // btnEdit
        private void btnEdit_Click(object sender, EventArgs e)
        {
            AddDiscountForm addDiscount = new AddDiscountForm();
            addDiscount.setDiscount(Convert.ToInt32(dgvDiscount.SelectedRows[0].Cells[0].Value.ToString()));
            addDiscount.ShowDialog();
            loadAllDiscountView();

        }
        // btnDelete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<Discount> list = new List<Discount>();
            string strings = "";
            for (int i = 0; i < dgvDiscount.SelectedRows.Count; i++)
            {
                strings += dgvDiscount.SelectedRows[i].Cells[1].Value.ToString() + ", ";
            }
            MyMessageBox messageBox = new MyMessageBox();
            DialogResult rs = messageBox.show("Are you sure delete " + strings, "Confirm delete", MyMessageBox.TypeMessage.YESNO, MyMessageBox.TypeIcon.QUESTION);
            if(rs== DialogResult.Yes)
            {

                for (int i = 0; i < dgvDiscount.SelectedRows.Count; i++)
                {
                    int id = Convert.ToInt32(dgvDiscount.SelectedRows[i].Cells[0].Value.ToString());
                    Discount discount = discountService.getDiscountById(id);
                    discountService.deleteDiscount(discount);
                    
                }
            }
            loadAllDiscountView();
        }
        // btnSearch
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtSearch.Text.Trim();
            dgvDiscount.DataSource=discountService.getListDiscountViewByName(name);
        }
    }
}
