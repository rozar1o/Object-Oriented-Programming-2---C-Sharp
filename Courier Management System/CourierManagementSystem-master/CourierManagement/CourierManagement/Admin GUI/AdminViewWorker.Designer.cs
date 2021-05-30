namespace CourierManagement.Admin_GUI
{
    partial class AdminViewWorker
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
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblAllBranch = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.lblBack = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblIcon = new System.Windows.Forms.Label();
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.lblBonus = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.cmbDesignation = new System.Windows.Forms.ComboBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblBranch = new System.Windows.Forms.Label();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblUserName1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLogout = new System.Windows.Forms.Label();
            this.lblUserIcon = new System.Windows.Forms.Label();
            this.lblFormName = new System.Windows.Forms.Label();
            this.lblAddBranch = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.BackColor = System.Drawing.Color.DimGray;
            this.lblAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.ForeColor = System.Drawing.Color.Cyan;
            this.lblAppName.Location = new System.Drawing.Point(13, 11);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(131, 20);
            this.lblAppName.TabIndex = 78;
            this.lblAppName.Text = "Courier Service";
            // 
            // lblAllBranch
            // 
            this.lblAllBranch.AutoSize = true;
            this.lblAllBranch.BackColor = System.Drawing.Color.DimGray;
            this.lblAllBranch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAllBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllBranch.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblAllBranch.Image = global::CourierManagement.Properties.Resources.branch1;
            this.lblAllBranch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAllBranch.Location = new System.Drawing.Point(15, 286);
            this.lblAllBranch.Name = "lblAllBranch";
            this.lblAllBranch.Size = new System.Drawing.Size(163, 29);
            this.lblAllBranch.TabIndex = 77;
            this.lblAllBranch.Text = "      All Branch ";
            this.lblAllBranch.Click += new System.EventHandler(this.lblAllBranch_Click);
            this.lblAllBranch.MouseEnter += new System.EventHandler(this.lblAllBranch_MouseEnter);
            this.lblAllBranch.MouseLeave += new System.EventHandler(this.lblAllBranch_MouseLeave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.DimGray;
            this.label11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Cornsilk;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Location = new System.Drawing.Point(9, 348);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 29);
            this.label11.TabIndex = 76;
            this.label11.Text = "                          ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.btnDeleteAccount);
            this.panel1.Controls.Add(this.lblBack);
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblIcon);
            this.panel1.Controls.Add(this.txtBonus);
            this.panel1.Controls.Add(this.lblBonus);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.cmbBranch);
            this.panel1.Controls.Add(this.cmbDesignation);
            this.panel1.Controls.Add(this.txtSalary);
            this.panel1.Controls.Add(this.lblBranch);
            this.panel1.Controls.Add(this.lblDesignation);
            this.panel1.Controls.Add(this.lblSalary);
            this.panel1.Location = new System.Drawing.Point(184, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 393);
            this.panel1.TabIndex = 74;
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.BackColor = System.Drawing.Color.Red;
            this.btnDeleteAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAccount.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnDeleteAccount.Location = new System.Drawing.Point(167, 353);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(201, 28);
            this.btnDeleteAccount.TabIndex = 80;
            this.btnDeleteAccount.Text = "Delete Account";
            this.btnDeleteAccount.UseVisualStyleBackColor = false;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.BackColor = System.Drawing.Color.SeaGreen;
            this.lblBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBack.Image = global::CourierManagement.Properties.Resources.back_arrow;
            this.lblBack.Location = new System.Drawing.Point(3, 3);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(37, 29);
            this.lblBack.TabIndex = 79;
            this.lblBack.Text = "    ";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.SeaGreen;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lblUserName.Location = new System.Drawing.Point(164, 111);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(51, 20);
            this.lblUserName.TabIndex = 44;
            this.lblUserName.Text = "Name";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.SeaGreen;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lblName.Location = new System.Drawing.Point(97, 114);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 43;
            this.lblName.Text = "Name";
            // 
            // lblIcon
            // 
            this.lblIcon.AutoSize = true;
            this.lblIcon.BackColor = System.Drawing.Color.SeaGreen;
            this.lblIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIcon.Image = global::CourierManagement.Properties.Resources.userlogin;
            this.lblIcon.Location = new System.Drawing.Point(174, 3);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(123, 91);
            this.lblIcon.TabIndex = 42;
            this.lblIcon.Text = "    ";
            // 
            // txtBonus
            // 
            this.txtBonus.BackColor = System.Drawing.Color.CadetBlue;
            this.txtBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBonus.Location = new System.Drawing.Point(165, 281);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(202, 26);
            this.txtBonus.TabIndex = 41;
            // 
            // lblBonus
            // 
            this.lblBonus.AutoSize = true;
            this.lblBonus.BackColor = System.Drawing.Color.SeaGreen;
            this.lblBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBonus.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lblBonus.Location = new System.Drawing.Point(93, 287);
            this.lblBonus.Name = "lblBonus";
            this.lblBonus.Size = new System.Drawing.Size(53, 17);
            this.lblBonus.TabIndex = 40;
            this.lblBonus.Text = "Bonus";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnUpdate.Location = new System.Drawing.Point(166, 320);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(201, 28);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbBranch
            // 
            this.cmbBranch.BackColor = System.Drawing.Color.CadetBlue;
            this.cmbBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(165, 237);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(202, 28);
            this.cmbBranch.TabIndex = 11;
            // 
            // cmbDesignation
            // 
            this.cmbDesignation.BackColor = System.Drawing.Color.CadetBlue;
            this.cmbDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDesignation.FormattingEnabled = true;
            this.cmbDesignation.Items.AddRange(new object[] {
            "Manager",
            "Worker",
            "Driver",
            "Delivery_boy"});
            this.cmbDesignation.Location = new System.Drawing.Point(165, 194);
            this.cmbDesignation.Name = "cmbDesignation";
            this.cmbDesignation.Size = new System.Drawing.Size(202, 28);
            this.cmbDesignation.TabIndex = 10;
            // 
            // txtSalary
            // 
            this.txtSalary.BackColor = System.Drawing.Color.CadetBlue;
            this.txtSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(166, 153);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(202, 26);
            this.txtSalary.TabIndex = 9;
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.BackColor = System.Drawing.Color.SeaGreen;
            this.lblBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBranch.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lblBranch.Location = new System.Drawing.Point(87, 243);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(59, 17);
            this.lblBranch.TabIndex = 5;
            this.lblBranch.Text = "Branch";
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.BackColor = System.Drawing.Color.SeaGreen;
            this.lblDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesignation.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lblDesignation.Location = new System.Drawing.Point(52, 200);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(94, 17);
            this.lblDesignation.TabIndex = 4;
            this.lblDesignation.Text = "Designation";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.BackColor = System.Drawing.Color.SeaGreen;
            this.lblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lblSalary.Location = new System.Drawing.Point(92, 159);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(54, 17);
            this.lblSalary.TabIndex = 3;
            this.lblSalary.Text = "Salary";
            // 
            // lblUserName1
            // 
            this.lblUserName1.AutoSize = true;
            this.lblUserName1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblUserName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblUserName1.Location = new System.Drawing.Point(63, 190);
            this.lblUserName1.Name = "lblUserName1";
            this.lblUserName1.Size = new System.Drawing.Size(55, 20);
            this.lblUserName1.TabIndex = 73;
            this.lblUserName1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(9, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 29);
            this.label3.TabIndex = 75;
            this.label3.Text = "                          ";
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.BackColor = System.Drawing.Color.DimGray;
            this.lblLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblLogout.Image = global::CourierManagement.Properties.Resources.logOut11;
            this.lblLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLogout.Location = new System.Drawing.Point(13, 317);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(165, 29);
            this.lblLogout.TabIndex = 71;
            this.lblLogout.Text = "         Logout    ";
            this.lblLogout.Click += new System.EventHandler(this.lblLogout_Click);
            this.lblLogout.MouseEnter += new System.EventHandler(this.lblLogout_MouseEnter);
            this.lblLogout.MouseLeave += new System.EventHandler(this.lblLogout_MouseLeave);
            // 
            // lblUserIcon
            // 
            this.lblUserIcon.AutoSize = true;
            this.lblUserIcon.BackColor = System.Drawing.Color.Honeydew;
            this.lblUserIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUserIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 110F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserIcon.Image = global::CourierManagement.Properties.Resources.admin_p1;
            this.lblUserIcon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblUserIcon.Location = new System.Drawing.Point(18, 49);
            this.lblUserIcon.Name = "lblUserIcon";
            this.lblUserIcon.Size = new System.Drawing.Size(148, 166);
            this.lblUserIcon.TabIndex = 70;
            this.lblUserIcon.Text = "  ";
            // 
            // lblFormName
            // 
            this.lblFormName.AutoSize = true;
            this.lblFormName.BackColor = System.Drawing.SystemColors.MenuText;
            this.lblFormName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblFormName.Location = new System.Drawing.Point(328, 11);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(137, 25);
            this.lblFormName.TabIndex = 69;
            this.lblFormName.Text = "Admin Form";
            // 
            // lblAddBranch
            // 
            this.lblAddBranch.AutoSize = true;
            this.lblAddBranch.BackColor = System.Drawing.Color.DimGray;
            this.lblAddBranch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAddBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddBranch.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblAddBranch.Image = global::CourierManagement.Properties.Resources.add_Branch;
            this.lblAddBranch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAddBranch.Location = new System.Drawing.Point(11, 255);
            this.lblAddBranch.Name = "lblAddBranch";
            this.lblAddBranch.Size = new System.Drawing.Size(167, 29);
            this.lblAddBranch.TabIndex = 68;
            this.lblAddBranch.Text = "     Add Branch";
            this.lblAddBranch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAddBranch.Click += new System.EventHandler(this.lblAddBranch_Click);
            this.lblAddBranch.MouseEnter += new System.EventHandler(this.lblAddBranch_MouseEnter);
            this.lblAddBranch.MouseLeave += new System.EventHandler(this.lblAddBranch_MouseLeave);
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.BackColor = System.Drawing.Color.DimGray;
            this.lblHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblHome.Image = global::CourierManagement.Properties.Resources.home1;
            this.lblHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHome.Location = new System.Drawing.Point(10, 224);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(168, 29);
            this.lblHome.TabIndex = 67;
            this.lblHome.Text = "         Home      ";
            this.lblHome.Click += new System.EventHandler(this.lblHome_Click);
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DimGray;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Cornsilk;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(9, 410);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 29);
            this.label9.TabIndex = 88;
            this.label9.Text = "                          ";
            // 
            // AdminViewWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(662, 453);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblMinimize);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblAppName);
            this.Controls.Add(this.lblAllBranch);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblUserName1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblLogout);
            this.Controls.Add(this.lblUserIcon);
            this.Controls.Add(this.lblFormName);
            this.Controls.Add(this.lblAddBranch);
            this.Controls.Add(this.lblHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminViewWorker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminViewWorker";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminViewWorker_FormClosed);
            this.Load += new System.EventHandler(this.AdminViewWorker_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblAllBranch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.ComboBox cmbDesignation;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblUserName1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Label lblUserIcon;
        private System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.Label lblAddBranch;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.TextBox txtBonus;
        private System.Windows.Forms.Label lblBonus;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label label9;
    }
}