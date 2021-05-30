using CourierManagement.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourierManagement
{
    public partial class EmpAddCust : Form
    {
        string[] mail = { "@gmail.com", "@yahoo.com", "@hotmail.com", "@mail.com", "@outlook.com" };
        string[] phone = { "017", "014", "013", "015", "019", "018", "016", "011" };
        DataAccess dataAccess = new DataAccess();
        DataTable usersTable;
        public EmpAddCust(DataTable usersTable)
        {
            InitializeComponent();
            this.usersTable = usersTable;
            lblHome.BackColor = Color.Black;
            UserName.Text = usersTable.Rows[0].Field<string>("UserName");
            // label4.Image = CourierManagement.Properties.Resources.Undo;
        }

        private void EmpAddCust_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            LoginForm logout = new LoginForm();
            logout.Show();
            this.Hide();
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            EmpHomeForm home = new EmpHomeForm(usersTable);
            home.Show();
            this.Hide();
        }

        private void lblProfile_Click(object sender, EventArgs e)
        {
            EmpProfile profile = new EmpProfile(usersTable);
            profile.Show();
            this.Hide();
        }

        private void lblServiceHistory_Click(object sender, EventArgs e)
        {
            string sql = $"select * from Product where Sending_Manager_id = '{usersTable.Rows[0].Field<int>("Id")}' or Receiving_Manager_id = '{usersTable.Rows[0].Field<int>("Id")}'";
            DataTable productTable = dataAccess.Execute(sql);

            EmpShowForm es = new EmpShowForm(usersTable, productTable, (int)Entities.Show.EmployeeShow.serviceHistory);
            es.Show();
            this.Hide();
        }

        private void lblEditProfile_Click(object sender, EventArgs e)
        {
            EmpEditForm edit = new EmpEditForm(usersTable);
            edit.Show();
            this.Hide();
        }

        private void lblProfile_MouseEnter(object sender, EventArgs e)
        {
            lblProfile.BackColor = Color.Black;
        }

        private void lblServiceHistory_MouseEnter(object sender, EventArgs e)
        {
            lblServiceHistory.BackColor = Color.Black;
        }

        private void lblEditProfile_MouseEnter(object sender, EventArgs e)
        {
            lblEditProfile.BackColor = Color.Black;
        }


        private void lblLogout_MouseEnter(object sender, EventArgs e)
        {
            lblLogout.BackColor = Color.Black;
        }

        private void lblProfile_MouseLeave(object sender, EventArgs e)
        {
            lblProfile.BackColor = Color.DeepSkyBlue;
        }

        private void lblServiceHistory_MouseLeave(object sender, EventArgs e)
        {
            lblServiceHistory.BackColor = Color.DeepSkyBlue;
        }

        private void lblEditProfile_MouseLeave(object sender, EventArgs e)
        {
            lblEditProfile.BackColor = Color.DeepSkyBlue;
        }


        private void lblLogout_MouseLeave(object sender, EventArgs e)
        {
            lblLogout.BackColor = Color.DeepSkyBlue;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            addNewCustomer();
        }

        private bool isUnique()
        {
            DataTable userTable;
            userTable = dataAccess.GetData<Users>($"where UserName = '{txtUsername.Text}' or EmailAddress = '{txtEmail.Text}'");
            if (userTable.Rows.Count > 0)
            {
                if (userTable.Rows[0].Field<string>("UserName").Equals(txtUsername.Text))
                {
                    errorProvider1.SetError(txtUsername, "User Name already taken!!!");
                    txtUsername.Focus();
                    return false;
                }
                else if (userTable.Rows[0].Field<string>("EmailAddress").Equals(txtEmail.Text))
                {
                    errorProvider1.SetError(txtEmail, "Email Already Used!!!");
                    txtEmail.Focus();
                    return false;
                }
            }
            return true;
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
            int validPassLength = 8;
            if (!txtPassword.Text.Equals(txtRePassword.Text))
            {
                errorProvider1.SetError(txtPassword, "Password doesn't match");
                errorProvider1.SetError(txtRePassword, "Password doesn't match");
                return false;
            }
            else if (txtPassword.Text.Length < validPassLength)
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
                UserName = txtUsername.Text,
                Password = txtPassword.Text,
                EmailAddress = txtEmail.Text,
                Information_given = true,
                UserType = (int)Users.UserTypeEnum.Customer,
                UpdatedDate = DateTime.Now
            };
            return users;
        }

        private Customers setCustomers(DataTable userTable)
        {
            Customers customer = new Customers()
            {
                User_Id = userTable.Rows[0].Field<int>("Id"),
                Address = txtAddress.Text,
                Contact = txtContact.Text,
                Name = txtName.Text,
                Sequrity_Que = txtSecurityQue.Text,
                UpdatedDate = DateTime.Now,
                Is_verified = true

            };
            return customer;
        }

        private void addNewCustomer()
        {
            if (isAllValid())
            {
                Users users = setUsers();
                
                int affectedRowCount = dataAccess.Insert<Users>(users, true);

                DataTable userTable = dataAccess.GetData<Users>($"where UserName = '{txtUsername.Text}' and Password = '{txtPassword.Text}'");
                if (affectedRowCount > 0)
                {

                    Customers customer = setCustomers(userTable);

                    affectedRowCount = dataAccess.Insert<Customers>(customer, true);

                    if (affectedRowCount > 0)
                    {
                        MessageBox.Show("New Customer Added successfully");
                        LoginForm lf = new LoginForm();
                        lf.Show();
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

        private bool isEmpty()
        {
            List<Control> controls = new List<Control>(this.panelEmployeeAddCustomer.Controls.Cast<Control>()).OrderBy(c => c.TabIndex).ToList<Control>();
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
                return false; ;
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

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtUsername.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
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
                addNewCustomer();
                e.SuppressKeyPress = true;
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.SetError(txtName, "");
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.SetError(txtUsername, "");
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
