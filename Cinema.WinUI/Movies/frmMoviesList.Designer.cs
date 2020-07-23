namespace Cinema.WinUI.Movies
{
    partial class frmMoviesList
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
            this.grdMoviesList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdMoviesList)).BeginInit();
            this.SuspendLayout();
            // 
            // grdMoviesList
            // 
            this.grdMoviesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMoviesList.Location = new System.Drawing.Point(-10, 167);
            this.grdMoviesList.Name = "grdMoviesList";
            this.grdMoviesList.RowHeadersWidth = 51;
            this.grdMoviesList.RowTemplate.Height = 24;
            this.grdMoviesList.Size = new System.Drawing.Size(811, 286);
            this.grdMoviesList.TabIndex = 0;
            // 
            // frmMoviesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdMoviesList);
            this.Name = "frmMoviesList";
            this.Text = "frmMoviesList";
            this.Load += new System.EventHandler(this.frmMoviesList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMoviesList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdMoviesList;
    }
}