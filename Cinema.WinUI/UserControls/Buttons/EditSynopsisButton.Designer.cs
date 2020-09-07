namespace Cinema.WinUI.UserControls.Buttons
{
    partial class EditSynopsisButton
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
            this.components = new System.ComponentModel.Container();
            this.btnEditSynopsis = new Cinema.WinUI.UserControls.ExtendedButton(this.components);
            this.SuspendLayout();
            // 
            // btnEditSynopsis
            // 
            this.btnEditSynopsis.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditSynopsis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(75)))));
            this.btnEditSynopsis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSynopsis.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSynopsis.ForeColor = System.Drawing.Color.White;
            this.btnEditSynopsis.Location = new System.Drawing.Point(0, 0);
            this.btnEditSynopsis.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditSynopsis.Name = "btnEditSynopsis";
            this.btnEditSynopsis.Size = new System.Drawing.Size(120, 40);
            this.btnEditSynopsis.TabIndex = 1;
            this.btnEditSynopsis.Text = "Synopsis";
            this.btnEditSynopsis.UseVisualStyleBackColor = false;
            this.btnEditSynopsis.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // EditSynopsisButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.btnEditSynopsis);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditSynopsisButton";
            this.Size = new System.Drawing.Size(120, 40);
            this.EnabledChanged += new System.EventHandler(this.EditButton_EnabledChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private ExtendedButton btnEditSynopsis;
    }
}
