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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMovieSynopsis));
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
            this.rtbSynopsisText.Location = new System.Drawing.Point(10, 80);
            this.rtbSynopsisText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbSynopsisText.Name = "rtbSynopsisText";
            this.rtbSynopsisText.Size = new System.Drawing.Size(583, 272);
            this.rtbSynopsisText.TabIndex = 0;
            this.rtbSynopsisText.Text = "";
            // 
            // lblMovieSynopsisTitle
            // 
            this.lblMovieSynopsisTitle.AutoSize = true;
            this.lblMovieSynopsisTitle.BackColor = System.Drawing.Color.White;
            this.lblMovieSynopsisTitle.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieSynopsisTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblMovieSynopsisTitle.Location = new System.Drawing.Point(9, 11);
            this.lblMovieSynopsisTitle.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblMovieSynopsisTitle.Name = "lblMovieSynopsisTitle";
            this.lblMovieSynopsisTitle.Padding = new System.Windows.Forms.Padding(7, 7, 7, 10);
            this.lblMovieSynopsisTitle.Size = new System.Drawing.Size(124, 40);
            this.lblMovieSynopsisTitle.TabIndex = 3;
            this.lblMovieSynopsisTitle.Text = "Movie info";
            this.lblMovieSynopsisTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblMovieSynopsisTitle);
            this.panel1.Location = new System.Drawing.Point(-2, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 52);
            this.panel1.TabIndex = 4;
            // 
            // btnOK
            // 
            this.btnOK.AutoSize = true;
            this.btnOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOK.Location = new System.Drawing.Point(472, 358);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 32);
            this.btnOK.TabIndex = 5;
            this.btnOK.ButtonClicked += new System.EventHandler(this.btnOK_Click);
            // 
            // FormMovieSynopsis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 410);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rtbSynopsisText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMovieSynopsis";
            this.Text = "eCinema - Movie Synopsis";
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