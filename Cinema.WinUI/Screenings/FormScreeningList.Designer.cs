namespace Cinema.WinUI.Movies
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.pnlFormTitle = new System.Windows.Forms.Panel();
            this.lblBreadCrumbsCurrent = new System.Windows.Forms.Label();
            this.lblBreadcrumbs = new System.Windows.Forms.Label();
            this.txtFormTitle = new System.Windows.Forms.TextBox();
            this.pnlSearchBars = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtDate = new Cinema.WinUI.UserControls.ExtendedTextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new Cinema.WinUI.UserControls.ExtendedTextBox();
            this.txtSearchBar = new Cinema.WinUI.UserControls.ExtendedTextBox();
            this.pnlDataGrid = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.btnAddNew = new Cinema.WinUI.UserControls.Buttons.AddNewButton();
            this.pagination = new Cinema.WinUI.UserControls.Pagination();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetailsAction = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdScreeningsList)).BeginInit();
            this.pnlFormTitle.SuspendLayout();
            this.pnlSearchBars.SuspendLayout();
            this.pnlDataGrid.SuspendLayout();
            this.pnlContent.SuspendLayout();
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
            this.Price,
            this.Status,
            this.DetailsAction});
            this.grdScreeningsList.GridColor = System.Drawing.Color.White;
            this.grdScreeningsList.Location = new System.Drawing.Point(20, 30);
            this.grdScreeningsList.Margin = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.grdScreeningsList.Name = "grdScreeningsList";
            this.grdScreeningsList.ReadOnly = true;
            this.grdScreeningsList.RowHeadersVisible = false;
            this.grdScreeningsList.RowHeadersWidth = 51;
            this.grdScreeningsList.RowTemplate.Height = 24;
            this.grdScreeningsList.Size = new System.Drawing.Size(1345, 470);
            this.grdScreeningsList.TabIndex = 0;
            this.grdScreeningsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdScreeningsList_CellContentClick);
            this.grdScreeningsList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdScreeningsList_CellFormatting);
            this.grdScreeningsList.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdScreeningsList_ColumnHeaderMouseClick);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.White;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Gray;
            this.lblSearch.Location = new System.Drawing.Point(17, 15);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(89, 18);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Movie name";
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
            this.lblBreadCrumbsCurrent.Size = new System.Drawing.Size(93, 17);
            this.lblBreadCrumbsCurrent.TabIndex = 5;
            this.lblBreadCrumbsCurrent.Text = "Screenings";
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
            this.txtFormTitle.Size = new System.Drawing.Size(161, 33);
            this.txtFormTitle.TabIndex = 0;
            this.txtFormTitle.Text = "Screenings";
            // 
            // pnlSearchBars
            // 
            this.pnlSearchBars.BackColor = System.Drawing.Color.White;
            this.pnlSearchBars.Controls.Add(this.lblStatus);
            this.pnlSearchBars.Controls.Add(this.cmbStatus);
            this.pnlSearchBars.Controls.Add(this.lblDate);
            this.pnlSearchBars.Controls.Add(this.txtDate);
            this.pnlSearchBars.Controls.Add(this.lblPrice);
            this.pnlSearchBars.Controls.Add(this.txtPrice);
            this.pnlSearchBars.Controls.Add(this.lblSearch);
            this.pnlSearchBars.Controls.Add(this.txtSearchBar);
            this.pnlSearchBars.Location = new System.Drawing.Point(29, 113);
            this.pnlSearchBars.Margin = new System.Windows.Forms.Padding(20);
            this.pnlSearchBars.Name = "pnlSearchBars";
            this.pnlSearchBars.Padding = new System.Windows.Forms.Padding(15);
            this.pnlSearchBars.Size = new System.Drawing.Size(1383, 89);
            this.pnlSearchBars.TabIndex = 9;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.White;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Gray;
            this.lblStatus.Location = new System.Drawing.Point(1174, 15);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 18);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(1177, 37);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(188, 24);
            this.cmbStatus.TabIndex = 7;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.White;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Gray;
            this.lblDate.Location = new System.Drawing.Point(954, 15);
            this.lblDate.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(39, 18);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date";
            // 
            // txtDate
            // 
            this.txtDate.BorderColor = System.Drawing.Color.DarkGray;
            this.txtDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDate.Location = new System.Drawing.Point(935, 39);
            this.txtDate.Margin = new System.Windows.Forms.Padding(25);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(214, 22);
            this.txtDate.TabIndex = 5;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.White;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Gray;
            this.lblPrice.Location = new System.Drawing.Point(700, 14);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(42, 18);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.BorderColor = System.Drawing.Color.DarkGray;
            this.txtPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPrice.Location = new System.Drawing.Point(703, 39);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(25);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(182, 22);
            this.txtPrice.TabIndex = 3;
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.BorderColor = System.Drawing.Color.DarkGray;
            this.txtSearchBar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearchBar.Location = new System.Drawing.Point(20, 39);
            this.txtSearchBar.Margin = new System.Windows.Forms.Padding(15);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(643, 22);
            this.txtSearchBar.TabIndex = 1;
            this.txtSearchBar.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pnlDataGrid
            // 
            this.pnlDataGrid.BackColor = System.Drawing.Color.White;
            this.pnlDataGrid.Controls.Add(this.grdScreeningsList);
            this.pnlDataGrid.Location = new System.Drawing.Point(29, 217);
            this.pnlDataGrid.Margin = new System.Windows.Forms.Padding(20);
            this.pnlDataGrid.Name = "pnlDataGrid";
            this.pnlDataGrid.Padding = new System.Windows.Forms.Padding(15);
            this.pnlDataGrid.Size = new System.Drawing.Size(1385, 502);
            this.pnlDataGrid.TabIndex = 10;
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.btnAddNew);
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
            // btnAddNew
            // 
            this.btnAddNew.AutoSize = true;
            this.btnAddNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddNew.Location = new System.Drawing.Point(964, 726);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(120, 40);
            this.btnAddNew.TabIndex = 11;
            this.btnAddNew.ButtonClicked += new System.EventHandler(this.btnAddNew_ButtonClicked);
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
            this.Title.FillWeight = 200F;
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
            this.Status.DataPropertyName = "Status";
            this.Status.FillWeight = 70F;
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // DetailsAction
            // 
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
            // 
            // FormScreeningList
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
            this.Name = "FormScreeningList";
            this.Text = "frmMoviesList";
            this.Load += new System.EventHandler(this.FormScreeningList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdScreeningsList)).EndInit();
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

        private System.Windows.Forms.DataGridView grdScreeningsList;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel pnlFormTitle;
        private System.Windows.Forms.TextBox txtFormTitle;
        private System.Windows.Forms.Panel pnlSearchBars;
        private System.Windows.Forms.Panel pnlDataGrid;
        private System.Windows.Forms.Panel pnlContent;
        private UserControls.Pagination pagination;
        private UserControls.Buttons.AddNewButton btnAddNew;
        private System.Windows.Forms.Label lblBreadCrumbsCurrent;
        private System.Windows.Forms.Label lblBreadcrumbs;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private UserControls.ExtendedTextBox txtDate;
        private UserControls.ExtendedTextBox txtPrice;
        private UserControls.ExtendedTextBox txtSearchBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hall;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewButtonColumn DetailsAction;
    }
}