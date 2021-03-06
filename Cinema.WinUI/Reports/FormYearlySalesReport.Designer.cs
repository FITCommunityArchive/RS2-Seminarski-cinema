﻿namespace Cinema.WinUI.Reports
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
            this.pgnYearlySales = new Cinema.WinUI.UserControls.Pagination();
            this.dgvUserSalesList = new System.Windows.Forms.DataGridView();
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExportPDF = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.nmrUserId = new System.Windows.Forms.NumericUpDown();
            this.nmrYear = new System.Windows.Forms.NumericUpDown();
            this.nmrNumberOfEntries = new System.Windows.Forms.NumericUpDown();
            this.lblShowEntries = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblReportTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBreadCrumbsCurrent = new System.Windows.Forms.Label();
            this.txtFormTitle = new System.Windows.Forms.TextBox();
            this.lblBreadcrumbs = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserSalesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUserId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrNumberOfEntries)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pgnYearlySales
            // 
            this.pgnYearlySales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pgnYearlySales.AutoSize = true;
            this.pgnYearlySales.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pgnYearlySales.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pgnYearlySales.Location = new System.Drawing.Point(1273, 6);
            this.pgnYearlySales.Margin = new System.Windows.Forms.Padding(7, 6, 0, 6);
            this.pgnYearlySales.Name = "pgnYearlySales";
            this.pgnYearlySales.PageIndex = 0;
            this.pgnYearlySales.Size = new System.Drawing.Size(210, 35);
            this.pgnYearlySales.TabIndex = 12;
            this.pgnYearlySales.TotalPages = 0;
            this.pgnYearlySales.PageChanged += new System.EventHandler(this.pgnYearlySales_PageChanged);
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
            this.dgvUserSalesList.Location = new System.Drawing.Point(20, 18);
            this.dgvUserSalesList.Margin = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.dgvUserSalesList.Name = "dgvUserSalesList";
            this.dgvUserSalesList.ReadOnly = true;
            this.dgvUserSalesList.RowHeadersVisible = false;
            this.dgvUserSalesList.RowHeadersWidth = 51;
            this.dgvUserSalesList.RowTemplate.Height = 24;
            this.dgvUserSalesList.Size = new System.Drawing.Size(1443, 468);
            this.dgvUserSalesList.TabIndex = 1;
            this.dgvUserSalesList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvReportReservations_CellFormatting);
            this.dgvUserSalesList.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUserSalesList_ColumnHeaderMouseClick);
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
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrint.AutoSize = true;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.DimGray;
            this.btnPrint.Location = new System.Drawing.Point(642, 24);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(7, 6, 0, 6);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(80, 37);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExportPDF
            // 
            this.btnExportPDF.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExportPDF.AutoSize = true;
            this.btnExportPDF.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btnExportPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportPDF.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportPDF.ForeColor = System.Drawing.Color.DimGray;
            this.btnExportPDF.Location = new System.Drawing.Point(463, 24);
            this.btnExportPDF.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnExportPDF.Name = "btnExportPDF";
            this.btnExportPDF.Size = new System.Drawing.Size(165, 37);
            this.btnExportPDF.TabIndex = 1;
            this.btnExportPDF.Text = "Export to PDF";
            this.btnExportPDF.UseVisualStyleBackColor = true;
            this.btnExportPDF.Click += new System.EventHandler(this.btnExportPDF_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustomerName.Location = new System.Drawing.Point(562, 49);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(172, 22);
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
            this.lblYear.Location = new System.Drawing.Point(192, 19);
            this.lblYear.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(171, 18);
            this.lblYear.TabIndex = 9;
            this.lblYear.Text = "Year";
            // 
            // nmrUserId
            // 
            this.nmrUserId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nmrUserId.Location = new System.Drawing.Point(377, 49);
            this.nmrUserId.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
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
            this.nmrUserId.Size = new System.Drawing.Size(171, 22);
            this.nmrUserId.TabIndex = 8;
            this.nmrUserId.ValueChanged += new System.EventHandler(this.SearchChanged);
            this.nmrUserId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nmrUserId_KeyDown);
            // 
            // nmrYear
            // 
            this.nmrYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nmrYear.Location = new System.Drawing.Point(192, 49);
            this.nmrYear.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.nmrYear.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nmrYear.Name = "nmrYear";
            this.nmrYear.Size = new System.Drawing.Size(171, 22);
            this.nmrYear.TabIndex = 7;
            this.nmrYear.ValueChanged += new System.EventHandler(this.SearchChanged);
            this.nmrYear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nmrYear_KeyDown);
            // 
            // nmrNumberOfEntries
            // 
            this.nmrNumberOfEntries.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nmrNumberOfEntries.Location = new System.Drawing.Point(20, 49);
            this.nmrNumberOfEntries.Margin = new System.Windows.Forms.Padding(20, 6, 7, 6);
            this.nmrNumberOfEntries.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nmrNumberOfEntries.Name = "nmrNumberOfEntries";
            this.nmrNumberOfEntries.Size = new System.Drawing.Size(158, 22);
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
            this.lblShowEntries.Location = new System.Drawing.Point(20, 19);
            this.lblShowEntries.Margin = new System.Windows.Forms.Padding(20, 6, 7, 6);
            this.lblShowEntries.Name = "lblShowEntries";
            this.lblShowEntries.Size = new System.Drawing.Size(158, 18);
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
            this.lblCustomerID.Location = new System.Drawing.Point(377, 19);
            this.lblCustomerID.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(171, 18);
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
            this.lblCustomerName.Location = new System.Drawing.Point(562, 19);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(172, 18);
            this.lblCustomerName.TabIndex = 11;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblReportTitle
            // 
            this.lblReportTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReportTitle.AutoSize = true;
            this.lblReportTitle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblReportTitle.Location = new System.Drawing.Point(13, 20);
            this.lblReportTitle.Name = "lblReportTitle";
            this.lblReportTitle.Size = new System.Drawing.Size(397, 25);
            this.lblReportTitle.TabIndex = 14;
            this.lblReportTitle.Text = "Sales per Customer (without VAT)";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1563, 922);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblBreadCrumbsCurrent);
            this.panel1.Controls.Add(this.txtFormTitle);
            this.panel1.Controls.Add(this.lblBreadcrumbs);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1563, 92);
            this.panel1.TabIndex = 0;
            // 
            // lblBreadCrumbsCurrent
            // 
            this.lblBreadCrumbsCurrent.AutoSize = true;
            this.lblBreadCrumbsCurrent.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreadCrumbsCurrent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBreadCrumbsCurrent.Location = new System.Drawing.Point(107, 55);
            this.lblBreadCrumbsCurrent.Margin = new System.Windows.Forms.Padding(0);
            this.lblBreadCrumbsCurrent.Name = "lblBreadCrumbsCurrent";
            this.lblBreadCrumbsCurrent.Size = new System.Drawing.Size(145, 17);
            this.lblBreadCrumbsCurrent.TabIndex = 11;
            this.lblBreadCrumbsCurrent.Text = "Yearly sale report";
            // 
            // txtFormTitle
            // 
            this.txtFormTitle.BackColor = System.Drawing.Color.White;
            this.txtFormTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFormTitle.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormTitle.ForeColor = System.Drawing.Color.Gray;
            this.txtFormTitle.Location = new System.Drawing.Point(40, 12);
            this.txtFormTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFormTitle.Name = "txtFormTitle";
            this.txtFormTitle.Size = new System.Drawing.Size(121, 33);
            this.txtFormTitle.TabIndex = 9;
            this.txtFormTitle.Text = "Reports";
            // 
            // lblBreadcrumbs
            // 
            this.lblBreadcrumbs.AutoSize = true;
            this.lblBreadcrumbs.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreadcrumbs.Location = new System.Drawing.Point(40, 55);
            this.lblBreadcrumbs.Margin = new System.Windows.Forms.Padding(0);
            this.lblBreadcrumbs.Name = "lblBreadcrumbs";
            this.lblBreadcrumbs.Size = new System.Drawing.Size(59, 17);
            this.lblBreadcrumbs.TabIndex = 10;
            this.lblBreadcrumbs.Text = "Home /";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(40, 129);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(40, 37, 40, 18);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1483, 652);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.dgvUserSalesList);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 148);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.panel3.Size = new System.Drawing.Size(1483, 504);
            this.panel3.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 62);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1483, 86);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.lblCustomerName, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblShowEntries, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.nmrNumberOfEntries, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblCustomerID, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblYear, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.nmrYear, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtCustomerName, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.nmrUserId, 2, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(741, 86);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.btnPrint);
            this.flowLayoutPanel1.Controls.Add(this.btnExportPDF);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(741, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(20, 18, 0, 6);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(742, 86);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lblReportTitle);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1483, 62);
            this.panel4.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.pgnYearlySales);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(40, 817);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(40, 18, 40, 37);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1483, 68);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // FormYearlySalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1563, 922);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1061, 728);
            this.Name = "FormYearlySalesReport";
            this.Text = "FormReports";
            this.Load += new System.EventHandler(this.FormReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserSalesList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUserId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrNumberOfEntries)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvUserSalesList;
        private UserControls.Pagination pgnYearlySales;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExportPDF;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.NumericUpDown nmrUserId;
        private System.Windows.Forms.NumericUpDown nmrYear;
        private System.Windows.Forms.NumericUpDown nmrNumberOfEntries;
        private System.Windows.Forms.Label lblShowEntries;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblCustomerName;
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
        private System.Windows.Forms.Label lblReportTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lblBreadCrumbsCurrent;
        private System.Windows.Forms.TextBox txtFormTitle;
        private System.Windows.Forms.Label lblBreadcrumbs;
    }
}