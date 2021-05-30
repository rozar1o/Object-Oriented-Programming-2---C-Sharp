namespace CourierManagement
{
    partial class CustRegForm
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
            this.label14 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblUserIcon = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lblRePassword = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtRePassword = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtSecurityQue = new System.Windows.Forms.TextBox();
            this.lblSecurityQue = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEye2 = new System.Windows.Forms.Label();
            this.lblEye1 = new System.Windows.Forms.Label();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.DarkGray;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 20);
            this.label14.TabIndex = 30;
            this.label14.Text = "Courier Service";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblLogin.Location = new System.Drawing.Point(62, 179);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(53, 20);
            this.lblLogin.TabIndex = 25;
            this.lblLogin.Text = "Login";
            this.lblLogin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblLogin_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label6.Location = new System.Drawing.Point(328, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Customer Form";
            // 
            // lblUserIcon
            // 
            this.lblUserIcon.AutoSize = true;
            this.lblUserIcon.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblUserIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUserIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 110F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserIcon.Image = global::CourierManagement.Properties.Resources.Customer_p1;
            this.lblUserIcon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblUserIcon.Location = new System.Drawing.Point(18, 49);
            this.lblUserIcon.Name = "lblUserIcon";
            this.lblUserIcon.Size = new System.Drawing.Size(148, 166);
            this.lblUserIcon.TabIndex = 22;
            this.lblUserIcon.Text = "  ";
            this.lblUserIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblUserName_MouseClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.LightCyan;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(171, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(221, 26);
            this.txtName.TabIndex = 2;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.LightCyan;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(171, 81);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(221, 26);
            this.txtUserName.TabIndex = 3;
            this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);
            this.txtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserName_KeyPress);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Orange;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.DarkRed;
            this.btnRegister.Location = new System.Drawing.Point(171, 347);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(221, 32);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.LightBlue;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label12.Location = new System.Drawing.Point(168, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 16);
            this.label12.TabIndex = 5;
            this.label12.Text = "Registration From";
            // 
            // lblRePassword
            // 
            this.lblRePassword.AutoSize = true;
            this.lblRePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRePassword.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblRePassword.Location = new System.Drawing.Point(48, 163);
            this.lblRePassword.Name = "lblRePassword";
            this.lblRePassword.Size = new System.Drawing.Size(103, 17);
            this.lblRePassword.TabIndex = 6;
            this.lblRePassword.Text = "Re-Password";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbName.Location = new System.Drawing.Point(102, 49);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(49, 17);
            this.lbName.TabIndex = 7;
            this.lbName.Text = "Name";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbUserName.Location = new System.Drawing.Point(70, 87);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(81, 17);
            this.lbUserName.TabIndex = 8;
            this.lbUserName.Text = "Username";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblContact.Location = new System.Drawing.Point(88, 202);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(63, 17);
            this.lblContact.TabIndex = 9;
            this.lblContact.Text = "Contact";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblEmail.Location = new System.Drawing.Point(104, 240);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 17);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.LightCyan;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(171, 119);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(221, 26);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // txtRePassword
            // 
            this.txtRePassword.BackColor = System.Drawing.Color.LightCyan;
            this.txtRePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRePassword.Location = new System.Drawing.Point(171, 157);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.Size = new System.Drawing.Size(221, 26);
            this.txtRePassword.TabIndex = 12;
            this.txtRePassword.UseSystemPasswordChar = true;
            this.txtRePassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRePassword_KeyDown);
            this.txtRePassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRePassword_KeyPress);
            // 
            // txtContact
            // 
            this.txtContact.BackColor = System.Drawing.Color.LightCyan;
            this.txtContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(171, 196);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(221, 26);
            this.txtContact.TabIndex = 13;
            this.txtContact.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContact_KeyDown);
            this.txtContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContact_KeyPress);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblPassword.Location = new System.Drawing.Point(74, 125);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(77, 17);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "Password";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.LightCyan;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(171, 234);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(221, 26);
            this.txtEmail.TabIndex = 15;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.LightCyan;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(171, 272);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(221, 26);
            this.txtAddress.TabIndex = 16;
            this.txtAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAddress_KeyDown);
            this.txtAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddress_KeyPress);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblAddress.Location = new System.Drawing.Point(84, 278);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(67, 17);
            this.lblAddress.TabIndex = 17;
            this.lblAddress.Text = "Address";
            // 
            // txtSecurityQue
            // 
            this.txtSecurityQue.BackColor = System.Drawing.Color.LightCyan;
            this.txtSecurityQue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecurityQue.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtSecurityQue.Location = new System.Drawing.Point(171, 310);
            this.txtSecurityQue.Name = "txtSecurityQue";
            this.txtSecurityQue.Size = new System.Drawing.Size(221, 26);
            this.txtSecurityQue.TabIndex = 18;
            this.txtSecurityQue.Text = "Who is your favourite person?";
            this.txtSecurityQue.Enter += new System.EventHandler(this.txtSecurityQue_Enter);
            this.txtSecurityQue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSecurityQue_KeyDown);
            this.txtSecurityQue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSecurityQue_KeyPress);
            this.txtSecurityQue.Leave += new System.EventHandler(this.txtSecurityQue_Leave);
            // 
            // lblSecurityQue
            // 
            this.lblSecurityQue.AutoSize = true;
            this.lblSecurityQue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecurityQue.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblSecurityQue.Location = new System.Drawing.Point(49, 316);
            this.lblSecurityQue.Name = "lblSecurityQue";
            this.lblSecurityQue.Size = new System.Drawing.Size(102, 17);
            this.lblSecurityQue.TabIndex = 19;
            this.lblSecurityQue.Text = "Security Que";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.lblEye2);
            this.panel1.Controls.Add(this.lblEye1);
            this.panel1.Controls.Add(this.lblSecurityQue);
            this.panel1.Controls.Add(this.txtSecurityQue);
            this.panel1.Controls.Add(this.lblAddress);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.txtContact);
            this.panel1.Controls.Add(this.txtRePassword);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.lblContact);
            this.panel1.Controls.Add(this.lbUserName);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.lblRePassword);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Location = new System.Drawing.Point(184, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 393);
            this.panel1.TabIndex = 26;
            // 
            // lblEye2
            // 
            this.lblEye2.AutoSize = true;
            this.lblEye2.BackColor = System.Drawing.Color.LightCyan;
            this.lblEye2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEye2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEye2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblEye2.Image = global::CourierManagement.Properties.Resources.Redo;
            this.lblEye2.Location = new System.Drawing.Point(367, 158);
            this.lblEye2.Name = "lblEye2";
            this.lblEye2.Size = new System.Drawing.Size(24, 20);
            this.lblEye2.TabIndex = 76;
            this.lblEye2.Text = "   ";
            this.lblEye2.Click += new System.EventHandler(this.lblEye2_Click);
            // 
            // lblEye1
            // 
            this.lblEye1.AutoSize = true;
            this.lblEye1.BackColor = System.Drawing.Color.LightCyan;
            this.lblEye1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEye1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEye1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblEye1.Image = global::CourierManagement.Properties.Resources.Redo;
            this.lblEye1.Location = new System.Drawing.Point(367, 122);
            this.lblEye1.Name = "lblEye1";
            this.lblEye1.Size = new System.Drawing.Size(24, 20);
            this.lblEye1.TabIndex = 75;
            this.lblEye1.Text = "   ";
            this.lblEye1.Click += new System.EventHandler(this.lblEye1_Click);
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.BackColor = System.Drawing.Color.Transparent;
            this.lblMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMinimize.Image = global::CourierManagement.Properties.Resources.minimize2;
            this.lblMinimize.Location = new System.Drawing.Point(586, 9);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(31, 29);
            this.lblMinimize.TabIndex = 87;
            this.lblMinimize.Text = "   ";
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblClose.Image = global::CourierManagement.Properties.Resources.cross1;
            this.lblClose.Location = new System.Drawing.Point(622, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(31, 29);
            this.lblClose.TabIndex = 86;
            this.lblClose.Text = "   ";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // CustRegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(662, 453);
            this.Controls.Add(this.lblMinimize);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblUserIcon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustRegForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustRegForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustRegForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblUserIcon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSecurityQue;
        private System.Windows.Forms.TextBox txtSecurityQue;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtRePassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lblRePassword;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblEye2;
        private System.Windows.Forms.Label lblEye1;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblClose;
    }
}