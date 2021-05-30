namespace CourierManagement
{
    partial class CustSerForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.grdShowData = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDeleteAcc = new System.Windows.Forms.Label();
            this.lblSerHistory = new System.Windows.Forms.Label();
            this.lblEditProfile = new System.Windows.Forms.Label();
            this.lblLogout = new System.Windows.Forms.Label();
            this.lblTrackOrder = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdShowData)).BeginInit();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.cmbSearch);
            this.panel1.Controls.Add(this.lblSearch);
            this.panel1.Controls.Add(this.grdShowData);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(184, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 393);
            this.panel1.TabIndex = 26;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(248, 36);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(196, 26);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // cmbSearch
            // 
            this.cmbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Items.AddRange(new object[] {
            "Reciever Name",
            "Receiver Phone"});
            this.cmbSearch.Location = new System.Drawing.Point(111, 36);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(121, 28);
            this.cmbSearch.TabIndex = 8;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(32, 37);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(73, 17);
            this.lblSearch.TabIndex = 7;
            this.lblSearch.Text = "Search By";
            // 
            // grdShowData
            // 
            this.grdShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdShowData.Location = new System.Drawing.Point(3, 83);
            this.grdShowData.Name = "grdShowData";
            this.grdShowData.Size = new System.Drawing.Size(463, 307);
            this.grdShowData.TabIndex = 6;
            this.grdShowData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdShowData_CellContentClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.LightBlue;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label12.Location = new System.Drawing.Point(161, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 16);
            this.label12.TabIndex = 5;
            this.label12.Text = "Service History From";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblUserName.Location = new System.Drawing.Point(62, 180);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(55, 20);
            this.lblUserName.TabIndex = 25;
            this.lblUserName.Text = "Name";
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
            // lblDeleteAcc
            // 
            this.lblDeleteAcc.AutoSize = true;
            this.lblDeleteAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblDeleteAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDeleteAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteAcc.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblDeleteAcc.Image = global::CourierManagement.Properties.Resources.delete;
            this.lblDeleteAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDeleteAcc.Location = new System.Drawing.Point(11, 351);
            this.lblDeleteAcc.Name = "lblDeleteAcc";
            this.lblDeleteAcc.Size = new System.Drawing.Size(165, 29);
            this.lblDeleteAcc.TabIndex = 56;
            this.lblDeleteAcc.Text = "     Delete Acc.";
            this.lblDeleteAcc.Click += new System.EventHandler(this.lblDeleteAcc_Click);
            this.lblDeleteAcc.MouseEnter += new System.EventHandler(this.lblDeleteAcc_MouseEnter);
            this.lblDeleteAcc.MouseLeave += new System.EventHandler(this.lblDeleteAcc_MouseLeave);
            // 
            // lblSerHistory
            // 
            this.lblSerHistory.AutoSize = true;
            this.lblSerHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblSerHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSerHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerHistory.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblSerHistory.Image = global::CourierManagement.Properties.Resources.service_history;
            this.lblSerHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSerHistory.Location = new System.Drawing.Point(10, 289);
            this.lblSerHistory.Name = "lblSerHistory";
            this.lblSerHistory.Size = new System.Drawing.Size(167, 29);
            this.lblSerHistory.TabIndex = 55;
            this.lblSerHistory.Text = "     Ser. History";
            // 
            // lblEditProfile
            // 
            this.lblEditProfile.AutoSize = true;
            this.lblEditProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblEditProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEditProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditProfile.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblEditProfile.Image = global::CourierManagement.Properties.Resources.edit_profile1;
            this.lblEditProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEditProfile.Location = new System.Drawing.Point(10, 320);
            this.lblEditProfile.Name = "lblEditProfile";
            this.lblEditProfile.Size = new System.Drawing.Size(167, 29);
            this.lblEditProfile.TabIndex = 54;
            this.lblEditProfile.Text = "     Edit Profile ";
            this.lblEditProfile.Click += new System.EventHandler(this.lblEditProfile_Click);
            this.lblEditProfile.MouseEnter += new System.EventHandler(this.lblEditProfile_MouseEnter);
            this.lblEditProfile.MouseLeave += new System.EventHandler(this.lblEditProfile_MouseLeave);
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblLogout.Image = global::CourierManagement.Properties.Resources.logOut1;
            this.lblLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLogout.Location = new System.Drawing.Point(11, 382);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(165, 29);
            this.lblLogout.TabIndex = 52;
            this.lblLogout.Text = "         Logout    ";
            this.lblLogout.Click += new System.EventHandler(this.lblLogout_Click);
            this.lblLogout.MouseEnter += new System.EventHandler(this.lblLogout_MouseEnter);
            this.lblLogout.MouseLeave += new System.EventHandler(this.lblLogout_MouseLeave);
            // 
            // lblTrackOrder
            // 
            this.lblTrackOrder.AutoSize = true;
            this.lblTrackOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTrackOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTrackOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackOrder.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblTrackOrder.Image = global::CourierManagement.Properties.Resources.tracking;
            this.lblTrackOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTrackOrder.Location = new System.Drawing.Point(10, 258);
            this.lblTrackOrder.Name = "lblTrackOrder";
            this.lblTrackOrder.Size = new System.Drawing.Size(167, 29);
            this.lblTrackOrder.TabIndex = 51;
            this.lblTrackOrder.Text = "    Track Order";
            this.lblTrackOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTrackOrder.Click += new System.EventHandler(this.lblTrackOrder_Click);
            this.lblTrackOrder.MouseEnter += new System.EventHandler(this.lblTrackOrder_MouseEnter);
            this.lblTrackOrder.MouseLeave += new System.EventHandler(this.lblTrackOrder_MouseLeave);
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblHome.Image = global::CourierManagement.Properties.Resources.home1;
            this.lblHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHome.Location = new System.Drawing.Point(9, 227);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(168, 29);
            this.lblHome.TabIndex = 50;
            this.lblHome.Text = "         Home      ";
            this.lblHome.Click += new System.EventHandler(this.lblHome_Click);
            this.lblHome.MouseEnter += new System.EventHandler(this.lblHome_MouseEnter);
            this.lblHome.MouseLeave += new System.EventHandler(this.lblHome_MouseLeave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 110F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Image = global::CourierManagement.Properties.Resources.Customer_p1;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Location = new System.Drawing.Point(18, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 166);
            this.label7.TabIndex = 22;
            this.label7.Text = "  ";
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
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Cornsilk;
            this.label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label19.Location = new System.Drawing.Point(13, 413);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(163, 29);
            this.label19.TabIndex = 91;
            this.label19.Text = "                         ";
            // 
            // CustSerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(662, 453);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lblMinimize);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblDeleteAcc);
            this.Controls.Add(this.lblSerHistory);
            this.Controls.Add(this.lblEditProfile);
            this.Controls.Add(this.lblLogout);
            this.Controls.Add(this.lblTrackOrder);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustSerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustSerForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustSerForm_FormClosed);
            this.Load += new System.EventHandler(this.CustSerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdShowData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView grdShowData;
        private System.Windows.Forms.Label lblDeleteAcc;
        private System.Windows.Forms.Label lblSerHistory;
        private System.Windows.Forms.Label lblEditProfile;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Label lblTrackOrder;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Label lblSearch;
    }
}