namespace Cinema.WinUI.Reports
{
    partial class FormYearlySalesReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pgnReservations = new Cinema.WinUI.UserControls.Pagination();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvUserSalesList = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnExportPDF = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.nmrUserId = new System.Windows.Forms.NumericUpDown();
            this.nmrYear = new System.Windows.Forms.NumericUpDown();
            this.nmrNumberOfEntries = new System.Windows.Forms.NumericUpDown();
            this.lblShowEntries = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblReportTitle = new System.Windows.Forms.Label();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Feb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.May = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearlyTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserSalesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUserId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrNumberOfEntries)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pgnReservations);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 716);
            this.panel1.Margin = new System.Windows.Forms.Padding(40, 37, 40, 37);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15);
            this.panel1.Size = new System.Drawing.Size(1477, 75);
            this.panel1.TabIndex = 12;
            // 
            // pgnReservations
            // 
            this.pgnReservations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pgnReservations.AutoSize = true;
            this.pgnReservations.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pgnReservations.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pgnReservations.Location = new System.Drawing.Point(1247, 24);
            this.pgnReservations.Margin = new System.Windows.Forms.Padding(5);
            this.pgnReservations.Name = "pgnReservations";
            this.pgnReservations.PageIndex = 0;
            this.pgnReservations.Size = new System.Drawing.Size(210, 35);
            this.pgnReservations.TabIndex = 12;
            this.pgnReservations.TotalPages = 0;
            this.pgnReservations.PageChanged += new System.EventHandler(this.pgnReservations_PageChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dgvUserSalesList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 91);
            this.panel2.Margin = new System.Windows.Forms.Padding(40, 37, 40, 37);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(15);
            this.panel2.Size = new System.Drawing.Size(1477, 625);
            this.panel2.TabIndex = 12;
            // 
            // dgvUserSalesList
            // 
            this.dgvUserSalesList.AllowUserToAddRows = false;
            this.dgvUserSalesList.AllowUserToDeleteRows = false;
            this.dgvUserSalesList.AllowUserToResizeColumns = false;
            this.dgvUserSalesList.AllowUserToResizeRows = false;
            this.dgvUserSalesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserSalesList.BackgroundColor = System.Drawing.Color.White;
            this.dgvUserSalesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUserSalesList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvUserSalesList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserSalesList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUserSalesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserSalesList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.UserFullName,
            this.Jan,
            this.Feb,
            this.Mar,
            this.Apr,
            this.May,
            this.Jun,
            this.Jul,
            this.Aug,
            this.Sep,
            this.Oct,
            this.Nov,
            this.Dec,
            this.YearlyTotal});
            this.dgvUserSalesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUserSalesList.GridColor = System.Drawing.Color.White;
            this.dgvUserSalesList.Location = new System.Drawing.Point(15, 15);
            this.dgvUserSalesList.Margin = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.dgvUserSalesList.Name = "dgvUserSalesList";
            this.dgvUserSalesList.ReadOnly = true;
            this.dgvUserSalesList.RowHeadersVisible = false;
            this.dgvUserSalesList.RowHeadersWidth = 51;
            this.dgvUserSalesList.RowTemplate.Height = 24;
            this.dgvUserSalesList.Size = new System.Drawing.Size(1447, 595);
            this.dgvUserSalesList.TabIndex = 1;
            this.dgvUserSalesList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvReportReservations_CellFormatting);
            this.dgvUserSalesList.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUserSalesList_ColumnHeaderMouseClick);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.DimGray;
            this.btnPrint.Location = new System.Drawing.Point(1263, 52);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(174, 27);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExcel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportExcel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.ForeColor = System.Drawing.Color.DimGray;
            this.btnExportExcel.Location = new System.Drawing.Point(863, 52);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(174, 27);
            this.btnExportExcel.TabIndex = 0;
            this.btnExportExcel.Text = "Export to excel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnExportPDF
            // 
            this.btnExportPDF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportPDF.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btnExportPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportPDF.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportPDF.ForeColor = System.Drawing.Color.DimGray;
            this.btnExportPDF.Location = new System.Drawing.Point(1063, 52);
            this.btnExportPDF.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnExportPDF.Name = "btnExportPDF";
            this.btnExportPDF.Size = new System.Drawing.Size(174, 27);
            this.btnExportPDF.TabIndex = 1;
            this.btnExportPDF.Text = "Export to PDF";
            this.btnExportPDF.UseVisualStyleBackColor = true;
            this.btnExportPDF.Click += new System.EventHandler(this.btnExportPDF_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomerName.Location = new System.Drawing.Point(460, 50);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(10, 10, 10, 15);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(180, 22);
            this.txtCustomerName.TabIndex = 12;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.SearchChanged);
            // 
            // lblYear
            // 
            this.lblYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.Color.DimGray;
            this.lblYear.Location = new System.Drawing.Point(153, 22);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(144, 18);
            this.lblYear.TabIndex = 9;
            this.lblYear.Text = "Year";
            // 
            // nmrUserId
            // 
            this.nmrUserId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nmrUserId.Location = new System.Drawing.Point(310, 50);
            this.nmrUserId.Margin = new System.Windows.Forms.Padding(10);
            this.nmrUserId.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nmrUserId.Minimum = new decimal(new int[] {
            -727379968,
            232,
            0,
            -2147483648});
            this.nmrUserId.Name = "nmrUserId";
            this.nmrUserId.Size = new System.Drawing.Size(130, 22);
            this.nmrUserId.TabIndex = 8;
            this.nmrUserId.ValueChanged += new System.EventHandler(this.SearchChanged);
            this.nmrUserId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nmrUserId_KeyDown);
            // 
            // nmrYear
            // 
            this.nmrYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nmrYear.Location = new System.Drawing.Point(160, 50);
            this.nmrYear.Margin = new System.Windows.Forms.Padding(10);
            this.nmrYear.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nmrYear.Name = "nmrYear";
            this.nmrYear.Size = new System.Drawing.Size(130, 22);
            this.nmrYear.TabIndex = 7;
            this.nmrYear.ValueChanged += new System.EventHandler(this.SearchChanged);
            this.nmrYear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nmrYear_KeyDown);
            // 
            // nmrNumberOfEntries
            // 
            this.nmrNumberOfEntries.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nmrNumberOfEntries.Location = new System.Drawing.Point(10, 50);
            this.nmrNumberOfEntries.Margin = new System.Windows.Forms.Padding(10);
            this.nmrNumberOfEntries.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nmrNumberOfEntries.Name = "nmrNumberOfEntries";
            this.nmrNumberOfEntries.Size = new System.Drawing.Size(130, 22);
            this.nmrNumberOfEntries.TabIndex = 5;
            this.nmrNumberOfEntries.ValueChanged += new System.EventHandler(this.SearchChanged);
            this.nmrNumberOfEntries.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nmrNumberOfEntries_KeyDown);
            // 
            // lblShowEntries
            // 
            this.lblShowEntries.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShowEntries.AutoSize = true;
            this.lblShowEntries.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowEntries.ForeColor = System.Drawing.Color.DimGray;
            this.lblShowEntries.Location = new System.Drawing.Point(10, 22);
            this.lblShowEntries.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblShowEntries.Name = "lblShowEntries";
            this.lblShowEntries.Size = new System.Drawing.Size(137, 18);
            this.lblShowEntries.TabIndex = 6;
            this.lblShowEntries.Text = "Show entries";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.ForeColor = System.Drawing.Color.DimGray;
            this.lblCustomerID.Location = new System.Drawing.Point(303, 22);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(144, 18);
            this.lblCustomerID.TabIndex = 10;
            this.lblCustomerID.Text = "ID";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.ForeColor = System.Drawing.Color.DimGray;
            this.lblCustomerName.Location = new System.Drawing.Point(453, 22);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(194, 18);
            this.lblCustomerName.TabIndex = 11;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Controls.Add(this.lblCustomerName, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCustomerID, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblShowEntries, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.nmrNumberOfEntries, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.nmrYear, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.nmrUserId, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblYear, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtCustomerName, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnExportPDF, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnExportExcel, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnPrint, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblReportTitle, 6, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.24779F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.75221F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1477, 91);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // lblReportTitle
            // 
            this.lblReportTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReportTitle.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblReportTitle, 2);
            this.lblReportTitle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblReportTitle.Location = new System.Drawing.Point(1053, 7);
            this.lblReportTitle.Name = "lblReportTitle";
            this.lblReportTitle.Size = new System.Drawing.Size(394, 25);
            this.lblReportTitle.TabIndex = 13;
            this.lblReportTitle.Text = "Sales per Customer";
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "UserId";
            this.UserId.FillWeight = 50F;
            this.UserId.HeaderText = "ID";
            this.UserId.MinimumWidth = 6;
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            // 
            // UserFullName
            // 
            this.UserFullName.DataPropertyName = "UserFullName";
            this.UserFullName.FillWeight = 200F;
            this.UserFullName.HeaderText = "Customer name";
            this.UserFullName.MinimumWidth = 6;
            this.UserFullName.Name = "UserFullName";
            this.UserFullName.ReadOnly = true;
            // 
            // Jan
            // 
            this.Jan.DataPropertyName = "1";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.Jan.DefaultCellStyle = dataGridViewCellStyle2;
            this.Jan.FillWeight = 70F;
            this.Jan.HeaderText = "Jan";
            this.Jan.MinimumWidth = 6;
            this.Jan.Name = "Jan";
            this.Jan.ReadOnly = true;
            this.Jan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Feb
            // 
            this.Feb.DataPropertyName = "2";
            dataGridViewCellStyle3.Format = "N0";
            this.Feb.DefaultCellStyle = dataGridViewCellStyle3;
            this.Feb.FillWeight = 70F;
            this.Feb.HeaderText = "Feb";
            this.Feb.MinimumWidth = 6;
            this.Feb.Name = "Feb";
            this.Feb.ReadOnly = true;
            this.Feb.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Mar
            // 
            this.Mar.DataPropertyName = "3";
            dataGridViewCellStyle4.Format = "N0";
            this.Mar.DefaultCellStyle = dataGridViewCellStyle4;
            this.Mar.FillWeight = 70F;
            this.Mar.HeaderText = "Mar";
            this.Mar.MinimumWidth = 6;
            this.Mar.Name = "Mar";
            this.Mar.ReadOnly = true;
            // 
            // Apr
            // 
            this.Apr.DataPropertyName = "4";
            dataGridViewCellStyle5.Format = "N0";
            this.Apr.DefaultCellStyle = dataGridViewCellStyle5;
            this.Apr.FillWeight = 70F;
            this.Apr.HeaderText = "Apr";
            this.Apr.MinimumWidth = 6;
            this.Apr.Name = "Apr";
            this.Apr.ReadOnly = true;
            // 
            // May
            // 
            this.May.DataPropertyName = "5";
            dataGridViewCellStyle6.Format = "N0";
            this.May.DefaultCellStyle = dataGridViewCellStyle6;
            this.May.FillWeight = 70F;
            this.May.HeaderText = "May";
            this.May.MinimumWidth = 6;
            this.May.Name = "May";
            this.May.ReadOnly = true;
            // 
            // Jun
            // 
            this.Jun.DataPropertyName = "6";
            dataGridViewCellStyle7.Format = "N0";
            this.Jun.DefaultCellStyle = dataGridViewCellStyle7;
            this.Jun.FillWeight = 70F;
            this.Jun.HeaderText = "Jun";
            this.Jun.MinimumWidth = 6;
            this.Jun.Name = "Jun";
            this.Jun.ReadOnly = true;
            // 
            // Jul
            // 
            this.Jul.DataPropertyName = "7";
            dataGridViewCellStyle8.Format = "N0";
            this.Jul.DefaultCellStyle = dataGridViewCellStyle8;
            this.Jul.FillWeight = 70F;
            this.Jul.HeaderText = "Jul";
            this.Jul.MinimumWidth = 6;
            this.Jul.Name = "Jul";
            this.Jul.ReadOnly = true;
            // 
            // Aug
            // 
            this.Aug.DataPropertyName = "8";
            dataGridViewCellStyle9.Format = "N0";
            this.Aug.DefaultCellStyle = dataGridViewCellStyle9;
            this.Aug.FillWeight = 70F;
            this.Aug.HeaderText = "Aug";
            this.Aug.MinimumWidth = 6;
            this.Aug.Name = "Aug";
            this.Aug.ReadOnly = true;
            // 
            // Sep
            // 
            this.Sep.DataPropertyName = "9";
            dataGridViewCellStyle10.Format = "N0";
            this.Sep.DefaultCellStyle = dataGridViewCellStyle10;
            this.Sep.FillWeight = 70F;
            this.Sep.HeaderText = "Sep";
            this.Sep.MinimumWidth = 6;
            this.Sep.Name = "Sep";
            this.Sep.ReadOnly = true;
            // 
            // Oct
            // 
            this.Oct.DataPropertyName = "10";
            dataGridViewCellStyle11.Format = "N0";
            this.Oct.DefaultCellStyle = dataGridViewCellStyle11;
            this.Oct.FillWeight = 70F;
            this.Oct.HeaderText = "Oct";
            this.Oct.MinimumWidth = 6;
            this.Oct.Name = "Oct";
            this.Oct.ReadOnly = true;
            // 
            // Nov
            // 
            this.Nov.DataPropertyName = "11";
            dataGridViewCellStyle12.Format = "N0";
            this.Nov.DefaultCellStyle = dataGridViewCellStyle12;
            this.Nov.FillWeight = 70F;
            this.Nov.HeaderText = "Nov";
            this.Nov.MinimumWidth = 6;
            this.Nov.Name = "Nov";
            this.Nov.ReadOnly = true;
            // 
            // Dec
            // 
            this.Dec.DataPropertyName = "12";
            this.Dec.FillWeight = 70F;
            this.Dec.HeaderText = "Dec";
            this.Dec.MinimumWidth = 6;
            this.Dec.Name = "Dec";
            this.Dec.ReadOnly = true;
            // 
            // YearlyTotal
            // 
            this.YearlyTotal.DataPropertyName = "YearlyTotal";
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.Format = "N0";
            this.YearlyTotal.DefaultCellStyle = dataGridViewCellStyle13;
            this.YearlyTotal.HeaderText = "Total";
            this.YearlyTotal.MinimumWidth = 6;
            this.YearlyTotal.Name = "YearlyTotal";
            this.YearlyTotal.ReadOnly = true;
            // 
            // FormYearlySalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 791);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormYearlySalesReport";
            this.Text = "FormReports";
            this.Load += new System.EventHandler(this.FormReports_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserSalesList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUserId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrNumberOfEntries)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvUserSalesList;
        private UserControls.Pagination pgnReservations;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnExportPDF;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.NumericUpDown nmrUserId;
        private System.Windows.Forms.NumericUpDown nmrYear;
        private System.Windows.Forms.NumericUpDown nmrNumberOfEntries;
        private System.Windows.Forms.Label lblShowEntries;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblReportTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Feb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apr;
        private System.Windows.Forms.DataGridViewTextBoxColumn May;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jun;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jul;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aug;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nov;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dec;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearlyTotal;
    }
}