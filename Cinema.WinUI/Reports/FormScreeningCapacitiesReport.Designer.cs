namespace Cinema.WinUI.Reports
{
    partial class FormScreeningCapacitiesReport
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
            this.pgnScreenings = new Cinema.WinUI.UserControls.Pagination();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pgnReservations = new Cinema.WinUI.UserControls.Pagination();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLoadScreenings = new System.Windows.Forms.Button();
            this.btnLoadReservations = new System.Windows.Forms.Button();
            this.btnExportPDF = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvUserSalesList = new System.Windows.Forms.DataGridView();
            this.dgvScreeningsList = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateAndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserSalesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScreeningsList)).BeginInit();
            this.SuspendLayout();
            // 
            // pgnScreenings
            // 
            this.pgnScreenings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pgnScreenings.AutoSize = true;
            this.pgnScreenings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pgnScreenings.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pgnScreenings.Location = new System.Drawing.Point(1250, 24);
            this.pgnScreenings.Margin = new System.Windows.Forms.Padding(5);
            this.pgnScreenings.Name = "pgnScreenings";
            this.pgnScreenings.PageIndex = 0;
            this.pgnScreenings.Size = new System.Drawing.Size(210, 35);
            this.pgnScreenings.TabIndex = 11;
            this.pgnScreenings.TotalPages = 0;
            this.pgnScreenings.PageChanged += new System.EventHandler(this.pgnScreenings_PageChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pgnReservations);
            this.panel1.Controls.Add(this.pgnScreenings);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnLoadScreenings, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLoadReservations, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnExportPDF, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPrint, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnExportExcel, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1477, 71);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // btnLoadScreenings
            // 
            this.btnLoadScreenings.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnLoadScreenings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btnLoadScreenings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadScreenings.Location = new System.Drawing.Point(186, 21);
            this.btnLoadScreenings.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnLoadScreenings.Name = "btnLoadScreenings";
            this.btnLoadScreenings.Size = new System.Drawing.Size(127, 28);
            this.btnLoadScreenings.TabIndex = 3;
            this.btnLoadScreenings.Text = "Screenings data";
            this.btnLoadScreenings.UseVisualStyleBackColor = true;
            this.btnLoadScreenings.Click += new System.EventHandler(this.btnLoadScreenings_Click);
            // 
            // btnLoadReservations
            // 
            this.btnLoadReservations.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnLoadReservations.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btnLoadReservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadReservations.Location = new System.Drawing.Point(13, 21);
            this.btnLoadReservations.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnLoadReservations.Name = "btnLoadReservations";
            this.btnLoadReservations.Size = new System.Drawing.Size(147, 28);
            this.btnLoadReservations.TabIndex = 2;
            this.btnLoadReservations.Text = "Reservations data";
            this.btnLoadReservations.UseVisualStyleBackColor = true;
            this.btnLoadReservations.Click += new System.EventHandler(this.btnLoadReservations_Click);
            // 
            // btnExportPDF
            // 
            this.btnExportPDF.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExportPDF.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btnExportPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportPDF.Location = new System.Drawing.Point(1257, 21);
            this.btnExportPDF.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnExportPDF.Name = "btnExportPDF";
            this.btnExportPDF.Size = new System.Drawing.Size(113, 28);
            this.btnExportPDF.TabIndex = 1;
            this.btnExportPDF.Text = "Export to PDF";
            this.btnExportPDF.UseVisualStyleBackColor = true;
            this.btnExportPDF.Click += new System.EventHandler(this.btnExportPDF_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Location = new System.Drawing.Point(1396, 21);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(68, 28);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExportExcel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportExcel.Location = new System.Drawing.Point(1112, 21);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(119, 28);
            this.btnExportExcel.TabIndex = 0;
            this.btnExportExcel.Text = "Export to excel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dgvUserSalesList);
            this.panel2.Controls.Add(this.dgvScreeningsList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 71);
            this.panel2.Margin = new System.Windows.Forms.Padding(40, 37, 40, 37);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(15);
            this.panel2.Size = new System.Drawing.Size(1477, 645);
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
            this.dgvUserSalesList.Size = new System.Drawing.Size(1447, 615);
            this.dgvUserSalesList.TabIndex = 1;
            this.dgvUserSalesList.Visible = false;
            this.dgvUserSalesList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvReportReservations_CellFormatting);
            // 
            // dgvScreeningsList
            // 
            this.dgvScreeningsList.AllowUserToAddRows = false;
            this.dgvScreeningsList.AllowUserToDeleteRows = false;
            this.dgvScreeningsList.AllowUserToResizeColumns = false;
            this.dgvScreeningsList.AllowUserToResizeRows = false;
            this.dgvScreeningsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvScreeningsList.BackgroundColor = System.Drawing.Color.White;
            this.dgvScreeningsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvScreeningsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvScreeningsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvScreeningsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvScreeningsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScreeningsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.Hall,
            this.DateAndTime,
            this.Price,
            this.Status});
            this.dgvScreeningsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvScreeningsList.GridColor = System.Drawing.Color.White;
            this.dgvScreeningsList.Location = new System.Drawing.Point(15, 15);
            this.dgvScreeningsList.Margin = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.dgvScreeningsList.Name = "dgvScreeningsList";
            this.dgvScreeningsList.ReadOnly = true;
            this.dgvScreeningsList.RowHeadersVisible = false;
            this.dgvScreeningsList.RowHeadersWidth = 51;
            this.dgvScreeningsList.RowTemplate.Height = 24;
            this.dgvScreeningsList.Size = new System.Drawing.Size(1447, 615);
            this.dgvScreeningsList.TabIndex = 0;
            this.dgvScreeningsList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvReports_CellFormatting);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Movie.Title";
            this.Title.FillWeight = 175F;
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 50;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Hall
            // 
            this.Hall.DataPropertyName = "Hall.Name";
            this.Hall.FillWeight = 70F;
            this.Hall.HeaderText = "Hall";
            this.Hall.MinimumWidth = 6;
            this.Hall.Name = "Hall";
            this.Hall.ReadOnly = true;
            this.Hall.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DateAndTime
            // 
            this.DateAndTime.DataPropertyName = "DateAndTime";
            this.DateAndTime.FillWeight = 70F;
            this.DateAndTime.HeaderText = "Date and Time";
            this.DateAndTime.MinimumWidth = 6;
            this.DateAndTime.Name = "DateAndTime";
            this.DateAndTime.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Pricing.Price";
            this.Price.FillWeight = 70F;
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "TimingStatus";
            this.Status.FillWeight = 70F;
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
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
            this.Mar.FillWeight = 70F;
            this.Mar.HeaderText = "Mar";
            this.Mar.MinimumWidth = 6;
            this.Mar.Name = "Mar";
            this.Mar.ReadOnly = true;
            // 
            // Apr
            // 
            this.Apr.DataPropertyName = "4";
            this.Apr.FillWeight = 70F;
            this.Apr.HeaderText = "Apr";
            this.Apr.MinimumWidth = 6;
            this.Apr.Name = "Apr";
            this.Apr.ReadOnly = true;
            // 
            // May
            // 
            this.May.DataPropertyName = "5";
            this.May.FillWeight = 70F;
            this.May.HeaderText = "May";
            this.May.MinimumWidth = 6;
            this.May.Name = "May";
            this.May.ReadOnly = true;
            // 
            // Jun
            // 
            this.Jun.DataPropertyName = "6";
            this.Jun.FillWeight = 70F;
            this.Jun.HeaderText = "Jun";
            this.Jun.MinimumWidth = 6;
            this.Jun.Name = "Jun";
            this.Jun.ReadOnly = true;
            // 
            // Jul
            // 
            this.Jul.DataPropertyName = "7";
            this.Jul.FillWeight = 70F;
            this.Jul.HeaderText = "Jul";
            this.Jul.MinimumWidth = 6;
            this.Jul.Name = "Jul";
            this.Jul.ReadOnly = true;
            // 
            // Aug
            // 
            this.Aug.DataPropertyName = "8";
            this.Aug.FillWeight = 70F;
            this.Aug.HeaderText = "Aug";
            this.Aug.MinimumWidth = 6;
            this.Aug.Name = "Aug";
            this.Aug.ReadOnly = true;
            // 
            // Sep
            // 
            this.Sep.DataPropertyName = "9";
            this.Sep.FillWeight = 70F;
            this.Sep.HeaderText = "Sep";
            this.Sep.MinimumWidth = 6;
            this.Sep.Name = "Sep";
            this.Sep.ReadOnly = true;
            // 
            // Oct
            // 
            this.Oct.DataPropertyName = "10";
            this.Oct.FillWeight = 70F;
            this.Oct.HeaderText = "Oct";
            this.Oct.MinimumWidth = 6;
            this.Oct.Name = "Oct";
            this.Oct.ReadOnly = true;
            // 
            // Nov
            // 
            this.Nov.DataPropertyName = "11";
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
            this.YearlyTotal.HeaderText = "Total";
            this.YearlyTotal.MinimumWidth = 6;
            this.YearlyTotal.Name = "YearlyTotal";
            this.YearlyTotal.ReadOnly = true;
            // 
            // FormReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 791);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormReports";
            this.Text = "FormReports";
            this.Load += new System.EventHandler(this.FormReports_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserSalesList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScreeningsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private UserControls.Pagination pgnScreenings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvScreeningsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hall;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateAndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button btnLoadReservations;
        private System.Windows.Forms.DataGridView dgvUserSalesList;
        private System.Windows.Forms.Button btnLoadScreenings;
        private System.Windows.Forms.Button btnExportPDF;
        private System.Windows.Forms.Button btnPrint;
        private UserControls.Pagination pgnReservations;
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