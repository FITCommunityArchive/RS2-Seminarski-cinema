using FontAwesome.Sharp;

namespace Cinema.WinUI
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnEvents = new FontAwesome.Sharp.IconButton();
            this.btnNews = new FontAwesome.Sharp.IconButton();
            this.btnPricing = new FontAwesome.Sharp.IconButton();
            this.btnReports = new FontAwesome.Sharp.IconButton();
            this.btnReservations = new FontAwesome.Sharp.IconButton();
            this.logoLargeWhite1 = new Cinema.WinUI.UserControls.Logos.LogoLargeWhite();
            this.btnUsers = new FontAwesome.Sharp.IconButton();
            this.btnScreenings = new FontAwesome.Sharp.IconButton();
            this.btnMovies = new FontAwesome.Sharp.IconButton();
            this.panelDashboardSubmenu = new System.Windows.Forms.Panel();
            this.btnDashboardSubmenu2 = new System.Windows.Forms.Button();
            this.btnDashboardSubmenu1 = new System.Windows.Forms.Button();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblFullName = new System.Windows.Forms.Label();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.panelBottomBar = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.tlpTopBar = new System.Windows.Forms.TableLayoutPanel();
            this.lblWelcomeMessage = new System.Windows.Forms.Label();
            this.panelSideMenu.SuspendLayout();
            this.panelDashboardSubmenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelBottomBar.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            this.tlpTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(209)))));
            this.panelSideMenu.Controls.Add(this.btnEvents);
            this.panelSideMenu.Controls.Add(this.btnNews);
            this.panelSideMenu.Controls.Add(this.btnPricing);
            this.panelSideMenu.Controls.Add(this.btnReports);
            this.panelSideMenu.Controls.Add(this.btnReservations);
            this.panelSideMenu.Controls.Add(this.logoLargeWhite1);
            this.panelSideMenu.Controls.Add(this.btnUsers);
            this.panelSideMenu.Controls.Add(this.btnScreenings);
            this.panelSideMenu.Controls.Add(this.btnMovies);
            this.panelSideMenu.Controls.Add(this.panelDashboardSubmenu);
            this.panelSideMenu.Controls.Add(this.btnDashboard);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 754);
            this.panelSideMenu.TabIndex = 0;
            // 
            // btnEvents
            // 
            this.btnEvents.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEvents.FlatAppearance.BorderSize = 0;
            this.btnEvents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(97)))));
            this.btnEvents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(97)))));
            this.btnEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvents.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnEvents.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvents.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEvents.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.btnEvents.IconColor = System.Drawing.Color.White;
            this.btnEvents.IconSize = 16;
            this.btnEvents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvents.Location = new System.Drawing.Point(0, 586);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnEvents.Rotation = 0D;
            this.btnEvents.Size = new System.Drawing.Size(250, 45);
            this.btnEvents.TabIndex = 10;
            this.btnEvents.Text = " Events";
            this.btnEvents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEvents.UseVisualStyleBackColor = true;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
            // 
            // btnNews
            // 
            this.btnNews.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNews.FlatAppearance.BorderSize = 0;
            this.btnNews.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(97)))));
            this.btnNews.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(97)))));
            this.btnNews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNews.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnNews.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNews.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNews.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            this.btnNews.IconColor = System.Drawing.Color.White;
            this.btnNews.IconSize = 16;
            this.btnNews.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNews.Location = new System.Drawing.Point(0, 541);
            this.btnNews.Name = "btnNews";
            this.btnNews.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnNews.Rotation = 0D;
            this.btnNews.Size = new System.Drawing.Size(250, 45);
            this.btnNews.TabIndex = 9;
            this.btnNews.Text = " News";
            this.btnNews.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNews.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNews.UseVisualStyleBackColor = true;
            this.btnNews.Click += new System.EventHandler(this.btnNews_Click);
            // 
            // btnPricing
            // 
            this.btnPricing.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPricing.FlatAppearance.BorderSize = 0;
            this.btnPricing.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(97)))));
            this.btnPricing.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(97)))));
            this.btnPricing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPricing.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnPricing.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPricing.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPricing.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.btnPricing.IconColor = System.Drawing.Color.White;
            this.btnPricing.IconSize = 16;
            this.btnPricing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPricing.Location = new System.Drawing.Point(0, 496);
            this.btnPricing.Name = "btnPricing";
            this.btnPricing.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnPricing.Rotation = 0D;
            this.btnPricing.Size = new System.Drawing.Size(250, 45);
            this.btnPricing.TabIndex = 8;
            this.btnPricing.Text = " Pricing";
            this.btnPricing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPricing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPricing.UseVisualStyleBackColor = true;
            this.btnPricing.Click += new System.EventHandler(this.btnPricing_Click);
            // 
            // btnReports
            // 
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(97)))));
            this.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(97)))));
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnReports.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReports.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnReports.IconColor = System.Drawing.Color.White;
            this.btnReports.IconSize = 16;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(0, 451);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnReports.Rotation = 0D;
            this.btnReports.Size = new System.Drawing.Size(250, 45);
            this.btnReports.TabIndex = 7;
            this.btnReports.Text = " Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnReservations
            // 
            this.btnReservations.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReservations.FlatAppearance.BorderSize = 0;
            this.btnReservations.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(97)))));
            this.btnReservations.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(97)))));
            this.btnReservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservations.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnReservations.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservations.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReservations.IconChar = FontAwesome.Sharp.IconChar.TicketAlt;
            this.btnReservations.IconColor = System.Drawing.Color.White;
            this.btnReservations.IconSize = 16;
            this.btnReservations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservations.Location = new System.Drawing.Point(0, 406);
            this.btnReservations.Name = "btnReservations";
            this.btnReservations.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnReservations.Rotation = 0D;
            this.btnReservations.Size = new System.Drawing.Size(250, 45);
            this.btnReservations.TabIndex = 6;
            this.btnReservations.Text = " Reservations";
            this.btnReservations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReservations.UseVisualStyleBackColor = true;
            this.btnReservations.Click += new System.EventHandler(this.btnReservations_Click);
            // 
            // logoLargeWhite1
            // 
            this.logoLargeWhite1.Location = new System.Drawing.Point(12, 639);
            this.logoLargeWhite1.Margin = new System.Windows.Forms.Padding(5);
            this.logoLargeWhite1.Name = "logoLargeWhite1";
            this.logoLargeWhite1.Size = new System.Drawing.Size(220, 85);
            this.logoLargeWhite1.TabIndex = 5;
            // 
            // btnUsers
            // 
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(97)))));
            this.btnUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(97)))));
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnUsers.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUsers.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnUsers.IconColor = System.Drawing.Color.White;
            this.btnUsers.IconSize = 16;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(0, 361);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnUsers.Rotation = 0D;
            this.btnUsers.Size = new System.Drawing.Size(250, 45);
            this.btnUsers.TabIndex = 5;
            this.btnUsers.Text = " Users";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnScreenings
            // 
            this.btnScreenings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnScreenings.FlatAppearance.BorderSize = 0;
            this.btnScreenings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(97)))));
            this.btnScreenings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(97)))));
            this.btnScreenings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScreenings.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnScreenings.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScreenings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnScreenings.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.btnScreenings.IconColor = System.Drawing.Color.White;
            this.btnScreenings.IconSize = 16;
            this.btnScreenings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScreenings.Location = new System.Drawing.Point(0, 316);
            this.btnScreenings.Name = "btnScreenings";
            this.btnScreenings.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnScreenings.Rotation = 0D;
            this.btnScreenings.Size = new System.Drawing.Size(250, 45);
            this.btnScreenings.TabIndex = 4;
            this.btnScreenings.Text = " Screenings";
            this.btnScreenings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScreenings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnScreenings.UseVisualStyleBackColor = true;
            this.btnScreenings.Click += new System.EventHandler(this.btnScreenings_Click);
            // 
            // btnMovies
            // 
            this.btnMovies.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMovies.FlatAppearance.BorderSize = 0;
            this.btnMovies.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(97)))));
            this.btnMovies.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(97)))));
            this.btnMovies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovies.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMovies.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovies.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMovies.IconChar = FontAwesome.Sharp.IconChar.Film;
            this.btnMovies.IconColor = System.Drawing.Color.White;
            this.btnMovies.IconSize = 16;
            this.btnMovies.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMovies.Location = new System.Drawing.Point(0, 271);
            this.btnMovies.Name = "btnMovies";
            this.btnMovies.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnMovies.Rotation = 0D;
            this.btnMovies.Size = new System.Drawing.Size(250, 45);
            this.btnMovies.TabIndex = 3;
            this.btnMovies.Text = " Movies";
            this.btnMovies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMovies.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMovies.UseVisualStyleBackColor = true;
            this.btnMovies.Click += new System.EventHandler(this.btnMovies_Click);
            // 
            // panelDashboardSubmenu
            // 
            this.panelDashboardSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(121)))));
            this.panelDashboardSubmenu.Controls.Add(this.btnDashboardSubmenu2);
            this.panelDashboardSubmenu.Controls.Add(this.btnDashboardSubmenu1);
            this.panelDashboardSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDashboardSubmenu.Location = new System.Drawing.Point(0, 190);
            this.panelDashboardSubmenu.Name = "panelDashboardSubmenu";
            this.panelDashboardSubmenu.Size = new System.Drawing.Size(250, 81);
            this.panelDashboardSubmenu.TabIndex = 2;
            // 
            // btnDashboardSubmenu2
            // 
            this.btnDashboardSubmenu2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboardSubmenu2.FlatAppearance.BorderSize = 0;
            this.btnDashboardSubmenu2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(97)))));
            this.btnDashboardSubmenu2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(97)))));
            this.btnDashboardSubmenu2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboardSubmenu2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboardSubmenu2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDashboardSubmenu2.Location = new System.Drawing.Point(0, 40);
            this.btnDashboardSubmenu2.Name = "btnDashboardSubmenu2";
            this.btnDashboardSubmenu2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDashboardSubmenu2.Size = new System.Drawing.Size(250, 40);
            this.btnDashboardSubmenu2.TabIndex = 1;
            this.btnDashboardSubmenu2.Text = "Submenu 2";
            this.btnDashboardSubmenu2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboardSubmenu2.UseVisualStyleBackColor = true;
            this.btnDashboardSubmenu2.Click += new System.EventHandler(this.btnDashaboardSubmenu2_Click);
            // 
            // btnDashboardSubmenu1
            // 
            this.btnDashboardSubmenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboardSubmenu1.FlatAppearance.BorderSize = 0;
            this.btnDashboardSubmenu1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(97)))));
            this.btnDashboardSubmenu1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(97)))));
            this.btnDashboardSubmenu1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboardSubmenu1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboardSubmenu1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDashboardSubmenu1.Location = new System.Drawing.Point(0, 0);
            this.btnDashboardSubmenu1.Name = "btnDashboardSubmenu1";
            this.btnDashboardSubmenu1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDashboardSubmenu1.Size = new System.Drawing.Size(250, 40);
            this.btnDashboardSubmenu1.TabIndex = 0;
            this.btnDashboardSubmenu1.Text = "Submenu 1";
            this.btnDashboardSubmenu1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboardSubmenu1.UseVisualStyleBackColor = true;
            this.btnDashboardSubmenu1.Click += new System.EventHandler(this.btnDashaboardSubmenu1_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(97)))));
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(97)))));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDashboard.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.ThLarge;
            this.btnDashboard.IconColor = System.Drawing.Color.White;
            this.btnDashboard.IconSize = 16;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 145);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnDashboard.Rotation = 0D;
            this.btnDashboard.Size = new System.Drawing.Size(250, 45);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = " Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.button1);
            this.panelLogo.Controls.Add(this.lblFullName);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 145);
            this.panelLogo.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Cinema.WinUI.Properties.Resources.avatar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 75);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.White;
            this.lblFullName.Location = new System.Drawing.Point(9, 107);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(38, 14);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "User";
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogout.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLogout.IconColor = System.Drawing.Color.Black;
            this.btnLogout.IconSize = 16;
            this.btnLogout.Location = new System.Drawing.Point(999, 5);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(11, 2, 11, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Rotation = 0D;
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // panelBottomBar
            // 
            this.panelBottomBar.BackColor = System.Drawing.Color.White;
            this.panelBottomBar.Controls.Add(this.label2);
            this.panelBottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomBar.Location = new System.Drawing.Point(250, 722);
            this.panelBottomBar.Name = "panelBottomBar";
            this.panelBottomBar.Size = new System.Drawing.Size(1085, 32);
            this.panelBottomBar.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Copyright eCinema © 2014-2020";
            // 
            // panelChildForm
            // 
            this.panelChildForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelChildForm.Controls.Add(this.tlpTopBar);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(2);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1085, 722);
            this.panelChildForm.TabIndex = 3;
            // 
            // tlpTopBar
            // 
            this.tlpTopBar.AutoSize = true;
            this.tlpTopBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpTopBar.BackColor = System.Drawing.Color.White;
            this.tlpTopBar.ColumnCount = 3;
            this.tlpTopBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTopBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTopBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTopBar.Controls.Add(this.btnLogout, 2, 0);
            this.tlpTopBar.Controls.Add(this.lblWelcomeMessage, 1, 0);
            this.tlpTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpTopBar.Location = new System.Drawing.Point(0, 0);
            this.tlpTopBar.Margin = new System.Windows.Forms.Padding(2);
            this.tlpTopBar.MaximumSize = new System.Drawing.Size(0, 33);
            this.tlpTopBar.MinimumSize = new System.Drawing.Size(610, 33);
            this.tlpTopBar.Name = "tlpTopBar";
            this.tlpTopBar.RowCount = 1;
            this.tlpTopBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTopBar.Size = new System.Drawing.Size(1085, 33);
            this.tlpTopBar.TabIndex = 3;
            // 
            // lblWelcomeMessage
            // 
            this.lblWelcomeMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWelcomeMessage.AutoSize = true;
            this.lblWelcomeMessage.Location = new System.Drawing.Point(931, 10);
            this.lblWelcomeMessage.Name = "lblWelcomeMessage";
            this.lblWelcomeMessage.Size = new System.Drawing.Size(54, 13);
            this.lblWelcomeMessage.TabIndex = 2;
            this.lblWelcomeMessage.Text = "Hello user";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1335, 754);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelBottomBar);
            this.Controls.Add(this.panelSideMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(950, 595);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eCinema - Dashboard";
            this.UserIsAllowed += new System.EventHandler(this.Form1_UserIsAllowed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelDashboardSubmenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelBottomBar.ResumeLayout(false);
            this.panelBottomBar.PerformLayout();
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            this.tlpTopBar.ResumeLayout(false);
            this.tlpTopBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelBottomBar;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblFullName;
        private UserControls.Logos.LogoLargeWhite logoLargeWhite1;
        private System.Windows.Forms.TableLayoutPanel tlpTopBar;
        private System.Windows.Forms.Panel panelDashboardSubmenu;
        private System.Windows.Forms.Button btnDashboardSubmenu2;
        private System.Windows.Forms.Button btnDashboardSubmenu1;
        private System.Windows.Forms.Label lblWelcomeMessage;
        private IconButton btnPricing;
        private IconButton btnDashboard;
        private IconButton btnLogout;
        private IconButton btnReservations;
        private IconButton btnReports;
        private IconButton btnNews;
        private IconButton btnEvents;
        private IconButton btnScreenings;
        private IconButton btnUsers;
        private IconButton btnMovies;
    }
}

