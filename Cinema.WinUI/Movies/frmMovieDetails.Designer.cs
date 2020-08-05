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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovieDetails));
            this.pnlFormTitle = new System.Windows.Forms.Panel();
            this.txtFormTitle = new System.Windows.Forms.TextBox();
            this.pnlDetails = new System.Windows.Forms.Panel();
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
            this.pnlFormTitle.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFormTitle
            // 
            this.pnlFormTitle.BackColor = System.Drawing.Color.White;
            this.pnlFormTitle.Controls.Add(this.txtFormTitle);
            this.pnlFormTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlFormTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlFormTitle.Name = "pnlFormTitle";
            this.pnlFormTitle.Size = new System.Drawing.Size(1537, 90);
            this.pnlFormTitle.TabIndex = 9;
            // 
            // txtFormTitle
            // 
            this.txtFormTitle.BackColor = System.Drawing.Color.White;
            this.txtFormTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFormTitle.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormTitle.ForeColor = System.Drawing.Color.Gray;
            this.txtFormTitle.Location = new System.Drawing.Point(37, 18);
            this.txtFormTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFormTitle.Name = "txtFormTitle";
            this.txtFormTitle.Size = new System.Drawing.Size(247, 33);
            this.txtFormTitle.TabIndex = 0;
            this.txtFormTitle.Text = "Movie details";
            // 
            // pnlDetails
            // 
            this.pnlDetails.BackColor = System.Drawing.Color.White;
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
            this.pnlDetails.Location = new System.Drawing.Point(32, 187);
            this.pnlDetails.Margin = new System.Windows.Forms.Padding(20);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Padding = new System.Windows.Forms.Padding(15);
            this.pnlDetails.Size = new System.Drawing.Size(1265, 724);
            this.pnlDetails.TabIndex = 11;
            // 
            // picPoster
            // 
            this.picPoster.Image = ((System.Drawing.Image)(resources.GetObject("picPoster.Image")));
            this.picPoster.Location = new System.Drawing.Point(30, 30);
            this.picPoster.Margin = new System.Windows.Forms.Padding(15);
            this.picPoster.Name = "picPoster";
            this.picPoster.Size = new System.Drawing.Size(400, 600);
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
            this.lbxGenres.Location = new System.Drawing.Point(625, 377);
            this.lbxGenres.Name = "lbxGenres";
            this.lbxGenres.Size = new System.Drawing.Size(590, 90);
            this.lbxGenres.TabIndex = 19;
            // 
            // chlGenres
            // 
            this.chlGenres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chlGenres.FormattingEnabled = true;
            this.chlGenres.Location = new System.Drawing.Point(625, 377);
            this.chlGenres.Margin = new System.Windows.Forms.Padding(4);
            this.chlGenres.MultiColumn = true;
            this.chlGenres.Name = "chlGenres";
            this.chlGenres.Size = new System.Drawing.Size(591, 102);
            this.chlGenres.TabIndex = 18;
            this.chlGenres.Visible = false;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.BackColor = System.Drawing.Color.White;
            this.lblGenre.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.ForeColor = System.Drawing.Color.Gray;
            this.lblGenre.Location = new System.Drawing.Point(460, 379);
            this.lblGenre.Margin = new System.Windows.Forms.Padding(15);
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
            this.txtActors.ForeColor = System.Drawing.Color.White;
            this.txtActors.Location = new System.Drawing.Point(626, 318);
            this.txtActors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 30);
            this.txtActors.Name = "txtActors";
            this.txtActors.Size = new System.Drawing.Size(590, 26);
            this.txtActors.TabIndex = 14;
            // 
            // txtDirectors
            // 
            this.txtDirectors.BackColor = System.Drawing.Color.White;
            this.txtDirectors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDirectors.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirectors.ForeColor = System.Drawing.Color.White;
            this.txtDirectors.Location = new System.Drawing.Point(626, 260);
            this.txtDirectors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 30);
            this.txtDirectors.Name = "txtDirectors";
            this.txtDirectors.Size = new System.Drawing.Size(590, 26);
            this.txtDirectors.TabIndex = 13;
            // 
            // txtCountry
            // 
            this.txtCountry.BackColor = System.Drawing.Color.White;
            this.txtCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCountry.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountry.ForeColor = System.Drawing.Color.White;
            this.txtCountry.Location = new System.Drawing.Point(626, 202);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 30);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(590, 26);
            this.txtCountry.TabIndex = 12;
            // 
            // txtDuration
            // 
            this.txtDuration.BackColor = System.Drawing.Color.White;
            this.txtDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDuration.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuration.ForeColor = System.Drawing.Color.White;
            this.txtDuration.Location = new System.Drawing.Point(626, 144);
            this.txtDuration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 30);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(590, 26);
            this.txtDuration.TabIndex = 11;
            // 
            // txtReleaseYear
            // 
            this.txtReleaseYear.BackColor = System.Drawing.Color.White;
            this.txtReleaseYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReleaseYear.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReleaseYear.ForeColor = System.Drawing.Color.White;
            this.txtReleaseYear.Location = new System.Drawing.Point(626, 86);
            this.txtReleaseYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 30);
            this.txtReleaseYear.Name = "txtReleaseYear";
            this.txtReleaseYear.Size = new System.Drawing.Size(590, 26);
            this.txtReleaseYear.TabIndex = 10;
            // 
            // txtMovieTitle
            // 
            this.txtMovieTitle.BackColor = System.Drawing.Color.White;
            this.txtMovieTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMovieTitle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovieTitle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMovieTitle.Location = new System.Drawing.Point(625, 28);
            this.txtMovieTitle.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.txtMovieTitle.Name = "txtMovieTitle";
            this.txtMovieTitle.Size = new System.Drawing.Size(590, 26);
            this.txtMovieTitle.TabIndex = 9;
            // 
            // lblActors
            // 
            this.lblActors.AutoSize = true;
            this.lblActors.BackColor = System.Drawing.Color.White;
            this.lblActors.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActors.ForeColor = System.Drawing.Color.Gray;
            this.lblActors.Location = new System.Drawing.Point(461, 322);
            this.lblActors.Margin = new System.Windows.Forms.Padding(15);
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
            this.lblDirectors.Location = new System.Drawing.Point(461, 263);
            this.lblDirectors.Margin = new System.Windows.Forms.Padding(15);
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
            this.lblCountry.Location = new System.Drawing.Point(461, 205);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(15);
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
            this.lblDuration.Location = new System.Drawing.Point(461, 147);
            this.lblDuration.Margin = new System.Windows.Forms.Padding(15);
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
            this.lblYear.Location = new System.Drawing.Point(461, 94);
            this.lblYear.Margin = new System.Windows.Forms.Padding(15);
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
            this.lblTitle.Location = new System.Drawing.Point(460, 30);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(84, 18);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Movie title";
            // 
            // frmMovieDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1537, 940);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.pnlFormTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMovieDetails";
            this.Text = "frmMovieDetails";
            this.Load += new System.EventHandler(this.frmMovieDetails_Load);
            this.pnlFormTitle.ResumeLayout(false);
            this.pnlFormTitle.PerformLayout();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).EndInit();
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
    }
}