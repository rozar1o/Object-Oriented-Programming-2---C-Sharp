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
    public partial class EmpEditForm : Form
    {
        DataTable usersTable;
        DataAccess dataAccess = new DataAccess();
        string[] phone = { "017", "014", "013", "015", "019", "018", "016", "011" };
        string[] mail = { "@gmail.com", "@yahoo.com", "@hotmail.com", "@mail.com", "@outlook.com" };

        public EmpEditForm(DataTable usersTable)
        {
            InitializeComponent();
            this.usersTable = usersTable;
            lblEditProfile.BackColor = Color.Black;
            UserName.Text = usersTable.Rows[0].Field<string>("UserName");
        }

        private void EmpEditForm_FormClosed(object sender, FormClosedEventArgs e)
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
            DataTable ProductsTable = dataAccess.Execute(sql);

            EmpShowForm es = new EmpShowForm(usersTable, ProductsTable, (int)Entities.Show.EmployeeShow.serviceHistory);
            es.Show();
            this.Hide();
        }
        private void lblHome_MouseEnter(object sender, EventArgs e)
        {
            lblHome.BackColor = Color.Black;
        }

        private void lblProfile_MouseEnter(object sender, EventArgs e)
        {
            lblProfile.BackColor = Color.Black;
        }

        private void lblServiceHistory_MouseEnter(object sender, EventArgs e)
        {
            lblServiceHistory.BackColor = Color.Black;
        }


        private void lblLogout_MouseEnter(object sender, EventArgs e)
        {
            lblLogout.BackColor = Color.Black;
        }

        private void lblHome_MouseLeave(object sender, EventArgs e)
        {
            lblHome.BackColor = Color.DeepSkyBlue;
        }

        private void lblProfile_MouseLeave(object sender, EventArgs e)
        {
            lblProfile.BackColor = Color.DeepSkyBlue;
        }

        private void lblServiceHistory_MouseLeave(object sender, EventArgs e)
        {
            lblServiceHistory.BackColor = Color.DeepSkyBlue;
        }


        private void lblLogout_MouseLeave(object sender, EventArgs e)
        {
            lblLogout.BackColor = Color.DeepSkyBlue;
        }

        private void fillLables()
        {
            DataTable EmployeeTable = dataAccess.GetData<Employee>($"where user_id = '{usersTable.Rows[0].Field<int>("Id")}'");

            txtName.Text = EmployeeTable.Rows[0].Field<string>("Name");
            dtpDateOfBirth.Value = EmployeeTable.Rows[0].Field<DateTime>("DOB");
            txtContact.Text = EmployeeTable.Rows[0].Field<string>("Contact");
            txtEducationalQualification.Text = EmployeeTable.Rows[0].Field<string>("Qualification");
            txtAddress.Text = EmployeeTable.Rows[0].Field<string>("Address");
            txtChangePassword.Text = usersTable.Rows[0].Field<string>("Password");
            txtRePassword.Text = usersTable.Rows[0].Field<string>("Password");
            txtEmail.Text = usersTable.Rows[0].Field<string>("EmailAddress");
            cmbBloodGroup.SelectedItem = EmployeeTable.Rows[0].Field<string>("Blood_Group");
        }

        private void EmpEditForm_Load(object sender, EventArgs e)
        {
            fillLables();
        }

        private bool isValidPassword()
        {
            int validPassLength = 8;
            if (!txtChangePassword.Text.Equals(txtRePassword.Text))
            {
                errorProvider1.SetError(txtChangePassword, "Password doesn't match");
                errorProvider1.SetError(txtRePassword, "Password doesn't match");
                return false;
            }
            else if (txtChangePassword.Text.Length < validPassLength)
            {
                errorProvider1.SetError(txtChangePassword, "Password must be at least 8 word");
                errorProvider1.SetError(txtRePassword, "Password must be at least 8 word");
                return false;
            }
            return true;
        }

        private bool isEmpty()
        {
            List<Control> controls = new List<Control>(this.Controls.Cast<Control>()).OrderBy(c => c.TabIndex).ToList<Control>();
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

        private Employee setEmployee()
        {
            DateTime dateOfBirth = this.dtpDateOfBirth.Value.Date;
            DataTable EmployeeTable = dataAccess.GetData<Employee>($"where User_id = '{usersTable.Rows[0].Field<int>("Id")}'");
            Employee employee = new Employee()
            {
                Id = EmployeeTable.Rows[0].Field<int>("Id"),
                Name = txtName.Text,
                DOB = dateOfBirth,
                Contact = txtContact.Text,
                Qualification = txtEducationalQualification.Text,
                Blood_Group = cmbBloodGroup.SelectedItem.ToString(),
                Address = txtAddress.Text,
                Bonus = float.Parse(EmployeeTable.Rows[0][4].ToString()),
                Branch_id = EmployeeTable.Rows[0].Field<int>("Branch_id"),
                Designation = EmployeeTable.Rows[0].Field<int>("Designation"),
                Joining_date = EmployeeTable.Rows[0].Field<DateTime>("Joining_date"),
                UpdatedDate = EmployeeTable.Rows[0].Field<DateTime>("UpdatedDate"),
                User_id = usersTable.Rows[0].Field<int>("Id"),
                Salary = float.Parse(EmployeeTable.Rows[0][3].ToString())
            };
            return employee;
        }

        private Users setUsers()
        {
            Users user = new Users()
            {
                Id = usersTable.Rows[0].Field<int>("Id"),
                Information_given = true,
                Password = txtChangePassword.Text,
                EmailAddress = usersTable.Rows[0].Field<string>("EmailAddress"),
                UpdatedDate = usersTable.Rows[0].Field<DateTime>("UpdatedDate"),
                UserName = usersTable.Rows[0].Field<string>("UserName"),
                UserType = usersTable.Rows[0].Field<int>("UserType")

            };
            return user;
        }

        private void editProfile()
        {
            
            if (isValidPassword() && isEmpty() && isvalidphone() && isValidEmail())
            {
                Employee employee = setEmployee();
                int rowsAffected = dataAccess.Insert<Employee>(employee, true);

                if (rowsAffected > 0)
                {
                    Users user = setUsers();

                    rowsAffected = dataAccess.Insert<Users>(user, true);
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Profile Edit Successfully");
                        EmpHomeForm home = new EmpHomeForm(usersTable);
                        home.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Something Went Wrong!!");
                    }
                }
            }
        }

        private bool isvalidphone()
        {
            foreach (string p in phone)
            {
                if (txtContact.Text.StartsWith(p))
                {
                    return true;
                }
            }
            return false;
        }

        private bool isValidEmail()
        {
            foreach (string e in mail)
            {
                if (txtEmail.Text.EndsWith(e))
                {
                    return true;
                }
            }
            return false;
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtpDateOfBirth.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void dtpDateOfBirth_KeyDown(object sender, KeyEventArgs e)
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
                txtEducationalQualification.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtEducationalQualification_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbBloodGroup.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void cmbBloodGroup_KeyDown(object sender, KeyEventArgs e)
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
                txtEmail.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtChangePassword.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtChangePassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtRePassword.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtRePassword_KeyDown(object sender, KeyEventArgs e)
        {
            editProfile();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            editProfile();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.SetError(txtName, "");
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.SetError(txtContact, "");
        }

        private void txtEducationalQualification_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.SetError(txtEducationalQualification, "");
        }

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.SetError(txtAddress, "");
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.SetError(txtEmail, "");
        }

        private void txtChangePassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.SetError(txtChangePassword, "");
        }

        private void txtRePassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.SetError(txtRePassword, "");
        }

        private void lblEye1_Click(object sender, EventArgs e)
        {
            if (txtChangePassword.UseSystemPasswordChar)
            {
                txtChangePassword.UseSystemPasswordChar = false;
                lblEye1.Image = CourierManagement.Properties.Resources.Undo;
            }
            else
            {
                txtChangePassword.UseSystemPasswordChar = true;
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
