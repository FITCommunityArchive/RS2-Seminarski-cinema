namespace Cinema.WinUI.Movies
{
    partial class FormScreeningDetails
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormScreeningDetails));
            this.pnlFormTitle = new System.Windows.Forms.Panel();
            this.logoSmall1 = new Cinema.WinUI.UserControls.Logos.LogoSmall();
            this.lblBreadCrumbsCurrent = new System.Windows.Forms.Label();
            this.lblBreadcrumbs = new System.Windows.Forms.Label();
            this.lblViewTitle = new System.Windows.Forms.Label();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.cmbPrice = new System.Windows.Forms.ComboBox();
            this.cmbMovie = new System.Windows.Forms.ComboBox();
            this.cmbHall = new System.Windows.Forms.ComboBox();
            this.dtpScreeningDate = new System.Windows.Forms.DateTimePicker();
            this.btnDelete = new Cinema.WinUI.UserControls.Buttons.DeleteButton();
            this.btnBack = new Cinema.WinUI.UserControls.Buttons.BackButton();
            this.btnSaveChanges = new Cinema.WinUI.UserControls.Buttons.SaveChangesButton();
            this.picPoster = new System.Windows.Forms.PictureBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblMovieTitle = new System.Windows.Forms.Label();
            this.lblHall = new System.Windows.Forms.Label();
            this.lblSchedule = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblFormCorner = new System.Windows.Forms.Label();
            this.pnlCornerLabel = new System.Windows.Forms.Panel();
            this.pnlFormTitle.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnlCornerLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormTitle
            // 
            this.pnlFormTitle.BackColor = System.Drawing.Color.White;
            this.pnlFormTitle.Controls.Add(this.logoSmall1);
            this.pnlFormTitle.Controls.Add(this.lblBreadCrumbsCurrent);
            this.pnlFormTitle.Controls.Add(this.lblBreadcrumbs);
            this.pnlFormTitle.Controls.Add(this.lblViewTitle);
            this.pnlFormTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlFormTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlFormTitle.Name = "pnlFormTitle";
            this.pnlFormTitle.Size = new System.Drawing.Size(1537, 90);
            this.pnlFormTitle.TabIndex = 9;
            // 
            // logoSmall1
            // 
            this.logoSmall1.Location = new System.Drawing.Point(1340, 18);
            this.logoSmall1.Margin = new System.Windows.Forms.Padding(5);
            this.logoSmall1.Name = "logoSmall1";
            this.logoSmall1.Size = new System.Drawing.Size(165, 60);
            this.logoSmall1.TabIndex = 4;
            // 
            // lblBreadCrumbsCurrent
            // 
            this.lblBreadCrumbsCurrent.AutoSize = true;
            this.lblBreadCrumbsCurrent.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreadCrumbsCurrent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBreadCrumbsCurrent.Location = new System.Drawing.Point(181, 63);
            this.lblBreadCrumbsCurrent.Margin = new System.Windows.Forms.Padding(0);
            this.lblBreadCrumbsCurrent.Name = "lblBreadCrumbsCurrent";
            this.lblBreadCrumbsCurrent.Size = new System.Drawing.Size(140, 17);
            this.lblBreadCrumbsCurrent.TabIndex = 3;
            this.lblBreadCrumbsCurrent.Text = "Screening details";
            // 
            // lblBreadcrumbs
            // 
            this.lblBreadcrumbs.AutoSize = true;
            this.lblBreadcrumbs.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreadcrumbs.Location = new System.Drawing.Point(29, 63);
            this.lblBreadcrumbs.Margin = new System.Windows.Forms.Padding(0);
            this.lblBreadcrumbs.Name = "lblBreadcrumbs";
            this.lblBreadcrumbs.Size = new System.Drawing.Size(152, 17);
            this.lblBreadcrumbs.TabIndex = 2;
            this.lblBreadcrumbs.Text = "Home / Screenings /";
            // 
            // lblViewTitle
            // 
            this.lblViewTitle.AutoSize = true;
            this.lblViewTitle.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblViewTitle.Location = new System.Drawing.Point(25, 11);
            this.lblViewTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblViewTitle.Name = "lblViewTitle";
            this.lblViewTitle.Size = new System.Drawing.Size(247, 32);
            this.lblViewTitle.TabIndex = 1;
            this.lblViewTitle.Text = "Screening details";
            // 
            // pnlDetails
            // 
            this.pnlDetails.BackColor = System.Drawing.Color.White;
            this.pnlDetails.Controls.Add(this.cmbPrice);
            this.pnlDetails.Controls.Add(this.cmbMovie);
            this.pnlDetails.Controls.Add(this.cmbHall);
            this.pnlDetails.Controls.Add(this.dtpScreeningDate);
            this.pnlDetails.Controls.Add(this.btnDelete);
            this.pnlDetails.Controls.Add(this.btnBack);
            this.pnlDetails.Controls.Add(this.btnSaveChanges);
            this.pnlDetails.Controls.Add(this.picPoster);
            this.pnlDetails.Controls.Add(this.lblPrice);
            this.pnlDetails.Controls.Add(this.lblMovieTitle);
            this.pnlDetails.Controls.Add(this.lblHall);
            this.pnlDetails.Controls.Add(this.lblSchedule);
            this.pnlDetails.ForeColor = System.Drawing.Color.White;
            this.pnlDetails.Location = new System.Drawing.Point(32, 187);
            this.pnlDetails.Margin = new System.Windows.Forms.Padding(20);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Padding = new System.Windows.Forms.Padding(15);
            this.pnlDetails.Size = new System.Drawing.Size(1473, 672);
            this.pnlDetails.TabIndex = 11;
            // 
            // cmbPrice
            // 
            this.cmbPrice.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPrice.ForeColor = System.Drawing.Color.Gray;
            this.cmbPrice.FormattingEnabled = true;
            this.cmbPrice.Location = new System.Drawing.Point(728, 210);
            this.cmbPrice.Name = "cmbPrice";
            this.cmbPrice.Size = new System.Drawing.Size(703, 26);
            this.cmbPrice.TabIndex = 31;
            // 
            // cmbMovie
            // 
            this.cmbMovie.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMovie.ForeColor = System.Drawing.Color.Gray;
            this.cmbMovie.FormattingEnabled = true;
            this.cmbMovie.Location = new System.Drawing.Point(728, 153);
            this.cmbMovie.Name = "cmbMovie";
            this.cmbMovie.Size = new System.Drawing.Size(703, 26);
            this.cmbMovie.TabIndex = 30;
            // 
            // cmbHall
            // 
            this.cmbHall.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHall.ForeColor = System.Drawing.Color.Gray;
            this.cmbHall.FormattingEnabled = true;
            this.cmbHall.Location = new System.Drawing.Point(728, 97);
            this.cmbHall.Name = "cmbHall";
            this.cmbHall.Size = new System.Drawing.Size(703, 26);
            this.cmbHall.TabIndex = 29;
            // 
            // dtpScreeningDate
            // 
            this.dtpScreeningDate.CalendarForeColor = System.Drawing.Color.Gray;
            this.dtpScreeningDate.CalendarTitleForeColor = System.Drawing.Color.Gray;
            this.dtpScreeningDate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpScreeningDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpScreeningDate.Location = new System.Drawing.Point(728, 37);
            this.dtpScreeningDate.Name = "dtpScreeningDate";
            this.dtpScreeningDate.Size = new System.Drawing.Size(703, 26);
            this.dtpScreeningDate.TabIndex = 28;
            this.dtpScreeningDate.Validating += new System.ComponentModel.CancelEventHandler(this.dtpScreeningDate_Validating);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Location = new System.Drawing.Point(903, 292);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 40);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.ButtonClicked += new System.EventHandler(this.btnDelete_ButtonClicked);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.Location = new System.Drawing.Point(1077, 292);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 40);
            this.btnBack.TabIndex = 25;
            this.btnBack.ButtonClicked += new System.EventHandler(this.btnBack_ButtonClicked);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.AutoSize = true;
            this.btnSaveChanges.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveChanges.Location = new System.Drawing.Point(728, 292);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(120, 40);
            this.btnSaveChanges.TabIndex = 21;
            this.btnSaveChanges.ButtonClicked += new System.EventHandler(this.btnSaveChanges_ButtonClicked);
            // 
            // picPoster
            // 
            this.picPoster.Image = ((System.Drawing.Image)(resources.GetObject("picPoster.Image")));
            this.picPoster.Location = new System.Drawing.Point(41, 30);
            this.picPoster.Margin = new System.Windows.Forms.Padding(27, 15, 15, 15);
            this.picPoster.Name = "picPoster";
            this.picPoster.Size = new System.Drawing.Size(400, 601);
            this.picPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPoster.TabIndex = 20;
            this.picPoster.TabStop = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.White;
            this.lblPrice.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Gray;
            this.lblPrice.Location = new System.Drawing.Point(511, 213);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(15);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(43, 18);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price";
            // 
            // lblMovieTitle
            // 
            this.lblMovieTitle.AutoSize = true;
            this.lblMovieTitle.BackColor = System.Drawing.Color.White;
            this.lblMovieTitle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblMovieTitle.Location = new System.Drawing.Point(511, 156);
            this.lblMovieTitle.Margin = new System.Windows.Forms.Padding(15);
            this.lblMovieTitle.Name = "lblMovieTitle";
            this.lblMovieTitle.Size = new System.Drawing.Size(52, 18);
            this.lblMovieTitle.TabIndex = 5;
            this.lblMovieTitle.Text = "Movie";
            // 
            // lblHall
            // 
            this.lblHall.AutoSize = true;
            this.lblHall.BackColor = System.Drawing.Color.White;
            this.lblHall.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHall.ForeColor = System.Drawing.Color.Gray;
            this.lblHall.Location = new System.Drawing.Point(511, 100);
            this.lblHall.Margin = new System.Windows.Forms.Padding(15);
            this.lblHall.Name = "lblHall";
            this.lblHall.Size = new System.Drawing.Size(34, 18);
            this.lblHall.TabIndex = 4;
            this.lblHall.Text = "Hall";
            // 
            // lblSchedule
            // 
            this.lblSchedule.AutoSize = true;
            this.lblSchedule.BackColor = System.Drawing.Color.White;
            this.lblSchedule.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchedule.ForeColor = System.Drawing.Color.Gray;
            this.lblSchedule.Location = new System.Drawing.Point(511, 43);
            this.lblSchedule.Margin = new System.Windows.Forms.Padding(15);
            this.lblSchedule.Name = "lblSchedule";
            this.lblSchedule.Size = new System.Drawing.Size(121, 18);
            this.lblSchedule.TabIndex = 3;
            this.lblSchedule.Text = "Movie schedule";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblFormCorner
            // 
            this.lblFormCorner.AutoSize = true;
            this.lblFormCorner.BackColor = System.Drawing.Color.White;
            this.lblFormCorner.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormCorner.ForeColor = System.Drawing.Color.DimGray;
            this.lblFormCorner.Location = new System.Drawing.Point(15, 7);
            this.lblFormCorner.Margin = new System.Windows.Forms.Padding(0);
            this.lblFormCorner.Name = "lblFormCorner";
            this.lblFormCorner.Padding = new System.Windows.Forms.Padding(9, 9, 9, 12);
            this.lblFormCorner.Size = new System.Drawing.Size(167, 44);
            this.lblFormCorner.TabIndex = 0;
            this.lblFormCorner.Text = "Screening info";
            this.lblFormCorner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCornerLabel
            // 
            this.pnlCornerLabel.BackColor = System.Drawing.Color.White;
            this.pnlCornerLabel.Controls.Add(this.lblFormCorner);
            this.pnlCornerLabel.Location = new System.Drawing.Point(32, 139);
            this.pnlCornerLabel.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCornerLabel.Name = "pnlCornerLabel";
            this.pnlCornerLabel.Size = new System.Drawing.Size(188, 50);
            this.pnlCornerLabel.TabIndex = 12;
            // 
            // FormScreeningDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1537, 937);
            this.Controls.Add(this.pnlCornerLabel);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.pnlFormTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormScreeningDetails";
            this.Text = "frmMovieDetails";
            this.Load += new System.EventHandler(this.frmScreeningDetails_Load);
            this.pnlFormTitle.ResumeLayout(false);
            this.pnlFormTitle.PerformLayout();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnlCornerLabel.ResumeLayout(false);
            this.pnlCornerLabel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormTitle;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblMovieTitle;
        private System.Windows.Forms.Label lblHall;
        private System.Windows.Forms.Label lblSchedule;
        private System.Windows.Forms.PictureBox picPoster;
        private UserControls.Buttons.SaveChangesButton btnSaveChanges;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private UserControls.Buttons.BackButton btnBack;
        private UserControls.Buttons.DeleteButton btnDelete;
        private System.Windows.Forms.Label lblFormCorner;
        private System.Windows.Forms.Panel pnlCornerLabel;
        private System.Windows.Forms.Label lblViewTitle;
        private System.Windows.Forms.Label lblBreadCrumbsCurrent;
        private System.Windows.Forms.Label lblBreadcrumbs;
        private UserControls.Logos.LogoSmall logoSmall1;
        private System.Windows.Forms.DateTimePicker dtpScreeningDate;
        private System.Windows.Forms.ComboBox cmbPrice;
        private System.Windows.Forms.ComboBox cmbMovie;
        private System.Windows.Forms.ComboBox cmbHall;
    }
}