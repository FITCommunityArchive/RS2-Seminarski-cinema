namespace Cinema.WinUI.Movies
{
    partial class frmMoviesList
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
            this.grdMoviesList = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Directors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchBar = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblSearchYear = new System.Windows.Forms.Label();
            this.txtSearchYear = new System.Windows.Forms.TextBox();
            this.lblSearchDuration = new System.Windows.Forms.Label();
            this.txtSearchDuration = new System.Windows.Forms.TextBox();
            this.pagination1 = new Cinema.WinUI.UserControls.Pagination();
            ((System.ComponentModel.ISupportInitialize)(this.grdMoviesList)).BeginInit();
            this.SuspendLayout();
            // 
            // grdMoviesList
            // 
            this.grdMoviesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdMoviesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMoviesList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Duration,
            this.Year,
            this.Country,
            this.Directors,
            this.Actors});
            this.grdMoviesList.Location = new System.Drawing.Point(0, 90);
            this.grdMoviesList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdMoviesList.Name = "grdMoviesList";
            this.grdMoviesList.RowHeadersWidth = 51;
            this.grdMoviesList.RowTemplate.Height = 24;
            this.grdMoviesList.Size = new System.Drawing.Size(800, 492);
            this.grdMoviesList.TabIndex = 0;
            this.grdMoviesList.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdMoviesList_ColumnHeaderMouseClick);
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            // 
            // Duration
            // 
            this.Duration.DataPropertyName = "Duration";
            this.Duration.HeaderText = "Duration";
            this.Duration.MinimumWidth = 6;
            this.Duration.Name = "Duration";
            // 
            // Year
            // 
            this.Year.DataPropertyName = "Year";
            this.Year.HeaderText = "Year";
            this.Year.MinimumWidth = 6;
            this.Year.Name = "Year";
            // 
            // Country
            // 
            this.Country.DataPropertyName = "Country";
            this.Country.HeaderText = "Country";
            this.Country.MinimumWidth = 6;
            this.Country.Name = "Country";
            // 
            // Directors
            // 
            this.Directors.DataPropertyName = "Directors";
            this.Directors.HeaderText = "Directors";
            this.Directors.MinimumWidth = 6;
            this.Directors.Name = "Directors";
            // 
            // Actors
            // 
            this.Actors.DataPropertyName = "Actors";
            this.Actors.HeaderText = "Actors";
            this.Actors.MinimumWidth = 6;
            this.Actors.Name = "Actors";
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.Location = new System.Drawing.Point(12, 41);
            this.txtSearchBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(289, 22);
            this.txtSearchBar.TabIndex = 1;
            this.txtSearchBar.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(13, 18);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(53, 17);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Search";
            // 
            // lblSearchYear
            // 
            this.lblSearchYear.AutoSize = true;
            this.lblSearchYear.Location = new System.Drawing.Point(555, 18);
            this.lblSearchYear.Name = "lblSearchYear";
            this.lblSearchYear.Size = new System.Drawing.Size(38, 17);
            this.lblSearchYear.TabIndex = 4;
            this.lblSearchYear.Text = "Year";
            // 
            // txtSearchYear
            // 
            this.txtSearchYear.Location = new System.Drawing.Point(557, 41);
            this.txtSearchYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchYear.Name = "txtSearchYear";
            this.txtSearchYear.Size = new System.Drawing.Size(117, 22);
            this.txtSearchYear.TabIndex = 3;
            this.txtSearchYear.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearchDuration
            // 
            this.lblSearchDuration.AutoSize = true;
            this.lblSearchDuration.Location = new System.Drawing.Point(424, 18);
            this.lblSearchDuration.Name = "lblSearchDuration";
            this.lblSearchDuration.Size = new System.Drawing.Size(62, 17);
            this.lblSearchDuration.TabIndex = 6;
            this.lblSearchDuration.Text = "Duration";
            // 
            // txtSearchDuration
            // 
            this.txtSearchDuration.Location = new System.Drawing.Point(427, 41);
            this.txtSearchDuration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchDuration.Name = "txtSearchDuration";
            this.txtSearchDuration.Size = new System.Drawing.Size(125, 22);
            this.txtSearchDuration.TabIndex = 5;
            this.txtSearchDuration.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pagination1
            // 
            this.pagination1.Location = new System.Drawing.Point(492, 603);
            this.pagination1.Margin = new System.Windows.Forms.Padding(5);
            this.pagination1.Name = "pagination1";
            this.pagination1.PageIndex = 0;
            this.pagination1.Size = new System.Drawing.Size(292, 46);
            this.pagination1.TabIndex = 7;
            this.pagination1.TotalPages = 0;
            this.pagination1.PageChanged += new System.EventHandler(this.pagination1_PageChanged);
            // 
            // frmMoviesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 663);
            this.Controls.Add(this.pagination1);
            this.Controls.Add(this.lblSearchDuration);
            this.Controls.Add(this.txtSearchDuration);
            this.Controls.Add(this.lblSearchYear);
            this.Controls.Add(this.txtSearchYear);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearchBar);
            this.Controls.Add(this.grdMoviesList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMoviesList";
            this.Text = "frmMoviesList";
            this.Load += new System.EventHandler(this.frmMoviesList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMoviesList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdMoviesList;
        private System.Windows.Forms.TextBox txtSearchBar;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblSearchYear;
        private System.Windows.Forms.TextBox txtSearchYear;
        private System.Windows.Forms.Label lblSearchDuration;
        private System.Windows.Forms.TextBox txtSearchDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn Directors;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actors;
        private UserControls.Pagination pagination1;
    }
}