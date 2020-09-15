namespace Cinema.WinUI.Screenings
{
    partial class FormScreeningList
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
            this.grdScreeningsList = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateAndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetailsAction = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblBreadCrumbsCurrent = new System.Windows.Forms.Label();
            this.lblBreadcrumbs = new System.Windows.Forms.Label();
            this.txtFormTitle = new System.Windows.Forms.TextBox();
            this.dtpScreeningDate = new System.Windows.Forms.DateTimePicker();
            this.lblHall = new System.Windows.Forms.Label();
            this.txtHall = new Cinema.WinUI.UserControls.ExtendedTextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new Cinema.WinUI.UserControls.ExtendedTextBox();
            this.txtSearchBar = new Cinema.WinUI.UserControls.ExtendedTextBox();
            this.btnAddNew = new Cinema.WinUI.UserControls.Buttons.AddNewButton();
            this.pagination = new Cinema.WinUI.UserControls.Pagination();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grdScreeningsList)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdScreeningsList
            // 
            this.grdScreeningsList.AllowUserToAddRows = false;
            this.grdScreeningsList.AllowUserToDeleteRows = false;
            this.grdScreeningsList.AllowUserToResizeColumns = false;
            this.grdScreeningsList.AllowUserToResizeRows = false;
            this.grdScreeningsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdScreeningsList.BackgroundColor = System.Drawing.Color.White;
            this.grdScreeningsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdScreeningsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.grdScreeningsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdScreeningsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdScreeningsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdScreeningsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.Hall,
            this.DateAndTime,
            this.Price,
            this.Status,
            this.DetailsAction});
            this.grdScreeningsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdScreeningsList.GridColor = System.Drawing.Color.White;
            this.grdScreeningsList.Location = new System.Drawing.Point(15, 15);
            this.grdScreeningsList.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.grdScreeningsList.Name = "grdScreeningsList";
            this.grdScreeningsList.ReadOnly = true;
            this.grdScreeningsList.RowHeadersVisible = false;
            this.grdScreeningsList.RowHeadersWidth = 51;
            this.grdScreeningsList.RowTemplate.Height = 24;
            this.grdScreeningsList.Size = new System.Drawing.Size(694, 206);
            this.grdScreeningsList.TabIndex = 0;
            this.grdScreeningsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdScreeningsList_CellContentClick);
            this.grdScreeningsList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdScreeningsList_CellFormatting);
            this.grdScreeningsList.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdScreeningsList_ColumnHeaderMouseClick);
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
            // DetailsAction
            // 
            this.DetailsAction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.DetailsAction.DefaultCellStyle = dataGridViewCellStyle2;
            this.DetailsAction.FillWeight = 50F;
            this.DetailsAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DetailsAction.HeaderText = "Action";
            this.DetailsAction.MinimumWidth = 4;
            this.DetailsAction.Name = "DetailsAction";
            this.DetailsAction.ReadOnly = true;
            this.DetailsAction.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DetailsAction.Text = "Details";
            this.DetailsAction.UseColumnTextForButtonValue = true;
            this.DetailsAction.Width = 54;
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Gray;
            this.lblSearch.Location = new System.Drawing.Point(15, 17);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(15, 5, 5, 5);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(75, 15);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Movie name";
            // 
            // lblBreadCrumbsCurrent
            // 
            this.lblBreadCrumbsCurrent.AutoSize = true;
            this.lblBreadCrumbsCurrent.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreadCrumbsCurrent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBreadCrumbsCurrent.Location = new System.Drawing.Point(80, 45);
            this.lblBreadCrumbsCurrent.Margin = new System.Windows.Forms.Padding(0);
            this.lblBreadCrumbsCurrent.Name = "lblBreadCrumbsCurrent";
            this.lblBreadCrumbsCurrent.Size = new System.Drawing.Size(79, 13);
            this.lblBreadCrumbsCurrent.TabIndex = 5;
            this.lblBreadCrumbsCurrent.Text = "Screenings";
            // 
            // lblBreadcrumbs
            // 
            this.lblBreadcrumbs.AutoSize = true;
            this.lblBreadcrumbs.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreadcrumbs.Location = new System.Drawing.Point(30, 45);
            this.lblBreadcrumbs.Margin = new System.Windows.Forms.Padding(0);
            this.lblBreadcrumbs.Name = "lblBreadcrumbs";
            this.lblBreadcrumbs.Size = new System.Drawing.Size(49, 13);
            this.lblBreadcrumbs.TabIndex = 4;
            this.lblBreadcrumbs.Text = "Home /";
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
            this.txtFormTitle.Size = new System.Drawing.Size(121, 27);
            this.txtFormTitle.TabIndex = 0;
            this.txtFormTitle.Text = "Screenings";
            // 
            // dtpScreeningDate
            // 
            this.dtpScreeningDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpScreeningDate.CalendarForeColor = System.Drawing.Color.Gray;
            this.dtpScreeningDate.CalendarTitleForeColor = System.Drawing.Color.Gray;
            this.dtpScreeningDate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpScreeningDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpScreeningDate.Location = new System.Drawing.Point(402, 42);
            this.dtpScreeningDate.Margin = new System.Windows.Forms.Padding(5);
            this.dtpScreeningDate.Name = "dtpScreeningDate";
            this.dtpScreeningDate.Size = new System.Drawing.Size(98, 22);
            this.dtpScreeningDate.TabIndex = 11;
            this.dtpScreeningDate.ValueChanged += new System.EventHandler(this.dtpScreeningDate_ValueChanged);
            this.dtpScreeningDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpScreeningDate_KeyDown);
            // 
            // lblHall
            // 
            this.lblHall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHall.AutoSize = true;
            this.lblHall.BackColor = System.Drawing.Color.White;
            this.lblHall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHall.ForeColor = System.Drawing.Color.Gray;
            this.lblHall.Location = new System.Drawing.Point(294, 17);
            this.lblHall.Margin = new System.Windows.Forms.Padding(5);
            this.lblHall.Name = "lblHall";
            this.lblHall.Size = new System.Drawing.Size(29, 15);
            this.lblHall.TabIndex = 10;
            this.lblHall.Text = "Hall";
            // 
            // txtHall
            // 
            this.txtHall.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHall.BorderColor = System.Drawing.Color.DarkGray;
            this.txtHall.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHall.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtHall.Location = new System.Drawing.Point(294, 42);
            this.txtHall.Margin = new System.Windows.Forms.Padding(5);
            this.txtHall.Name = "txtHall";
            this.txtHall.Size = new System.Drawing.Size(98, 22);
            this.txtHall.TabIndex = 9;
            this.txtHall.TextChanged += new System.EventHandler(this.SearchChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.White;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Gray;
            this.lblStatus.Location = new System.Drawing.Point(618, 17);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(5);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(41, 15);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStatus.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.ForeColor = System.Drawing.Color.Gray;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(618, 42);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(5, 5, 15, 5);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(91, 22);
            this.cmbStatus.TabIndex = 7;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.White;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Gray;
            this.lblDate.Location = new System.Drawing.Point(402, 17);
            this.lblDate.Margin = new System.Windows.Forms.Padding(5);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 15);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date";
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.White;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Gray;
            this.lblPrice.Location = new System.Drawing.Point(510, 17);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(5);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(35, 15);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrice.BorderColor = System.Drawing.Color.DarkGray;
            this.txtPrice.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPrice.Location = new System.Drawing.Point(510, 42);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(5);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(98, 22);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.TextChanged += new System.EventHandler(this.SearchChanged);
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchBar.BorderColor = System.Drawing.Color.DarkGray;
            this.txtSearchBar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearchBar.Location = new System.Drawing.Point(15, 42);
            this.txtSearchBar.Margin = new System.Windows.Forms.Padding(15, 5, 5, 5);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(269, 22);
            this.txtSearchBar.TabIndex = 1;
            this.txtSearchBar.TextChanged += new System.EventHandler(this.SearchChanged);
            // 
            // btnAddNew
            // 
            this.btnAddNew.AutoSize = true;
            this.btnAddNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddNew.Location = new System.Drawing.Point(414, 5);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(90, 32);
            this.btnAddNew.TabIndex = 11;
            this.btnAddNew.ButtonClicked += new System.EventHandler(this.btnAddNew_ButtonClicked);
            // 
            // pagination
            // 
            this.pagination.AutoSize = true;
            this.pagination.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pagination.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagination.Location = new System.Drawing.Point(514, 5);
            this.pagination.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.pagination.Name = "pagination";
            this.pagination.PageIndex = 0;
            this.pagination.Size = new System.Drawing.Size(210, 35);
            this.pagination.TabIndex = 10;
            this.pagination.TotalPages = 0;
            this.pagination.PageChanged += new System.EventHandler(this.pagination_PageChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 561);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtFormTitle);
            this.panel1.Controls.Add(this.lblBreadcrumbs);
            this.panel1.Controls.Add(this.lblBreadCrumbsCurrent);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 75);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Controls.Add(this.dtpScreeningDate, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblSearch, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbStatus, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblStatus, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtSearchBar, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtHall, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblHall, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtPrice, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblPrice, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblDate, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(30, 105);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(30, 30, 30, 15);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(724, 75);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.pagination);
            this.flowLayoutPanel1.Controls.Add(this.btnAddNew);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(30, 476);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(30, 15, 30, 30);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(724, 55);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.grdScreeningsList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(30, 210);
            this.panel2.Margin = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(15);
            this.panel2.Size = new System.Drawing.Size(724, 236);
            this.panel2.TabIndex = 3;
            // 
            // FormScreeningList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormScreeningList";
            this.Text = "frmMoviesList";
            this.Load += new System.EventHandler(this.FormScreeningList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdScreeningsList)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdScreeningsList;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtFormTitle;
        private UserControls.Pagination pagination;
        private UserControls.Buttons.AddNewButton btnAddNew;
        private System.Windows.Forms.Label lblBreadCrumbsCurrent;
        private System.Windows.Forms.Label lblBreadcrumbs;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private UserControls.ExtendedTextBox txtPrice;
        private UserControls.ExtendedTextBox txtSearchBar;
        private System.Windows.Forms.Label lblHall;
        private UserControls.ExtendedTextBox txtHall;
        private System.Windows.Forms.DateTimePicker dtpScreeningDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hall;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateAndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewButtonColumn DetailsAction;
    }
}