namespace Cinema.WinUI.Users
{
    partial class FormUserDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserDetails));
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblErrors = new System.Windows.Forms.Label();
            this.gbRoles = new System.Windows.Forms.GroupBox();
            this.rbCustomer = new System.Windows.Forms.RadioButton();
            this.rbContentEditor = new System.Windows.Forms.RadioButton();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.btnDelete = new Cinema.WinUI.UserControls.Buttons.DeleteButton();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblPasswordConfirm = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.picLoading = new System.Windows.Forms.PictureBox();
            this.btnSaveChanges = new Cinema.WinUI.UserControls.Buttons.SaveChangesButton();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtFormTitle = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.gbRoles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsername.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(57, 66);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(232, 27);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Tag = "username";
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(54, 45);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(90, 18);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblErrors);
            this.panel1.Controls.Add(this.gbRoles);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.txtConfirmPassword);
            this.panel1.Controls.Add(this.lblPasswordConfirm);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.btnChangePassword);
            this.panel1.Controls.Add(this.picLoading);
            this.panel1.Controls.Add(this.btnSaveChanges);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.lblPhone);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.lblLastName);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Controls.Add(this.lblFirstName);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Location = new System.Drawing.Point(28, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 422);
            this.panel1.TabIndex = 2;
            // 
            // lblErrors
            // 
            this.lblErrors.AutoSize = true;
            this.lblErrors.Location = new System.Drawing.Point(54, 17);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(0, 13);
            this.lblErrors.TabIndex = 32;
            // 
            // gbRoles
            // 
            this.gbRoles.Controls.Add(this.rbCustomer);
            this.gbRoles.Controls.Add(this.rbContentEditor);
            this.gbRoles.Controls.Add(this.rbAdmin);
            this.gbRoles.Location = new System.Drawing.Point(613, 66);
            this.gbRoles.Name = "gbRoles";
            this.gbRoles.Size = new System.Drawing.Size(200, 100);
            this.gbRoles.TabIndex = 31;
            this.gbRoles.TabStop = false;
            this.gbRoles.Text = "Roles";
            // 
            // rbCustomer
            // 
            this.rbCustomer.AutoSize = true;
            this.rbCustomer.Location = new System.Drawing.Point(11, 69);
            this.rbCustomer.Name = "rbCustomer";
            this.rbCustomer.Size = new System.Drawing.Size(69, 17);
            this.rbCustomer.TabIndex = 32;
            this.rbCustomer.TabStop = true;
            this.rbCustomer.Tag = "-3";
            this.rbCustomer.Text = "Customer";
            this.rbCustomer.UseVisualStyleBackColor = true;
            // 
            // rbContentEditor
            // 
            this.rbContentEditor.AutoSize = true;
            this.rbContentEditor.Location = new System.Drawing.Point(11, 46);
            this.rbContentEditor.Name = "rbContentEditor";
            this.rbContentEditor.Size = new System.Drawing.Size(91, 17);
            this.rbContentEditor.TabIndex = 31;
            this.rbContentEditor.TabStop = true;
            this.rbContentEditor.Tag = "-2";
            this.rbContentEditor.Text = "Content editor";
            this.rbContentEditor.UseVisualStyleBackColor = true;
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Location = new System.Drawing.Point(11, 22);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(85, 17);
            this.rbAdmin.TabIndex = 30;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Tag = "-1";
            this.rbAdmin.Text = "Administrator";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Location = new System.Drawing.Point(723, 338);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 32);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.ButtonClicked += new System.EventHandler(this.btnDelete_ButtonClicked);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(335, 264);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(232, 27);
            this.txtConfirmPassword.TabIndex = 28;
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
            // 
            // lblPasswordConfirm
            // 
            this.lblPasswordConfirm.AutoSize = true;
            this.lblPasswordConfirm.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordConfirm.Location = new System.Drawing.Point(332, 243);
            this.lblPasswordConfirm.Name = "lblPasswordConfirm";
            this.lblPasswordConfirm.Size = new System.Drawing.Size(154, 18);
            this.lblPasswordConfirm.TabIndex = 29;
            this.lblPasswordConfirm.Text = "Confirm password";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(335, 198);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(232, 27);
            this.txtPassword.TabIndex = 26;
            this.txtPassword.Tag = "password";
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(332, 177);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(85, 18);
            this.lblPassword.TabIndex = 27;
            this.lblPassword.Text = "Password";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(335, 198);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(232, 27);
            this.btnChangePassword.TabIndex = 25;
            this.btnChangePassword.Text = "Change password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnChangePassword_MouseClick);
            // 
            // picLoading
            // 
            this.picLoading.Image = global::Cinema.WinUI.Properties.Resources.Spinner;
            this.picLoading.InitialImage = global::Cinema.WinUI.Properties.Resources.Spinner;
            this.picLoading.Location = new System.Drawing.Point(182, 321);
            this.picLoading.Name = "picLoading";
            this.picLoading.Size = new System.Drawing.Size(78, 72);
            this.picLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLoading.TabIndex = 23;
            this.picLoading.TabStop = false;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.AutoSize = true;
            this.btnSaveChanges.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveChanges.Location = new System.Drawing.Point(57, 338);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(90, 32);
            this.btnSaveChanges.TabIndex = 22;
            this.btnSaveChanges.ButtonClicked += new System.EventHandler(this.btnSaveChanges_ButtonClicked);
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPhone.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(57, 198);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(232, 27);
            this.txtPhone.TabIndex = 12;
            this.txtPhone.Tag = "phone";
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhoneNumber_Validating);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(54, 177);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(125, 18);
            this.lblPhone.TabIndex = 13;
            this.lblPhone.Text = "Phone number";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLastName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(335, 131);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(232, 27);
            this.txtLastName.TabIndex = 10;
            this.txtLastName.Tag = "lastName";
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLastName_Validating);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(332, 110);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(94, 18);
            this.lblLastName.TabIndex = 11;
            this.lblLastName.Text = "Last name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFirstName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(57, 131);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(232, 27);
            this.txtFirstName.TabIndex = 8;
            this.txtFirstName.Tag = "firstName";
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(54, 110);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(95, 18);
            this.lblFirstName.TabIndex = 9;
            this.lblFirstName.Text = "First name";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(335, 66);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(232, 27);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.Tag = "email";
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(332, 45);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 18);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
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
            this.txtFormTitle.Size = new System.Drawing.Size(149, 27);
            this.txtFormTitle.TabIndex = 1;
            this.txtFormTitle.Text = "Add new user";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.txtFormTitle);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(961, 73);
            this.panel4.TabIndex = 5;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // FormUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 556);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUserDetails";
            this.Text = "eCinema - User details";
            this.Load += new System.EventHandler(this.FormUserDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbRoles.ResumeLayout(false);
            this.gbRoles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFormTitle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private UserControls.Buttons.SaveChangesButton btnSaveChanges;
        private System.Windows.Forms.PictureBox picLoading;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblPasswordConfirm;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private UserControls.Buttons.DeleteButton btnDelete;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.GroupBox gbRoles;
        private System.Windows.Forms.RadioButton rbCustomer;
        private System.Windows.Forms.RadioButton rbContentEditor;
        private System.Windows.Forms.Label lblErrors;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}