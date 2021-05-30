using CourierManagement.Entities;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CourierManagement
{
    public partial class PassChange : Form
    {
        DataAccess dataAccess = new DataAccess();
        public PassChange()
        {
            InitializeComponent();
            lblSequrityQueIcon.Image = CourierManagement.Properties.Resources.help;
            btnChangePassword.Text = "Verify";
            btnChangePassword.Location = new Point(388, 245);
        }

        private bool isPasswordValid()
        {
            int validPassLength = 8;
            if (!txtPassword.Text.Equals(txtSequrityQue.Text))
            {
                errorProvider1.SetError(txtSequrityQue, "Password doesn't match");
                errorProvider1.SetError(txtPassword, "Password doesn't match");
                return false;
            }
            else if (txtPassword.Text.Length < validPassLength)
            {
                errorProvider1.SetError(txtSequrityQue, "Password must be at least 8 word");
                errorProvider1.SetError(txtPassword, "Password must be at least 8 word");
                return false;
            }
            return true;
        }

        private void verify()
        {
            DataTable userTable = dataAccess.GetData<Users>($"where UserName = '{txtUserName.Text}'");
            if (userTable.Rows.Count > 0)
            {
                if(userTable.Rows[0].Field<int>("UserType") == (int)Users.UserTypeEnum.Customer)
                {
                    DataTable customerTable = dataAccess.GetData<Customers>($"where User_Id = '{userTable.Rows[0].Field<int>("Id")}' and Sequrity_Que = '{txtSequrityQue.Text}'");
                    if (customerTable.Rows.Count > 0)
                    {
                        txtUserName.Focus();
                        txtSequrityQue.Text = "New Password!!!";
                        txtSequrityQue.ForeColor = Color.Gray;

                        txtPassword.Text = "Repeat New Password!!!";
                        txtPassword.ForeColor = Color.Gray;

                        MessageBox.Show("Verified");
                        lblSequrityQueIcon.Image = CourierManagement.Properties.Resources.Pass1;
                        btnChangePassword.Location = new Point(388, 298);
                        btnChangePassword.Text = "Changed Password";
                        lblPasswordIcon.Visible = true;
                        txtPassword.Visible = true;
                        lblEye_2.Visible = true;
                        lblEye_1.Visible = true;
                    }
                    else
                    {
                        errorProvider1.SetError(txtUserName, "User Name Maybe wrong");
                        errorProvider1.SetError(txtSequrityQue, "Sequrity Que ans maybe Wrong");
                        MessageBox.Show("User Name or Sequrity Que ans is not Correct!!!");
                        LoginForm loginForm = new LoginForm();
                        loginForm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("You can't Chnage your Password In this way\nAsk the Admin about it");
                }
            }
        }

        private Users setUsers()
        {
            DataTable UserTable = dataAccess.GetData<Users>($"where UserName = '{txtUserName.Text}'");
            Users user = new Users()
            {
                Id = UserTable.Rows[0].Field<int>("Id"),
                EmailAddress = UserTable.Rows[0].Field<string>("EmailAddress"),
                UpdatedDate= UserTable.Rows[0].Field<DateTime>("UpdatedDate"),
                Information_given = UserTable.Rows[0].Field<bool>("Information_given"),
                UserName = UserTable.Rows[0].Field<string>("UserName"),
                UserType = UserTable.Rows[0].Field<int>("UserType"),
                Password = txtSequrityQue.Text
            };
            return user;
        }

        private void changePassword()
        {
            if (isPasswordValid())
            {
                Users user = setUsers();
                int rowsAffected = dataAccess.Insert<Users>(user, true);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Password changed Successfully");
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Something Went Wrong!!!");
                }
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (btnChangePassword.Text.Equals("Verify"))
            {
                verify();
            }
            else
            {
                changePassword();
            }
        }

        private void PassChange_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                txtSequrityQue.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtSequrityQue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (btnChangePassword.Text.Equals("Verify"))
                {
                    verify();
                }
                else
                {
                    txtPassword.Focus();
                    txtPassword.Text = "";
                }
                
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                changePassword();
                e.SuppressKeyPress = true;
            }
        }

        private void txtSequrityQue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (lblEye_1.Visible)
            {
                txtSequrityQue.UseSystemPasswordChar = true;
                txtSequrityQue.ForeColor = Color.Black;
                errorProvider1.SetError(txtSequrityQue, "");
            }
            else
            {
                txtSequrityQue.ForeColor = Color.Black;
                errorProvider1.SetError(txtSequrityQue, "");
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.ForeColor = Color.Black;
            errorProvider1.SetError(txtPassword, "");
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            LoginForm logout = new LoginForm();
            logout.Show();
            this.Hide();
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text.Equals("Username"))
            {
                txtUserName.Text = "";
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text.Equals(""))
            {
                txtUserName.Text = "Username";
                txtUserName.ForeColor = Color.Gray;
            }
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtUserName.ForeColor = Color.Black;
            errorProvider1.SetError(txtUserName, "");
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void txtSequrityQue_Enter(object sender, EventArgs e)
        {
            if (txtSequrityQue.Text.Equals("Sequrity Question") || txtSequrityQue.Text.Equals("New Password!!!"))
            {
                txtSequrityQue.Text = "";
            }
        }

        private void txtSequrityQue_Leave(object sender, EventArgs e)
        {
            if (txtSequrityQue.Text.Equals(""))
            {
                txtSequrityQue.Text = "Sequrity Question";
                txtSequrityQue.ForeColor = Color.Gray;
            }
            
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtSequrityQue.Text.Equals("Repeat New Password!!!"))
            {
                txtSequrityQue.Text = "";
            }
            
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtSequrityQue.Text.Equals(""))
            {
                txtSequrityQue.Text = "Repeat New Password!!!";
                txtSequrityQue.ForeColor = Color.Gray;
            }
        }
    }
}
