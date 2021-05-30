
using CourierManagement.Entities;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CourierManagement
{
    public partial class AdminAddWorkerForm : Form
    {
        DataTable UserTable;
        DataAccess dataAccess = new DataAccess();
        string[] mail = { "@gmail.com", "@yahoo.com", "@hotmail.com", "@mail.com", "@outlook.com" };
        string[] phone = { "017", "014", "013", "015", "019", "018", "016", "011" };
        public AdminAddWorkerForm(DataTable UserTable)
        {
            InitializeComponent();
            lblHome.BackColor = Color.Firebrick;
            this.UserTable = UserTable;
            lblName.Text = UserTable.Rows[0].Field<string>("UserName");
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void lblAddBranch_MouseEnter(object sender, EventArgs e)
        {
            lblAddBranch.BackColor = Color.Firebrick;
        }

        private void lblAllBranch_MouseEnter(object sender, EventArgs e)
        {
            lblAllBranch.BackColor = Color.Firebrick;
        }

        private void lblLogout_MouseEnter(object sender, EventArgs e)
        {
            lblLogout.BackColor = Color.Firebrick;
        }

        private void lblAddBranch_MouseLeave(object sender, EventArgs e)
        {
            lblAddBranch.BackColor = Color.DimGray;
        }

        private void lblAllBranch_MouseLeave(object sender, EventArgs e)
        {
            lblAllBranch.BackColor = Color.DimGray;
        }

        private void lblLogout_MouseLeave(object sender, EventArgs e)
        {
            lblLogout.BackColor = Color.DimGray;
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            AdminHomeForm home = new AdminHomeForm(UserTable);
            home.Show();
            this.Hide();
        }

        private void lblAddBranch_Click(object sender, EventArgs e)
        {
            AdminAddBranchForm adminAdd = new AdminAddBranchForm(UserTable);
            adminAdd.Show();
            this.Hide();
        }

        private void AdminAddWorkerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
                txtEmail.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtContact.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtSalary_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbDesignation.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void cmbBranch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addWorker();
                e.SuppressKeyPress = true;
            }
        }

        private void cmbDesignation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbBranch.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private int getDesignation()
        {
            string designation = cmbDesignation.SelectedItem.ToString();
            int desig;
            if (designation.Equals("Manager"))
            {
                desig = (int)Employee.DesignationEnum.Manager;
            }
            else if (designation.Equals("Worker"))
            {
                desig = (int)Employee.DesignationEnum.Worker;
            }
            else if (designation.Equals("Driver"))
            {
                desig = (int)Employee.DesignationEnum.Driver;
            }
            else
            {
                desig = (int)Employee.DesignationEnum.Delivery_boy;
            }

            return desig;
        }

        private Employee setEmployee(DataTable userTable)
        {
            int desig = getDesignation();

            Employee employee = new Employee()
            {
                User_id = UserTable.Rows[0].Field<int>("Id"),
                Contact = txtContact.Text,
                UpdatedDate = DateTime.Now,
                Salary = float.Parse(txtSalary.Text),
                Branch_id = (int)cmbBranch.SelectedValue,
                Designation = desig,
                Name = "",
                Address = "",
                Blood_Group = "",
                Bonus = 0,
                DOB = DateTime.Now,
                Joining_date = DateTime.Now,
                Qualification = ""
            };
            return employee;
        }

        private Users setUsers()
        {
            Users user = new Users()
            {
                UserName = txtUserName.Text,
                Password = txtPassword.Text,
                EmailAddress = txtEmail.Text,
                Information_given = false,
                UserType = (int)Users.UserTypeEnum.Employee,
                UpdatedDate = DateTime.Now
            };
            return user;
        }

        private void addWorker()
        {
            if(isValidated() && isUnique())
            {
                Users user = setUsers();
                
                int affectedRowCount = dataAccess.Insert<Users>(user, true);
                DataTable userTable = dataAccess.GetData<Users>($"where UserName = '{txtUserName.Text}' and Password = '{txtPassword.Text}'");

                if (affectedRowCount > 0)
                {
                    Employee employee = setEmployee(userTable);
                    
                    affectedRowCount = dataAccess.Insert<Employee>(employee, true);

                    if (affectedRowCount > 0)
                    {
                        MessageBox.Show("Worker Added Successfully");
                        AdminHomeForm adminHome = new AdminHomeForm(userTable);
                        adminHome.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Something Went Wrong!!!");
                    }
                }
                else
                {
                    MessageBox.Show("Unable to Add worker!!!");
                }
            }
        }

        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            addWorker();
        }

        private DataTable Branch()
        {
            DataTable dt = dataAccess.GetData<Branch>("");
            return dt;
        }

        private void AdminAddWorkerForm_Load(object sender, EventArgs e)
        {
            DataTable dt = Branch();
            cmbBranch.DisplayMember = "Branch_Name";
            cmbBranch.ValueMember = "Id";
            cmbBranch.DataSource = dt;
            cmbDesignation.SelectedItem = "Manager";
        }

        private void txtContact_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSalary.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private bool isUnique()
        {
            DataTable userTable;
            userTable = dataAccess.GetData<Users>($"where UserName = '{txtUserName.Text}' or EmailAddress = '{txtEmail.Text}'");
            if (userTable.Rows.Count > 0)
            {
                if (userTable.Rows[0].Field<string>("UserName").Equals(txtUserName.Text))
                {
                    errorProvider1.SetError(txtUserName, "User Name already taken!!!");
                    txtUserName.Focus();
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

        private bool isValidated()
        {
            int mobileNumberValidLength = 11;
            if (!isvalidphone())
            {
                errorProvider1.SetError(txtContact, "This is not a valid contact number!!!");
                txtContact.Focus();
                return false;
            }
            else if (txtContact.Text.Length < mobileNumberValidLength)
            {
                errorProvider1.SetError(txtContact, "There must be 11 number in your phone!!!");
                txtContact.Focus();
                return false;
            }
            else if (txtContact.Text.Length > mobileNumberValidLength)
            {
                errorProvider1.SetError(txtContact, "There must be 11 number in your phone!!!");
                txtContact.Focus();
                return false;
            }
            else if (!isValidEmail())
            {
                errorProvider1.SetError(txtEmail, "This is not a valid Email address!!!");
                txtEmail.Focus();
                return false;
            }
            else if (txtPassword.Text.Length < 8)
            {
                errorProvider1.SetError(txtPassword, "Password should be atleast 8 word");
                txtPassword.Focus();
                return false;
            }

            return true;
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

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.SetError(txtUserName, "");
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.SetError(txtPassword, "");
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.SetError(txtContact, "");
            if (!(char.IsNumber(e.KeyChar) || (e.KeyChar == (char)8)))
            {
                e.Handled = true;
            }
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.SetError(txtSalary, "");
            if (!(char.IsNumber(e.KeyChar) || (e.KeyChar == (char)8)))
            {
                e.Handled = true;
            }
        }

        private void lblAllBranch_Click(object sender, EventArgs e)
        {
            DataTable BranchTable = dataAccess.GetData<Branch>("");
            AdminShowForm view = new AdminShowForm(BranchTable, (int)Entities.Show.AdminShow.allBranch, UserTable);
            view.Show();
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
            if (this.WindowState != FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.SetError(txtEmail, "");
        }
    }
}
