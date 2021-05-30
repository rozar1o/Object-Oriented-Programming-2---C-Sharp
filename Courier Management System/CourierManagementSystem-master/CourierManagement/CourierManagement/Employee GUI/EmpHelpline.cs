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
    public partial class EmpHelpline : Form
    {
        DataTable usersTable;
        DataAccess dataAccess = new DataAccess();
        public EmpHelpline(DataTable usersTable)
        {
            InitializeComponent();
            this.usersTable = usersTable;
            lblHome.BackColor = Color.Black;
            UserName.Text = usersTable.Rows[0].Field<string>("UserName");
        }

        private void EmpHelpline_FormClosed(object sender, FormClosedEventArgs e)
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
            DataTable productsTable = dataAccess.Execute(sql);

            EmpShowForm es = new EmpShowForm(usersTable, productsTable, (int)Entities.Show.EmployeeShow.serviceHistory);
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

        private Employee_Problem setEmployeeProblem()
        {
            DataTable employeeTable = dataAccess.GetData<Employee>($"where User_id = '{usersTable.Rows[0].Field<int>("Id")}'");

            Employee_Problem ep = new Employee_Problem()
            {
                UpdatedDate = DateTime.Now,
                Problem = rtbProblem.Text,
                User_id = usersTable.Rows[0].Field<int>("Id"),
                Branch_id = employeeTable.Rows[0].Field<int>("Branch_id")
            };
            return ep;
        }
        private void updateProblem()
        {
            Employee_Problem ep = setEmployeeProblem();
            
            int rowsAffected = dataAccess.Insert<Employee_Problem>(ep, true);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Complain Updated Sucessfully");
                EmpHomeForm home = new EmpHomeForm(usersTable);
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Something Went Wrong!!!");
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(rtbProblem.Text.Trim().Length != 0)
            {
                updateProblem();
            }
            else
            {
                MessageBox.Show("You haven't write any Complain");
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
