namespace Cinema.WinUI.Movies
{
    partial class FormMovieSynopsis
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
            this.rtbSynopsisText = new System.Windows.Forms.RichTextBox();
            this.lblMovieSynopsisTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOK = new Cinema.WinUI.UserControls.Buttons.OKButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbSynopsisText
            // 
            this.rtbSynopsisText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbSynopsisText.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbSynopsisText.ForeColor = System.Drawing.Color.Black;
            this.rtbSynopsisText.Location = new System.Drawing.Point(13, 99);
            this.rtbSynopsisText.Name = "rtbSynopsisText";
            this.rtbSynopsisText.Size = new System.Drawing.Size(776, 334);
            this.rtbSynopsisText.TabIndex = 0;
            this.rtbSynopsisText.Text = "";
            // 
            // lblMovieSynopsisTitle
            // 
            this.lblMovieSynopsisTitle.AutoSize = true;
            this.lblMovieSynopsisTitle.BackColor = System.Drawing.Color.White;
            this.lblMovieSynopsisTitle.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieSynopsisTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblMovieSynopsisTitle.Location = new System.Drawing.Point(12, 13);
            this.lblMovieSynopsisTitle.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblMovieSynopsisTitle.Name = "lblMovieSynopsisTitle";
            this.lblMovieSynopsisTitle.Padding = new System.Windows.Forms.Padding(9, 9, 9, 12);
            this.lblMovieSynopsisTitle.Size = new System.Drawing.Size(152, 50);
            this.lblMovieSynopsisTitle.TabIndex = 3;
            this.lblMovieSynopsisTitle.Text = "Movie info";
            this.lblMovieSynopsisTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblMovieSynopsisTitle);
            this.panel1.Location = new System.Drawing.Point(-3, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 64);
            this.panel1.TabIndex = 4;
            // 
            // btnOK
            // 
            this.btnOK.AutoSize = true;
            this.btnOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOK.Location = new System.Drawing.Point(629, 440);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(160, 49);
            this.btnOK.TabIndex = 5;
            this.btnOK.ButtonClicked += new System.EventHandler(this.btnOK_Click);
            // 
            // FormMovieSynopsis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rtbSynopsisText);
            this.Name = "FormMovieSynopsis";
            this.Text = "FormMovieSynopsis";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbSynopsisText;
        private System.Windows.Forms.Label lblMovieSynopsisTitle;
        private System.Windows.Forms.Panel panel1;
        private UserControls.Buttons.OKButton btnOK;
    }
}