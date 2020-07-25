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
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnPreviousPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.rtxCurrentPage = new System.Windows.Forms.RichTextBox();
            this.rtxLastPage = new System.Windows.Forms.RichTextBox();
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
            this.grdMoviesList.Name = "grdMoviesList";
            this.grdMoviesList.RowHeadersWidth = 51;
            this.grdMoviesList.RowTemplate.Height = 24;
            this.grdMoviesList.Size = new System.Drawing.Size(800, 276);
            this.grdMoviesList.TabIndex = 0;
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
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(290, 22);
            this.txtSearchBar.TabIndex = 1;
            this.txtSearchBar.TextChanged += new System.EventHandler(this.txtSearchBar_TextChanged);
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
            this.txtSearchYear.Location = new System.Drawing.Point(558, 41);
            this.txtSearchYear.Name = "txtSearchYear";
            this.txtSearchYear.Size = new System.Drawing.Size(117, 22);
            this.txtSearchYear.TabIndex = 3;
            this.txtSearchYear.TextChanged += new System.EventHandler(this.txtSearchYear_TextChanged);
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
            this.txtSearchDuration.Name = "txtSearchDuration";
            this.txtSearchDuration.Size = new System.Drawing.Size(125, 22);
            this.txtSearchDuration.TabIndex = 5;
            this.txtSearchDuration.TextChanged += new System.EventHandler(this.txtSearchDuration_TextChanged);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.Location = new System.Drawing.Point(427, 388);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(40, 40);
            this.btnFirstPage.TabIndex = 7;
            this.btnFirstPage.Text = "<<";
            this.btnFirstPage.UseVisualStyleBackColor = true;
            // 
            // btnLastPage
            // 
            this.btnLastPage.Location = new System.Drawing.Point(627, 387);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(40, 40);
            this.btnLastPage.TabIndex = 8;
            this.btnLastPage.Text = ">>";
            this.btnLastPage.UseVisualStyleBackColor = true;
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.Location = new System.Drawing.Point(467, 388);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(40, 40);
            this.btnPreviousPage.TabIndex = 10;
            this.btnPreviousPage.Text = "<";
            this.btnPreviousPage.UseVisualStyleBackColor = true;
            // 
            // btnNextPage
            // 
            this.btnNextPage.Location = new System.Drawing.Point(587, 387);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(40, 40);
            this.btnNextPage.TabIndex = 11;
            this.btnNextPage.Text = ">";
            this.btnNextPage.UseVisualStyleBackColor = true;
            // 
            // rtxCurrentPage
            // 
            this.rtxCurrentPage.Location = new System.Drawing.Point(507, 388);
            this.rtxCurrentPage.Name = "rtxCurrentPage";
            this.rtxCurrentPage.ReadOnly = true;
            this.rtxCurrentPage.Size = new System.Drawing.Size(34, 34);
            this.rtxCurrentPage.TabIndex = 12;
            this.rtxCurrentPage.Text = "1";
            this.rtxCurrentPage.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // rtxLastPage
            // 
            this.rtxLastPage.Location = new System.Drawing.Point(547, 387);
            this.rtxLastPage.Name = "rtxLastPage";
            this.rtxLastPage.ReadOnly = true;
            this.rtxLastPage.Size = new System.Drawing.Size(34, 34);
            this.rtxLastPage.TabIndex = 13;
            this.rtxLastPage.Text = "1";
            // 
            // frmMoviesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtxLastPage);
            this.Controls.Add(this.rtxCurrentPage);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btnPreviousPage);
            this.Controls.Add(this.btnLastPage);
            this.Controls.Add(this.btnFirstPage);
            this.Controls.Add(this.lblSearchDuration);
            this.Controls.Add(this.txtSearchDuration);
            this.Controls.Add(this.lblSearchYear);
            this.Controls.Add(this.txtSearchYear);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearchBar);
            this.Controls.Add(this.grdMoviesList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Button btnFirstPage;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Button btnPreviousPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.RichTextBox rtxCurrentPage;
        private System.Windows.Forms.RichTextBox rtxLastPage;
    }
}