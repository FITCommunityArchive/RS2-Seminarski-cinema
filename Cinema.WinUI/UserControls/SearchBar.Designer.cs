namespace Cinema.WinUI.UserControls
{
    partial class SearchBar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrTxtSearchBar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ctrTxtSearchBar
            // 
            this.ctrTxtSearchBar.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrTxtSearchBar.Location = new System.Drawing.Point(23, 22);
            this.ctrTxtSearchBar.Name = "ctrTxtSearchBar";
            this.ctrTxtSearchBar.Size = new System.Drawing.Size(354, 23);
            this.ctrTxtSearchBar.TabIndex = 0;
            this.ctrTxtSearchBar.Text = "Search";
            this.ctrTxtSearchBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ctrTxtSearchBar_KeyDown);
            // 
            // SearchBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ctrTxtSearchBar);
            this.Name = "SearchBar";
            this.Size = new System.Drawing.Size(421, 80);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ctrTxtSearchBar;
    }
}
