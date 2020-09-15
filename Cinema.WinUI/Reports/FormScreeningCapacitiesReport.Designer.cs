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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pgnReservations = new Cinema.WinUI.UserControls.Pagination();
            this.dgvScreeningCapacitiesList = new System.Windows.Forms.DataGridView();
            this.ScreeningId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateAndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Occupied = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Free = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnExportPDF = new System.Windows.Forms.Button();
            this.lblMovieTitle = new System.Windows.Forms.Label();
            this.nmrNumberOfEntries = new System.Windows.Forms.NumericUpDown();
            this.lblShowEntries = new System.Windows.Forms.Label();
            this.lblHallName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblReportTitle = new System.Windows.Forms.Label();
            this.txtMovieTitle = new System.Windows.Forms.TextBox();
            this.txtHallName = new System.Windows.Forms.TextBox();
            this.dtpScreeningDate = new System.Windows.Forms.DateTimePicker();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtFormTitle = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblBreadCrumbsCurrent = new System.Windows.Forms.Label();
            this.lblBreadcrumbs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScreeningCapacitiesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrNumberOfEntries)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pgnReservations
            // 
            this.pgnReservations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pgnReservations.AutoSize = true;
            this.pgnReservations.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pgnReservations.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pgnReservations.Location = new System.Drawing.Point(998, 5);
            this.pgnReservations.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.pgnReservations.Name = "pgnReservations";
            this.pgnReservations.PageIndex = 0;
            this.pgnReservations.Size = new System.Drawing.Size(210, 35);
            this.pgnReservations.TabIndex = 12;
            this.pgnReservations.TotalPages = 0;
            this.pgnReservations.PageChanged += new System.EventHandler(this.pgnReservations_PageChanged);
            // 
            // dgvScreeningCapacitiesList
            // 
            this.dgvScreeningCapacitiesList.AllowUserToAddRows = false;
            this.dgvScreeningCapacitiesList.AllowUserToDeleteRows = false;
            this.dgvScreeningCapacitiesList.AllowUserToResizeColumns = false;
            this.dgvScreeningCapacitiesList.AllowUserToResizeRows = false;
            this.dgvScreeningCapacitiesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvScreeningCapacitiesList.BackgroundColor = System.Drawing.Color.White;
            this.dgvScreeningCapacitiesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvScreeningCapacitiesList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvScreeningCapacitiesList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvScreeningCapacitiesList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvScreeningCapacitiesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScreeningCapacitiesList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ScreeningId,
            this.Title,
            this.Hall,
            this.DateAndTime,
            this.Capacity,
            this.Occupied,
            this.Free});
            this.dgvScreeningCapacitiesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvScreeningCapacitiesList.GridColor = System.Drawing.Color.White;
            this.dgvScreeningCapacitiesList.Location = new System.Drawing.Point(15, 15);
            this.dgvScreeningCapacitiesList.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.dgvScreeningCapacitiesList.Name = "dgvScreeningCapacitiesList";
            this.dgvScreeningCapacitiesList.ReadOnly = true;
            this.dgvScreeningCapacitiesList.RowHeadersVisible = false;
            this.dgvScreeningCapacitiesList.RowHeadersWidth = 51;
            this.dgvScreeningCapacitiesList.RowTemplate.Height = 24;
            this.dgvScreeningCapacitiesList.Size = new System.Drawing.Size(1178, 414);
            this.dgvScreeningCapacitiesList.TabIndex = 1;
            this.dgvScreeningCapacitiesList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvReportReservations_CellFormatting);
            this.dgvScreeningCapacitiesList.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvScreeningCapacitiesList_ColumnHeaderMouseClick);
            // 
            // ScreeningId
            // 
            this.ScreeningId.DataPropertyName = "Screening.Id";
            this.ScreeningId.FillWeight = 50F;
            this.ScreeningId.HeaderText = "Id";
            this.ScreeningId.MinimumWidth = 6;
            this.ScreeningId.Name = "ScreeningId";
            this.ScreeningId.ReadOnly = true;
            this.ScreeningId.Visible = false;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Screening.Movie.Title";
            this.Title.FillWeight = 200F;
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Hall
            // 
            this.Hall.DataPropertyName = "Screening.Hall.Name";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hall.DefaultCellStyle = dataGridViewCellStyle10;
            this.Hall.HeaderText = "Hall";
            this.Hall.MinimumWidth = 6;
            this.Hall.Name = "Hall";
            this.Hall.ReadOnly = true;
            // 
            // DateAndTime
            // 
            this.DateAndTime.DataPropertyName = "Screening.DateAndTime";
            this.DateAndTime.HeaderText = "Date and time";
            this.DateAndTime.MinimumWidth = 6;
            this.DateAndTime.Name = "DateAndTime";
            this.DateAndTime.ReadOnly = true;
            // 
            // Capacity
            // 
            this.Capacity.DataPropertyName = "Capacity";
            this.Capacity.HeaderText = "Capacity";
            this.Capacity.MinimumWidth = 6;
            this.Capacity.Name = "Capacity";
            this.Capacity.ReadOnly = true;
            // 
            // Occupied
            // 
            this.Occupied.DataPropertyName = "Occupied";
            this.Occupied.HeaderText = "Occupied";
            this.Occupied.MinimumWidth = 6;
            this.Occupied.Name = "Occupied";
            this.Occupied.ReadOnly = true;
            // 
            // Free
            // 
            this.Free.DataPropertyName = "Free";
            this.Free.HeaderText = "Free";
            this.Free.MinimumWidth = 6;
            this.Free.Name = "Free";
            this.Free.ReadOnly = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.AutoSize = true;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.DimGray;
            this.btnPrint.Location = new System.Drawing.Point(544, 20);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(45, 25);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExcel.AutoSize = true;
            this.btnExportExcel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportExcel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.ForeColor = System.Drawing.Color.DimGray;
            this.btnExportExcel.Location = new System.Drawing.Point(322, 20);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(5);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(105, 25);
            this.btnExportExcel.TabIndex = 0;
            this.btnExportExcel.Text = "Export to excel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnExportPDF
            // 
            this.btnExportPDF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportPDF.AutoSize = true;
            this.btnExportPDF.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btnExportPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportPDF.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportPDF.ForeColor = System.Drawing.Color.DimGray;
            this.btnExportPDF.Location = new System.Drawing.Point(437, 20);
            this.btnExportPDF.Margin = new System.Windows.Forms.Padding(5);
            this.btnExportPDF.Name = "btnExportPDF";
            this.btnExportPDF.Size = new System.Drawing.Size(97, 25);
            this.btnExportPDF.TabIndex = 1;
            this.btnExportPDF.Text = "Export to PDF";
            this.btnExportPDF.UseVisualStyleBackColor = true;
            this.btnExportPDF.Click += new System.EventHandler(this.btnExportPDF_Click);
            // 
            // lblMovieTitle
            // 
            this.lblMovieTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMovieTitle.AutoSize = true;
            this.lblMovieTitle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblMovieTitle.Location = new System.Drawing.Point(125, 16);
            this.lblMovieTitle.Margin = new System.Windows.Forms.Padding(5);
            this.lblMovieTitle.Name = "lblMovieTitle";
            this.lblMovieTitle.Size = new System.Drawing.Size(110, 14);
            this.lblMovieTitle.TabIndex = 9;
            this.lblMovieTitle.Text = "Movie title";
            // 
            // nmrNumberOfEntries
            // 
            this.nmrNumberOfEntries.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nmrNumberOfEntries.Location = new System.Drawing.Point(15, 40);
            this.nmrNumberOfEntries.Margin = new System.Windows.Forms.Padding(15, 5, 5, 5);
            this.nmrNumberOfEntries.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nmrNumberOfEntries.Name = "nmrNumberOfEntries";
            this.nmrNumberOfEntries.Size = new System.Drawing.Size(100, 20);
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
            this.lblShowEntries.Location = new System.Drawing.Point(15, 16);
            this.lblShowEntries.Margin = new System.Windows.Forms.Padding(15, 5, 5, 5);
            this.lblShowEntries.Name = "lblShowEntries";
            this.lblShowEntries.Size = new System.Drawing.Size(100, 14);
            this.lblShowEntries.TabIndex = 6;
            this.lblShowEntries.Text = "Show entries";
            // 
            // lblHallName
            // 
            this.lblHallName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHallName.AutoSize = true;
            this.lblHallName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHallName.ForeColor = System.Drawing.Color.DimGray;
            this.lblHallName.Location = new System.Drawing.Point(245, 16);
            this.lblHallName.Margin = new System.Windows.Forms.Padding(5);
            this.lblHallName.Name = "lblHallName";
            this.lblHallName.Size = new System.Drawing.Size(110, 14);
            this.lblHallName.TabIndex = 10;
            this.lblHallName.Text = "Hall";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.DimGray;
            this.lblDate.Location = new System.Drawing.Point(365, 16);
            this.lblDate.Margin = new System.Windows.Forms.Padding(5);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(110, 14);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "Date";
            // 
            // lblReportTitle
            // 
            this.lblReportTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReportTitle.AutoSize = true;
            this.lblReportTitle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblReportTitle.Location = new System.Drawing.Point(13, 16);
            this.lblReportTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReportTitle.Name = "lblReportTitle";
            this.lblReportTitle.Size = new System.Drawing.Size(189, 18);
            this.lblReportTitle.TabIndex = 13;
            this.lblReportTitle.Text = "Screening Capacities";
            // 
            // txtMovieTitle
            // 
            this.txtMovieTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMovieTitle.Location = new System.Drawing.Point(125, 40);
            this.txtMovieTitle.Margin = new System.Windows.Forms.Padding(5);
            this.txtMovieTitle.Name = "txtMovieTitle";
            this.txtMovieTitle.Size = new System.Drawing.Size(110, 20);
            this.txtMovieTitle.TabIndex = 14;
            this.txtMovieTitle.TextChanged += new System.EventHandler(this.SearchChanged);
            // 
            // txtHallName
            // 
            this.txtHallName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHallName.Location = new System.Drawing.Point(245, 40);
            this.txtHallName.Margin = new System.Windows.Forms.Padding(5);
            this.txtHallName.Name = "txtHallName";
            this.txtHallName.Size = new System.Drawing.Size(110, 20);
            this.txtHallName.TabIndex = 15;
            this.txtHallName.TextChanged += new System.EventHandler(this.SearchChanged);
            // 
            // dtpScreeningDate
            // 
            this.dtpScreeningDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpScreeningDate.CalendarForeColor = System.Drawing.Color.Gray;
            this.dtpScreeningDate.CalendarTitleForeColor = System.Drawing.Color.Gray;
            this.dtpScreeningDate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpScreeningDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpScreeningDate.Location = new System.Drawing.Point(365, 40);
            this.dtpScreeningDate.Margin = new System.Windows.Forms.Padding(5);
            this.dtpScreeningDate.Name = "dtpScreeningDate";
            this.dtpScreeningDate.Size = new System.Drawing.Size(110, 22);
            this.dtpScreeningDate.TabIndex = 16;
            this.dtpScreeningDate.ValueChanged += new System.EventHandler(this.dtpScreeningDate_ValueChanged);
            this.dtpScreeningDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpScreeningDate_KeyDown);
            // 
            // cmbStatus
            // 
            this.cmbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStatus.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.ForeColor = System.Drawing.Color.Gray;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(485, 40);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(5);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(114, 22);
            this.cmbStatus.TabIndex = 17;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.White;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Gray;
            this.lblStatus.Location = new System.Drawing.Point(485, 15);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(5);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(114, 15);
            this.lblStatus.TabIndex = 18;
            this.lblStatus.Text = "Status";
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
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1268, 784);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1268, 75);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(30, 105);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(30, 30, 30, 15);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1208, 564);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblReportTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1208, 50);
            this.panel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1208, 70);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Controls.Add(this.lblDate, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblShowEntries, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.nmrNumberOfEntries, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblMovieTitle, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblHallName, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.cmbStatus, 4, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblStatus, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtMovieTitle, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.dtpScreeningDate, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtHallName, 2, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(604, 70);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.btnPrint);
            this.flowLayoutPanel1.Controls.Add(this.btnExportPDF);
            this.flowLayoutPanel1.Controls.Add(this.btnExportExcel);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(604, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(15, 15, 0, 15);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(604, 70);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.pgnReservations);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(30, 699);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(30, 15, 30, 30);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1208, 55);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.dgvScreeningCapacitiesList);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 120);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(15);
            this.panel3.Size = new System.Drawing.Size(1208, 444);
            this.panel3.TabIndex = 2;
            // 
            // txtFormTitle
            // 
            this.txtFormTitle.BackColor = System.Drawing.Color.White;
            this.txtFormTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFormTitle.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormTitle.ForeColor = System.Drawing.Color.Gray;
            this.txtFormTitle.Location = new System.Drawing.Point(30, 10);
            this.txtFormTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtFormTitle.Name = "txtFormTitle";
            this.txtFormTitle.Size = new System.Drawing.Size(91, 27);
            this.txtFormTitle.TabIndex = 9;
            this.txtFormTitle.Text = "Reports";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lblBreadCrumbsCurrent);
            this.panel4.Controls.Add(this.txtFormTitle);
            this.panel4.Controls.Add(this.lblBreadcrumbs);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1268, 75);
            this.panel4.TabIndex = 1;
            // 
            // lblBreadCrumbsCurrent
            // 
            this.lblBreadCrumbsCurrent.AutoSize = true;
            this.lblBreadCrumbsCurrent.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreadCrumbsCurrent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBreadCrumbsCurrent.Location = new System.Drawing.Point(80, 45);
            this.lblBreadCrumbsCurrent.Margin = new System.Windows.Forms.Padding(0);
            this.lblBreadCrumbsCurrent.Name = "lblBreadCrumbsCurrent";
            this.lblBreadCrumbsCurrent.Size = new System.Drawing.Size(142, 13);
            this.lblBreadCrumbsCurrent.TabIndex = 11;
            this.lblBreadCrumbsCurrent.Text = "Screening capacities";
            // 
            // lblBreadcrumbs
            // 
            this.lblBreadcrumbs.AutoSize = true;
            this.lblBreadcrumbs.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreadcrumbs.Location = new System.Drawing.Point(30, 45);
            this.lblBreadcrumbs.Margin = new System.Windows.Forms.Padding(0);
            this.lblBreadcrumbs.Name = "lblBreadcrumbs";
            this.lblBreadcrumbs.Size = new System.Drawing.Size(49, 13);
            this.lblBreadcrumbs.TabIndex = 10;
            this.lblBreadcrumbs.Text = "Home /";
            // 
            // FormScreeningCapacitiesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 784);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormScreeningCapacitiesReport";
            this.Text = "FormReports";
            this.Load += new System.EventHandler(this.FormReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScreeningCapacitiesList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrNumberOfEntries)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvScreeningCapacitiesList;
        private UserControls.Pagination pgnReservations;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnExportPDF;
        private System.Windows.Forms.Label lblMovieTitle;
        private System.Windows.Forms.NumericUpDown nmrNumberOfEntries;
        private System.Windows.Forms.Label lblShowEntries;
        private System.Windows.Forms.Label lblHallName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblReportTitle;
        private System.Windows.Forms.TextBox txtMovieTitle;
        private System.Windows.Forms.TextBox txtHallName;
        private System.Windows.Forms.DateTimePicker dtpScreeningDate;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScreeningId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hall;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateAndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Occupied;
        private System.Windows.Forms.DataGridViewTextBoxColumn Free;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblBreadCrumbsCurrent;
        private System.Windows.Forms.TextBox txtFormTitle;
        private System.Windows.Forms.Label lblBreadcrumbs;
    }
}