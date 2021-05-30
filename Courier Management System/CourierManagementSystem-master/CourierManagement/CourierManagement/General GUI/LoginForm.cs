using CourierManagement.Employee_GUI;
using CourierManagement.Entities;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CourierManagement
{
    public partial class LoginForm : Form
    {
        DataAccess dataAccess = new DataAccess();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            login();
        }

        bool isEmpty()
        {
            if ((txtUserName.Text.Equals("Username") && (txtPassword.Text.Equals("********")||txtPassword.Text.Equals(""))))
            {
                errorProvider1.SetError(txtUserName, "User Name is empty!!!");
                errorProvider1.SetError(txtPassword, "Password field is Emptyy!!");
                txtUserName.Focus();
                return false;
            }
            else if (txtUserName.Text.Equals("Username"))
            {
                errorProvider1.SetError(txtUserName, "User Name Left Emptyy!!");
                txtUserName.Focus();
                return false;
            }
            else if (txtPassword.Text.Equals("********") || txtPassword.Text.Equals(""))
            {
                errorProvider1.SetError(txtPassword, "Password field should not be blank!!");
                txtPassword.Focus();
                return false;
            }
            return true;
        }

        private void login()
        {
            if (isEmpty())
            {
                DataTable userTable;
                userTable = dataAccess.GetData<Users>($"where UserName = '{txtUserName.Text}' and Password = '{txtPassword.Text}'");

                if (userTable.Rows.Count > 0)
                {
                    if (userTable.Rows[0].Field<int>("UserType") == (int)Users.UserTypeEnum.Admin)
                    {
                        AdminHomeForm adminHome = new AdminHomeForm(userTable);
                        adminHome.Show();
                        this.Hide();
                    }
                    else if (userTable.Rows[0].Field<int>("UserType") == (int)Users.UserTypeEnum.Employee)
                    {
                        if (userTable.Rows[0].Field<bool>("Information_given"))
                        {
                            DataTable employeeTable = dataAccess.GetData<Employee>($"where User_id = '{userTable.Rows[0].Field<int>("id")}'");
                            if (employeeTable.Rows[0].Field<int>("Designation") == (int)Employee.DesignationEnum.Manager)
                            {
                                EmpHomeForm employeeHome = new EmpHomeForm(userTable);
                                employeeHome.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("You are not a manager So you can't Login to the home page!!!");
                            }
                        }
                        else
                        {
                            EmpRegistration employeeRegistration = new EmpRegistration(userTable);
                            employeeRegistration.Show();
                            this.Hide();
                        }
                    }
                    else if(userTable.Rows[0].Field<int>("UserType") == (int)Users.UserTypeEnum.Customer)
                    {
                        DataTable customerTable = dataAccess.GetData<Customers>($"where User_Id = '{userTable.Rows[0].Field<int>("Id")}'");
                        if (customerTable.Rows[0].Field<bool>("Is_verified"))
                        {
                            CustHomeForm customeerHome = new CustHomeForm(userTable);
                            customeerHome.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Please wait for verification");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("UserName or Password is not correct!!!");
                    errorProvider1.SetError(txtUserName, "User Name maybe wrong!!!");
                    errorProvider1.SetError(txtPassword, "Password Maybe wrong!!!");
                }
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
                
                login();
                e.SuppressKeyPress = true;
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text.Equals("Username"))
            {
                txtUserName.Text = "";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals("********"))
            {
                txtPassword.Text = "";
            }

        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if(txtUserName.Text.Equals(""))
            {
                txtUserName.Text = "Username";
                txtUserName.ForeColor = Color.Gray;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(""))
            {
                txtPassword.Text = "********";
                txtPassword.ForeColor = Color.Gray;
            }
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtUserName.ForeColor = Color.Black;
            errorProvider1.SetError(txtUserName, "");
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPassword.ForeColor = Color.Black;
            errorProvider1.SetError(txtPassword, "");
        }

        private void lblForgotPass_MouseEnter(object sender, EventArgs e)
        {
            lblForgotPass.ForeColor = Color.Red;
        }

        private void lblForgotPass_MouseLeave(object sender, EventArgs e)
        {
            lblForgotPass.ForeColor = Color.CornflowerBlue;
        }

        private void lblForgotPass_MouseClick(object sender, MouseEventArgs e)
        {
            PassChange passChange = new PassChange();
            passChange.Show();
            this.Hide();
        }

        private void lblRegister_MouseEnter(object sender, EventArgs e)
        {
            lblRegister.ForeColor = Color.Green;
        }

        private void lblRegister_MouseLeave(object sender, EventArgs e)
        {
            lblRegister.ForeColor = Color.CornflowerBlue;
        }

        private void lblRegister_MouseClick(object sender, MouseEventArgs e)
        {
            CustRegForm custRegister = new CustRegForm();
            custRegister.Show();
            this.Hide();
        }

        private void lblEye_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar)
            {
                txtPassword.UseSystemPasswordChar = false;
                lblEye.Image = CourierManagement.Properties.Resources.Undo;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                lblEye.Image = CourierManagement.Properties.Resources.Redo;
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            if(this.WindowState != FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }
    }
}
