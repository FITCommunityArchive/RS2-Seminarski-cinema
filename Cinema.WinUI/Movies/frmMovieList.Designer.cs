﻿namespace Cinema.WinUI.Movies
{
    partial class frmMovieList
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
            this.grdMoviesList = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Directors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Writers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetailsAction = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtSearchBar = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblSearchYear = new System.Windows.Forms.Label();
            this.txtSearchYear = new System.Windows.Forms.TextBox();
            this.lblSearchDuration = new System.Windows.Forms.Label();
            this.txtSearchDuration = new System.Windows.Forms.TextBox();
            this.pnlFormTitle = new System.Windows.Forms.Panel();
            this.txtFormTitle = new System.Windows.Forms.TextBox();
            this.pnlSearchBars = new System.Windows.Forms.Panel();
            this.pnlDataGrid = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.btnAddNew = new Cinema.WinUI.UserControls.Buttons.AddNewButton();
            this.pgnMoviesList = new Cinema.WinUI.UserControls.Pagination();
            ((System.ComponentModel.ISupportInitialize)(this.grdMoviesList)).BeginInit();
            this.pnlFormTitle.SuspendLayout();
            this.pnlSearchBars.SuspendLayout();
            this.pnlDataGrid.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdMoviesList
            // 
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
            this.grdMoviesList.GridColor = System.Drawing.Color.White;
            this.grdMoviesList.Location = new System.Drawing.Point(15, 24);
            this.grdMoviesList.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.grdMoviesList.Name = "grdMoviesList";
            this.grdMoviesList.ReadOnly = true;
            this.grdMoviesList.RowHeadersVisible = false;
            this.grdMoviesList.RowHeadersWidth = 51;
            this.grdMoviesList.RowTemplate.Height = 24;
            this.grdMoviesList.Size = new System.Drawing.Size(1009, 382);
            this.grdMoviesList.TabIndex = 0;
            this.grdMoviesList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMoviesList_CellContentClick);
            this.grdMoviesList.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdMoviesList_ColumnHeaderMouseClick);
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
            // txtSearchBar
            // 
            this.txtSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchBar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearchBar.Location = new System.Drawing.Point(15, 32);
            this.txtSearchBar.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(821, 20);
            this.txtSearchBar.TabIndex = 1;
            this.txtSearchBar.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.White;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Gray;
            this.lblSearch.Location = new System.Drawing.Point(13, 12);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 4);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(55, 18);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Search";
            // 
            // lblSearchYear
            // 
            this.lblSearchYear.AutoSize = true;
            this.lblSearchYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchYear.ForeColor = System.Drawing.Color.Gray;
            this.lblSearchYear.Location = new System.Drawing.Point(951, 12);
            this.lblSearchYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchYear.Name = "lblSearchYear";
            this.lblSearchYear.Size = new System.Drawing.Size(38, 18);
            this.lblSearchYear.TabIndex = 4;
            this.lblSearchYear.Text = "Year";
            // 
            // txtSearchYear
            // 
            this.txtSearchYear.Location = new System.Drawing.Point(954, 31);
            this.txtSearchYear.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchYear.Name = "txtSearchYear";
            this.txtSearchYear.Size = new System.Drawing.Size(70, 20);
            this.txtSearchYear.TabIndex = 3;
            this.txtSearchYear.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearchDuration
            // 
            this.lblSearchDuration.AutoSize = true;
            this.lblSearchDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchDuration.ForeColor = System.Drawing.Color.Gray;
            this.lblSearchDuration.Location = new System.Drawing.Point(837, 11);
            this.lblSearchDuration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchDuration.Name = "lblSearchDuration";
            this.lblSearchDuration.Size = new System.Drawing.Size(64, 18);
            this.lblSearchDuration.TabIndex = 6;
            this.lblSearchDuration.Text = "Duration";
            // 
            // txtSearchDuration
            // 
            this.txtSearchDuration.Location = new System.Drawing.Point(840, 31);
            this.txtSearchDuration.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchDuration.Name = "txtSearchDuration";
            this.txtSearchDuration.Size = new System.Drawing.Size(110, 20);
            this.txtSearchDuration.TabIndex = 5;
            this.txtSearchDuration.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pnlFormTitle
            // 
            this.pnlFormTitle.BackColor = System.Drawing.Color.White;
            this.pnlFormTitle.Controls.Add(this.txtFormTitle);
            this.pnlFormTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlFormTitle.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFormTitle.Name = "pnlFormTitle";
            this.pnlFormTitle.Size = new System.Drawing.Size(1085, 73);
            this.pnlFormTitle.TabIndex = 8;
            // 
            // txtFormTitle
            // 
            this.txtFormTitle.BackColor = System.Drawing.Color.White;
            this.txtFormTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFormTitle.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormTitle.ForeColor = System.Drawing.Color.Gray;
            this.txtFormTitle.Location = new System.Drawing.Point(28, 15);
            this.txtFormTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtFormTitle.Name = "txtFormTitle";
            this.txtFormTitle.Size = new System.Drawing.Size(75, 33);
            this.txtFormTitle.TabIndex = 0;
            this.txtFormTitle.Text = "Movies";
            // 
            // pnlSearchBars
            // 
            this.pnlSearchBars.BackColor = System.Drawing.Color.White;
            this.pnlSearchBars.Controls.Add(this.txtSearchDuration);
            this.pnlSearchBars.Controls.Add(this.txtSearchYear);
            this.pnlSearchBars.Controls.Add(this.lblSearch);
            this.pnlSearchBars.Controls.Add(this.lblSearchYear);
            this.pnlSearchBars.Controls.Add(this.txtSearchBar);
            this.pnlSearchBars.Controls.Add(this.lblSearchDuration);
            this.pnlSearchBars.Location = new System.Drawing.Point(22, 92);
            this.pnlSearchBars.Margin = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.pnlSearchBars.Name = "pnlSearchBars";
            this.pnlSearchBars.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.pnlSearchBars.Size = new System.Drawing.Size(1037, 72);
            this.pnlSearchBars.TabIndex = 9;
            // 
            // pnlDataGrid
            // 
            this.pnlDataGrid.BackColor = System.Drawing.Color.White;
            this.pnlDataGrid.Controls.Add(this.grdMoviesList);
            this.pnlDataGrid.Location = new System.Drawing.Point(22, 176);
            this.pnlDataGrid.Margin = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.pnlDataGrid.Name = "pnlDataGrid";
            this.pnlDataGrid.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.pnlDataGrid.Size = new System.Drawing.Size(1039, 408);
            this.pnlDataGrid.TabIndex = 10;
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.btnAddNew);
            this.pnlContent.Controls.Add(this.pgnMoviesList);
            this.pnlContent.Controls.Add(this.pnlSearchBars);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(2);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.pnlContent.Size = new System.Drawing.Size(1085, 650);
            this.pnlContent.TabIndex = 11;
            // 
            // btnAddNew
            // 
            this.btnAddNew.AutoSize = true;
            this.btnAddNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddNew.Location = new System.Drawing.Point(723, 590);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(120, 35);
            this.btnAddNew.TabIndex = 11;
            this.btnAddNew.ButtonClicked += new System.EventHandler(this.btnAddNew_ButtonClicked);
            // 
            // pgnMoviesList
            // 
            this.pgnMoviesList.AutoSize = true;
            this.pgnMoviesList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pgnMoviesList.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pgnMoviesList.Location = new System.Drawing.Point(849, 590);
            this.pgnMoviesList.Margin = new System.Windows.Forms.Padding(4);
            this.pgnMoviesList.Name = "pgnMoviesList";
            this.pgnMoviesList.PageIndex = 0;
            this.pgnMoviesList.Size = new System.Drawing.Size(210, 35);
            this.pgnMoviesList.TabIndex = 10;
            this.pgnMoviesList.TotalPages = 0;
            this.pgnMoviesList.PageChanged += new System.EventHandler(this.pgnMoviesList_PageChanged);
            // 
            // frmMovieList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1085, 650);
            this.Controls.Add(this.pnlFormTitle);
            this.Controls.Add(this.pnlDataGrid);
            this.Controls.Add(this.pnlContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMovieList";
            this.Text = "frmMoviesList";
            this.Load += new System.EventHandler(this.frmMoviesList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMoviesList)).EndInit();
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

        private System.Windows.Forms.DataGridView grdMoviesList;
        private System.Windows.Forms.TextBox txtSearchBar;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblSearchYear;
        private System.Windows.Forms.TextBox txtSearchYear;
        private System.Windows.Forms.Label lblSearchDuration;
        private System.Windows.Forms.TextBox txtSearchDuration;
        private System.Windows.Forms.Panel pnlFormTitle;
        private System.Windows.Forms.TextBox txtFormTitle;
        private System.Windows.Forms.Panel pnlSearchBars;
        private System.Windows.Forms.Panel pnlDataGrid;
        private System.Windows.Forms.Panel pnlContent;
        private UserControls.Pagination pgnMoviesList;
        private UserControls.Buttons.AddNewButton btnAddNew;
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