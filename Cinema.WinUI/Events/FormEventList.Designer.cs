namespace Cinema.WinUI.Events
{
    partial class FormEventList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBreadCrumbsCurrent = new System.Windows.Forms.Label();
            this.txtFormTitle = new System.Windows.Forms.TextBox();
            this.lblBreadcrumbs = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dtpEventDate = new System.Windows.Forms.DateTimePicker();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtSearchBar = new Cinema.WinUI.UserControls.ExtendedTextBox();
            this.lblPromoter = new System.Windows.Forms.Label();
            this.txtPromoter = new Cinema.WinUI.UserControls.ExtendedTextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtAuthor = new Cinema.WinUI.UserControls.ExtendedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grdList = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Promoter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateAndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetailsAction = new System.Windows.Forms.DataGridViewButtonColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pagination = new Cinema.WinUI.UserControls.Pagination();
            this.btnAddNew = new Cinema.WinUI.UserControls.Buttons.AddNewButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
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
            this.panel1.Controls.Add(this.lblBreadCrumbsCurrent);
            this.panel1.Controls.Add(this.txtFormTitle);
            this.panel1.Controls.Add(this.lblBreadcrumbs);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 75);
            this.panel1.TabIndex = 0;
            // 
            // lblBreadCrumbsCurrent
            // 
            this.lblBreadCrumbsCurrent.AutoSize = true;
            this.lblBreadCrumbsCurrent.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreadCrumbsCurrent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBreadCrumbsCurrent.Location = new System.Drawing.Point(80, 45);
            this.lblBreadCrumbsCurrent.Margin = new System.Windows.Forms.Padding(0);
            this.lblBreadCrumbsCurrent.Name = "lblBreadCrumbsCurrent";
            this.lblBreadCrumbsCurrent.Size = new System.Drawing.Size(51, 13);
            this.lblBreadCrumbsCurrent.TabIndex = 5;
            this.lblBreadCrumbsCurrent.Text = "Events";
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
            this.txtFormTitle.Text = "Events";
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Controls.Add(this.dtpEventDate, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblSearch, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbType, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblType, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblDate, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtSearchBar, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblPromoter, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtPromoter, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblAuthor, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtAuthor, 1, 1);
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
            // dtpEventDate
            // 
            this.dtpEventDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpEventDate.CalendarForeColor = System.Drawing.Color.Gray;
            this.dtpEventDate.CalendarTitleForeColor = System.Drawing.Color.Gray;
            this.dtpEventDate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEventDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEventDate.Location = new System.Drawing.Point(510, 42);
            this.dtpEventDate.Margin = new System.Windows.Forms.Padding(5);
            this.dtpEventDate.Name = "dtpEventDate";
            this.dtpEventDate.Size = new System.Drawing.Size(98, 22);
            this.dtpEventDate.TabIndex = 14;
            this.dtpEventDate.ValueChanged += new System.EventHandler(this.dtpEventDate_ValueChanged);
            this.dtpEventDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpEventDate_KeyDown);
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.White;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Gray;
            this.lblSearch.Location = new System.Drawing.Point(15, 17);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(15, 5, 5, 5);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(63, 15);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Event Title";
            // 
            // cmbType
            // 
            this.cmbType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbType.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.ForeColor = System.Drawing.Color.Gray;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(618, 42);
            this.cmbType.Margin = new System.Windows.Forms.Padding(5, 5, 15, 5);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(91, 22);
            this.cmbType.TabIndex = 7;
            this.cmbType.Click += new System.EventHandler(this.cmbType_Click);
            // 
            // lblType
            // 
            this.lblType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.Color.White;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.Gray;
            this.lblType.Location = new System.Drawing.Point(618, 17);
            this.lblType.Margin = new System.Windows.Forms.Padding(5);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(33, 15);
            this.lblType.TabIndex = 8;
            this.lblType.Text = "Type";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.White;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Gray;
            this.lblDate.Location = new System.Drawing.Point(510, 17);
            this.lblDate.Margin = new System.Windows.Forms.Padding(5);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 15);
            this.lblDate.TabIndex = 13;
            this.lblDate.Text = "Date";
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
            // lblPromoter
            // 
            this.lblPromoter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPromoter.AutoSize = true;
            this.lblPromoter.BackColor = System.Drawing.Color.White;
            this.lblPromoter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromoter.ForeColor = System.Drawing.Color.Gray;
            this.lblPromoter.Location = new System.Drawing.Point(402, 17);
            this.lblPromoter.Margin = new System.Windows.Forms.Padding(5);
            this.lblPromoter.Name = "lblPromoter";
            this.lblPromoter.Size = new System.Drawing.Size(58, 15);
            this.lblPromoter.TabIndex = 12;
            this.lblPromoter.Text = "Promoter";
            // 
            // txtPromoter
            // 
            this.txtPromoter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPromoter.BorderColor = System.Drawing.Color.DarkGray;
            this.txtPromoter.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPromoter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPromoter.Location = new System.Drawing.Point(402, 42);
            this.txtPromoter.Margin = new System.Windows.Forms.Padding(5);
            this.txtPromoter.Name = "txtPromoter";
            this.txtPromoter.Size = new System.Drawing.Size(98, 22);
            this.txtPromoter.TabIndex = 11;
            this.txtPromoter.TextChanged += new System.EventHandler(this.SearchChanged);
            // 
            // lblAuthor
            // 
            this.lblAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.BackColor = System.Drawing.Color.White;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ForeColor = System.Drawing.Color.Gray;
            this.lblAuthor.Location = new System.Drawing.Point(294, 17);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(5);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(42, 15);
            this.lblAuthor.TabIndex = 10;
            this.lblAuthor.Text = "Author";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAuthor.BorderColor = System.Drawing.Color.DarkGray;
            this.txtAuthor.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAuthor.Location = new System.Drawing.Point(294, 42);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(5);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(98, 22);
            this.txtAuthor.TabIndex = 9;
            this.txtAuthor.TextChanged += new System.EventHandler(this.SearchChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.grdList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(30, 210);
            this.panel2.Margin = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(15);
            this.panel2.Size = new System.Drawing.Size(724, 236);
            this.panel2.TabIndex = 2;
            // 
            // grdList
            // 
            this.grdList.AllowUserToAddRows = false;
            this.grdList.AllowUserToDeleteRows = false;
            this.grdList.AllowUserToResizeColumns = false;
            this.grdList.AllowUserToResizeRows = false;
            this.grdList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdList.BackgroundColor = System.Drawing.Color.White;
            this.grdList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.grdList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.Description,
            this.Author,
            this.Promoter,
            this.DateAndTime,
            this.Type,
            this.DetailsAction});
            this.grdList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdList.GridColor = System.Drawing.Color.White;
            this.grdList.Location = new System.Drawing.Point(15, 15);
            this.grdList.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.grdList.Name = "grdList";
            this.grdList.ReadOnly = true;
            this.grdList.RowHeadersVisible = false;
            this.grdList.RowHeadersWidth = 51;
            this.grdList.RowTemplate.Height = 24;
            this.grdList.Size = new System.Drawing.Size(694, 206);
            this.grdList.TabIndex = 0;
            this.grdList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdList_CellContentClick);
            this.grdList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdList_CellFormatting);
            this.grdList.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdList_ColumnHeaderMouseClick);
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
            this.Title.DataPropertyName = "Title";
            this.Title.FillWeight = 175F;
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 50;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.FillWeight = 70F;
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Author
            // 
            this.Author.DataPropertyName = "Author.FullName";
            this.Author.FillWeight = 70F;
            this.Author.HeaderText = "Author";
            this.Author.MinimumWidth = 6;
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            // 
            // Promoter
            // 
            this.Promoter.DataPropertyName = "Promoter";
            this.Promoter.HeaderText = "Promoter";
            this.Promoter.MinimumWidth = 6;
            this.Promoter.Name = "Promoter";
            this.Promoter.ReadOnly = true;
            // 
            // DateAndTime
            // 
            this.DateAndTime.DataPropertyName = "DateAndTime";
            this.DateAndTime.HeaderText = "Date and time";
            this.DateAndTime.MinimumWidth = 6;
            this.DateAndTime.Name = "DateAndTime";
            this.DateAndTime.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type.Name";
            this.Type.FillWeight = 70F;
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // DetailsAction
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.DetailsAction.DefaultCellStyle = dataGridViewCellStyle6;
            this.DetailsAction.FillWeight = 50F;
            this.DetailsAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DetailsAction.HeaderText = "Action";
            this.DetailsAction.MinimumWidth = 4;
            this.DetailsAction.Name = "DetailsAction";
            this.DetailsAction.ReadOnly = true;
            this.DetailsAction.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DetailsAction.Text = "Details";
            this.DetailsAction.UseColumnTextForButtonValue = true;
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
            this.flowLayoutPanel1.TabIndex = 3;
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
            // FormEventList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormEventList";
            this.Text = "eCinema - Events";
            this.Load += new System.EventHandler(this.FormEventsList_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdList;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtFormTitle;
        private UserControls.Pagination pagination;
        private UserControls.Buttons.AddNewButton btnAddNew;
        private System.Windows.Forms.Label lblBreadCrumbsCurrent;
        private System.Windows.Forms.Label lblBreadcrumbs;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
        private UserControls.ExtendedTextBox txtSearchBar;
        private System.Windows.Forms.Label lblAuthor;
        private UserControls.ExtendedTextBox txtAuthor;
        private System.Windows.Forms.Label lblPromoter;
        private UserControls.ExtendedTextBox txtPromoter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Promoter;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateAndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewButtonColumn DetailsAction;
        private System.Windows.Forms.DateTimePicker dtpEventDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}