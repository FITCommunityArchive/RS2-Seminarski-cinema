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
            this.tlpWidget = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIncome = new System.Windows.Forms.Label();
            this.lblMonthly = new System.Windows.Forms.Label();
            this.lblIncomeCounter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTickets = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTicketsCounter = new System.Windows.Forms.Label();
            this.lblPercent = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNewVisits = new System.Windows.Forms.Label();
            this.lblVisits = new System.Windows.Forms.Label();
            this.lblToday = new System.Windows.Forms.Label();
            this.lblVisitsCounter = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFirstMonth = new System.Windows.Forms.Label();
            this.lblUserActivity = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblUserCounter = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpWidget.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpWidget
            // 
            this.tlpWidget.BackColor = System.Drawing.Color.White;
            this.tlpWidget.ColumnCount = 3;
            this.tlpWidget.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpWidget.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpWidget.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tlpWidget.Controls.Add(this.label2, 0, 2);
            this.tlpWidget.Controls.Add(this.lblIncome, 0, 0);
            this.tlpWidget.Controls.Add(this.lblMonthly, 2, 0);
            this.tlpWidget.Controls.Add(this.lblIncomeCounter, 0, 1);
            this.tlpWidget.Controls.Add(this.label1, 2, 2);
            this.tlpWidget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpWidget.Location = new System.Drawing.Point(10, 10);
            this.tlpWidget.Margin = new System.Windows.Forms.Padding(10);
            this.tlpWidget.Name = "tlpWidget";
            this.tlpWidget.RowCount = 3;
            this.tlpWidget.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.16129F));
            this.tlpWidget.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.83871F));
            this.tlpWidget.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpWidget.Size = new System.Drawing.Size(232, 140);
            this.tlpWidget.TabIndex = 0;
            this.tlpWidget.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tlpWidget_CellPaint);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 100);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10);
            this.label2.Size = new System.Drawing.Size(122, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total income";
            // 
            // lblIncome
            // 
            this.lblIncome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIncome.AutoSize = true;
            this.lblIncome.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncome.Location = new System.Drawing.Point(3, 3);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Padding = new System.Windows.Forms.Padding(10);
            this.lblIncome.Size = new System.Drawing.Size(122, 36);
            this.lblIncome.TabIndex = 1;
            this.lblIncome.Text = "Income";
            // 
            // lblMonthly
            // 
            this.lblMonthly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMonthly.AutoSize = true;
            this.lblMonthly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(195)))), ((int)(((byte)(82)))));
            this.lblMonthly.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthly.ForeColor = System.Drawing.Color.White;
            this.lblMonthly.Location = new System.Drawing.Point(158, 12);
            this.lblMonthly.Margin = new System.Windows.Forms.Padding(10);
            this.lblMonthly.Name = "lblMonthly";
            this.lblMonthly.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblMonthly.Size = new System.Drawing.Size(64, 17);
            this.lblMonthly.TabIndex = 2;
            this.lblMonthly.Text = "Monthly";
            this.lblMonthly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIncomeCounter
            // 
            this.lblIncomeCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIncomeCounter.AutoSize = true;
            this.tlpWidget.SetColumnSpan(this.lblIncomeCounter, 3);
            this.lblIncomeCounter.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncomeCounter.Location = new System.Drawing.Point(3, 43);
            this.lblIncomeCounter.Name = "lblIncomeCounter";
            this.lblIncomeCounter.Padding = new System.Windows.Forms.Padding(10);
            this.lblIncomeCounter.Size = new System.Drawing.Size(226, 49);
            this.lblIncomeCounter.TabIndex = 3;
            this.lblIncomeCounter.Text = "40 866,200";
            this.lblIncomeCounter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(195)))), ((int)(((byte)(82)))));
            this.label1.Location = new System.Drawing.Point(151, 100);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(78, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "98%";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTickets, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTicketsCounter, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPercent, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(262, 10);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.16129F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.83871F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(214, 140);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 100);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10);
            this.label3.Size = new System.Drawing.Size(111, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total income";
            // 
            // lblTickets
            // 
            this.lblTickets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTickets.AutoSize = true;
            this.lblTickets.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTickets.Location = new System.Drawing.Point(3, 3);
            this.lblTickets.Name = "lblTickets";
            this.lblTickets.Padding = new System.Windows.Forms.Padding(10);
            this.lblTickets.Size = new System.Drawing.Size(111, 36);
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
            this.label5.Location = new System.Drawing.Point(140, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(10);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label5.Size = new System.Drawing.Size(64, 17);
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
            this.lblTicketsCounter.Location = new System.Drawing.Point(3, 43);
            this.lblTicketsCounter.Name = "lblTicketsCounter";
            this.lblTicketsCounter.Padding = new System.Windows.Forms.Padding(10);
            this.lblTicketsCounter.Size = new System.Drawing.Size(208, 49);
            this.lblTicketsCounter.TabIndex = 3;
            this.lblTicketsCounter.Text = "275,800";
            this.lblTicketsCounter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPercent
            // 
            this.lblPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPercent.AutoSize = true;
            this.lblPercent.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(195)))), ((int)(((byte)(82)))));
            this.lblPercent.Location = new System.Drawing.Point(133, 100);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Padding = new System.Windows.Forms.Padding(10);
            this.lblPercent.Size = new System.Drawing.Size(78, 33);
            this.lblPercent.TabIndex = 4;
            this.lblPercent.Text = "20%";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel2.Controls.Add(this.lblNewVisits, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblVisits, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblToday, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblVisitsCounter, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label12, 2, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(496, 10);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.16129F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.83871F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(213, 140);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // lblNewVisits
            // 
            this.lblNewVisits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNewVisits.AutoSize = true;
            this.lblNewVisits.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewVisits.Location = new System.Drawing.Point(3, 100);
            this.lblNewVisits.Name = "lblNewVisits";
            this.lblNewVisits.Padding = new System.Windows.Forms.Padding(10);
            this.lblNewVisits.Size = new System.Drawing.Size(103, 33);
            this.lblNewVisits.TabIndex = 5;
            this.lblNewVisits.Text = "New visits";
            // 
            // lblVisits
            // 
            this.lblVisits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVisits.AutoSize = true;
            this.lblVisits.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisits.Location = new System.Drawing.Point(3, 3);
            this.lblVisits.Name = "lblVisits";
            this.lblVisits.Padding = new System.Windows.Forms.Padding(10);
            this.lblVisits.Size = new System.Drawing.Size(103, 36);
            this.lblVisits.TabIndex = 1;
            this.lblVisits.Text = "Visits";
            // 
            // lblToday
            // 
            this.lblToday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblToday.AutoSize = true;
            this.lblToday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(195)))), ((int)(((byte)(82)))));
            this.lblToday.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToday.ForeColor = System.Drawing.Color.White;
            this.lblToday.Location = new System.Drawing.Point(139, 12);
            this.lblToday.Margin = new System.Windows.Forms.Padding(10);
            this.lblToday.Name = "lblToday";
            this.lblToday.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblToday.Size = new System.Drawing.Size(64, 17);
            this.lblToday.TabIndex = 2;
            this.lblToday.Text = "Today";
            this.lblToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVisitsCounter
            // 
            this.lblVisitsCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVisitsCounter.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.lblVisitsCounter, 3);
            this.lblVisitsCounter.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisitsCounter.Location = new System.Drawing.Point(3, 43);
            this.lblVisitsCounter.Name = "lblVisitsCounter";
            this.lblVisitsCounter.Padding = new System.Windows.Forms.Padding(10);
            this.lblVisitsCounter.Size = new System.Drawing.Size(207, 49);
            this.lblVisitsCounter.TabIndex = 3;
            this.lblVisitsCounter.Text = "106,120";
            this.lblVisitsCounter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(195)))), ((int)(((byte)(82)))));
            this.label12.Location = new System.Drawing.Point(132, 100);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(10);
            this.label12.Size = new System.Drawing.Size(78, 33);
            this.label12.TabIndex = 4;
            this.label12.Text = "44%";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel3.Controls.Add(this.lblFirstMonth, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblUserActivity, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label15, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblUserCounter, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label17, 2, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(729, 10);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.16129F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.83871F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(218, 140);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // lblFirstMonth
            // 
            this.lblFirstMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFirstMonth.AutoSize = true;
            this.lblFirstMonth.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstMonth.Location = new System.Drawing.Point(3, 100);
            this.lblFirstMonth.Name = "lblFirstMonth";
            this.lblFirstMonth.Padding = new System.Windows.Forms.Padding(10);
            this.lblFirstMonth.Size = new System.Drawing.Size(108, 33);
            this.lblFirstMonth.TabIndex = 5;
            this.lblFirstMonth.Text = "First month";
            // 
            // lblUserActivity
            // 
            this.lblUserActivity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserActivity.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserActivity.Location = new System.Drawing.Point(3, 3);
            this.lblUserActivity.Name = "lblUserActivity";
            this.lblUserActivity.Padding = new System.Windows.Forms.Padding(10);
            this.lblUserActivity.Size = new System.Drawing.Size(108, 36);
            this.lblUserActivity.TabIndex = 1;
            this.lblUserActivity.Text = "User activity";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(195)))), ((int)(((byte)(82)))));
            this.label15.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(144, 12);
            this.label15.Margin = new System.Windows.Forms.Padding(10);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label15.Size = new System.Drawing.Size(64, 17);
            this.label15.TabIndex = 2;
            this.label15.Text = "Monthly";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserCounter
            // 
            this.lblUserCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserCounter.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.lblUserCounter, 3);
            this.lblUserCounter.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserCounter.Location = new System.Drawing.Point(3, 43);
            this.lblUserCounter.Name = "lblUserCounter";
            this.lblUserCounter.Padding = new System.Windows.Forms.Padding(10);
            this.lblUserCounter.Size = new System.Drawing.Size(212, 49);
            this.lblUserCounter.TabIndex = 3;
            this.lblUserCounter.Text = "80,600";
            this.lblUserCounter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(195)))), ((int)(((byte)(82)))));
            this.label17.Location = new System.Drawing.Point(137, 100);
            this.label17.Name = "label17";
            this.label17.Padding = new System.Windows.Forms.Padding(10);
            this.label17.Size = new System.Drawing.Size(78, 33);
            this.label17.TabIndex = 4;
            this.label17.Text = "38%";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.tableLayoutPanel4.SetColumnSpan(this.chart1, 2);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 46);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(770, 205);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel5.SetColumnSpan(this.tableLayoutPanel4, 4);
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 659F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label7, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.chart1, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(10, 170);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.97248F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.02752F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(937, 254);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(10);
            this.label6.Size = new System.Drawing.Size(111, 36);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ticketing data";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(786, 13);
            this.label7.Margin = new System.Windows.Forms.Padding(10);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label7.Size = new System.Drawing.Size(141, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Monthly data";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 234F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 233F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 238F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel3, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.tlpWidget, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.81917F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.18083F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(957, 557);
            this.tableLayoutPanel5.TabIndex = 6;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 557);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Name = "FormDashboard";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.tlpWidget.ResumeLayout(false);
            this.tlpWidget.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpWidget;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.Label lblMonthly;
        private System.Windows.Forms.Label lblIncomeCounter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTickets;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTicketsCounter;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblNewVisits;
        private System.Windows.Forms.Label lblVisits;
        private System.Windows.Forms.Label lblToday;
        private System.Windows.Forms.Label lblVisitsCounter;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblFirstMonth;
        private System.Windows.Forms.Label lblUserActivity;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblUserCounter;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    }
}