namespace Cinema.WinUI.Movies
{
    partial class FormMovieList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMovieList));
            this.grdMoviesList = new System.Windows.Forms.DataGridView();
            this.txtSearchBar = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblSearchYear = new System.Windows.Forms.Label();
            this.txtSearchYear = new System.Windows.Forms.TextBox();
            this.lblSearchDuration = new System.Windows.Forms.Label();
            this.txtSearchDuration = new System.Windows.Forms.TextBox();
            this.lblBreadCrumbsCurrent = new System.Windows.Forms.Label();
            this.lblBreadcrumbs = new System.Windows.Forms.Label();
            this.txtFormTitle = new System.Windows.Forms.TextBox();
            this.btnAddNew = new Cinema.WinUI.UserControls.Buttons.AddNewButton();
            this.pgnMoviesList = new Cinema.WinUI.UserControls.Pagination();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Directors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Writers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetailsAction = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdMoviesList)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdMoviesList
            // 
            this.grdMoviesList.AllowUserToAddRows = false;
            this.grdMoviesList.AllowUserToDeleteRows = false;
            this.grdMoviesList.AllowUserToResizeColumns = false;
            this.grdMoviesList.AllowUserToResizeRows = false;
            this.grdMoviesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdMoviesList.BackgroundColor = System.Drawing.Color.White;
            this.grdMoviesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdMoviesList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.grdMoviesList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMoviesList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdMoviesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMoviesList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.Duration,
            this.Year,
            this.Country,
            this.Directors,
            this.Writers,
            this.Actors,
            this.DetailsAction});
            this.grdMoviesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMoviesList.GridColor = System.Drawing.Color.White;
            this.grdMoviesList.Location = new System.Drawing.Point(15, 15);
            this.grdMoviesList.Margin = new System.Windows.Forms.Padding(15);
            this.grdMoviesList.Name = "grdMoviesList";
            this.grdMoviesList.ReadOnly = true;
            this.grdMoviesList.RowHeadersVisible = false;
            this.grdMoviesList.RowHeadersWidth = 51;
            this.grdMoviesList.RowTemplate.Height = 24;
            this.grdMoviesList.Size = new System.Drawing.Size(694, 206);
            this.grdMoviesList.TabIndex = 0;
            this.grdMoviesList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMoviesList_CellContentClick);
            this.grdMoviesList.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdMoviesList_ColumnHeaderMouseClick);
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchBar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearchBar.Location = new System.Drawing.Point(15, 42);
            this.txtSearchBar.Margin = new System.Windows.Forms.Padding(15, 5, 5, 5);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(414, 20);
            this.txtSearchBar.TabIndex = 1;
            this.txtSearchBar.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
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
            this.lblSearch.Size = new System.Drawing.Size(46, 15);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Search";
            // 
            // lblSearchYear
            // 
            this.lblSearchYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSearchYear.AutoSize = true;
            this.lblSearchYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchYear.ForeColor = System.Drawing.Color.Gray;
            this.lblSearchYear.Location = new System.Drawing.Point(583, 17);
            this.lblSearchYear.Margin = new System.Windows.Forms.Padding(5);
            this.lblSearchYear.Name = "lblSearchYear";
            this.lblSearchYear.Size = new System.Drawing.Size(32, 15);
            this.lblSearchYear.TabIndex = 4;
            this.lblSearchYear.Text = "Year";
            // 
            // txtSearchYear
            // 
            this.txtSearchYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchYear.Location = new System.Drawing.Point(583, 42);
            this.txtSearchYear.Margin = new System.Windows.Forms.Padding(5, 5, 15, 5);
            this.txtSearchYear.Name = "txtSearchYear";
            this.txtSearchYear.Size = new System.Drawing.Size(126, 20);
            this.txtSearchYear.TabIndex = 3;
            this.txtSearchYear.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearchDuration
            // 
            this.lblSearchDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSearchDuration.AutoSize = true;
            this.lblSearchDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchDuration.ForeColor = System.Drawing.Color.Gray;
            this.lblSearchDuration.Location = new System.Drawing.Point(439, 17);
            this.lblSearchDuration.Margin = new System.Windows.Forms.Padding(5);
            this.lblSearchDuration.Name = "lblSearchDuration";
            this.lblSearchDuration.Size = new System.Drawing.Size(54, 15);
            this.lblSearchDuration.TabIndex = 6;
            this.lblSearchDuration.Text = "Duration";
            // 
            // txtSearchDuration
            // 
            this.txtSearchDuration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchDuration.Location = new System.Drawing.Point(439, 42);
            this.txtSearchDuration.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearchDuration.Name = "txtSearchDuration";
            this.txtSearchDuration.Size = new System.Drawing.Size(134, 20);
            this.txtSearchDuration.TabIndex = 5;
            this.txtSearchDuration.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblBreadCrumbsCurrent
            // 
            this.lblBreadCrumbsCurrent.AutoSize = true;
            this.lblBreadCrumbsCurrent.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreadCrumbsCurrent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBreadCrumbsCurrent.Location = new System.Drawing.Point(80, 45);
            this.lblBreadCrumbsCurrent.Margin = new System.Windows.Forms.Padding(0);
            this.lblBreadCrumbsCurrent.Name = "lblBreadCrumbsCurrent";
            this.lblBreadCrumbsCurrent.Size = new System.Drawing.Size(52, 13);
            this.lblBreadCrumbsCurrent.TabIndex = 5;
            this.lblBreadCrumbsCurrent.Text = "Movies";
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
            this.txtFormTitle.Size = new System.Drawing.Size(75, 27);
            this.txtFormTitle.TabIndex = 0;
            this.txtFormTitle.Text = "Movies";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnAddNew.AutoSize = true;
            this.btnAddNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddNew.Location = new System.Drawing.Point(414, 5);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(90, 35);
            this.btnAddNew.TabIndex = 11;
            this.btnAddNew.ButtonClicked += new System.EventHandler(this.btnAddNew_ButtonClicked);
            // 
            // pgnMoviesList
            // 
            this.pgnMoviesList.AutoSize = true;
            this.pgnMoviesList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pgnMoviesList.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pgnMoviesList.Location = new System.Drawing.Point(514, 5);
            this.pgnMoviesList.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.pgnMoviesList.Name = "pgnMoviesList";
            this.pgnMoviesList.PageIndex = 0;
            this.pgnMoviesList.Size = new System.Drawing.Size(210, 35);
            this.pgnMoviesList.TabIndex = 10;
            this.pgnMoviesList.TotalPages = 0;
            this.pgnMoviesList.PageChanged += new System.EventHandler(this.pgnMoviesList_PageChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.txtSearchYear, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtSearchDuration, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblSearch, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtSearchBar, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblSearchYear, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblSearchDuration, 1, 0);
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
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.pgnMoviesList);
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
            this.panel2.Controls.Add(this.grdMoviesList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(30, 210);
            this.panel2.Margin = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(15);
            this.panel2.Size = new System.Drawing.Size(724, 236);
            this.panel2.TabIndex = 3;
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
            this.Title.FillWeight = 200F;
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 50;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Duration
            // 
            this.Duration.DataPropertyName = "Duration";
            this.Duration.FillWeight = 70F;
            this.Duration.HeaderText = "Duration";
            this.Duration.MinimumWidth = 6;
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            this.Duration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Year
            // 
            this.Year.DataPropertyName = "Year";
            this.Year.FillWeight = 70F;
            this.Year.HeaderText = "Year";
            this.Year.MinimumWidth = 6;
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            this.Year.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Country
            // 
            this.Country.DataPropertyName = "Country";
            this.Country.FillWeight = 85.47237F;
            this.Country.HeaderText = "Country";
            this.Country.MinimumWidth = 6;
            this.Country.Name = "Country";
            this.Country.ReadOnly = true;
            this.Country.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Directors
            // 
            this.Directors.DataPropertyName = "Directors";
            this.Directors.FillWeight = 85.47237F;
            this.Directors.HeaderText = "Directors";
            this.Directors.MinimumWidth = 6;
            this.Directors.Name = "Directors";
            this.Directors.ReadOnly = true;
            this.Directors.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Writers
            // 
            this.Writers.DataPropertyName = "Writers";
            this.Writers.HeaderText = "Writers";
            this.Writers.MinimumWidth = 6;
            this.Writers.Name = "Writers";
            this.Writers.ReadOnly = true;
            // 
            // Actors
            // 
            this.Actors.DataPropertyName = "Actors";
            this.Actors.FillWeight = 85.47237F;
            this.Actors.HeaderText = "Actors";
            this.Actors.MinimumWidth = 6;
            this.Actors.Name = "Actors";
            this.Actors.ReadOnly = true;
            this.Actors.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // FormMovieList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormMovieList";
            this.Text = "eCinema - Movies";
            this.Load += new System.EventHandler(this.frmMoviesList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMoviesList)).EndInit();
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

        private System.Windows.Forms.DataGridView grdMoviesList;
        private System.Windows.Forms.TextBox txtSearchBar;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblSearchYear;
        private System.Windows.Forms.TextBox txtSearchYear;
        private System.Windows.Forms.Label lblSearchDuration;
        private System.Windows.Forms.TextBox txtSearchDuration;
        private System.Windows.Forms.TextBox txtFormTitle;
        private UserControls.Pagination pgnMoviesList;
        private UserControls.Buttons.AddNewButton btnAddNew;
        private System.Windows.Forms.Label lblBreadCrumbsCurrent;
        private System.Windows.Forms.Label lblBreadcrumbs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn Directors;
        private System.Windows.Forms.DataGridViewTextBoxColumn Writers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actors;
        private System.Windows.Forms.DataGridViewButtonColumn DetailsAction;
    }
}