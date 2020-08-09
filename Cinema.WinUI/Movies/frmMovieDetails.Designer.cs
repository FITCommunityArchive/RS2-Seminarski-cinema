namespace Cinema.WinUI.Movies
{
    partial class frmMovieDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovieDetails));
            this.pnlFormTitle = new System.Windows.Forms.Panel();
            this.txtFormTitle = new System.Windows.Forms.TextBox();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.btnDelete = new Cinema.WinUI.UserControls.Buttons.DeleteButton();
            this.btnEdit = new Cinema.WinUI.UserControls.Buttons.EditButton();
            this.btnBack = new Cinema.WinUI.UserControls.Buttons.BackButton();
            this.txtWriters = new System.Windows.Forms.TextBox();
            this.lblWriters = new System.Windows.Forms.Label();
            this.btnUploadPoster = new Cinema.WinUI.UserControls.Buttons.UploadButton();
            this.btnSaveChanges = new Cinema.WinUI.UserControls.Buttons.SaveChangesButton();
            this.picPoster = new System.Windows.Forms.PictureBox();
            this.lbxGenres = new System.Windows.Forms.ListBox();
            this.chlGenres = new System.Windows.Forms.CheckedListBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtActors = new System.Windows.Forms.TextBox();
            this.txtDirectors = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtReleaseYear = new System.Windows.Forms.TextBox();
            this.txtMovieTitle = new System.Windows.Forms.TextBox();
            this.lblActors = new System.Windows.Forms.Label();
            this.lblDirectors = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnlFormTitle.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFormTitle
            // 
            this.pnlFormTitle.BackColor = System.Drawing.Color.White;
            this.pnlFormTitle.Controls.Add(this.txtFormTitle);
            this.pnlFormTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlFormTitle.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFormTitle.Name = "pnlFormTitle";
            this.pnlFormTitle.Size = new System.Drawing.Size(1153, 73);
            this.pnlFormTitle.TabIndex = 9;
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
            this.txtFormTitle.Size = new System.Drawing.Size(185, 27);
            this.txtFormTitle.TabIndex = 0;
            this.txtFormTitle.Text = "Movie details";
            // 
            // pnlDetails
            // 
            this.pnlDetails.BackColor = System.Drawing.Color.White;
            this.pnlDetails.Controls.Add(this.btnDelete);
            this.pnlDetails.Controls.Add(this.btnEdit);
            this.pnlDetails.Controls.Add(this.btnBack);
            this.pnlDetails.Controls.Add(this.txtWriters);
            this.pnlDetails.Controls.Add(this.lblWriters);
            this.pnlDetails.Controls.Add(this.btnUploadPoster);
            this.pnlDetails.Controls.Add(this.btnSaveChanges);
            this.pnlDetails.Controls.Add(this.picPoster);
            this.pnlDetails.Controls.Add(this.lbxGenres);
            this.pnlDetails.Controls.Add(this.chlGenres);
            this.pnlDetails.Controls.Add(this.lblGenre);
            this.pnlDetails.Controls.Add(this.txtActors);
            this.pnlDetails.Controls.Add(this.txtDirectors);
            this.pnlDetails.Controls.Add(this.txtCountry);
            this.pnlDetails.Controls.Add(this.txtDuration);
            this.pnlDetails.Controls.Add(this.txtReleaseYear);
            this.pnlDetails.Controls.Add(this.txtMovieTitle);
            this.pnlDetails.Controls.Add(this.lblActors);
            this.pnlDetails.Controls.Add(this.lblDirectors);
            this.pnlDetails.Controls.Add(this.lblCountry);
            this.pnlDetails.Controls.Add(this.lblDuration);
            this.pnlDetails.Controls.Add(this.lblYear);
            this.pnlDetails.Controls.Add(this.lblTitle);
            this.pnlDetails.ForeColor = System.Drawing.Color.White;
            this.pnlDetails.Location = new System.Drawing.Point(24, 152);
            this.pnlDetails.Margin = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.pnlDetails.Size = new System.Drawing.Size(1105, 588);
            this.pnlDetails.TabIndex = 11;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Location = new System.Drawing.Point(809, 526);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 40);
            this.btnDelete.TabIndex = 27;
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEdit.Location = new System.Drawing.Point(547, 526);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(120, 40);
            this.btnEdit.TabIndex = 26;
            this.btnEdit.ButtonClicked += new System.EventHandler(this.btnEdit_ButtonClicked);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.Location = new System.Drawing.Point(940, 526);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 40);
            this.btnBack.TabIndex = 25;
            this.btnBack.ButtonClicked += new System.EventHandler(this.btnBack_ButtonClicked);
            // 
            // txtWriters
            // 
            this.txtWriters.BackColor = System.Drawing.Color.White;
            this.txtWriters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWriters.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWriters.ForeColor = System.Drawing.Color.DimGray;
            this.txtWriters.Location = new System.Drawing.Point(546, 293);
            this.txtWriters.Margin = new System.Windows.Forms.Padding(2, 2, 20, 24);
            this.txtWriters.Name = "txtWriters";
            this.txtWriters.Size = new System.Drawing.Size(528, 22);
            this.txtWriters.TabIndex = 24;
            this.txtWriters.Validating += new System.ComponentModel.CancelEventHandler(this.txtWriters_Validating);
            // 
            // lblWriters
            // 
            this.lblWriters.AutoSize = true;
            this.lblWriters.BackColor = System.Drawing.Color.White;
            this.lblWriters.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWriters.ForeColor = System.Drawing.Color.Gray;
            this.lblWriters.Location = new System.Drawing.Point(383, 293);
            this.lblWriters.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.lblWriters.Name = "lblWriters";
            this.lblWriters.Size = new System.Drawing.Size(53, 14);
            this.lblWriters.TabIndex = 23;
            this.lblWriters.Text = "Writers";
            // 
            // btnUploadPoster
            // 
            this.btnUploadPoster.AutoSize = true;
            this.btnUploadPoster.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUploadPoster.Location = new System.Drawing.Point(31, 526);
            this.btnUploadPoster.Margin = new System.Windows.Forms.Padding(2);
            this.btnUploadPoster.Name = "btnUploadPoster";
            this.btnUploadPoster.Size = new System.Drawing.Size(120, 40);
            this.btnUploadPoster.TabIndex = 22;
            this.btnUploadPoster.ButtonClicked += new System.EventHandler(this.btnUploadPoster_ButtonClicked);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.AutoSize = true;
            this.btnSaveChanges.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveChanges.Location = new System.Drawing.Point(678, 526);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(120, 40);
            this.btnSaveChanges.TabIndex = 21;
            this.btnSaveChanges.ButtonClicked += new System.EventHandler(this.btnSaveChanges_ButtonClicked);
            // 
            // picPoster
            // 
            this.picPoster.Image = ((System.Drawing.Image)(resources.GetObject("picPoster.Image")));
            this.picPoster.Location = new System.Drawing.Point(31, 24);
            this.picPoster.Margin = new System.Windows.Forms.Padding(20, 12, 11, 12);
            this.picPoster.Name = "picPoster";
            this.picPoster.Size = new System.Drawing.Size(300, 488);
            this.picPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPoster.TabIndex = 20;
            this.picPoster.TabStop = false;
            // 
            // lbxGenres
            // 
            this.lbxGenres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxGenres.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxGenres.ForeColor = System.Drawing.Color.Gray;
            this.lbxGenres.FormattingEnabled = true;
            this.lbxGenres.ItemHeight = 14;
            this.lbxGenres.Location = new System.Drawing.Point(547, 399);
            this.lbxGenres.Margin = new System.Windows.Forms.Padding(2, 24, 20, 2);
            this.lbxGenres.Name = "lbxGenres";
            this.lbxGenres.Size = new System.Drawing.Size(528, 98);
            this.lbxGenres.TabIndex = 19;
            // 
            // chlGenres
            // 
            this.chlGenres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chlGenres.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chlGenres.ForeColor = System.Drawing.Color.Gray;
            this.chlGenres.FormattingEnabled = true;
            this.chlGenres.Location = new System.Drawing.Point(547, 399);
            this.chlGenres.Margin = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.chlGenres.MultiColumn = true;
            this.chlGenres.Name = "chlGenres";
            this.chlGenres.Size = new System.Drawing.Size(528, 85);
            this.chlGenres.TabIndex = 18;
            this.chlGenres.Visible = false;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.BackColor = System.Drawing.Color.White;
            this.lblGenre.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.ForeColor = System.Drawing.Color.Gray;
            this.lblGenre.Location = new System.Drawing.Point(383, 391);
            this.lblGenre.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(52, 14);
            this.lblGenre.TabIndex = 16;
            this.lblGenre.Text = "Genres";
            // 
            // txtActors
            // 
            this.txtActors.BackColor = System.Drawing.Color.White;
            this.txtActors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtActors.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActors.ForeColor = System.Drawing.Color.DimGray;
            this.txtActors.Location = new System.Drawing.Point(546, 345);
            this.txtActors.Margin = new System.Windows.Forms.Padding(2, 2, 20, 24);
            this.txtActors.Name = "txtActors";
            this.txtActors.Size = new System.Drawing.Size(528, 22);
            this.txtActors.TabIndex = 14;
            this.txtActors.Validating += new System.ComponentModel.CancelEventHandler(this.txtActors_Validating);
            // 
            // txtDirectors
            // 
            this.txtDirectors.BackColor = System.Drawing.Color.White;
            this.txtDirectors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDirectors.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirectors.ForeColor = System.Drawing.Color.DimGray;
            this.txtDirectors.Location = new System.Drawing.Point(546, 241);
            this.txtDirectors.Margin = new System.Windows.Forms.Padding(2, 2, 20, 24);
            this.txtDirectors.Name = "txtDirectors";
            this.txtDirectors.Size = new System.Drawing.Size(528, 22);
            this.txtDirectors.TabIndex = 13;
            this.txtDirectors.Validating += new System.ComponentModel.CancelEventHandler(this.txtDirectors_Validating);
            // 
            // txtCountry
            // 
            this.txtCountry.BackColor = System.Drawing.Color.White;
            this.txtCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCountry.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountry.ForeColor = System.Drawing.Color.DimGray;
            this.txtCountry.Location = new System.Drawing.Point(546, 189);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(2, 2, 20, 24);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(528, 22);
            this.txtCountry.TabIndex = 12;
            this.txtCountry.Validating += new System.ComponentModel.CancelEventHandler(this.txtCountry_Validating);
            // 
            // txtDuration
            // 
            this.txtDuration.BackColor = System.Drawing.Color.White;
            this.txtDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDuration.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuration.ForeColor = System.Drawing.Color.DimGray;
            this.txtDuration.Location = new System.Drawing.Point(546, 137);
            this.txtDuration.Margin = new System.Windows.Forms.Padding(2, 2, 20, 24);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(528, 22);
            this.txtDuration.TabIndex = 11;
            this.txtDuration.Validating += new System.ComponentModel.CancelEventHandler(this.txtDuration_Validating);
            // 
            // txtReleaseYear
            // 
            this.txtReleaseYear.BackColor = System.Drawing.Color.White;
            this.txtReleaseYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReleaseYear.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReleaseYear.ForeColor = System.Drawing.Color.DimGray;
            this.txtReleaseYear.Location = new System.Drawing.Point(546, 85);
            this.txtReleaseYear.Margin = new System.Windows.Forms.Padding(2, 2, 20, 24);
            this.txtReleaseYear.Name = "txtReleaseYear";
            this.txtReleaseYear.Size = new System.Drawing.Size(528, 22);
            this.txtReleaseYear.TabIndex = 10;
            this.txtReleaseYear.Validating += new System.ComponentModel.CancelEventHandler(this.txtReleaseYear_Validating);
            // 
            // txtMovieTitle
            // 
            this.txtMovieTitle.BackColor = System.Drawing.Color.White;
            this.txtMovieTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMovieTitle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovieTitle.ForeColor = System.Drawing.Color.DimGray;
            this.txtMovieTitle.Location = new System.Drawing.Point(546, 33);
            this.txtMovieTitle.Margin = new System.Windows.Forms.Padding(2, 2, 20, 24);
            this.txtMovieTitle.Name = "txtMovieTitle";
            this.txtMovieTitle.Size = new System.Drawing.Size(528, 22);
            this.txtMovieTitle.TabIndex = 9;
            this.txtMovieTitle.Validating += new System.ComponentModel.CancelEventHandler(this.txtMovieTitle_Validating);
            // 
            // lblActors
            // 
            this.lblActors.AutoSize = true;
            this.lblActors.BackColor = System.Drawing.Color.White;
            this.lblActors.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActors.ForeColor = System.Drawing.Color.Gray;
            this.lblActors.Location = new System.Drawing.Point(383, 345);
            this.lblActors.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.lblActors.Name = "lblActors";
            this.lblActors.Size = new System.Drawing.Size(56, 14);
            this.lblActors.TabIndex = 8;
            this.lblActors.Text = "Actor(s)";
            // 
            // lblDirectors
            // 
            this.lblDirectors.AutoSize = true;
            this.lblDirectors.BackColor = System.Drawing.Color.White;
            this.lblDirectors.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectors.ForeColor = System.Drawing.Color.Gray;
            this.lblDirectors.Location = new System.Drawing.Point(383, 241);
            this.lblDirectors.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.lblDirectors.Name = "lblDirectors";
            this.lblDirectors.Size = new System.Drawing.Size(73, 14);
            this.lblDirectors.TabIndex = 7;
            this.lblDirectors.Text = "Director(s)";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.BackColor = System.Drawing.Color.White;
            this.lblCountry.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.ForeColor = System.Drawing.Color.Gray;
            this.lblCountry.Location = new System.Drawing.Point(383, 189);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(57, 14);
            this.lblCountry.TabIndex = 6;
            this.lblCountry.Text = "Country";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.BackColor = System.Drawing.Color.White;
            this.lblDuration.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.ForeColor = System.Drawing.Color.Gray;
            this.lblDuration.Location = new System.Drawing.Point(383, 137);
            this.lblDuration.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(125, 14);
            this.lblDuration.TabIndex = 5;
            this.lblDuration.Text = "Duration (minutes)";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.White;
            this.lblYear.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.Color.Gray;
            this.lblYear.Location = new System.Drawing.Point(383, 85);
            this.lblYear.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(89, 14);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "Release year";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblTitle.Location = new System.Drawing.Point(383, 33);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(71, 14);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Movie title";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmMovieDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 764);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.pnlFormTitle);
            this.Name = "frmMovieDetails";
            this.Text = "frmMovieDetails";
            this.Load += new System.EventHandler(this.frmMovieDetails_Load);
            this.pnlFormTitle.ResumeLayout(false);
            this.pnlFormTitle.PerformLayout();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormTitle;
        private System.Windows.Forms.TextBox txtFormTitle;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Label lblActors;
        private System.Windows.Forms.Label lblDirectors;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtReleaseYear;
        private System.Windows.Forms.TextBox txtMovieTitle;
        private System.Windows.Forms.TextBox txtDirectors;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtActors;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.CheckedListBox chlGenres;
        private System.Windows.Forms.ListBox lbxGenres;
        private System.Windows.Forms.PictureBox picPoster;
        private UserControls.Buttons.SaveChangesButton btnSaveChanges;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private UserControls.Buttons.UploadButton btnUploadPoster;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtWriters;
        private System.Windows.Forms.Label lblWriters;
        private UserControls.Buttons.BackButton btnBack;
        private UserControls.Buttons.EditButton btnEdit;
        private UserControls.Buttons.DeleteButton btnDelete;
    }
}