using LiveCharts;
using LiveCharts.Wpf;
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
    public partial class FormAnalyst : Form
    {
        private StatisticalService statisticalService;
        private CustomerService customerService;
        private BillService billService;
        public FormAnalyst()
        {
            InitializeComponent();
            statisticalService = new StatisticalService();
            customerService = new CustomerService();
            billService = new BillService();
            loadTotalInCurrentDate();
            loadTotalInMonth();
            loadTotalInYear();
            loadTotalCustomer();
            chartRevenue.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Month",
                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
            });
            chartRevenue.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Revenue",
                //abelFormatter = value => value.ToString("C")
                LabelFormatter = value => value.ToString("#,##0đ")
            });
            chartRevenue.LegendLocation = LiveCharts.LegendLocation.Right;
            loadRevenue();
            loadChartCustomer(2019);
        }
        //private void loadRevenue()
        //{
        //    chartRevenue.Series.Clear();
        //    SeriesCollection series = new SeriesCollection();
        //    Random r = new Random();
        //    for (int i =2020; i< 2024; i++)
        //    {

        //        List<double> values = new List<double>();
        //        for(int month = 1; month <= 12; month++)
        //        {

        //            values.Add(r.NextDouble() * 200 + 30);
        //        }
        //        series.Add(new LineSeries()
        //        {

        //            Title = i.ToString(),
        //            Values = new ChartValues<double>(values)
        //        });
        //    }
        //    chartRevenue.Series = series;

        //}
        private void loadRevenue()
        {
            chartRevenue.Series.Clear();
            SeriesCollection series = new SeriesCollection();
            List<int> years = statisticalService.getAllYear();
            Random r = new Random();
            foreach (int i in years)
            {

                List<double> values = new List<double>();
                for (int month = 1; month <= 12; month++)
                {

                    values.Add(statisticalService.getAllRevenue(i, month).Value);
                }
                series.Add(new LineSeries()
                {

                    Title = i.ToString(),
                    Values = new ChartValues<double>(values)
                });
            }
            chartRevenue.Series = series;

        }
        private void loadTotalInCurrentDate()
        {
            DateTime curentDate = DateTime.Now.Date;
            lblDailySale.Text = statisticalService.getAllRevenueInDate(curentDate).ToString("#,##0.00") + " đ";
        }
        private void loadTotalInMonth()
        {
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            Revenue revenue = statisticalService.getAllRevenue(year, month);
            lblMonthlySale.Text = revenue.Value.ToString("#,##0.00") + " đ";
        }
        private void loadTotalInYear()
        {
            int year = DateTime.Now.Year;
            lblYearSale.Text = statisticalService.getAllRevenueInYear(year).ToString("#,##0.00") + " đ";
        }
        private void loadTotalCustomer()
        {
            lblTotalCustomer.Text = customerService.getAmountCustomerInSystem().ToString();
            cbbSelectCustomerByYear.DataSource = customerService.getAllYear();
        }
        
        private void loadChartCustomer(int year)
        {
            chartCustomer.Series["AmountCustomer"].Points.Clear();
            for (int i = 1; i < 13; i++)
            {
                int value = customerService.getAmountInMonthAndYear(i, year);
                chartCustomer.Series["AmountCustomer"].Points.Add(value);
                chartCustomer.Series["AmountCustomer"].Points[i - 1].Color = Color.Plum;
                chartCustomer.Series["AmountCustomer"].Points[i - 1].AxisLabel = i.ToString();
                chartCustomer.Series["AmountCustomer"].Points[i - 1].LegendText = value.ToString();
                chartCustomer.Series["AmountCustomer"].Points[i - 1].Label = value.ToString();
            }
        }
        private void cbbSelectCustomerByYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadChartCustomer(Convert.ToInt32(cbbSelectCustomerByYear.Text));
        }
    }
}
