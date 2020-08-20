namespace Cinema.WinUI.Movies
{
    partial class FormReservationList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdReservationsList = new System.Windows.Forms.DataGridView();
            this.lblReservationId = new System.Windows.Forms.Label();
            this.pnlFormTitle = new System.Windows.Forms.Panel();
            this.lblBreadCrumbsCurrent = new System.Windows.Forms.Label();
            this.lblBreadcrumbs = new System.Windows.Forms.Label();
            this.txtFormTitle = new System.Windows.Forms.TextBox();
            this.pnlSearchBars = new System.Windows.Forms.Panel();
            this.dtpDateAdded = new System.Windows.Forms.DateTimePicker();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.txtCustomer = new Cinema.WinUI.UserControls.ExtendedTextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new Cinema.WinUI.UserControls.ExtendedTextBox();
            this.txtReservationId = new Cinema.WinUI.UserControls.ExtendedTextBox();
            this.pnlDataGrid = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pagination = new Cinema.WinUI.UserControls.Pagination();
            this.lblMovie = new System.Windows.Forms.Label();
            this.txtMovie = new Cinema.WinUI.UserControls.ExtendedTextBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Screening = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetailsAction = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdReservationsList)).BeginInit();
            this.pnlFormTitle.SuspendLayout();
            this.pnlSearchBars.SuspendLayout();
            this.pnlDataGrid.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdReservationsList
            // 
            this.grdReservationsList.AllowUserToAddRows = false;
            this.grdReservationsList.AllowUserToDeleteRows = false;
            this.grdReservationsList.AllowUserToResizeColumns = false;
            this.grdReservationsList.AllowUserToResizeRows = false;
            this.grdReservationsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdReservationsList.BackgroundColor = System.Drawing.Color.White;
            this.grdReservationsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdReservationsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.grdReservationsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdReservationsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdReservationsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdReservationsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Screening,
            this.FullName,
            this.Price,
            this.CreatedAt,
            this.Status,
            this.DetailsAction});
            this.grdReservationsList.GridColor = System.Drawing.Color.White;
            this.grdReservationsList.Location = new System.Drawing.Point(20, 30);
            this.grdReservationsList.Margin = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.grdReservationsList.Name = "grdReservationsList";
            this.grdReservationsList.ReadOnly = true;
            this.grdReservationsList.RowHeadersVisible = false;
            this.grdReservationsList.RowHeadersWidth = 51;
            this.grdReservationsList.RowTemplate.Height = 24;
            this.grdReservationsList.Size = new System.Drawing.Size(1345, 470);
            this.grdReservationsList.TabIndex = 0;
            this.grdReservationsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdReservationsList_CellContentClick);
            this.grdReservationsList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdReservationsList_CellFormatting);
            this.grdReservationsList.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdReservationsList_ColumnHeaderMouseClick);
            // 
            // lblReservationId
            // 
            this.lblReservationId.AutoSize = true;
            this.lblReservationId.BackColor = System.Drawing.Color.White;
            this.lblReservationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationId.ForeColor = System.Drawing.Color.Gray;
            this.lblReservationId.Location = new System.Drawing.Point(17, 15);
            this.lblReservationId.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblReservationId.Name = "lblReservationId";
            this.lblReservationId.Size = new System.Drawing.Size(105, 18);
            this.lblReservationId.TabIndex = 2;
            this.lblReservationId.Text = "Reservation ID";
            // 
            // pnlFormTitle
            // 
            this.pnlFormTitle.BackColor = System.Drawing.Color.White;
            this.pnlFormTitle.Controls.Add(this.lblBreadCrumbsCurrent);
            this.pnlFormTitle.Controls.Add(this.lblBreadcrumbs);
            this.pnlFormTitle.Controls.Add(this.txtFormTitle);
            this.pnlFormTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlFormTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlFormTitle.Name = "pnlFormTitle";
            this.pnlFormTitle.Size = new System.Drawing.Size(1447, 90);
            this.pnlFormTitle.TabIndex = 8;
            // 
            // lblBreadCrumbsCurrent
            // 
            this.lblBreadCrumbsCurrent.AutoSize = true;
            this.lblBreadCrumbsCurrent.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreadCrumbsCurrent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBreadCrumbsCurrent.Location = new System.Drawing.Point(99, 59);
            this.lblBreadCrumbsCurrent.Margin = new System.Windows.Forms.Padding(0);
            this.lblBreadCrumbsCurrent.Name = "lblBreadCrumbsCurrent";
            this.lblBreadCrumbsCurrent.Size = new System.Drawing.Size(108, 17);
            this.lblBreadCrumbsCurrent.TabIndex = 5;
            this.lblBreadCrumbsCurrent.Text = "Reservations";
            // 
            // lblBreadcrumbs
            // 
            this.lblBreadcrumbs.AutoSize = true;
            this.lblBreadcrumbs.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreadcrumbs.Location = new System.Drawing.Point(33, 59);
            this.lblBreadcrumbs.Margin = new System.Windows.Forms.Padding(0);
            this.lblBreadcrumbs.Name = "lblBreadcrumbs";
            this.lblBreadcrumbs.Size = new System.Drawing.Size(59, 17);
            this.lblBreadcrumbs.TabIndex = 4;
            this.lblBreadcrumbs.Text = "Home /";
            // 
            // txtFormTitle
            // 
            this.txtFormTitle.BackColor = System.Drawing.Color.White;
            this.txtFormTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFormTitle.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormTitle.ForeColor = System.Drawing.Color.Gray;
            this.txtFormTitle.Location = new System.Drawing.Point(37, 18);
            this.txtFormTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFormTitle.Name = "txtFormTitle";
            this.txtFormTitle.Size = new System.Drawing.Size(194, 33);
            this.txtFormTitle.TabIndex = 0;
            this.txtFormTitle.Text = "Reservations";
            // 
            // pnlSearchBars
            // 
            this.pnlSearchBars.BackColor = System.Drawing.Color.White;
            this.pnlSearchBars.Controls.Add(this.lblMovie);
            this.pnlSearchBars.Controls.Add(this.txtMovie);
            this.pnlSearchBars.Controls.Add(this.dtpDateAdded);
            this.pnlSearchBars.Controls.Add(this.lblCustomer);
            this.pnlSearchBars.Controls.Add(this.txtCustomer);
            this.pnlSearchBars.Controls.Add(this.lblStatus);
            this.pnlSearchBars.Controls.Add(this.cmbStatus);
            this.pnlSearchBars.Controls.Add(this.lblDate);
            this.pnlSearchBars.Controls.Add(this.lblPrice);
            this.pnlSearchBars.Controls.Add(this.txtPrice);
            this.pnlSearchBars.Controls.Add(this.lblReservationId);
            this.pnlSearchBars.Controls.Add(this.txtReservationId);
            this.pnlSearchBars.Location = new System.Drawing.Point(29, 113);
            this.pnlSearchBars.Margin = new System.Windows.Forms.Padding(20);
            this.pnlSearchBars.Name = "pnlSearchBars";
            this.pnlSearchBars.Padding = new System.Windows.Forms.Padding(15);
            this.pnlSearchBars.Size = new System.Drawing.Size(1383, 89);
            this.pnlSearchBars.TabIndex = 9;
            // 
            // dtpDateAdded
            // 
            this.dtpDateAdded.CalendarForeColor = System.Drawing.Color.Gray;
            this.dtpDateAdded.CalendarTitleForeColor = System.Drawing.Color.Gray;
            this.dtpDateAdded.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateAdded.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateAdded.Location = new System.Drawing.Point(901, 37);
            this.dtpDateAdded.Name = "dtpDateAdded";
            this.dtpDateAdded.Size = new System.Drawing.Size(214, 26);
            this.dtpDateAdded.TabIndex = 11;
            this.dtpDateAdded.ValueChanged += new System.EventHandler(this.dtpDateAdded_ValueChanged);
            this.dtpDateAdded.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpDateAdded_KeyDown);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.BackColor = System.Drawing.Color.White;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.ForeColor = System.Drawing.Color.Gray;
            this.lblCustomer.Location = new System.Drawing.Point(455, 15);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(74, 18);
            this.lblCustomer.TabIndex = 10;
            this.lblCustomer.Text = "Customer";
            // 
            // txtCustomer
            // 
            this.txtCustomer.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCustomer.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCustomer.Location = new System.Drawing.Point(458, 37);
            this.txtCustomer.Margin = new System.Windows.Forms.Padding(25);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(182, 26);
            this.txtCustomer.TabIndex = 9;
            this.txtCustomer.TextChanged += new System.EventHandler(this.SearchChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.White;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Gray;
            this.lblStatus.Location = new System.Drawing.Point(1171, 11);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(131, 18);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Reservation status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.ForeColor = System.Drawing.Color.Gray;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(1174, 37);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(188, 26);
            this.cmbStatus.TabIndex = 7;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.White;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Gray;
            this.lblDate.Location = new System.Drawing.Point(898, 15);
            this.lblDate.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(83, 18);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date added";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.White;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Gray;
            this.lblPrice.Location = new System.Drawing.Point(696, 15);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(103, 18);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price with VAT";
            // 
            // txtPrice
            // 
            this.txtPrice.BorderColor = System.Drawing.Color.DarkGray;
            this.txtPrice.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPrice.Location = new System.Drawing.Point(699, 37);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(25);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(143, 26);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.TextChanged += new System.EventHandler(this.SearchChanged);
            // 
            // txtReservationId
            // 
            this.txtReservationId.BorderColor = System.Drawing.Color.DarkGray;
            this.txtReservationId.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReservationId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtReservationId.Location = new System.Drawing.Point(20, 37);
            this.txtReservationId.Margin = new System.Windows.Forms.Padding(15);
            this.txtReservationId.Name = "txtReservationId";
            this.txtReservationId.Size = new System.Drawing.Size(138, 26);
            this.txtReservationId.TabIndex = 1;
            this.txtReservationId.TextChanged += new System.EventHandler(this.SearchChanged);
            // 
            // pnlDataGrid
            // 
            this.pnlDataGrid.BackColor = System.Drawing.Color.White;
            this.pnlDataGrid.Controls.Add(this.grdReservationsList);
            this.pnlDataGrid.Location = new System.Drawing.Point(29, 217);
            this.pnlDataGrid.Margin = new System.Windows.Forms.Padding(20);
            this.pnlDataGrid.Name = "pnlDataGrid";
            this.pnlDataGrid.Padding = new System.Windows.Forms.Padding(15);
            this.pnlDataGrid.Size = new System.Drawing.Size(1385, 502);
            this.pnlDataGrid.TabIndex = 10;
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.pagination);
            this.pnlContent.Controls.Add(this.pnlSearchBars);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(15);
            this.pnlContent.Size = new System.Drawing.Size(1447, 800);
            this.pnlContent.TabIndex = 11;
            // 
            // pagination
            // 
            this.pagination.AutoSize = true;
            this.pagination.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pagination.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagination.Location = new System.Drawing.Point(1132, 726);
            this.pagination.Margin = new System.Windows.Forms.Padding(5);
            this.pagination.Name = "pagination";
            this.pagination.PageIndex = 0;
            this.pagination.Size = new System.Drawing.Size(210, 35);
            this.pagination.TabIndex = 10;
            this.pagination.TotalPages = 0;
            this.pagination.PageChanged += new System.EventHandler(this.pagination_PageChanged);
            // 
            // lblMovie
            // 
            this.lblMovie.AutoSize = true;
            this.lblMovie.BackColor = System.Drawing.Color.White;
            this.lblMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovie.ForeColor = System.Drawing.Color.Gray;
            this.lblMovie.Location = new System.Drawing.Point(214, 15);
            this.lblMovie.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblMovie.Name = "lblMovie";
            this.lblMovie.Size = new System.Drawing.Size(48, 18);
            this.lblMovie.TabIndex = 13;
            this.lblMovie.Text = "Movie";
            // 
            // txtMovie
            // 
            this.txtMovie.BorderColor = System.Drawing.Color.DarkGray;
            this.txtMovie.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovie.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMovie.Location = new System.Drawing.Point(217, 37);
            this.txtMovie.Margin = new System.Windows.Forms.Padding(25);
            this.txtMovie.Name = "txtMovie";
            this.txtMovie.Size = new System.Drawing.Size(182, 26);
            this.txtMovie.TabIndex = 12;
            this.txtMovie.TextChanged += new System.EventHandler(this.SearchChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.FillWeight = 50F;
            this.Id.HeaderText = "Reservation ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Screening
            // 
            this.Screening.DataPropertyName = "Screening.Movie.Title";
            this.Screening.HeaderText = "Movie";
            this.Screening.MinimumWidth = 6;
            this.Screening.Name = "Screening";
            this.Screening.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "User.FullName";
            this.FullName.FillWeight = 70F;
            this.FullName.HeaderText = "Customer";
            this.FullName.MinimumWidth = 50;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Invoice.PriceWithTax";
            this.Price.FillWeight = 50F;
            this.Price.HeaderText = "Price with VAT";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CreatedAt
            // 
            this.CreatedAt.DataPropertyName = "CreatedAt";
            this.CreatedAt.FillWeight = 50F;
            this.CreatedAt.HeaderText = "Date added";
            this.CreatedAt.MinimumWidth = 6;
            this.CreatedAt.Name = "CreatedAt";
            this.CreatedAt.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.FillWeight = 40F;
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // DetailsAction
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.DetailsAction.DefaultCellStyle = dataGridViewCellStyle4;
            this.DetailsAction.FillWeight = 60F;
            this.DetailsAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DetailsAction.HeaderText = "Action";
            this.DetailsAction.MinimumWidth = 4;
            this.DetailsAction.Name = "DetailsAction";
            this.DetailsAction.ReadOnly = true;
            this.DetailsAction.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DetailsAction.Text = "Cancel Reservation";
            this.DetailsAction.UseColumnTextForButtonValue = true;
            // 
            // FormReservationList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1447, 800);
            this.Controls.Add(this.pnlFormTitle);
            this.Controls.Add(this.pnlDataGrid);
            this.Controls.Add(this.pnlContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormReservationList";
            this.Text = "frmMoviesList";
            this.Load += new System.EventHandler(this.FormReservationList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdReservationsList)).EndInit();
            this.pnlFormTitle.ResumeLayout(false);
            this.pnlFormTitle.PerformLayout();
            this.pnlSearchBars.ResumeLayout(false);
            this.pnlSearchBars.PerformLayout();
            this.pnlDataGrid.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdReservationsList;
        private System.Windows.Forms.Label lblReservationId;
        private System.Windows.Forms.Panel pnlFormTitle;
        private System.Windows.Forms.TextBox txtFormTitle;
        private System.Windows.Forms.Panel pnlSearchBars;
        private System.Windows.Forms.Panel pnlDataGrid;
        private System.Windows.Forms.Panel pnlContent;
        private UserControls.Pagination pagination;
        private System.Windows.Forms.Label lblBreadCrumbsCurrent;
        private System.Windows.Forms.Label lblBreadcrumbs;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private UserControls.ExtendedTextBox txtPrice;
        private UserControls.ExtendedTextBox txtReservationId;
        private System.Windows.Forms.Label lblCustomer;
        private UserControls.ExtendedTextBox txtCustomer;
        private System.Windows.Forms.DateTimePicker dtpDateAdded;
        private System.Windows.Forms.Label lblMovie;
        private UserControls.ExtendedTextBox txtMovie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Screening;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewButtonColumn DetailsAction;
    }
}