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
            this.txtWriters = new System.Windows.Forms.TextBox();
            this.lblWriters = new System.Windows.Forms.Label();
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
            this.btnUploadPoster = new Cinema.WinUI.UserControls.Buttons.UploadButton();
            this.btnSaveChanges = new Cinema.WinUI.UserControls.Buttons.SaveChangesButton();
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
            this.txtFormTitle.Size = new System.Drawing.Size(185, 33);
            this.txtFormTitle.TabIndex = 0;
            this.txtFormTitle.Text = "Movie details";
            // 
            // pnlDetails
            // 
            this.pnlDetails.BackColor = System.Drawing.Color.White;
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
            // txtWriters
            // 
            this.txtWriters.BackColor = System.Drawing.Color.White;
            this.txtWriters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWriters.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWriters.ForeColor = System.Drawing.Color.DimGray;
            this.txtWriters.Location = new System.Drawing.Point(546, 293);
            this.txtWriters.Margin = new System.Windows.Forms.Padding(2, 2, 2, 24);
            this.txtWriters.Name = "txtWriters";
            this.txtWriters.Size = new System.Drawing.Size(515, 26);
            this.txtWriters.TabIndex = 24;
            this.txtWriters.Validating += new System.ComponentModel.CancelEventHandler(this.txtWriters_Validating);
            // 
            // lblWriters
            // 
            this.lblWriters.AutoSize = true;
            this.lblWriters.BackColor = System.Drawing.Color.White;
            this.lblWriters.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWriters.ForeColor = System.Drawing.Color.Gray;
            this.lblWriters.Location = new System.Drawing.Point(344, 295);
            this.lblWriters.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.lblWriters.Name = "lblWriters";
            this.lblWriters.Size = new System.Drawing.Size(61, 18);
            this.lblWriters.TabIndex = 23;
            this.lblWriters.Text = "Writers";
            // 
            // picPoster
            // 
            this.picPoster.Image = ((System.Drawing.Image)(resources.GetObject("picPoster.Image")));
            this.picPoster.Location = new System.Drawing.Point(22, 24);
            this.picPoster.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
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
            this.lbxGenres.ItemHeight = 18;
            this.lbxGenres.Location = new System.Drawing.Point(547, 399);
            this.lbxGenres.Margin = new System.Windows.Forms.Padding(2, 24, 2, 2);
            this.lbxGenres.Name = "lbxGenres";
            this.lbxGenres.Size = new System.Drawing.Size(514, 108);
            this.lbxGenres.TabIndex = 19;
            // 
            // chlGenres
            // 
            this.chlGenres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chlGenres.FormattingEnabled = true;
            this.chlGenres.Location = new System.Drawing.Point(547, 399);
            this.chlGenres.Margin = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.chlGenres.MultiColumn = true;
            this.chlGenres.Name = "chlGenres";
            this.chlGenres.Size = new System.Drawing.Size(515, 105);
            this.chlGenres.TabIndex = 18;
            this.chlGenres.Visible = false;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.BackColor = System.Drawing.Color.White;
            this.lblGenre.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.ForeColor = System.Drawing.Color.Gray;
            this.lblGenre.Location = new System.Drawing.Point(344, 393);
            this.lblGenre.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(61, 18);
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
            this.txtActors.Margin = new System.Windows.Forms.Padding(2, 2, 2, 24);
            this.txtActors.Name = "txtActors";
            this.txtActors.Size = new System.Drawing.Size(515, 26);
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
            this.txtDirectors.Margin = new System.Windows.Forms.Padding(2, 2, 2, 24);
            this.txtDirectors.Name = "txtDirectors";
            this.txtDirectors.Size = new System.Drawing.Size(515, 26);
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
            this.txtCountry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 24);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(515, 26);
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
            this.txtDuration.Margin = new System.Windows.Forms.Padding(2, 2, 2, 24);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(515, 26);
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
            this.txtReleaseYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 24);
            this.txtReleaseYear.Name = "txtReleaseYear";
            this.txtReleaseYear.Size = new System.Drawing.Size(515, 26);
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
            this.txtMovieTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 24);
            this.txtMovieTitle.Name = "txtMovieTitle";
            this.txtMovieTitle.Size = new System.Drawing.Size(515, 26);
            this.txtMovieTitle.TabIndex = 9;
            this.txtMovieTitle.Validating += new System.ComponentModel.CancelEventHandler(this.txtMovieTitle_Validating);
            // 
            // lblActors
            // 
            this.lblActors.AutoSize = true;
            this.lblActors.BackColor = System.Drawing.Color.White;
            this.lblActors.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActors.ForeColor = System.Drawing.Color.Gray;
            this.lblActors.Location = new System.Drawing.Point(344, 347);
            this.lblActors.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.lblActors.Name = "lblActors";
            this.lblActors.Size = new System.Drawing.Size(70, 18);
            this.lblActors.TabIndex = 8;
            this.lblActors.Text = "Actor(s)";
            // 
            // lblDirectors
            // 
            this.lblDirectors.AutoSize = true;
            this.lblDirectors.BackColor = System.Drawing.Color.White;
            this.lblDirectors.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectors.ForeColor = System.Drawing.Color.Gray;
            this.lblDirectors.Location = new System.Drawing.Point(344, 243);
            this.lblDirectors.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.lblDirectors.Name = "lblDirectors";
            this.lblDirectors.Size = new System.Drawing.Size(89, 18);
            this.lblDirectors.TabIndex = 7;
            this.lblDirectors.Text = "Director(s)";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.BackColor = System.Drawing.Color.White;
            this.lblCountry.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.ForeColor = System.Drawing.Color.Gray;
            this.lblCountry.Location = new System.Drawing.Point(344, 191);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(68, 18);
            this.lblCountry.TabIndex = 6;
            this.lblCountry.Text = "Country";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.BackColor = System.Drawing.Color.White;
            this.lblDuration.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.ForeColor = System.Drawing.Color.Gray;
            this.lblDuration.Location = new System.Drawing.Point(344, 139);
            this.lblDuration.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(149, 18);
            this.lblDuration.TabIndex = 5;
            this.lblDuration.Text = "Duration (minutes)";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.White;
            this.lblYear.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.Color.Gray;
            this.lblYear.Location = new System.Drawing.Point(344, 87);
            this.lblYear.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(103, 18);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "Release year";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblTitle.Location = new System.Drawing.Point(344, 35);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(84, 18);
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
            // btnUploadPoster
            // 
            this.btnUploadPoster.Location = new System.Drawing.Point(547, 511);
            this.btnUploadPoster.Margin = new System.Windows.Forms.Padding(2);
            this.btnUploadPoster.Name = "btnUploadPoster";
            this.btnUploadPoster.Size = new System.Drawing.Size(90, 28);
            this.btnUploadPoster.TabIndex = 22;
            this.btnUploadPoster.ButtonClicked += new System.EventHandler(this.btnUploadPoster_ButtonClicked);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(641, 511);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(120, 31);
            this.btnSaveChanges.TabIndex = 21;
            this.btnSaveChanges.ButtonClicked += new System.EventHandler(this.btnSaveChanges_ButtonClicked);
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
    }
}