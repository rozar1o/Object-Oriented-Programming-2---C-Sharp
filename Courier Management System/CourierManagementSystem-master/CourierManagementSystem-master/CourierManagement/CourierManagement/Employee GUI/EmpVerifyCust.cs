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

namespace CourierManagement.Employee_GUI
{
    public partial class EmpVerifyCust : Form
    {
        DataAccess dataAccess = new DataAccess();
        DataTable usersTable;
        int id;
        public EmpVerifyCust(DataTable usersTable,int id)
        {    
            InitializeComponent();
            this.usersTable = usersTable;
            this.id = id;
            //this.check = check;
            lblHome.BackColor = Color.Black;
            UserName.Text = usersTable.Rows[0].Field<string>("UserName");
        }

        private void EmpVerifyCust_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

        private void lblEditProfile_Click(object sender, EventArgs e)
        {
            EmpEditForm edit = new EmpEditForm(usersTable);
            edit.Show();
            this.Hide();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            LoginForm logout = new LoginForm();
            logout.Show();
            this.Hide();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
                DataTable unverifiedCustomersTable = dataAccess.GetData<Customers>($"where Is_verified = '{false}'");
                EmpShowForm sh = new EmpShowForm(usersTable, unverifiedCustomersTable, (int)Entities.Show.EmployeeShow.varifyCustomers);
                sh.Show();
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

        private void lblServiceHistory_Click(object sender, EventArgs e)
        {
            string sql = $"select * from Product where Sending_Manager_id = '{usersTable.Rows[0].Field<int>("Id")}' or Receiving_Manager_id = '{usersTable.Rows[0].Field<int>("Id")}'";
            DataTable productsTable = dataAccess.Execute(sql);
            EmpShowForm sh = new EmpShowForm(usersTable,productsTable, (int)Entities.Show.EmployeeShow.serviceHistory);
            sh.Show();
            this.Hide();
        }

        private void EmpVerifyCust_Load(object sender, EventArgs e)
        {
            string sql = $"select c.Name,u.UserName,u.Password,c.Contact,u.EmailAddress,c.Address,c.Sequrity_Que from Users as u,Customers as c where u.Id = c.User_id and u.Id = '{id}'";
            DataTable customersTable = dataAccess.Execute(sql);

            lblName1.Text = customersTable.Rows[0][0].ToString();
            lblUsername1.Text = customersTable.Rows[0][1].ToString();
            lblPassword1.Text = customersTable.Rows[0][2].ToString();
            lblContact1.Text = customersTable.Rows[0][3].ToString();
            lblEmail1.Text = customersTable.Rows[0][4].ToString();
            lblAddress1.Text = customersTable.Rows[0][5].ToString();
            lblSecurityQue1.Text = customersTable.Rows[0][6].ToString();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            int rowsAffected = dataAccess.Delete("Customers", "User_Id", id.ToString());
            if (rowsAffected > 0)
            {
                rowsAffected = dataAccess.Delete("Users", "Id", id.ToString());
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Account Deleted Successfully");
                    DataTable customersTable = dataAccess.GetData<Customers>($"where Is_verified = '{false}'");
                    EmpShowForm es = new EmpShowForm(usersTable, customersTable, (int)Entities.Show.EmployeeShow.varifyCustomers);
                    es.Show();
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


        private Customers setCustomers()
        {
            DataTable customersTable = dataAccess.GetData<Customers>($"where User_id='{id}'");
            Customers customers = new Customers()
            {
                User_Id = customersTable.Rows[0].Field<int>("User_Id"),
                Name = customersTable.Rows[0].Field<string>("Name"),
                Id = customersTable.Rows[0].Field<int>("Id"),
                Address = customersTable.Rows[0].Field<string>("Address"),
                Contact = customersTable.Rows[0].Field<string>("Contact"),
                UpdatedDate = customersTable.Rows[0].Field<DateTime>("UpdatedDate"),
                Sequrity_Que = customersTable.Rows[0].Field<string>("Sequrity_Que"),
                Is_verified = true

            };
            return customers;
        }
        private void btnVerifiedAccount_Click(object sender, EventArgs e)
        {
            Customers customers = setCustomers();
            int rowsAffected = dataAccess.Insert<Customers>(customers, true);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Customer Verified Successfully");
                this.Dispose();
                DataTable CustomersTable = dataAccess.GetData<Customers>($"where Is_verified = '{false}'");
                EmpShowForm sh = new EmpShowForm(usersTable, CustomersTable, (int)Entities.Show.EmployeeShow.varifyCustomers);
                sh.Show();
                this.Hide();
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
    }
}
