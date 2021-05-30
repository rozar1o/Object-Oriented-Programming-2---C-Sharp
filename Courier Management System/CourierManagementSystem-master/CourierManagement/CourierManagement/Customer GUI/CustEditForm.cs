using CourierManagement.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CourierManagement
{
    public partial class CustEditForm : Form
    {
        string[] mail = { "@gmail.com", "@yahoo.com", "@hotmail.com", "@mail.com", "@outlook.com" };
        string[] phone = { "017", "014", "013", "015", "019", "018", "016", "011" };
        DataTable userTable,customerTable;
        DataAccess dataAccess = new DataAccess();
        public CustEditForm(DataTable userTable)
        {
            InitializeComponent();
            this.userTable = userTable;
            lblEditProfile.BackColor = Color.Blue;
            lbluName.Text = userTable.Rows[0].Field<string>("UserName");
        }

        private void CustEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label25_Click(object sender, EventArgs e)
        {
            LoginForm logout = new LoginForm();
            logout.Show();
            this.Hide();
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            CustHomeForm custHome = new CustHomeForm(userTable);
            custHome.Show();
            this.Hide();
        }

        private void lblTrackOrder_Click(object sender, EventArgs e)
        {
            CustTrackForm custTrack = new CustTrackForm(userTable);
            custTrack.Show();
            this.Hide();
        }

        private void lblSerHistory_Click(object sender, EventArgs e)
        {
            CustSerForm custserForm = new CustSerForm(userTable);
            custserForm.Show();
            this.Hide();
        }

        private void lblHome_MouseEnter(object sender, EventArgs e)
        {
            lblHome.BackColor = Color.Blue;
        }

        private void lblHome_MouseLeave(object sender, EventArgs e)
        {
            lblHome.BackColor = Color.FromArgb(0,0,64);
        }

        private void lblTrackOrder_MouseEnter(object sender, EventArgs e)
        {
            lblTrackOrder.BackColor = Color.Blue;
        }

        private void lblSerHistory_MouseEnter(object sender, EventArgs e)
        {
            lblSerHistory.BackColor = Color.Blue;
        }

        private void lblDeleteAcc_MouseEnter(object sender, EventArgs e)
        {
            lblDeleteAcc.BackColor = Color.Blue;
        }

        private void label25_MouseEnter(object sender, EventArgs e)
        {
            label25.BackColor = Color.Blue;
        }

        private void lblTrackOrder_MouseLeave(object sender, EventArgs e)
        {
            lblTrackOrder.BackColor = Color.FromArgb(0, 0, 64);
        }

        private void lblSerHistory_MouseLeave(object sender, EventArgs e)
        {
            lblSerHistory.BackColor = Color.FromArgb(0, 0, 64);
        }


        private void lblDeleteAcc_MouseLeave(object sender, EventArgs e)
        {
            lblDeleteAcc.BackColor = Color.FromArgb(0, 0, 64);
        }

        private void label25_MouseLeave(object sender, EventArgs e)
        {
            label25.BackColor = Color.FromArgb(0, 0, 64);
        }

        private void fillTable()
        {
            customerTable = dataAccess.GetData<Customers>($"where User_id = '{userTable.Rows[0].Field<int>("Id")}'");
            if (customerTable.Rows.Count > 0)
            {
                txtName.Text = customerTable.Rows[0].Field<string>("Name");
                txtUserName.Text = userTable.Rows[0].Field<string>("UserName");
                txtContact.Text = customerTable.Rows[0].Field<string>("Contact");
                txtAddress.Text = customerTable.Rows[0].Field<string>("Address");
                txtRePassword.Text = userTable.Rows[0].Field<string>("Password");
                txtPassword.Text = userTable.Rows[0].Field<string>("Password");
                txtEmail.Text = userTable.Rows[0].Field<string>("EmailAddress");
                txtSecurityQue.Text = customerTable.Rows[0].Field<string>("Sequrity_Que");
            }
        }

        private void CustEditForm_Load(object sender, EventArgs e)
        {
            fillTable();
        }

        private Users setUsers()
        {
            Users users = new Users()
            {
                Id = userTable.Rows[0].Field<int>("Id"),
                UserName = txtUserName.Text,
                Password = txtRePassword.Text,
                EmailAddress = txtEmail.Text,
                Information_given = true,
                UserType = (int)Users.UserTypeEnum.Customer,
                UpdatedDate = userTable.Rows[0].Field<DateTime>("UpdatedDate")
            };
            return users;
        }


        private Customers setCustomers()
        {
            Customers customer = new Customers()
            {
                Id = customerTable.Rows[0].Field<int>("Id"),
                User_Id = this.userTable.Rows[0].Field<int>("Id"),
                Address = txtAddress.Text,
                Contact = txtContact.Text,
                Name = txtName.Text,
                Sequrity_Que = txtSecurityQue.Text,
                UpdatedDate = customerTable.Rows[0].Field<DateTime>("UpdatedDate"),
                Is_verified = true

            };
            return customer;
        }
        private void edit()
        {
            if (isChecked())
            {
                Users users = setUsers();

                int affectedRowCount = dataAccess.Insert<Users>(users, true);

                DataTable userTable = dataAccess.GetData<Users>($"where UserName = '{txtUserName.Text}' and Password = '{txtRePassword.Text}'");
                if (affectedRowCount > 0)
                {
                    Customers customer = setCustomers();

                    affectedRowCount = dataAccess.Insert<Customers>(customer, true);

                    if (affectedRowCount > 0)
                    {
                        MessageBox.Show("Profile Edited Successfull");
                        CustHomeForm customerHome = new CustHomeForm(this.userTable);
                        customerHome.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Unable to save.");
                    }
                }
                else
                {
                    MessageBox.Show("Unable to save.");
                }

            }
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            edit();
        }

        private bool isUnique()
        {
            //yet to develop
            return true;
        }

        private bool isValidate()
        {
            int phoneValidLength = 11;
            if (isvalidphone())
            {
                errorProvider1.SetError(txtContact, "This is not a valid contact number!!!");
                return false;
            }
            else if (txtContact.Text.Length < phoneValidLength)
            {
                errorProvider1.SetError(txtContact, "There must be 11 number in your phone!!!");
                return false;
            }
            else if (txtContact.Text.Length > phoneValidLength)
            {
                errorProvider1.SetError(txtContact, "There must be 11 number in your phone!!!");
                return false;
            }
            else if (isValidEmail())
            {
                errorProvider1.SetError(txtEmail, "This is not a valid Email address!!!");
                return false;
            }

            return true;
        }

        private bool isvalidphone()
        {
            foreach (string p in phone)
            {
                if (txtContact.Text.StartsWith(p))
                {
                    return false;
                }
            }
            return true;
        }

        private bool isValidEmail()
        {
            foreach (string e in mail)
            {
                if (txtEmail.Text.EndsWith(e))
                {
                    return false;
                }
            }
            return true;
        }

        private bool isValidPassword()
        {
            if (!txtRePassword.Text.Equals(txtPassword.Text))
            {
                errorProvider1.SetError(txtRePassword, "Password doesn't match");
                errorProvider1.SetError(txtPassword, "Password doesn't match");
                return false;
            }
            else if (txtRePassword.Text.Length < 8)
            {
                errorProvider1.SetError(txtRePassword, "Password must be at least 8 word");
                errorProvider1.SetError(txtPassword, "Password must be at least 8 word");
                return false;
            }
            return true;
        }

        private bool isChecked()
        {
            return isUnique() && isEmpty() && isValidate() && isValidPassword();
        }

        private bool isEmpty()
        {
            List<Control> controls = new List<Control>(this.panel1.Controls.Cast<Control>()).OrderBy(c => c.TabIndex).ToList<Control>();
            foreach (var control in controls)
            {
                if (control is TextBox)
                {
                    bool flag = EmptyValidationTextBox(errorProvider1, control as TextBox);

                    if (flag == true)
                    {
                        return false;
                    }
                }
            }
            if (txtSecurityQue.Text.Equals("Who is your favourite person?"))
            {
                errorProvider1.SetError(txtSecurityQue, "This field should be left blank!!");
                return false;
            }
            return true;
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtUserName.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtRePassword.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtRePassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtContact.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtContact_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmail.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAddress.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSecurityQue.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtSecurityQue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                edit();
            }
        }
        private void lblEye1_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar)
            {
                txtPassword.UseSystemPasswordChar = false;
                lblEye1.Image = CourierManagement.Properties.Resources.Undo;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                lblEye1.Image = CourierManagement.Properties.Resources.Redo;
            }
        }
        private void lblEye2_Click(object sender, EventArgs e)
        {
            if (txtRePassword.UseSystemPasswordChar)
            {
                txtRePassword.UseSystemPasswordChar = false;
                lblEye2.Image = CourierManagement.Properties.Resources.Undo;
            }
            else
            {
                txtRePassword.UseSystemPasswordChar = true;
                lblEye2.Image = CourierManagement.Properties.Resources.Redo;
            }
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Action_According_Dialog_Result(DialogResult dialogResult)
        {
            if (dialogResult == DialogResult.Yes)
            {
                string id = userTable.Rows[0].Field<int>("Id").ToString();
                int rowsAffected = dataAccess.Delete("Customers", "User_Id", id);
                if (rowsAffected > 0)
                {
                    rowsAffected = dataAccess.Delete("Users", "Id", id);
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Account Deleted Successfully");
                        LoginForm lf = new LoginForm();
                        lf.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Something Went Wrong!!!");
                    }
                }
                else
                {
                    MessageBox.Show("Something Went Wrong!!!");
                }
            }
        }

        private void lblDeleteAcc_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you Want to Delete the Customer Account?", "Account deleting", MessageBoxButtons.YesNo);

            Action_According_Dialog_Result(dialogResult);
        }

        private bool EmptyValidationTextBox(ErrorProvider errorProvider, TextBox textbox)
        {
            if (textbox.Text.Trim().Length == 0)
            {
                textbox.Focus();
                errorProvider.SetError(textbox, "This field should not be left blank!!");
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
