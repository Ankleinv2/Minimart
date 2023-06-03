namespace ManageMiniMart.View
{
    partial class FormStatistical
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStatistical));
            this.chartBill = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartProduct = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtpStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnStatistical = new Guna.UI2.WinForms.Guna2Button();
            this.cbbBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chartBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProduct)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartBill
            // 
            this.chartBill.BackColor = System.Drawing.Color.RosyBrown;
            this.chartBill.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            this.chartBill.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea1.BackImageTransparentColor = System.Drawing.Color.White;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartBill.ChartAreas.Add(chartArea1);
            this.chartBill.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chartBill.Legends.Add(legend1);
            this.chartBill.Location = new System.Drawing.Point(0, 0);
            this.chartBill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartBill.Name = "chartBill";
            this.chartBill.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            series1.Legend = "Legend1";
            series1.Name = "Total bill";
            this.chartBill.Series.Add(series1);
            this.chartBill.Size = new System.Drawing.Size(905, 387);
            this.chartBill.TabIndex = 0;
            this.chartBill.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Total number of bill";
            this.chartBill.Titles.Add(title1);
            // 
            // chartRevenue
            // 
            this.chartRevenue.BackColor = System.Drawing.Color.RosyBrown;
            this.chartRevenue.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            this.chartRevenue.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea2);
            this.chartRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chartRevenue.Legends.Add(legend2);
            this.chartRevenue.Location = new System.Drawing.Point(0, 32);
            this.chartRevenue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartRevenue.Name = "chartRevenue";
            this.chartRevenue.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))))};
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            series2.LabelBorderWidth = 3;
            series2.Legend = "Legend1";
            series2.Name = "Revenue";
            this.chartRevenue.Series.Add(series2);
            this.chartRevenue.Size = new System.Drawing.Size(1329, 256);
            this.chartRevenue.TabIndex = 1;
            this.chartRevenue.Text = "chart2";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "Revenue";
            this.chartRevenue.Titles.Add(title2);
            // 
            // chartProduct
            // 
            this.chartProduct.BackColor = System.Drawing.Color.RosyBrown;
            this.chartProduct.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            this.chartProduct.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.chartProduct.BorderlineColor = System.Drawing.Color.Empty;
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            chartArea3.BackImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            chartArea3.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chartProduct.ChartAreas.Add(chartArea3);
            this.chartProduct.Dock = System.Windows.Forms.DockStyle.Right;
            legend3.Alignment = System.Drawing.StringAlignment.Center;
            legend3.BackColor = System.Drawing.Color.Transparent;
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            this.chartProduct.Legends.Add(legend3);
            this.chartProduct.Location = new System.Drawing.Point(905, 0);
            this.chartProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartProduct.Name = "chartProduct";
            series3.BorderColor = System.Drawing.Color.AntiqueWhite;
            series3.BorderWidth = 6;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.LabelBorderWidth = 10;
            series3.LabelForeColor = System.Drawing.Color.White;
            series3.Legend = "Legend1";
            series3.MarkerBorderColor = System.Drawing.Color.MediumBlue;
            series3.MarkerBorderWidth = 10;
            series3.MarkerSize = 10;
            series3.Name = "Products";
            this.chartProduct.Series.Add(series3);
            this.chartProduct.Size = new System.Drawing.Size(424, 387);
            this.chartProduct.TabIndex = 2;
            this.chartProduct.Text = "chart3";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Title1";
            title3.Text = "Top 5 most sold products";
            this.chartProduct.Titles.Add(title3);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.BorderRadius = 10;
            this.dtpStartDate.Checked = true;
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpStartDate.Location = new System.Drawing.Point(151, 21);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpStartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(247, 34);
            this.dtpStartDate.TabIndex = 3;
            this.dtpStartDate.Value = new System.DateTime(2023, 6, 2, 20, 48, 39, 350);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.BorderRadius = 10;
            this.dtpEndDate.Checked = true;
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpEndDate.Location = new System.Drawing.Point(486, 19);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpEndDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEndDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(246, 34);
            this.dtpEndDate.TabIndex = 4;
            this.dtpEndDate.Value = new System.DateTime(2023, 6, 2, 20, 48, 39, 350);
            // 
            // btnStatistical
            // 
            this.btnStatistical.BorderRadius = 10;
            this.btnStatistical.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStatistical.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStatistical.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStatistical.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStatistical.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnStatistical.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistical.ForeColor = System.Drawing.Color.White;
            this.btnStatistical.Image = ((System.Drawing.Image)(resources.GetObject("btnStatistical.Image")));
            this.btnStatistical.Location = new System.Drawing.Point(993, 15);
            this.btnStatistical.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStatistical.Name = "btnStatistical";
            this.btnStatistical.Size = new System.Drawing.Size(207, 40);
            this.btnStatistical.TabIndex = 5;
            this.btnStatistical.Text = "Statistical";
            this.btnStatistical.Click += new System.EventHandler(this.btnStatistical_Click);
            // 
            // cbbBy
            // 
            this.cbbBy.BackColor = System.Drawing.Color.Transparent;
            this.cbbBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cbbBy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbBy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbBy.ItemHeight = 30;
            this.cbbBy.Location = new System.Drawing.Point(786, 19);
            this.cbbBy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbBy.Name = "cbbBy";
            this.cbbBy.Size = new System.Drawing.Size(175, 36);
            this.cbbBy.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(417, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(51, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "From";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1329, 751);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtpEndDate);
            this.panel2.Controls.Add(this.dtpStartDate);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbbBy);
            this.panel2.Controls.Add(this.btnStatistical);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1329, 76);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.chartBill);
            this.panel3.Controls.Add(this.chartProduct);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1329, 387);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.chartRevenue);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 463);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1329, 288);
            this.panel4.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(877, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(28, 387);
            this.panel5.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1329, 32);
            this.panel6.TabIndex = 2;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // FormStatistical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1329, 751);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormStatistical";
            this.Text = "FormStatistical";
            ((System.ComponentModel.ISupportInitialize)(this.chartBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartBill;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProduct;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStartDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEndDate;
        private Guna.UI2.WinForms.Guna2Button btnStatistical;
        private Guna.UI2.WinForms.Guna2ComboBox cbbBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}