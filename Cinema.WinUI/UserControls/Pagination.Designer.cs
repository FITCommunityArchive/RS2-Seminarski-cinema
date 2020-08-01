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
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnPreviousPage = new System.Windows.Forms.Button();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.btnCurrentPage = new System.Windows.Forms.Button();
            this.btnTotalPages = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNextPage
            // 
            this.btnNextPage.BackColor = System.Drawing.Color.White;
            this.btnNextPage.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPage.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextPage.Location = new System.Drawing.Point(140, 0);
            this.btnNextPage.Margin = new System.Windows.Forms.Padding(0);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(35, 35);
            this.btnNextPage.TabIndex = 17;
            this.btnNextPage.Text = ">";
            this.btnNextPage.UseVisualStyleBackColor = false;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.BackColor = System.Drawing.Color.White;
            this.btnPreviousPage.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnPreviousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviousPage.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousPage.Location = new System.Drawing.Point(35, 0);
            this.btnPreviousPage.Margin = new System.Windows.Forms.Padding(0);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(35, 35);
            this.btnPreviousPage.TabIndex = 16;
            this.btnPreviousPage.Text = "<";
            this.btnPreviousPage.UseVisualStyleBackColor = false;
            this.btnPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);
            // 
            // btnLastPage
            // 
            this.btnLastPage.BackColor = System.Drawing.Color.White;
            this.btnLastPage.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnLastPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastPage.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLastPage.Location = new System.Drawing.Point(175, 0);
            this.btnLastPage.Margin = new System.Windows.Forms.Padding(0);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(35, 35);
            this.btnLastPage.TabIndex = 15;
            this.btnLastPage.Text = ">>";
            this.btnLastPage.UseVisualStyleBackColor = false;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.BackColor = System.Drawing.Color.White;
            this.btnFirstPage.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnFirstPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirstPage.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirstPage.Location = new System.Drawing.Point(0, 0);
            this.btnFirstPage.Margin = new System.Windows.Forms.Padding(0);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(35, 35);
            this.btnFirstPage.TabIndex = 14;
            this.btnFirstPage.Text = "<<";
            this.btnFirstPage.UseVisualStyleBackColor = false;
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // btnCurrentPage
            // 
            this.btnCurrentPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(75)))));
            this.btnCurrentPage.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCurrentPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrentPage.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurrentPage.ForeColor = System.Drawing.Color.White;
            this.btnCurrentPage.Location = new System.Drawing.Point(70, 0);
            this.btnCurrentPage.Margin = new System.Windows.Forms.Padding(0);
            this.btnCurrentPage.Name = "btnCurrentPage";
            this.btnCurrentPage.Size = new System.Drawing.Size(35, 35);
            this.btnCurrentPage.TabIndex = 18;
            this.btnCurrentPage.Text = "1";
            this.btnCurrentPage.UseVisualStyleBackColor = false;
            this.btnCurrentPage.Click += new System.EventHandler(this.btnCurrentPage_Click);
            // 
            // btnTotalPages
            // 
            this.btnTotalPages.BackColor = System.Drawing.Color.White;
            this.btnTotalPages.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnTotalPages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotalPages.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalPages.Location = new System.Drawing.Point(105, 0);
            this.btnTotalPages.Margin = new System.Windows.Forms.Padding(0);
            this.btnTotalPages.Name = "btnTotalPages";
            this.btnTotalPages.Size = new System.Drawing.Size(35, 35);
            this.btnTotalPages.TabIndex = 19;
            this.btnTotalPages.Text = "1";
            this.btnTotalPages.UseVisualStyleBackColor = false;
            this.btnTotalPages.Click += new System.EventHandler(this.btnTotalPages_Click);
            // 
            // Pagination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTotalPages);
            this.Controls.Add(this.btnCurrentPage);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btnPreviousPage);
            this.Controls.Add(this.btnLastPage);
            this.Controls.Add(this.btnFirstPage);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Pagination";
            this.Size = new System.Drawing.Size(210, 35);
            this.Load += new System.EventHandler(this.Pagination_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnPreviousPage;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Button btnFirstPage;
        private System.Windows.Forms.Button btnCurrentPage;
        private System.Windows.Forms.Button btnTotalPages;
    }
}
