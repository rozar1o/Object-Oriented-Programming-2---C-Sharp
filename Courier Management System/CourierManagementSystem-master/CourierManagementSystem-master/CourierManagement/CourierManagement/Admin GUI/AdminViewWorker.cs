using CourierManagement.Entities;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CourierManagement.Admin_GUI
{
    public partial class AdminViewWorker : Form
    {
        DataTable EmployeeTable,showTable,userTable;
        DataAccess dataAccess = new DataAccess();

        public AdminViewWorker(DataTable EmployeeTable,DataTable showTable,DataTable userTable)
        {
            InitializeComponent();
            lblHome.BackColor = Color.Firebrick;
            this.EmployeeTable = EmployeeTable;
            this.showTable = showTable;
            this.userTable=userTable;
        }

        private void AdminViewWorker_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            AdminShowForm AdminShow = new AdminShowForm(showTable, (int)Entities.Show.AdminShow.workerList, userTable);
            AdminShow.Show();
            this.Hide();
        }

        private void lblAddBranch_Click(object sender, EventArgs e)
        {
            AdminAddBranchForm AdminAddBranch = new AdminAddBranchForm(userTable);
            AdminAddBranch.Show();
            this.Hide();
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            AdminHomeForm home = new AdminHomeForm(userTable);
            home.Show();
            this.Hide();
        }

        private void lblAllBranch_Click(object sender, EventArgs e)
        {
            AdminShowForm adminShow = new AdminShowForm(dataAccess.GetData<Branch>(""), (int)Entities.Show.AdminShow.allBranch, userTable);
            adminShow.Show();
            this.Hide();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            LoginForm logout = new LoginForm();
            logout.Show();
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

        private void setValue()
        {
            lblUserName.Text = EmployeeTable.Rows[0].Field<string>("Name");
            txtSalary.Text = EmployeeTable.Rows[0][3].ToString();
            txtBonus.Text = EmployeeTable.Rows[0][4].ToString();
            cmbDesignation.SelectedItem = ((Employee.DesignationEnum)EmployeeTable.Rows[0].Field<int>("Designation")).ToString();

            DataTable branchTable = dataAccess.GetData<Branch>("");
            cmbBranch.DataSource = branchTable;
            cmbBranch.DisplayMember = "Branch_Name";
            cmbBranch.ValueMember = "Id";
            cmbBranch.SelectedIndex = EmployeeTable.Rows[0].Field<int>("Branch_id")-1;
        }

        private Employee setEmployee()
        {
            string desi = cmbDesignation.SelectedItem.ToString();
            int desig;
            if (desi.Equals("Manager"))
            {
                desig = (int)Employee.DesignationEnum.Manager;
            }
            else if (desi.Equals("Worker"))
            {
                desig = (int)Employee.DesignationEnum.Worker;
            }
            else if (desi.Equals("Driver"))
            {
                desig = (int)Employee.DesignationEnum.Driver;
            }
            else
            {
                desig = (int)Employee.DesignationEnum.Delivery_boy;
            }
            Employee e = new Employee()
            {
                Id = EmployeeTable.Rows[0].Field<int>("Id"),
                UpdatedDate = EmployeeTable.Rows[0].Field<DateTime>("UpdatedDate"),
                Name = EmployeeTable.Rows[0].Field<string>("Name"),
                Designation = desig,
                DOB = EmployeeTable.Rows[0].Field<DateTime>("DOB"),
                Address = EmployeeTable.Rows[0].Field<string>("Address"),
                Joining_date = EmployeeTable.Rows[0].Field<DateTime>("Joining_date"),
                Blood_Group = EmployeeTable.Rows[0].Field<string>("Blood_Group"),
                Bonus = float.Parse(txtBonus.Text),
                Branch_id = (int)cmbBranch.SelectedValue,
                Contact = EmployeeTable.Rows[0].Field<string>("Contact"),
                Qualification = EmployeeTable.Rows[0].Field<string>("Qualification"),
                Salary = float.Parse(txtSalary.Text),
                User_id = EmployeeTable.Rows[0].Field<int>("User_id")
            };
            return e;
        }

        private void update()
        {
            Employee employee = setEmployee();
            int rowsAffected = dataAccess.Insert<Employee>(employee, true);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Profile updated of the worker");
                AdminShowForm AdminShow = new AdminShowForm(dataAccess.GetData<Employee>(""), (int)Entities.Show.AdminShow.allBranch, userTable);
                AdminShow.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Something Went Wrong!!!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            update();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void delete()
        {
            string id = EmployeeTable.Rows[0].Field<int>("User_id").ToString();
            int rowsAffected = dataAccess.Delete("Employee", "User_id", id);
            if (rowsAffected > 0)
            {
                rowsAffected = dataAccess.Delete("Users", "Id", id);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Account Deleted Successfully");
                    DataTable EmployeeTable = dataAccess.GetData<Employee>("");
                    AdminShowForm AdminShow = new AdminShowForm(EmployeeTable, (int)Entities.Show.AdminShow.workerList, userTable);
                    AdminShow.Show();
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

        private void AdminViewWorker_Load(object sender, EventArgs e)
        {
            setValue();
        }
    }
}
