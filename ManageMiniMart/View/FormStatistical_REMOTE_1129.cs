using ManageMiniMart.BLL;
using ManageMiniMart.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageMiniMart.View
{
    public partial class FormStatistical : Form
    {
        private StatisticalService statisticService;
        public FormStatistical()
        {
            InitializeComponent();
            statisticService = new StatisticalService();
            setCBBBy();
            chartBill.Titles.Add( "Total bill");
        }
        private void setCBBBy()
        {
            cbbBy.Items.Add("By date");
            cbbBy.Items.Add("By month");
            cbbBy.Items.Add("By year");
            cbbBy.SelectedIndex = 0;
        }
        private void btnStatistical_Click(object sender, EventArgs e)
        {

            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date;
            chartRevenue.ChartAreas[0].AxisY.LabelStyle.Format = "#,##";
            if (cbbBy.SelectedIndex == 0)
            {
                // Bill
                chartBill.ChartAreas[0].AxisX.Title = "Date";
                chartBill.ChartAreas[0].AxisY.Title = "Total bill";
                chartBill.Series[0].IsValueShownAsLabel = true;

                List<object> listBill = statisticService.getListBillByStartDateAndEndDate(startDate, endDate);
                chartBill.DataSource = listBill;
                chartBill.Series[0].XValueMember = "Date";
                chartBill.Series[0].YValueMembers = "Value";
                chartBill.DataBind();

                // Product
                chartProduct.Series[0].IsValueShownAsLabel = true;

                List<object> listProduct2 = statisticService.getListProductByStartDateAndEndDate2(startDate, endDate);
                chartProduct.DataSource = listProduct2;
                chartProduct.Series[0].XValueMember = "ProductName";
                chartProduct.Series[0].YValueMembers = "Value";
                chartProduct.DataBind();

                // Revenue
                chartRevenue.Series[0].Points.Clear();
                List<ObjectDTO> listRevenue = statisticService.getListRevenueByStartDateAndEndDate3(startDate, endDate);
                if (listRevenue != null)
                {
                    int i = 0;
                    foreach (var x in listRevenue)
                    {
                        chartRevenue.Series[0].Points.AddXY(x.Text, x.Value);
                        chartRevenue.Series[0].Points[i].Label = x.Value.ToString("#,##");
                        chartRevenue.Series[0].Points[i].LegendText = x.Text.ToString();

                        i++;
                    }
                }
            }
            else if (cbbBy.SelectedIndex == 1)
            {
                // Bill;
                chartBill.ChartAreas[0].AxisX.Title = "Month";
                chartBill.ChartAreas[0].AxisY.Title = "Value";
                chartBill.Series[0].IsValueShownAsLabel = true;

                List<object> listBill = statisticService.getListBillByMonth(startDate, endDate);
                chartBill.DataSource = listBill;
                chartBill.Series[0].XValueMember = "Date";
                chartBill.Series[0].YValueMembers = "Value";
                chartBill.DataBind();

                //Product
                chartProduct.Series[0].IsValueShownAsLabel = true;

                List<object> listProduct2 = statisticService.getListProductByStartDateAndEndDate2(startDate, endDate);
                chartProduct.DataSource = listProduct2;
                chartProduct.Series[0].XValueMember = "ProductName";
                chartProduct.Series[0].YValueMembers = "Value";
                chartProduct.DataBind();
                // Revenue
                chartRevenue.Series[0].Points.Clear();
                List<ObjectDTO> listRevenue = statisticService.getListRevenueByMonth2(startDate, endDate);

                if (listRevenue != null)
                {
                    int i = 0;
                    foreach (var x in listRevenue)
                    {
                        chartRevenue.Series[0].Points.AddXY(x.Text, x.Value);
                        chartRevenue.Series[0].Points[i].Label = x.Value.ToString("#,##");
                        chartRevenue.Series[0].Points[i].LegendText = x.Text.ToString();

                        i++;
                    }
                }



            }
            else if (cbbBy.SelectedIndex == 2)
            {
                // Bill;
                chartBill.ChartAreas[0].AxisX.Title = "Year";
                chartBill.ChartAreas[0].AxisY.Title = "Value";
                chartBill.Series[0].IsValueShownAsLabel = true;

                List<object> listBill = statisticService.getListBillByYear(startDate, endDate);
                chartBill.DataSource = listBill;
                chartBill.Series[0].XValueMember = "Date";
                chartBill.Series[0].YValueMembers = "Value";
                chartBill.DataBind();
                chartProduct.Series[0].IsValueShownAsLabel = true;
                // Product
                List<object> listProduct2 = statisticService.getListProductByStartDateAndEndDate2(startDate, endDate);
                chartProduct.DataSource = listProduct2;
                chartProduct.Series[0].XValueMember = "ProductName";
                chartProduct.Series[0].YValueMembers = "Value";
                chartProduct.DataBind();

                // Revenue
                chartRevenue.Series[0].Points.Clear();
                List<ObjectDTO> listRevenue = statisticService.getListRevenueByYear2(startDate, endDate);

                if (listRevenue != null)
                {
                    int i = 0;
                    foreach (var x in listRevenue)
                    {
                        chartRevenue.Series[0].Points.AddXY(x.Text, x.Value);
                        chartRevenue.Series[0].Points[i].Label = x.Value.ToString("#,##");
                        chartRevenue.Series[0].Points[i].LegendText = x.Text.ToString();
                        i++;
                    }
                }
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
