using CourierManagement.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourierManagement
{
    public partial class EmpProfile : Form
    {
        DataAccess dataAccess = new DataAccess();
        DataTable usersTable;
        public EmpProfile(DataTable usersTable)
        {
            InitializeComponent();
            this.usersTable = usersTable;
            lblProfile.BackColor = Color.Black;
            UserName.Text = usersTable.Rows[0].Field<string>("UserName");
        }

        private void EmpProfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            LoginForm logout = new LoginForm();
            logout.Show();
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

        private void lblHome_Click(object sender, EventArgs e)
        {
            EmpHomeForm home = new EmpHomeForm(usersTable);
            home.Show();
            this.Hide();
        }

        private void lblEditProfile_Click(object sender, EventArgs e)
        {
            EmpEditForm edit = new EmpEditForm(usersTable);
            edit.Show();
            this.Hide();
        }

        private void lblHome_MouseEnter(object sender, EventArgs e)
        {
            label14.BackColor = Color.Black;
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

        private void lblHome_MouseLeave(object sender, EventArgs e)
        {
            lblHome.BackColor = Color.DeepSkyBlue;
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

        private string branch_name(int id)
        {
            DataTable branchTable = dataAccess.GetData<Branch>($"where Id = '{id}'");
            return branchTable.Rows[0].Field<string>("Branch_Name");
        }

        private string total_recived()
        {
            DataTable branchTable = dataAccess.GetData<Product>($"where Receiving_Manager_id = '{usersTable.Rows[0].Field<int>("Id")}'");
            return branchTable.Rows.Count.ToString();
        }
        private string total_sent()
        {
            DataTable branchTable = dataAccess.GetData<Product>($"where Sending_Manager_id = '{usersTable.Rows[0].Field<int>("Id")}'");
            return branchTable.Rows.Count.ToString();
        }

        private void fillLables()
        {
            DataTable EmployeeTable = dataAccess.GetData<Employee>($"where user_id = '{usersTable.Rows[0].Field<int>("Id")}'");

            lblName1.Text = EmployeeTable.Rows[0].Field<string>("Name");
            lblBranch1.Text = branch_name(EmployeeTable.Rows[0].Field<int>("Branch_id"));
            lblDesignation1.Text = Enum.GetName(typeof(Employee.DesignationEnum), EmployeeTable.Rows[0].Field<int>("Designation"));
            lblEmail1.Text = usersTable.Rows[0].Field<string>("EmailAddress");
            lblDateOfBirth1.Text = EmployeeTable.Rows[0].Field<DateTime>("DOB").ToString("dd-MM-yyyy");
            lblBloodGroup1.Text = EmployeeTable.Rows[0].Field<string>("Blood_Group");
            lblContact1.Text = EmployeeTable.Rows[0].Field<string>("Contact");
            lblAddress1.Text = EmployeeTable.Rows[0].Field<string>("Address");
            lblTotalPlaceOrder1.Text = total_sent();
            lblTotalReceiveOrder1.Text = total_recived();
        }

        private void EmpProfile_Load(object sender, EventArgs e)
        {
            fillLables();
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
