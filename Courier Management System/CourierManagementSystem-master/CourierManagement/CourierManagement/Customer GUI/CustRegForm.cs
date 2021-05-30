using CourierManagement.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourierManagement
{
    public partial class CustRegForm : Form
    {
        string[] mail = { "@gmail.com", "@yahoo.com", "@hotmail.com", "@mail.com","@outlook.com" };
        string[] phone = { "017", "014", "013", "015", "019", "018", "016", "011" };
        DataAccess dataAccess = new DataAccess();
        public CustRegForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            register();
        }

        private bool isUnique()
        {
            DataTable usersTable;
            usersTable = dataAccess.GetData<Users>($"where UserName = '{txtUserName.Text}' or EmailAddress = '{txtEmail.Text}'");
            if (usersTable.Rows.Count > 0)
            {
                if (usersTable.Rows[0].Field<string>("UserName").Equals(txtUserName.Text))
                {
                    errorProvider1.SetError(txtUserName, "User Name already taken!!!");
                    txtUserName.Focus();
                    return false;
                }
                else if (usersTable.Rows[0].Field<string>("EmailAddress").Equals(txtEmail.Text))
                {
                    errorProvider1.SetError(txtEmail, "Email Already Used!!!");
                    txtEmail.Focus();
                    return false;
                }
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
                register();
                e.SuppressKeyPress = true;
            }
        }

        private bool isValid()
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
            int validPasswordLength = 8;
            if (!txtPassword.Text.Equals(txtRePassword.Text))
            {
                errorProvider1.SetError(txtPassword, "Password doesn't match");
                errorProvider1.SetError(txtRePassword, "Password doesn't match");
                return false;
            }
            else if (txtPassword.Text.Length < validPasswordLength)
            {
                errorProvider1.SetError(txtPassword, "Password must be at least 8 word");
                errorProvider1.SetError(txtRePassword, "Password must be at least 8 word");
                return false;
            }
            return true;
        }

        private bool isAllValid()
        {
            return isUnique() && isEmpty() && isValid() && isValidPassword();
        }

        private Users setUsers()
        {
            Users users = new Users()
            {
                UserName = txtUserName.Text,
                Password = txtPassword.Text,
                EmailAddress = txtEmail.Text,
                Information_given = true,
                UserType = (int)Users.UserTypeEnum.Customer,
                UpdatedDate = DateTime.Now
            };
            return users;
        }

        private Customers setCustomers(DataTable UsersTable)
        {
            Customers customer = new Customers()
            {
                User_Id = UsersTable.Rows[0].Field<int>("Id"),
                Address = txtAddress.Text,
                Contact = txtContact.Text,
                Name = txtName.Text,
                Sequrity_Que = txtSecurityQue.Text,
                UpdatedDate = DateTime.Now,
                Is_verified = false

            };
            return customer;
        }
        private void register()
        {
            if (isAllValid())
            {
                Users users = setUsers();
                int affectedRowCount = dataAccess.Insert<Users>(users, true);
                DataTable UsersTable = dataAccess.GetData<Users>($"where UserName = '{txtUserName.Text}' and Password = '{txtPassword.Text}'");
                if (affectedRowCount > 0)
                {
                    Customers customer = setCustomers(UsersTable);
                    affectedRowCount = dataAccess.Insert<Customers>(customer, true);

                    if (affectedRowCount > 0)
                    {
                        MessageBox.Show("Registration successful");
                        MessageBox.Show("Please wait for the verification!!");
                        LoginForm LoginForm = new LoginForm();
                        LoginForm.Show();
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

        private void CustRegForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.SetError(txtName, "");
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.SetError(txtUserName, "");
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.SetError(txtPassword, "");
        }

        private void txtRePassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.SetError(txtRePassword, "");
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.SetError(txtContact, "");
            if (!(char.IsNumber(e.KeyChar) || (e.KeyChar == (char)8)))
            {
                e.Handled = true;
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.SetError(txtEmail, "");
        }

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.SetError(txtAddress, "");
        }

        private void txtSecurityQue_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.SetError(txtSecurityQue, "");
        }

        private void txtSecurityQue_Enter(object sender, EventArgs e)
        {
            if (txtSecurityQue.Text.Equals("Who is your favourite person?"))
            {
                txtSecurityQue.Text = "";
                txtSecurityQue.ForeColor = Color.Black;
            }
        }

        private void txtSecurityQue_Leave(object sender, EventArgs e)
        {
            if (txtSecurityQue.Text.Equals(""))
            {
                txtSecurityQue.Text = "Who is your favourite person?";
                txtSecurityQue.ForeColor = Color.Gray;
            }
        }

        private void lblUserName_MouseClick(object sender, MouseEventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        private void lblLogin_MouseClick(object sender, MouseEventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
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
    }
}
