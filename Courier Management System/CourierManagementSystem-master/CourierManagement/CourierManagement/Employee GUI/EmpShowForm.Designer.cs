﻿namespace CourierManagement
{
    partial class EmpShowForm
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
            this.label14 = new System.Windows.Forms.Label();
            this.lblServiceHistory = new System.Windows.Forms.Label();
            this.lblEditProfile = new System.Windows.Forms.Label();
            this.panelEmployeeShow = new System.Windows.Forms.Panel();
            this.txtSearchBy = new System.Windows.Forms.TextBox();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.DataGridViewShow = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.lblLogout = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblProfile = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panelEmployeeShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewShow)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.DimGray;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Cyan;
            this.label14.Location = new System.Drawing.Point(13, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 20);
            this.label14.TabIndex = 54;
            this.label14.Text = "Courier Service";
            // 
            // lblServiceHistory
            // 
            this.lblServiceHistory.AutoSize = true;
            this.lblServiceHistory.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblServiceHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblServiceHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceHistory.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblServiceHistory.Image = global::CourierManagement.Properties.Resources.service_history;
            this.lblServiceHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblServiceHistory.Location = new System.Drawing.Point(11, 286);
            this.lblServiceHistory.Name = "lblServiceHistory";
            this.lblServiceHistory.Size = new System.Drawing.Size(167, 29);
            this.lblServiceHistory.TabIndex = 52;
            this.lblServiceHistory.Text = "     Ser. History";
            this.lblServiceHistory.Click += new System.EventHandler(this.lblServiceHistory_Click);
            this.lblServiceHistory.MouseEnter += new System.EventHandler(this.lblServiceHistory_MouseEnter);
            this.lblServiceHistory.MouseLeave += new System.EventHandler(this.lblServiceHistory_MouseLeave);
            // 
            // lblEditProfile
            // 
            this.lblEditProfile.AutoSize = true;
            this.lblEditProfile.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblEditProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEditProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditProfile.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblEditProfile.Image = global::CourierManagement.Properties.Resources.edit_profile1;
            this.lblEditProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEditProfile.Location = new System.Drawing.Point(11, 317);
            this.lblEditProfile.Name = "lblEditProfile";
            this.lblEditProfile.Size = new System.Drawing.Size(167, 29);
            this.lblEditProfile.TabIndex = 51;
            this.lblEditProfile.Text = "     Edit Profile ";
            this.lblEditProfile.Click += new System.EventHandler(this.lblEditProfile_Click);
            this.lblEditProfile.MouseEnter += new System.EventHandler(this.lblEditProfile_MouseEnter);
            this.lblEditProfile.MouseLeave += new System.EventHandler(this.lblEditProfile_MouseLeave);
            // 
            // panelEmployeeShow
            // 
            this.panelEmployeeShow.BackColor = System.Drawing.SystemColors.Menu;
            this.panelEmployeeShow.Controls.Add(this.txtSearchBy);
            this.panelEmployeeShow.Controls.Add(this.cmbPosition);
            this.panelEmployeeShow.Controls.Add(this.lblSearch);
            this.panelEmployeeShow.Controls.Add(this.DataGridViewShow);
            this.panelEmployeeShow.Controls.Add(this.label12);
            this.panelEmployeeShow.Location = new System.Drawing.Point(184, 49);
            this.panelEmployeeShow.Name = "panelEmployeeShow";
            this.panelEmployeeShow.Size = new System.Drawing.Size(469, 393);
            this.panelEmployeeShow.TabIndex = 50;
            // 
            // txtSearchBy
            // 
            this.txtSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBy.Location = new System.Drawing.Point(244, 32);
            this.txtSearchBy.Name = "txtSearchBy";
            this.txtSearchBy.Size = new System.Drawing.Size(193, 26);
            this.txtSearchBy.TabIndex = 13;
            this.txtSearchBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchBy_KeyPress);
            // 
            // cmbPosition
            // 
            this.cmbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(107, 32);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(121, 28);
            this.cmbPosition.TabIndex = 12;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(28, 35);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(73, 17);
            this.lblSearch.TabIndex = 11;
            this.lblSearch.Text = "Search By";
            // 
            // DataGridViewShow
            // 
            this.DataGridViewShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewShow.Location = new System.Drawing.Point(3, 75);
            this.DataGridViewShow.Name = "DataGridViewShow";
            this.DataGridViewShow.Size = new System.Drawing.Size(463, 315);
            this.DataGridViewShow.TabIndex = 6;
            this.DataGridViewShow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewShow_CellContentClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Purple;
            this.label12.Location = new System.Drawing.Point(199, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 16);
            this.label12.TabIndex = 5;
            this.label12.Text = "Show From";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.BackColor = System.Drawing.Color.DarkTurquoise;
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.ForeColor = System.Drawing.Color.DarkGreen;
            this.UserName.Location = new System.Drawing.Point(63, 195);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(55, 20);
            this.UserName.TabIndex = 49;
            this.UserName.Text = "Name";
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblLogout.Image = global::CourierManagement.Properties.Resources.logOut1;
            this.lblLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLogout.Location = new System.Drawing.Point(13, 348);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(165, 29);
            this.lblLogout.TabIndex = 47;
            this.lblLogout.Text = "         Logout    ";
            this.lblLogout.Click += new System.EventHandler(this.lblLogout_Click);
            this.lblLogout.MouseEnter += new System.EventHandler(this.lblLogout_MouseEnter);
            this.lblLogout.MouseLeave += new System.EventHandler(this.lblLogout_MouseLeave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 110F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Image = global::CourierManagement.Properties.Resources.user;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Location = new System.Drawing.Point(18, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 166);
            this.label7.TabIndex = 46;
            this.label7.Text = "  ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.MenuText;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(328, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 25);
            this.label6.TabIndex = 45;
            this.label6.Text = "Employee Form";
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfile.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblProfile.Image = global::CourierManagement.Properties.Resources.profile_det1;
            this.lblProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblProfile.Location = new System.Drawing.Point(11, 255);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(167, 29);
            this.lblProfile.TabIndex = 44;
            this.lblProfile.Text = "          Profile    ";
            this.lblProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProfile.Click += new System.EventHandler(this.lblProfile_Click);
            this.lblProfile.MouseEnter += new System.EventHandler(this.lblProfile_MouseEnter);
            this.lblProfile.MouseLeave += new System.EventHandler(this.lblProfile_MouseLeave);
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblHome.Image = global::CourierManagement.Properties.Resources.home1;
            this.lblHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHome.Location = new System.Drawing.Point(10, 224);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(168, 29);
            this.lblHome.TabIndex = 43;
            this.lblHome.Text = "         Home      ";
            this.lblHome.Click += new System.EventHandler(this.lblHome_Click);
            this.lblHome.MouseEnter += new System.EventHandler(this.lblHome_MouseEnter);
            this.lblHome.MouseLeave += new System.EventHandler(this.lblHome_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(15, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 29);
            this.label1.TabIndex = 55;
            this.label1.Text = "                         ";
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
            this.label9.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Cornsilk;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(15, 410);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 29);
            this.label9.TabIndex = 88;
            this.label9.Text = "                         ";
            // 
            // EmpShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(662, 453);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblMinimize);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblServiceHistory);
            this.Controls.Add(this.lblEditProfile);
            this.Controls.Add(this.panelEmployeeShow);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.lblLogout);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblProfile);
            this.Controls.Add(this.lblHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmpShowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmpViewCust_SerHistory";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmpViewCust_SerHistory_FormClosed);
            this.Load += new System.EventHandler(this.EmpShowForm_Load);
            this.panelEmployeeShow.ResumeLayout(false);
            this.panelEmployeeShow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblServiceHistory;
        private System.Windows.Forms.Label lblEditProfile;
        private System.Windows.Forms.Panel panelEmployeeShow;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.DataGridView DataGridViewShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSearchBy;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.Label lblSearch;
    }
}