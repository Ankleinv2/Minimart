namespace ManageMiniMart.View
{
    partial class AddShiftWorkForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddShiftWorkForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvEmloyee = new Guna.UI2.WinForms.Guna2DataGridView();
            this.personidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtpEndTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpShiftDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpStartTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblShiftId = new System.Windows.Forms.Label();
            this.lblShiftdate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtShiftName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmployeeName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnFind = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmloyee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnMaximize);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 78);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 30;
            this.btnMinimize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMinimize.Location = new System.Drawing.Point(701, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(27, 30);
            this.btnMinimize.TabIndex = 31;
            this.btnMinimize.UseVisualStyleBackColor = true;
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btnMaximize.IconColor = System.Drawing.Color.White;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 30;
            this.btnMaximize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMaximize.Location = new System.Drawing.Point(734, 12);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(27, 30);
            this.btnMaximize.TabIndex = 32;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 30;
            this.btnExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExit.Location = new System.Drawing.Point(767, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(28, 30);
            this.btnExit.TabIndex = 33;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(268, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 32);
            this.label8.TabIndex = 30;
            this.label8.Text = "Shiftwork form";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(823, 449);
            this.panel2.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvEmloyee);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 198);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(823, 195);
            this.panel5.TabIndex = 31;
            // 
            // dgvEmloyee
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            this.dgvEmloyee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmloyee.AutoGenerateColumns = false;
            this.dgvEmloyee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmloyee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmloyee.ColumnHeadersHeight = 50;
            this.dgvEmloyee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvEmloyee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personidDataGridViewTextBoxColumn,
            this.personnameDataGridViewTextBoxColumn,
            this.birthdateDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.Remove});
            this.dgvEmloyee.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgvEmloyee.DataSource = this.personBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmloyee.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmloyee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmloyee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEmloyee.Location = new System.Drawing.Point(0, 0);
            this.dgvEmloyee.Name = "dgvEmloyee";
            this.dgvEmloyee.RowHeadersVisible = false;
            this.dgvEmloyee.RowHeadersWidth = 50;
            this.dgvEmloyee.RowTemplate.Height = 50;
            this.dgvEmloyee.RowTemplate.ReadOnly = true;
            this.dgvEmloyee.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmloyee.Size = new System.Drawing.Size(823, 195);
            this.dgvEmloyee.TabIndex = 4;
            this.dgvEmloyee.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEmloyee.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvEmloyee.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvEmloyee.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvEmloyee.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvEmloyee.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dgvEmloyee.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEmloyee.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvEmloyee.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEmloyee.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEmloyee.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEmloyee.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvEmloyee.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvEmloyee.ThemeStyle.ReadOnly = false;
            this.dgvEmloyee.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEmloyee.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEmloyee.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEmloyee.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvEmloyee.ThemeStyle.RowsStyle.Height = 50;
            this.dgvEmloyee.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEmloyee.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvEmloyee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmloyee_CellContentClick);
            // 
            // personidDataGridViewTextBoxColumn
            // 
            this.personidDataGridViewTextBoxColumn.DataPropertyName = "person_id";
            this.personidDataGridViewTextBoxColumn.HeaderText = "person_id";
            this.personidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personidDataGridViewTextBoxColumn.Name = "personidDataGridViewTextBoxColumn";
            // 
            // personnameDataGridViewTextBoxColumn
            // 
            this.personnameDataGridViewTextBoxColumn.DataPropertyName = "person_name";
            this.personnameDataGridViewTextBoxColumn.HeaderText = "person_name";
            this.personnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personnameDataGridViewTextBoxColumn.Name = "personnameDataGridViewTextBoxColumn";
            // 
            // birthdateDataGridViewTextBoxColumn
            // 
            this.birthdateDataGridViewTextBoxColumn.DataPropertyName = "birthdate";
            this.birthdateDataGridViewTextBoxColumn.HeaderText = "birthdate";
            this.birthdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birthdateDataGridViewTextBoxColumn.Name = "birthdateDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "salary";
            this.salaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // Remove
            // 
            this.Remove.HeaderText = "REMOVE";
            this.Remove.MinimumWidth = 6;
            this.Remove.Name = "Remove";
            this.Remove.Text = "remove";
            this.Remove.UseColumnTextForButtonValue = true;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(ManageMiniMart.DAL.Person);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Controls.Add(this.btnCancel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 393);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(823, 56);
            this.panel4.TabIndex = 30;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BorderRadius = 10;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSave.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSave.Location = new System.Drawing.Point(152, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 45);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "SAVE";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.SlateBlue;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnCancel.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCancel.Location = new System.Drawing.Point(525, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(131, 45);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtpEndTime);
            this.panel3.Controls.Add(this.dtpShiftDate);
            this.panel3.Controls.Add(this.dtpStartTime);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lblShiftId);
            this.panel3.Controls.Add(this.lblShiftdate);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtShiftName);
            this.panel3.Controls.Add(this.txtEmployeeName);
            this.panel3.Controls.Add(this.btnFind);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(823, 198);
            this.panel3.TabIndex = 29;
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpEndTime.Checked = true;
            this.dtpEndTime.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.dtpEndTime.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEndTime.Location = new System.Drawing.Point(275, 122);
            this.dtpEndTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEndTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.ShowUpDown = true;
            this.dtpEndTime.Size = new System.Drawing.Size(225, 26);
            this.dtpEndTime.TabIndex = 34;
            this.dtpEndTime.Value = new System.DateTime(2023, 5, 4, 1, 25, 21, 189);
            // 
            // dtpShiftDate
            // 
            this.dtpShiftDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpShiftDate.Checked = true;
            this.dtpShiftDate.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.dtpShiftDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpShiftDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpShiftDate.Location = new System.Drawing.Point(275, 40);
            this.dtpShiftDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpShiftDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpShiftDate.Name = "dtpShiftDate";
            this.dtpShiftDate.ShowUpDown = true;
            this.dtpShiftDate.Size = new System.Drawing.Size(225, 26);
            this.dtpShiftDate.TabIndex = 33;
            this.dtpShiftDate.Value = new System.DateTime(2023, 5, 4, 1, 25, 30, 414);
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpStartTime.Checked = true;
            this.dtpStartTime.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.dtpStartTime.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStartTime.Location = new System.Drawing.Point(275, 80);
            this.dtpStartTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStartTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShowUpDown = true;
            this.dtpStartTime.Size = new System.Drawing.Size(225, 26);
            this.dtpStartTime.TabIndex = 33;
            this.dtpStartTime.Value = new System.DateTime(2023, 5, 4, 1, 25, 30, 414);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(88, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "End time";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(88, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 32;
            this.label3.Text = "Start time";
            // 
            // lblShiftId
            // 
            this.lblShiftId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblShiftId.AutoSize = true;
            this.lblShiftId.Location = new System.Drawing.Point(549, 31);
            this.lblShiftId.Name = "lblShiftId";
            this.lblShiftId.Size = new System.Drawing.Size(0, 13);
            this.lblShiftId.TabIndex = 31;
            this.lblShiftId.Visible = false;
            // 
            // lblShiftdate
            // 
            this.lblShiftdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblShiftdate.AutoSize = true;
            this.lblShiftdate.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShiftdate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblShiftdate.Location = new System.Drawing.Point(88, 43);
            this.lblShiftdate.Name = "lblShiftdate";
            this.lblShiftdate.Size = new System.Drawing.Size(67, 19);
            this.lblShiftdate.TabIndex = 29;
            this.lblShiftdate.Text = "Shift date";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(88, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "Shift name";
            // 
            // txtShiftName
            // 
            this.txtShiftName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtShiftName.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.txtShiftName.BorderRadius = 10;
            this.txtShiftName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtShiftName.DefaultText = "";
            this.txtShiftName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtShiftName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtShiftName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtShiftName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtShiftName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtShiftName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtShiftName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShiftName.ForeColor = System.Drawing.Color.White;
            this.txtShiftName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtShiftName.Location = new System.Drawing.Point(275, 5);
            this.txtShiftName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtShiftName.Name = "txtShiftName";
            this.txtShiftName.PasswordChar = '\0';
            this.txtShiftName.PlaceholderText = "";
            this.txtShiftName.SelectedText = "";
            this.txtShiftName.Size = new System.Drawing.Size(225, 30);
            this.txtShiftName.TabIndex = 28;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmployeeName.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.txtEmployeeName.BorderRadius = 10;
            this.txtEmployeeName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmployeeName.DefaultText = "";
            this.txtEmployeeName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmployeeName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmployeeName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmployeeName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmployeeName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtEmployeeName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmployeeName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeName.ForeColor = System.Drawing.Color.White;
            this.txtEmployeeName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmployeeName.Location = new System.Drawing.Point(273, 159);
            this.txtEmployeeName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.PasswordChar = '\0';
            this.txtEmployeeName.PlaceholderText = "";
            this.txtEmployeeName.SelectedText = "";
            this.txtEmployeeName.Size = new System.Drawing.Size(225, 30);
            this.txtEmployeeName.TabIndex = 28;
            // 
            // btnFind
            // 
            this.btnFind.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFind.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnFind.BorderRadius = 9;
            this.btnFind.BorderThickness = 1;
            this.btnFind.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFind.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFind.FillColor = System.Drawing.Color.Empty;
            this.btnFind.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.ImageSize = new System.Drawing.Size(50, 50);
            this.btnFind.Location = new System.Drawing.Point(533, 134);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(106, 48);
            this.btnFind.TabIndex = 27;
            this.btnFind.Text = "Find";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(88, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "EmployeeName";
            // 
            // AddShiftWorkForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(823, 527);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddShiftWorkForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddShiftWork";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmloyee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtEmployeeName;
        private Guna.UI2.WinForms.Guna2Button btnFind;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2DataGridView dgvEmloyee;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn personidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Remove;
        private System.Windows.Forms.Label lblShiftId;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEndTime;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStartTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtShiftName;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpShiftDate;
        private System.Windows.Forms.Label lblShiftdate;
    }
}