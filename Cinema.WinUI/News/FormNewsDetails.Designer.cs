namespace Cinema.WinUI.Screenings
{
    partial class FormNewsDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewsDetails));
            this.pnlFormTitle = new System.Windows.Forms.Panel();
            this.logoSmall1 = new Cinema.WinUI.UserControls.Logos.LogoSmall();
            this.lblBreadCrumbsCurrent = new System.Windows.Forms.Label();
            this.lblBreadcrumbs = new System.Windows.Forms.Label();
            this.lblViewTitle = new System.Windows.Forms.Label();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.btnUpload = new Cinema.WinUI.UserControls.Buttons.UploadButton();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.txtNewsTitle = new Cinema.WinUI.UserControls.ExtendedTextBox();
            this.cmbNewsType = new System.Windows.Forms.ComboBox();
            this.btnDelete = new Cinema.WinUI.UserControls.Buttons.DeleteButton();
            this.btnBack = new Cinema.WinUI.UserControls.Buttons.BackButton();
            this.btnSaveChanges = new Cinema.WinUI.UserControls.Buttons.SaveChangesButton();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblNewsType = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblFormCorner = new System.Windows.Forms.Label();
            this.pnlCornerLabel = new System.Windows.Forms.Panel();
            this.pnlFormTitle.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
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
            this.lblBreadCrumbsCurrent.Location = new System.Drawing.Point(141, 63);
            this.lblBreadCrumbsCurrent.Margin = new System.Windows.Forms.Padding(0);
            this.lblBreadCrumbsCurrent.Name = "lblBreadCrumbsCurrent";
            this.lblBreadCrumbsCurrent.Size = new System.Drawing.Size(105, 17);
            this.lblBreadCrumbsCurrent.TabIndex = 3;
            this.lblBreadCrumbsCurrent.Text = "News details";
            // 
            // lblBreadcrumbs
            // 
            this.lblBreadcrumbs.AutoSize = true;
            this.lblBreadcrumbs.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreadcrumbs.Location = new System.Drawing.Point(29, 63);
            this.lblBreadcrumbs.Margin = new System.Windows.Forms.Padding(0);
            this.lblBreadcrumbs.Name = "lblBreadcrumbs";
            this.lblBreadcrumbs.Size = new System.Drawing.Size(112, 17);
            this.lblBreadcrumbs.TabIndex = 2;
            this.lblBreadcrumbs.Text = "Home / News /";
            // 
            // lblViewTitle
            // 
            this.lblViewTitle.AutoSize = true;
            this.lblViewTitle.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblViewTitle.Location = new System.Drawing.Point(25, 11);
            this.lblViewTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblViewTitle.Name = "lblViewTitle";
            this.lblViewTitle.Size = new System.Drawing.Size(185, 32);
            this.lblViewTitle.TabIndex = 1;
            this.lblViewTitle.Text = "News details";
            // 
            // pnlDetails
            // 
            this.pnlDetails.BackColor = System.Drawing.Color.White;
            this.pnlDetails.Controls.Add(this.btnUpload);
            this.pnlDetails.Controls.Add(this.rtbDescription);
            this.pnlDetails.Controls.Add(this.txtNewsTitle);
            this.pnlDetails.Controls.Add(this.cmbNewsType);
            this.pnlDetails.Controls.Add(this.btnDelete);
            this.pnlDetails.Controls.Add(this.btnBack);
            this.pnlDetails.Controls.Add(this.btnSaveChanges);
            this.pnlDetails.Controls.Add(this.picImage);
            this.pnlDetails.Controls.Add(this.lblDescription);
            this.pnlDetails.Controls.Add(this.lblNewsType);
            this.pnlDetails.Controls.Add(this.lblTitle);
            this.pnlDetails.ForeColor = System.Drawing.Color.White;
            this.pnlDetails.Location = new System.Drawing.Point(32, 187);
            this.pnlDetails.Margin = new System.Windows.Forms.Padding(20);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Padding = new System.Windows.Forms.Padding(15);
            this.pnlDetails.Size = new System.Drawing.Size(1473, 672);
            this.pnlDetails.TabIndex = 11;
            // 
            // btnUpload
            // 
            this.btnUpload.AutoSize = true;
            this.btnUpload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpload.Location = new System.Drawing.Point(41, 310);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(120, 40);
            this.btnUpload.TabIndex = 37;
            this.btnUpload.ButtonClicked += new System.EventHandler(this.btnUpload_ButtonClicked);
            // 
            // rtbDescription
            // 
            this.rtbDescription.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDescription.Location = new System.Drawing.Point(728, 147);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(703, 411);
            this.rtbDescription.TabIndex = 36;
            this.rtbDescription.Text = "";
            this.rtbDescription.Validating += new System.ComponentModel.CancelEventHandler(this.rtbDescription_Validating);
            // 
            // txtNewsTitle
            // 
            this.txtNewsTitle.BorderColor = System.Drawing.Color.DarkGray;
            this.txtNewsTitle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewsTitle.ForeColor = System.Drawing.Color.Gray;
            this.txtNewsTitle.Location = new System.Drawing.Point(728, 43);
            this.txtNewsTitle.Margin = new System.Windows.Forms.Padding(25);
            this.txtNewsTitle.Name = "txtNewsTitle";
            this.txtNewsTitle.Size = new System.Drawing.Size(703, 26);
            this.txtNewsTitle.TabIndex = 35;
            this.txtNewsTitle.Validating += new System.ComponentModel.CancelEventHandler(this.txtNewsTitle_Validating);
            // 
            // cmbNewsType
            // 
            this.cmbNewsType.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNewsType.ForeColor = System.Drawing.Color.Gray;
            this.cmbNewsType.FormattingEnabled = true;
            this.cmbNewsType.Location = new System.Drawing.Point(728, 95);
            this.cmbNewsType.Name = "cmbNewsType";
            this.cmbNewsType.Size = new System.Drawing.Size(703, 26);
            this.cmbNewsType.TabIndex = 30;
            this.cmbNewsType.Validating += new System.ComponentModel.CancelEventHandler(this.cmbNewsType_Validating);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Location = new System.Drawing.Point(887, 591);
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
            this.btnBack.Location = new System.Drawing.Point(1046, 591);
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
            this.btnSaveChanges.Location = new System.Drawing.Point(728, 591);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(120, 40);
            this.btnSaveChanges.TabIndex = 21;
            this.btnSaveChanges.ButtonClicked += new System.EventHandler(this.btnSaveChanges_ButtonClicked);
            // 
            // picImage
            // 
            this.picImage.Image = ((System.Drawing.Image)(resources.GetObject("picImage.Image")));
            this.picImage.Location = new System.Drawing.Point(41, 30);
            this.picImage.Margin = new System.Windows.Forms.Padding(27, 15, 15, 15);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(484, 262);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 20;
            this.picImage.TabStop = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.White;
            this.lblDescription.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.Gray;
            this.lblDescription.Location = new System.Drawing.Point(586, 147);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(15);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(90, 18);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Description";
            // 
            // lblNewsType
            // 
            this.lblNewsType.AutoSize = true;
            this.lblNewsType.BackColor = System.Drawing.Color.White;
            this.lblNewsType.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewsType.ForeColor = System.Drawing.Color.Gray;
            this.lblNewsType.Location = new System.Drawing.Point(586, 94);
            this.lblNewsType.Margin = new System.Windows.Forms.Padding(15);
            this.lblNewsType.Name = "lblNewsType";
            this.lblNewsType.Size = new System.Drawing.Size(87, 18);
            this.lblNewsType.TabIndex = 5;
            this.lblNewsType.Text = "News type";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblTitle.Location = new System.Drawing.Point(586, 42);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(38, 18);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Title";
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
            this.lblFormCorner.Location = new System.Drawing.Point(28, 6);
            this.lblFormCorner.Margin = new System.Windows.Forms.Padding(0);
            this.lblFormCorner.Name = "lblFormCorner";
            this.lblFormCorner.Padding = new System.Windows.Forms.Padding(9, 9, 9, 12);
            this.lblFormCorner.Size = new System.Drawing.Size(123, 44);
            this.lblFormCorner.TabIndex = 0;
            this.lblFormCorner.Text = "News info";
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
            // FormNewsDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1537, 937);
            this.Controls.Add(this.pnlCornerLabel);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.pnlFormTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormNewsDetails";
            this.Text = "frmMovieDetails";
            this.Load += new System.EventHandler(this.frmNewsDetails_Load);
            this.pnlFormTitle.ResumeLayout(false);
            this.pnlFormTitle.PerformLayout();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnlCornerLabel.ResumeLayout(false);
            this.pnlCornerLabel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormTitle;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblNewsType;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picImage;
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
        private System.Windows.Forms.ComboBox cmbNewsType;
        private UserControls.ExtendedTextBox txtNewsTitle;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private UserControls.Buttons.UploadButton btnUpload;
    }
}