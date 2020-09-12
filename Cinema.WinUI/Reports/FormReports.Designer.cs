namespace Cinema.WinUI.Reports
{
    partial class FormReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReports));
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
            this.dgvReservationsList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Screening = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvScreeningsList = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateAndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservationsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScreeningsList)).BeginInit();
            this.SuspendLayout();
            // 
            // pgnScreenings
            // 
            this.pgnScreenings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pgnScreenings.AutoSize = true;
            this.pgnScreenings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pgnScreenings.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pgnScreenings.Location = new System.Drawing.Point(885, 13);
            this.pgnScreenings.Margin = new System.Windows.Forms.Padding(4);
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
            this.panel1.Location = new System.Drawing.Point(0, 582);
            this.panel1.Margin = new System.Windows.Forms.Padding(30);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.panel1.Size = new System.Drawing.Size(1108, 61);
            this.panel1.TabIndex = 12;
            // 
            // pgnReservations
            // 
            this.pgnReservations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pgnReservations.AutoSize = true;
            this.pgnReservations.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pgnReservations.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pgnReservations.Location = new System.Drawing.Point(883, 13);
            this.pgnReservations.Margin = new System.Windows.Forms.Padding(4);
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
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1108, 58);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // btnLoadScreenings
            // 
            this.btnLoadScreenings.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnLoadScreenings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btnLoadScreenings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadScreenings.Location = new System.Drawing.Point(140, 17);
            this.btnLoadScreenings.Margin = new System.Windows.Forms.Padding(10);
            this.btnLoadScreenings.Name = "btnLoadScreenings";
            this.btnLoadScreenings.Size = new System.Drawing.Size(95, 23);
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
            this.btnLoadReservations.Location = new System.Drawing.Point(10, 17);
            this.btnLoadReservations.Margin = new System.Windows.Forms.Padding(10);
            this.btnLoadReservations.Name = "btnLoadReservations";
            this.btnLoadReservations.Size = new System.Drawing.Size(110, 23);
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
            this.btnExportPDF.Location = new System.Drawing.Point(942, 17);
            this.btnExportPDF.Margin = new System.Windows.Forms.Padding(10);
            this.btnExportPDF.Name = "btnExportPDF";
            this.btnExportPDF.Size = new System.Drawing.Size(85, 23);
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
            this.btnPrint.Location = new System.Drawing.Point(1047, 17);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(10);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(51, 23);
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
            this.btnExportExcel.Location = new System.Drawing.Point(833, 17);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(10);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(89, 23);
            this.btnExportExcel.TabIndex = 0;
            this.btnExportExcel.Text = "Export to excel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dgvReservationsList);
            this.panel2.Controls.Add(this.dgvScreeningsList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Margin = new System.Windows.Forms.Padding(30);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.panel2.Size = new System.Drawing.Size(1108, 524);
            this.panel2.TabIndex = 12;
            // 
            // dgvReservationsList
            // 
            this.dgvReservationsList.AllowUserToAddRows = false;
            this.dgvReservationsList.AllowUserToDeleteRows = false;
            this.dgvReservationsList.AllowUserToResizeColumns = false;
            this.dgvReservationsList.AllowUserToResizeRows = false;
            this.dgvReservationsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservationsList.BackgroundColor = System.Drawing.Color.White;
            this.dgvReservationsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReservationsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvReservationsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservationsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReservationsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservationsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Screening,
            this.FullName,
            this.dataGridViewTextBoxColumn2,
            this.CreatedAt,
            this.dataGridViewTextBoxColumn3});
            this.dgvReservationsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReservationsList.GridColor = System.Drawing.Color.White;
            this.dgvReservationsList.Location = new System.Drawing.Point(11, 12);
            this.dgvReservationsList.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.dgvReservationsList.Name = "dgvReservationsList";
            this.dgvReservationsList.ReadOnly = true;
            this.dgvReservationsList.RowHeadersVisible = false;
            this.dgvReservationsList.RowHeadersWidth = 51;
            this.dgvReservationsList.RowTemplate.Height = 24;
            this.dgvReservationsList.Size = new System.Drawing.Size(1086, 500);
            this.dgvReservationsList.TabIndex = 1;
            this.dgvReservationsList.Visible = false;
            this.dgvReservationsList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvReportReservations_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.FillWeight = 50F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Reservation ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
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
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Invoice.PriceWithTax";
            this.dataGridViewTextBoxColumn2.FillWeight = 50F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Price with VAT";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn3.FillWeight = 40F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Status";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvScreeningsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
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
            this.dgvScreeningsList.Location = new System.Drawing.Point(11, 12);
            this.dgvScreeningsList.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.dgvScreeningsList.Name = "dgvScreeningsList";
            this.dgvScreeningsList.ReadOnly = true;
            this.dgvScreeningsList.RowHeadersVisible = false;
            this.dgvScreeningsList.RowHeadersWidth = 51;
            this.dgvScreeningsList.RowTemplate.Height = 24;
            this.dgvScreeningsList.Size = new System.Drawing.Size(1086, 500);
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
            // FormReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 643);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormReports";
            this.Text = "eCinema - Reports";
            this.Load += new System.EventHandler(this.FormReports_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservationsList)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvReservationsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Screening;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnLoadScreenings;
        private System.Windows.Forms.Button btnExportPDF;
        private System.Windows.Forms.Button btnPrint;
        private UserControls.Pagination pgnReservations;
    }
}