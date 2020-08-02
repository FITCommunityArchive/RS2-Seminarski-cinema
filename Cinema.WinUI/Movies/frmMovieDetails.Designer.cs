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
            this.pnlFormTitle = new System.Windows.Forms.Panel();
            this.txtFormTitle = new System.Windows.Forms.TextBox();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblDirectors = new System.Windows.Forms.Label();
            this.lblActors = new System.Windows.Forms.Label();
            this.txtMovieTitle = new System.Windows.Forms.TextBox();
            this.txtReleaseYear = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtDirectors = new System.Windows.Forms.TextBox();
            this.txtActors = new System.Windows.Forms.TextBox();
            this.pnlFormTitle.SuspendLayout();
            this.pnlDetails.SuspendLayout();
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
            this.pnlDetails.Location = new System.Drawing.Point(24, 152);
            this.pnlDetails.Margin = new System.Windows.Forms.Padding(15);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.pnlDetails.Size = new System.Drawing.Size(1105, 588);
            this.pnlDetails.TabIndex = 11;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblTitle.Location = new System.Drawing.Point(367, 60);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(74, 18);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Movie title";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.White;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.Color.Gray;
            this.lblYear.Location = new System.Drawing.Point(367, 132);
            this.lblYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 4);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(94, 18);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "Release year";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.BackColor = System.Drawing.Color.White;
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.ForeColor = System.Drawing.Color.Gray;
            this.lblDuration.Location = new System.Drawing.Point(367, 204);
            this.lblDuration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 4);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(130, 18);
            this.lblDuration.TabIndex = 5;
            this.lblDuration.Text = "Duration (minutes)";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.BackColor = System.Drawing.Color.White;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.ForeColor = System.Drawing.Color.Gray;
            this.lblCountry.Location = new System.Drawing.Point(367, 276);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 4);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(60, 18);
            this.lblCountry.TabIndex = 6;
            this.lblCountry.Text = "Country";
            // 
            // lblDirectors
            // 
            this.lblDirectors.AutoSize = true;
            this.lblDirectors.BackColor = System.Drawing.Color.White;
            this.lblDirectors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectors.ForeColor = System.Drawing.Color.Gray;
            this.lblDirectors.Location = new System.Drawing.Point(367, 348);
            this.lblDirectors.Margin = new System.Windows.Forms.Padding(2, 0, 2, 4);
            this.lblDirectors.Name = "lblDirectors";
            this.lblDirectors.Size = new System.Drawing.Size(79, 18);
            this.lblDirectors.TabIndex = 7;
            this.lblDirectors.Text = "Director(s)";
            // 
            // lblActors
            // 
            this.lblActors.AutoSize = true;
            this.lblActors.BackColor = System.Drawing.Color.White;
            this.lblActors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActors.ForeColor = System.Drawing.Color.Gray;
            this.lblActors.Location = new System.Drawing.Point(367, 420);
            this.lblActors.Margin = new System.Windows.Forms.Padding(2, 0, 2, 4);
            this.lblActors.Name = "lblActors";
            this.lblActors.Size = new System.Drawing.Size(61, 18);
            this.lblActors.TabIndex = 8;
            this.lblActors.Text = "Actor(s)";
            // 
            // txtMovieTitle
            // 
            this.txtMovieTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMovieTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMovieTitle.Location = new System.Drawing.Point(513, 58);
            this.txtMovieTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtMovieTitle.Name = "txtMovieTitle";
            this.txtMovieTitle.Size = new System.Drawing.Size(514, 20);
            this.txtMovieTitle.TabIndex = 9;
            // 
            // txtReleaseYear
            // 
            this.txtReleaseYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReleaseYear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtReleaseYear.Location = new System.Drawing.Point(513, 132);
            this.txtReleaseYear.Margin = new System.Windows.Forms.Padding(2);
            this.txtReleaseYear.Name = "txtReleaseYear";
            this.txtReleaseYear.Size = new System.Drawing.Size(514, 20);
            this.txtReleaseYear.TabIndex = 10;
            // 
            // txtDuration
            // 
            this.txtDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDuration.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDuration.Location = new System.Drawing.Point(513, 206);
            this.txtDuration.Margin = new System.Windows.Forms.Padding(2);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(514, 20);
            this.txtDuration.TabIndex = 11;
            // 
            // txtCountry
            // 
            this.txtCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCountry.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCountry.Location = new System.Drawing.Point(513, 278);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(2);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(514, 20);
            this.txtCountry.TabIndex = 12;
            // 
            // txtDirectors
            // 
            this.txtDirectors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDirectors.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDirectors.Location = new System.Drawing.Point(513, 350);
            this.txtDirectors.Margin = new System.Windows.Forms.Padding(2);
            this.txtDirectors.Name = "txtDirectors";
            this.txtDirectors.Size = new System.Drawing.Size(514, 20);
            this.txtDirectors.TabIndex = 13;
            // 
            // txtActors
            // 
            this.txtActors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtActors.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtActors.Location = new System.Drawing.Point(513, 422);
            this.txtActors.Margin = new System.Windows.Forms.Padding(2);
            this.txtActors.Name = "txtActors";
            this.txtActors.Size = new System.Drawing.Size(514, 20);
            this.txtActors.TabIndex = 14;
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
    }
}