namespace Cinema.WinUI.UserControls
{
    partial class Pagination
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
            this.rtxLastPage = new System.Windows.Forms.RichTextBox();
            this.rtxCurrentPage = new System.Windows.Forms.RichTextBox();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnPreviousPage = new System.Windows.Forms.Button();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxLastPage
            // 
            this.rtxLastPage.Location = new System.Drawing.Point(93, 2);
            this.rtxLastPage.Margin = new System.Windows.Forms.Padding(2);
            this.rtxLastPage.Name = "rtxLastPage";
            this.rtxLastPage.ReadOnly = true;
            this.rtxLastPage.Size = new System.Drawing.Size(26, 28);
            this.rtxLastPage.TabIndex = 19;
            this.rtxLastPage.Text = "1";
            // 
            // rtxCurrentPage
            // 
            this.rtxCurrentPage.Location = new System.Drawing.Point(63, 3);
            this.rtxCurrentPage.Margin = new System.Windows.Forms.Padding(2);
            this.rtxCurrentPage.Name = "rtxCurrentPage";
            this.rtxCurrentPage.ReadOnly = true;
            this.rtxCurrentPage.Size = new System.Drawing.Size(26, 28);
            this.rtxCurrentPage.TabIndex = 18;
            this.rtxCurrentPage.Text = "1";
            // 
            // btnNextPage
            // 
            this.btnNextPage.Location = new System.Drawing.Point(123, 2);
            this.btnNextPage.Margin = new System.Windows.Forms.Padding(2);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(30, 32);
            this.btnNextPage.TabIndex = 17;
            this.btnNextPage.Text = ">";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.Location = new System.Drawing.Point(33, 3);
            this.btnPreviousPage.Margin = new System.Windows.Forms.Padding(2);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(30, 32);
            this.btnPreviousPage.TabIndex = 16;
            this.btnPreviousPage.Text = "<";
            this.btnPreviousPage.UseVisualStyleBackColor = true;
            this.btnPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);
            // 
            // btnLastPage
            // 
            this.btnLastPage.Location = new System.Drawing.Point(153, 2);
            this.btnLastPage.Margin = new System.Windows.Forms.Padding(2);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(30, 32);
            this.btnLastPage.TabIndex = 15;
            this.btnLastPage.Text = ">>";
            this.btnLastPage.UseVisualStyleBackColor = true;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.Location = new System.Drawing.Point(3, 3);
            this.btnFirstPage.Margin = new System.Windows.Forms.Padding(2);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(30, 32);
            this.btnFirstPage.TabIndex = 14;
            this.btnFirstPage.Text = "<<";
            this.btnFirstPage.UseVisualStyleBackColor = true;
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // Pagination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtxLastPage);
            this.Controls.Add(this.rtxCurrentPage);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btnPreviousPage);
            this.Controls.Add(this.btnLastPage);
            this.Controls.Add(this.btnFirstPage);
            this.Name = "Pagination";
            this.Size = new System.Drawing.Size(185, 37);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxLastPage;
        private System.Windows.Forms.RichTextBox rtxCurrentPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnPreviousPage;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Button btnFirstPage;
    }
}
