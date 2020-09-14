namespace Cinema.WinUI
{
    partial class FormDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpWidget = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIncome = new System.Windows.Forms.Label();
            this.lblIncomeAmount = new System.Windows.Forms.Label();
            this.lblIncomePercent = new System.Windows.Forms.Label();
            this.lblAnnual = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTickets = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTicketsCounter = new System.Windows.Forms.Label();
            this.lblPercent = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNewVisits = new System.Windows.Forms.Label();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.lblToday = new System.Windows.Forms.Label();
            this.lblCustomersCounter = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCapacityCount = new System.Windows.Forms.Label();
            this.lblCapacities = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblCapacitiesFreeOccupied = new System.Windows.Forms.Label();
            this.lblOccupiedCount = new System.Windows.Forms.Label();
            this.crtSalesPerMonth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMainChartName = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvScreenings = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateAndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pgnScreenings = new Cinema.WinUI.UserControls.Pagination();
            this.label1 = new System.Windows.Forms.Label();
            this.tlpWidget.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crtSalesPerMonth)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScreenings)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpWidget
            // 
            this.tlpWidget.BackColor = System.Drawing.Color.White;
            this.tlpWidget.ColumnCount = 3;
            this.tlpWidget.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tlpWidget.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tlpWidget.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tlpWidget.Controls.Add(this.label2, 0, 2);
            this.tlpWidget.Controls.Add(this.lblIncome, 0, 0);
            this.tlpWidget.Controls.Add(this.lblIncomeAmount, 0, 1);
            this.tlpWidget.Controls.Add(this.lblIncomePercent, 2, 2);
            this.tlpWidget.Controls.Add(this.lblAnnual, 2, 0);
            this.tlpWidget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpWidget.Location = new System.Drawing.Point(13, 12);
            this.tlpWidget.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.tlpWidget.MinimumSize = new System.Drawing.Size(0, 172);
            this.tlpWidget.Name = "tlpWidget";
            this.tlpWidget.RowCount = 3;
            this.tlpWidget.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.16129F));
            this.tlpWidget.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.83871F));
            this.tlpWidget.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpWidget.Size = new System.Drawing.Size(374, 173);
            this.tlpWidget.TabIndex = 0;
            this.tlpWidget.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tlpWidget_CellPaint);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.label2.Size = new System.Drawing.Size(242, 41);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ticket Sales";
            // 
            // lblIncome
            // 
            this.lblIncome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIncome.AutoSize = true;
            this.lblIncome.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncome.Location = new System.Drawing.Point(4, 4);
            this.lblIncome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.lblIncome.Size = new System.Drawing.Size(242, 44);
            this.lblIncome.TabIndex = 1;
            this.lblIncome.Text = "Income";
            // 
            // lblIncomeAmount
            // 
            this.lblIncomeAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIncomeAmount.AutoSize = true;
            this.tlpWidget.SetColumnSpan(this.lblIncomeAmount, 3);
            this.lblIncomeAmount.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncomeAmount.Location = new System.Drawing.Point(4, 55);
            this.lblIncomeAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIncomeAmount.Name = "lblIncomeAmount";
            this.lblIncomeAmount.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.lblIncomeAmount.Size = new System.Drawing.Size(369, 60);
            this.lblIncomeAmount.TabIndex = 3;
            this.lblIncomeAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIncomePercent
            // 
            this.lblIncomePercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIncomePercent.AutoSize = true;
            this.lblIncomePercent.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncomePercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(195)))), ((int)(((byte)(82)))));
            this.lblIncomePercent.Location = new System.Drawing.Point(269, 124);
            this.lblIncomePercent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIncomePercent.Name = "lblIncomePercent";
            this.lblIncomePercent.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.lblIncomePercent.Size = new System.Drawing.Size(104, 41);
            this.lblIncomePercent.TabIndex = 4;
            this.lblIncomePercent.Text = "98%";
            // 
            // lblAnnual
            // 
            this.lblAnnual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnnual.AutoSize = true;
            this.lblAnnual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(195)))), ((int)(((byte)(82)))));
            this.lblAnnual.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnnual.ForeColor = System.Drawing.Color.White;
            this.lblAnnual.Location = new System.Drawing.Point(278, 16);
            this.lblAnnual.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.lblAnnual.Name = "lblAnnual";
            this.lblAnnual.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lblAnnual.Size = new System.Drawing.Size(86, 21);
            this.lblAnnual.TabIndex = 2;
            this.lblAnnual.Text = "Annual";
            this.lblAnnual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTickets, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTicketsCounter, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPercent, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(413, 12);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(0, 172);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.16129F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.83871F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(294, 173);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.label3.Size = new System.Drawing.Size(159, 41);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tickets Count";
            // 
            // lblTickets
            // 
            this.lblTickets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTickets.AutoSize = true;
            this.lblTickets.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTickets.Location = new System.Drawing.Point(4, 4);
            this.lblTickets.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTickets.Name = "lblTickets";
            this.lblTickets.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.lblTickets.Size = new System.Drawing.Size(159, 44);
            this.lblTickets.TabIndex = 1;
            this.lblTickets.Text = "Tickets";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(195)))), ((int)(((byte)(82)))));
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(195, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.label5.Size = new System.Drawing.Size(86, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Annual";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTicketsCounter
            // 
            this.lblTicketsCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTicketsCounter.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblTicketsCounter, 3);
            this.lblTicketsCounter.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketsCounter.Location = new System.Drawing.Point(4, 55);
            this.lblTicketsCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTicketsCounter.Name = "lblTicketsCounter";
            this.lblTicketsCounter.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.lblTicketsCounter.Size = new System.Drawing.Size(286, 60);
            this.lblTicketsCounter.TabIndex = 3;
            this.lblTicketsCounter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPercent
            // 
            this.lblPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPercent.AutoSize = true;
            this.lblPercent.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(195)))), ((int)(((byte)(82)))));
            this.lblPercent.Location = new System.Drawing.Point(186, 124);
            this.lblPercent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.lblPercent.Size = new System.Drawing.Size(104, 41);
            this.lblPercent.TabIndex = 4;
            this.lblPercent.Text = "20%";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel2.Controls.Add(this.lblNewVisits, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblCustomers, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblToday, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblCustomersCounter, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label12, 2, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(733, 12);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.tableLayoutPanel2.MinimumSize = new System.Drawing.Size(0, 172);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.16129F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.83871F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(294, 173);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // lblNewVisits
            // 
            this.lblNewVisits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNewVisits.AutoSize = true;
            this.lblNewVisits.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewVisits.Location = new System.Drawing.Point(4, 124);
            this.lblNewVisits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewVisits.Name = "lblNewVisits";
            this.lblNewVisits.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.lblNewVisits.Size = new System.Drawing.Size(159, 41);
            this.lblNewVisits.TabIndex = 5;
            this.lblNewVisits.Text = "New visits";
            // 
            // lblCustomers
            // 
            this.lblCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomers.Location = new System.Drawing.Point(4, 4);
            this.lblCustomers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.lblCustomers.Size = new System.Drawing.Size(159, 44);
            this.lblCustomers.TabIndex = 1;
            this.lblCustomers.Text = "Customers";
            // 
            // lblToday
            // 
            this.lblToday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblToday.AutoSize = true;
            this.lblToday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(195)))), ((int)(((byte)(82)))));
            this.lblToday.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToday.ForeColor = System.Drawing.Color.White;
            this.lblToday.Location = new System.Drawing.Point(195, 16);
            this.lblToday.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.lblToday.Name = "lblToday";
            this.lblToday.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lblToday.Size = new System.Drawing.Size(86, 21);
            this.lblToday.TabIndex = 2;
            this.lblToday.Text = "Overall";
            this.lblToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCustomersCounter
            // 
            this.lblCustomersCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustomersCounter.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.lblCustomersCounter, 3);
            this.lblCustomersCounter.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomersCounter.Location = new System.Drawing.Point(4, 55);
            this.lblCustomersCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomersCounter.Name = "lblCustomersCounter";
            this.lblCustomersCounter.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.lblCustomersCounter.Size = new System.Drawing.Size(286, 60);
            this.lblCustomersCounter.TabIndex = 3;
            this.lblCustomersCounter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(195)))), ((int)(((byte)(82)))));
            this.label12.Location = new System.Drawing.Point(186, 124);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.label12.Size = new System.Drawing.Size(104, 41);
            this.label12.TabIndex = 4;
            this.label12.Text = "44%";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.lblCapacityCount, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblCapacities, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label15, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblCapacitiesFreeOccupied, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblOccupiedCount, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.label1, 2, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1053, 12);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.tableLayoutPanel3.MinimumSize = new System.Drawing.Size(0, 172);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.16129F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.83871F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(312, 173);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // lblCapacityCount
            // 
            this.lblCapacityCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCapacityCount.AutoSize = true;
            this.lblCapacityCount.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacityCount.Location = new System.Drawing.Point(4, 123);
            this.lblCapacityCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCapacityCount.Name = "lblCapacityCount";
            this.lblCapacityCount.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.lblCapacityCount.Size = new System.Drawing.Size(140, 49);
            this.lblCapacityCount.TabIndex = 6;
            this.lblCapacityCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCapacities
            // 
            this.lblCapacities.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCapacities.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacities.Location = new System.Drawing.Point(4, 5);
            this.lblCapacities.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCapacities.Name = "lblCapacities";
            this.lblCapacities.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.lblCapacities.Size = new System.Drawing.Size(140, 44);
            this.lblCapacities.TabIndex = 1;
            this.lblCapacities.Text = "Screenings";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(195)))), ((int)(((byte)(82)))));
            this.label15.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(176, 17);
            this.label15.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.label15.Size = new System.Drawing.Size(123, 21);
            this.label15.TabIndex = 2;
            this.label15.Text = "Now";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCapacitiesFreeOccupied
            // 
            this.lblCapacitiesFreeOccupied.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCapacitiesFreeOccupied.AutoSize = true;
            this.lblCapacitiesFreeOccupied.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacitiesFreeOccupied.Location = new System.Drawing.Point(4, 67);
            this.lblCapacitiesFreeOccupied.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCapacitiesFreeOccupied.Name = "lblCapacitiesFreeOccupied";
            this.lblCapacitiesFreeOccupied.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.lblCapacitiesFreeOccupied.Size = new System.Drawing.Size(140, 42);
            this.lblCapacitiesFreeOccupied.TabIndex = 3;
            this.lblCapacitiesFreeOccupied.Text = "Capacity";
            this.lblCapacitiesFreeOccupied.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOccupiedCount
            // 
            this.lblOccupiedCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOccupiedCount.AutoSize = true;
            this.lblOccupiedCount.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccupiedCount.ForeColor = System.Drawing.Color.Red;
            this.lblOccupiedCount.Location = new System.Drawing.Point(167, 123);
            this.lblOccupiedCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOccupiedCount.Name = "lblOccupiedCount";
            this.lblOccupiedCount.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.lblOccupiedCount.Size = new System.Drawing.Size(141, 49);
            this.lblOccupiedCount.TabIndex = 7;
            this.lblOccupiedCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // crtSalesPerMonth
            // 
            this.crtSalesPerMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.crtSalesPerMonth.ChartAreas.Add(chartArea1);
            this.tableLayoutPanel4.SetColumnSpan(this.crtSalesPerMonth, 2);
            legend1.Name = "Legend1";
            this.crtSalesPerMonth.Legends.Add(legend1);
            this.crtSalesPerMonth.Location = new System.Drawing.Point(4, 70);
            this.crtSalesPerMonth.Margin = new System.Windows.Forms.Padding(4);
            this.crtSalesPerMonth.Name = "crtSalesPerMonth";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Sales per month";
            this.crtSalesPerMonth.Series.Add(series1);
            this.crtSalesPerMonth.Size = new System.Drawing.Size(1129, 239);
            this.crtSalesPerMonth.TabIndex = 4;
            this.crtSalesPerMonth.Text = "chart1";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel5.SetColumnSpan(this.tableLayoutPanel4, 4);
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 879F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 215F));
            this.tableLayoutPanel4.Controls.Add(this.lblMainChartName, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.crtSalesPerMonth, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(13, 209);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.97248F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.02752F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1352, 325);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // lblMainChartName
            // 
            this.lblMainChartName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.SetColumnSpan(this.lblMainChartName, 2);
            this.lblMainChartName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainChartName.Location = new System.Drawing.Point(4, 5);
            this.lblMainChartName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMainChartName.Name = "lblMainChartName";
            this.lblMainChartName.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.lblMainChartName.Size = new System.Drawing.Size(1129, 44);
            this.lblMainChartName.TabIndex = 1;
            this.lblMainChartName.Text = "Ticketing data";
            this.lblMainChartName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 320F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 320F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 338F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel3, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.tlpWidget, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.dgvScreenings, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.pgnScreenings, 3, 3);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 197F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 297F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1348, 898);
            this.tableLayoutPanel5.TabIndex = 6;
            // 
            // dgvScreenings
            // 
            this.dgvScreenings.AllowUserToAddRows = false;
            this.dgvScreenings.AllowUserToDeleteRows = false;
            this.dgvScreenings.AllowUserToResizeColumns = false;
            this.dgvScreenings.AllowUserToResizeRows = false;
            this.dgvScreenings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvScreenings.BackgroundColor = System.Drawing.Color.White;
            this.dgvScreenings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvScreenings.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvScreenings.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvScreenings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvScreenings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScreenings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.Hall,
            this.DateAndTime,
            this.Price,
            this.Status});
            this.tableLayoutPanel5.SetColumnSpan(this.dgvScreenings, 4);
            this.dgvScreenings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvScreenings.Location = new System.Drawing.Point(13, 558);
            this.dgvScreenings.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.dgvScreenings.Name = "dgvScreenings";
            this.dgvScreenings.ReadOnly = true;
            this.dgvScreenings.RowHeadersVisible = false;
            this.dgvScreenings.RowHeadersWidth = 51;
            this.dgvScreenings.Size = new System.Drawing.Size(1352, 273);
            this.dgvScreenings.TabIndex = 6;
            this.dgvScreenings.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvScreenings_CellFormatting);
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
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Hall
            // 
            this.Hall.DataPropertyName = "Hall.Name";
            this.Hall.HeaderText = "Hall";
            this.Hall.MinimumWidth = 6;
            this.Hall.Name = "Hall";
            this.Hall.ReadOnly = true;
            // 
            // DateAndTime
            // 
            this.DateAndTime.DataPropertyName = "DateAndTime";
            this.DateAndTime.HeaderText = "Date And Time";
            this.DateAndTime.MinimumWidth = 6;
            this.DateAndTime.Name = "DateAndTime";
            this.DateAndTime.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Pricing.Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "TimingStatus";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // pgnScreenings
            // 
            this.pgnScreenings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pgnScreenings.AutoSize = true;
            this.pgnScreenings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pgnScreenings.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pgnScreenings.Location = new System.Drawing.Point(1155, 848);
            this.pgnScreenings.Margin = new System.Windows.Forms.Padding(5, 5, 13, 5);
            this.pgnScreenings.Name = "pgnScreenings";
            this.pgnScreenings.PageIndex = 0;
            this.pgnScreenings.Size = new System.Drawing.Size(210, 35);
            this.pgnScreenings.TabIndex = 11;
            this.pgnScreenings.TotalPages = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.label1.Size = new System.Drawing.Size(141, 42);
            this.label1.TabIndex = 8;
            this.label1.Text = "Occupied";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 898);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDashboard";
            this.Text = "eCinema";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.tlpWidget.ResumeLayout(false);
            this.tlpWidget.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crtSalesPerMonth)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScreenings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpWidget;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.Label lblAnnual;
        private System.Windows.Forms.Label lblIncomeAmount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTickets;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTicketsCounter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblNewVisits;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.Label lblToday;
        private System.Windows.Forms.Label lblCustomersCounter;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblCapacities;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblCapacitiesFreeOccupied;
        private System.Windows.Forms.DataVisualization.Charting.Chart crtSalesPerMonth;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblMainChartName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.DataGridView dgvScreenings;
        private UserControls.Pagination pgnScreenings;
        private System.Windows.Forms.Label lblCapacityCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIncomePercent;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label lblOccupiedCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hall;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateAndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Label label1;
    }
}