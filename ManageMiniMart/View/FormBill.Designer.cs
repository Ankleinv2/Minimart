namespace ManageMiniMart
{
    partial class FormBill
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpBillDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbbSort2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbSort1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnSortBy = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvBill = new Guna.UI2.WinForms.Guna2DataGridView();
            this.billViewBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.billViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShowDetail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billViewBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billViewBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.dtpBillDate);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 84);
            this.panel1.TabIndex = 0;
            // 
            // dtpBillDate
            // 
            this.dtpBillDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpBillDate.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.dtpBillDate.BorderRadius = 9;
            this.dtpBillDate.BorderThickness = 1;
            this.dtpBillDate.Checked = true;
            this.dtpBillDate.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.dtpBillDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpBillDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpBillDate.Location = new System.Drawing.Point(173, 25);
            this.dtpBillDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpBillDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpBillDate.Name = "dtpBillDate";
            this.dtpBillDate.Size = new System.Drawing.Size(177, 36);
            this.dtpBillDate.TabIndex = 36;
            this.dtpBillDate.Value = new System.DateTime(2023, 4, 8, 22, 56, 26, 751);
            this.dtpBillDate.ValueChanged += new System.EventHandler(this.dtpBillDate_ValueChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSearch.BorderRadius = 25;
            this.btnSearch.BorderThickness = 1;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(666, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 45);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BorderRadius = 20;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(454, 25);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(206, 40);
            this.txtSearch.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel2.Controls.Add(this.cbbSort2);
            this.panel2.Controls.Add(this.cbbSort1);
            this.panel2.Controls.Add(this.btnSortBy);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 339);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 111);
            this.panel2.TabIndex = 3;
            // 
            // cbbSort2
            // 
            this.cbbSort2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbSort2.BackColor = System.Drawing.Color.Transparent;
            this.cbbSort2.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.cbbSort2.BorderRadius = 10;
            this.cbbSort2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbSort2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSort2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.cbbSort2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbSort2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbSort2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbSort2.ForeColor = System.Drawing.Color.White;
            this.cbbSort2.ItemHeight = 30;
            this.cbbSort2.Location = new System.Drawing.Point(557, 30);
            this.cbbSort2.Name = "cbbSort2";
            this.cbbSort2.Size = new System.Drawing.Size(190, 36);
            this.cbbSort2.TabIndex = 8;
            // 
            // cbbSort1
            // 
            this.cbbSort1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbSort1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.cbbSort1.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.cbbSort1.BorderRadius = 10;
            this.cbbSort1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbSort1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSort1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.cbbSort1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbSort1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbSort1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbSort1.ForeColor = System.Drawing.Color.White;
            this.cbbSort1.ItemHeight = 30;
            this.cbbSort1.Location = new System.Drawing.Point(316, 30);
            this.cbbSort1.Name = "cbbSort1";
            this.cbbSort1.Size = new System.Drawing.Size(208, 36);
            this.cbbSort1.TabIndex = 7;
            // 
            // btnSortBy
            // 
            this.btnSortBy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSortBy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSortBy.BorderRadius = 25;
            this.btnSortBy.BorderThickness = 1;
            this.btnSortBy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSortBy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSortBy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSortBy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSortBy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnSortBy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortBy.ForeColor = System.Drawing.Color.White;
            this.btnSortBy.Location = new System.Drawing.Point(95, 30);
            this.btnSortBy.Name = "btnSortBy";
            this.btnSortBy.Size = new System.Drawing.Size(170, 45);
            this.btnSortBy.TabIndex = 4;
            this.btnSortBy.Text = "Sort by";
            this.btnSortBy.Click += new System.EventHandler(this.btnSortBy_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvBill);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 255);
            this.panel3.TabIndex = 4;
            // 
            // dgvBill
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            this.dgvBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBill.AutoGenerateColumns = false;
            this.dgvBill.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBill.ColumnHeadersHeight = 50;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.CreatedTime,
            this.customerNameDataGridViewTextBoxColumn,
            this.employeeNameDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.ShowDetail});
            this.dgvBill.DataSource = this.billViewBindingSource2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBill.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBill.Location = new System.Drawing.Point(0, 0);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.RowHeadersVisible = false;
            this.dgvBill.RowHeadersWidth = 50;
            this.dgvBill.RowTemplate.Height = 50;
            this.dgvBill.RowTemplate.ReadOnly = true;
            this.dgvBill.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBill.Size = new System.Drawing.Size(800, 255);
            this.dgvBill.TabIndex = 3;
            this.dgvBill.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBill.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBill.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBill.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBill.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBill.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dgvBill.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBill.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvBill.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBill.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBill.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBill.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBill.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvBill.ThemeStyle.ReadOnly = false;
            this.dgvBill.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBill.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBill.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBill.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBill.ThemeStyle.RowsStyle.Height = 50;
            this.dgvBill.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBill.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBill_CellContentClick);
            // 
            // billViewBindingSource2
            // 
            this.billViewBindingSource2.DataSource = typeof(ManageMiniMart.DTO.BillView);
            // 
            // billViewBindingSource
            // 
            this.billViewBindingSource.DataSource = typeof(ManageMiniMart.DTO.BillView);
            // 
            // billViewBindingSource1
            // 
            this.billViewBindingSource1.DataSource = typeof(ManageMiniMart.DTO.BillView);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // CreatedTime
            // 
            this.CreatedTime.DataPropertyName = "CreatedTime";
            this.CreatedTime.HeaderText = "Create Time";
            this.CreatedTime.MinimumWidth = 6;
            this.CreatedTime.Name = "CreatedTime";
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "Customer Name";
            this.customerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            // 
            // employeeNameDataGridViewTextBoxColumn
            // 
            this.employeeNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeName";
            this.employeeNameDataGridViewTextBoxColumn.HeaderText = "Employee Name";
            this.employeeNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeNameDataGridViewTextBoxColumn.Name = "employeeNameDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // ShowDetail
            // 
            this.ShowDetail.HeaderText = "";
            this.ShowDetail.MinimumWidth = 6;
            this.ShowDetail.Name = "ShowDetail";
            this.ShowDetail.Text = "Show Detail";
            this.ShowDetail.UseColumnTextForButtonValue = true;
            // 
            // FormBill
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInvoice";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billViewBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billViewBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnSortBy;
        private System.Windows.Forms.BindingSource billViewBindingSource;
        private System.Windows.Forms.BindingSource billViewBindingSource1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvBill;
        private System.Windows.Forms.BindingSource billViewBindingSource2;
        private Guna.UI2.WinForms.Guna2ComboBox cbbSort1;
        private Guna.UI2.WinForms.Guna2ComboBox cbbSort2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpBillDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ShowDetail;
    }
}