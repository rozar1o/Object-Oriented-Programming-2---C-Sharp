namespace CourierManagement
{
    partial class CustOrderForm
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblCustomerForm = new System.Windows.Forms.Label();
            this.lblDeleteAcc = new System.Windows.Forms.Label();
            this.lblSerHistory = new System.Windows.Forms.Label();
            this.lblEditProfile = new System.Windows.Forms.Label();
            this.lblLogout = new System.Windows.Forms.Label();
            this.lblTrackOrder = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbBrach1 = new System.Windows.Forms.ComboBox();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.btnSubmitOrder = new System.Windows.Forms.Button();
            this.txtDesProduct = new System.Windows.Forms.TextBox();
            this.cmbSelectCategory = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblSelectItem = new System.Windows.Forms.Label();
            this.lblDestinationCustomer = new System.Windows.Forms.Label();
            this.lblNewOrderFrom = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.label14.TabIndex = 61;
            this.label14.Text = "Courier Service";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblUserName.Location = new System.Drawing.Point(63, 180);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(55, 20);
            this.lblUserName.TabIndex = 59;
            this.lblUserName.Text = "Name";
            // 
            // lblCustomerForm
            // 
            this.lblCustomerForm.AutoSize = true;
            this.lblCustomerForm.BackColor = System.Drawing.Color.MediumAquamarine;
            this.lblCustomerForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerForm.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblCustomerForm.Location = new System.Drawing.Point(328, 11);
            this.lblCustomerForm.Name = "lblCustomerForm";
            this.lblCustomerForm.Size = new System.Drawing.Size(172, 25);
            this.lblCustomerForm.TabIndex = 57;
            this.lblCustomerForm.Text = "Customer Form";
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
            this.lblDeleteAcc.TabIndex = 68;
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
            this.lblSerHistory.TabIndex = 67;
            this.lblSerHistory.Text = "     Ser. History";
            this.lblSerHistory.Click += new System.EventHandler(this.lblSerHistory_Click);
            this.lblSerHistory.MouseEnter += new System.EventHandler(this.lblSerHistory_MouseEnter);
            this.lblSerHistory.MouseLeave += new System.EventHandler(this.lblSerHistory_MouseLeave);
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
            this.lblEditProfile.TabIndex = 66;
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
            this.lblLogout.TabIndex = 64;
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
            this.lblTrackOrder.TabIndex = 63;
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
            this.lblHome.TabIndex = 62;
            this.lblHome.Text = "         Home      ";
            this.lblHome.Click += new System.EventHandler(this.lblHome_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.BackgroundImage = global::CourierManagement.Properties.Resources.order;
            this.panel1.Controls.Add(this.cmbBrach1);
            this.panel1.Controls.Add(this.cmbBranch);
            this.panel1.Controls.Add(this.cmbSize);
            this.panel1.Controls.Add(this.cmbPaymentMethod);
            this.panel1.Controls.Add(this.btnSubmitOrder);
            this.panel1.Controls.Add(this.txtDesProduct);
            this.panel1.Controls.Add(this.cmbSelectCategory);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtContactNumber);
            this.panel1.Controls.Add(this.txtFullName);
            this.panel1.Controls.Add(this.lblSelectItem);
            this.panel1.Controls.Add(this.lblDestinationCustomer);
            this.panel1.Controls.Add(this.lblNewOrderFrom);
            this.panel1.Location = new System.Drawing.Point(184, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 393);
            this.panel1.TabIndex = 60;
            // 
            // cmbBrach1
            // 
            this.cmbBrach1.BackColor = System.Drawing.Color.Linen;
            this.cmbBrach1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBrach1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbBrach1.FormattingEnabled = true;
            this.cmbBrach1.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.cmbBrach1.Location = new System.Drawing.Point(67, 339);
            this.cmbBrach1.Name = "cmbBrach1";
            this.cmbBrach1.Size = new System.Drawing.Size(209, 28);
            this.cmbBrach1.TabIndex = 37;
            this.cmbBrach1.Text = "Branch";
            this.cmbBrach1.SelectedIndexChanged += new System.EventHandler(this.cmbBrach1_SelectedIndexChanged);
            // 
            // cmbBranch
            // 
            this.cmbBranch.BackColor = System.Drawing.Color.Linen;
            this.cmbBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBranch.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(282, 131);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(155, 28);
            this.cmbBranch.TabIndex = 36;
            this.cmbBranch.Text = "Branch";
            this.cmbBranch.SelectedIndexChanged += new System.EventHandler(this.cmbBranch_SelectedIndexChanged);
            // 
            // cmbSize
            // 
            this.cmbSize.BackColor = System.Drawing.Color.Linen;
            this.cmbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSize.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large",
            "Extra_Large"});
            this.cmbSize.Location = new System.Drawing.Point(67, 131);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(209, 28);
            this.cmbSize.TabIndex = 35;
            this.cmbSize.Text = "Size";
            this.cmbSize.SelectedIndexChanged += new System.EventHandler(this.cmbSize_SelectedIndexChanged);
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.BackColor = System.Drawing.Color.Linen;
            this.cmbPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaymentMethod.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Items.AddRange(new object[] {
            "Cash"});
            this.cmbPaymentMethod.Location = new System.Drawing.Point(282, 99);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(155, 28);
            this.cmbPaymentMethod.TabIndex = 32;
            this.cmbPaymentMethod.Text = "Payment Method";
            this.cmbPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.cmbPaymentMethod_SelectedIndexChanged);
            // 
            // btnSubmitOrder
            // 
            this.btnSubmitOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmitOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitOrder.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnSubmitOrder.Location = new System.Drawing.Point(308, 339);
            this.btnSubmitOrder.Name = "btnSubmitOrder";
            this.btnSubmitOrder.Size = new System.Drawing.Size(129, 28);
            this.btnSubmitOrder.TabIndex = 31;
            this.btnSubmitOrder.Text = "Submit Order";
            this.btnSubmitOrder.UseVisualStyleBackColor = true;
            this.btnSubmitOrder.Click += new System.EventHandler(this.btnSubmitOrder_Click);
            // 
            // txtDesProduct
            // 
            this.txtDesProduct.BackColor = System.Drawing.Color.Linen;
            this.txtDesProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesProduct.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtDesProduct.Location = new System.Drawing.Point(282, 65);
            this.txtDesProduct.Name = "txtDesProduct";
            this.txtDesProduct.Size = new System.Drawing.Size(155, 26);
            this.txtDesProduct.TabIndex = 29;
            this.txtDesProduct.Text = "Describe the Product";
            this.txtDesProduct.Enter += new System.EventHandler(this.txtDesProduct_Enter);
            this.txtDesProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDesProduct_KeyDown);
            this.txtDesProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesProduct_KeyPress);
            this.txtDesProduct.Leave += new System.EventHandler(this.txtDesProduct_Leave);
            // 
            // cmbSelectCategory
            // 
            this.cmbSelectCategory.BackColor = System.Drawing.Color.Linen;
            this.cmbSelectCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectCategory.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbSelectCategory.FormattingEnabled = true;
            this.cmbSelectCategory.Items.AddRange(new object[] {
            "Document",
            "Package",
            "Accessories",
            "Electronics",
            "Groceries",
            "Others"});
            this.cmbSelectCategory.Location = new System.Drawing.Point(67, 65);
            this.cmbSelectCategory.Name = "cmbSelectCategory";
            this.cmbSelectCategory.Size = new System.Drawing.Size(209, 28);
            this.cmbSelectCategory.TabIndex = 28;
            this.cmbSelectCategory.Text = "Select Category";
            this.cmbSelectCategory.SelectedIndexChanged += new System.EventHandler(this.cmbSelectCategory_SelectedIndexChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.Linen;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtAddress.Location = new System.Drawing.Point(67, 307);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(209, 26);
            this.txtAddress.TabIndex = 23;
            this.txtAddress.Text = "Address";
            this.txtAddress.Enter += new System.EventHandler(this.txtAddress_Enter);
            this.txtAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAddress_KeyDown);
            this.txtAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddress_KeyPress);
            this.txtAddress.Leave += new System.EventHandler(this.txtAddress_Leave);
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.Linen;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtQuantity.Location = new System.Drawing.Point(67, 99);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(209, 26);
            this.txtQuantity.TabIndex = 22;
            this.txtQuantity.Text = "Quantity";
            this.txtQuantity.Enter += new System.EventHandler(this.txtQuantity_Enter);
            this.txtQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyDown);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            this.txtQuantity.Leave += new System.EventHandler(this.txtQuantity_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Linen;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtEmail.Location = new System.Drawing.Point(67, 275);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(209, 26);
            this.txtEmail.TabIndex = 20;
            this.txtEmail.Text = "Email*";
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.BackColor = System.Drawing.Color.Linen;
            this.txtContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNumber.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtContactNumber.Location = new System.Drawing.Point(67, 243);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(209, 26);
            this.txtContactNumber.TabIndex = 19;
            this.txtContactNumber.Text = "Contact Number";
            this.txtContactNumber.Enter += new System.EventHandler(this.txtContactNumber_Enter);
            this.txtContactNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContactNumber_KeyDown);
            this.txtContactNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContactNumber_KeyPress);
            this.txtContactNumber.Leave += new System.EventHandler(this.txtContactNumber_Leave);
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.Color.Linen;
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtFullName.Location = new System.Drawing.Point(67, 211);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(209, 26);
            this.txtFullName.TabIndex = 18;
            this.txtFullName.Text = "Full Name";
            this.txtFullName.Enter += new System.EventHandler(this.txtFullName_Enter);
            this.txtFullName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFullName_KeyDown);
            this.txtFullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFullName_KeyPress);
            this.txtFullName.Leave += new System.EventHandler(this.txtFullName_Leave);
            // 
            // lblSelectItem
            // 
            this.lblSelectItem.AutoSize = true;
            this.lblSelectItem.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSelectItem.Location = new System.Drawing.Point(68, 42);
            this.lblSelectItem.Name = "lblSelectItem";
            this.lblSelectItem.Size = new System.Drawing.Size(101, 20);
            this.lblSelectItem.TabIndex = 15;
            this.lblSelectItem.Text = "Select Item";
            // 
            // lblDestinationCustomer
            // 
            this.lblDestinationCustomer.AutoSize = true;
            this.lblDestinationCustomer.BackColor = System.Drawing.Color.Transparent;
            this.lblDestinationCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinationCustomer.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDestinationCustomer.Location = new System.Drawing.Point(68, 188);
            this.lblDestinationCustomer.Name = "lblDestinationCustomer";
            this.lblDestinationCustomer.Size = new System.Drawing.Size(183, 20);
            this.lblDestinationCustomer.TabIndex = 14;
            this.lblDestinationCustomer.Text = "Destination Customer";
            // 
            // lblNewOrderFrom
            // 
            this.lblNewOrderFrom.AutoSize = true;
            this.lblNewOrderFrom.BackColor = System.Drawing.Color.LightBlue;
            this.lblNewOrderFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewOrderFrom.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblNewOrderFrom.Location = new System.Drawing.Point(166, 11);
            this.lblNewOrderFrom.Name = "lblNewOrderFrom";
            this.lblNewOrderFrom.Size = new System.Drawing.Size(120, 16);
            this.lblNewOrderFrom.TabIndex = 5;
            this.lblNewOrderFrom.Text = "New Order From";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 110F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Image = global::CourierManagement.Properties.Resources.Customer_p1;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Location = new System.Drawing.Point(18, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 166);
            this.label7.TabIndex = 58;
            this.label7.Text = "  ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.label19.Location = new System.Drawing.Point(14, 413);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(163, 29);
            this.label19.TabIndex = 91;
            this.label19.Text = "                         ";
            // 
            // CustOrderForm
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
            this.Controls.Add(this.lblCustomerForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustNewDelForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustNewDelForm_FormClosed);
            this.Load += new System.EventHandler(this.CustOrderForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeleteAcc;
        private System.Windows.Forms.Label lblSerHistory;
        private System.Windows.Forms.Label lblEditProfile;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Label lblTrackOrder;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSelectItem;
        private System.Windows.Forms.Label lblDestinationCustomer;
        private System.Windows.Forms.Label lblNewOrderFrom;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCustomerForm;
        private System.Windows.Forms.ComboBox cmbSelectCategory;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtDesProduct;
        private System.Windows.Forms.Button btnSubmitOrder;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.ComboBox cmbBrach1;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label label19;
    }
}