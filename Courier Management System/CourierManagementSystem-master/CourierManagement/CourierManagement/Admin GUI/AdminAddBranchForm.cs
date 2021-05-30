using CourierManagement.Entities;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CourierManagement
{
    public partial class AdminAddBranchForm : Form
    {
        DataTable userDataTable;
        DataAccess dataAcess = new DataAccess();
        public AdminAddBranchForm(DataTable userDataTable)
        {
            InitializeComponent();
            lblAddBranch.BackColor = Color.Firebrick;
            this.userDataTable = userDataTable;
            lblUserName.Text = userDataTable.Rows[0].Field<string>("UserName");
        }

        private void AdminAddBranchForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            log.Show();
            this.Hide();
        }

        private void lblHome_MouseEnter(object sender, EventArgs e)
        {
            lblHome.BackColor = Color.Firebrick;
        }

        private void lblAllBranch_MouseEnter(object sender, EventArgs e)
        {
            lblAllBranch.BackColor = Color.Firebrick;
        }

        private void lblLogout_MouseEnter(object sender, EventArgs e)
        {
            lblLogout.BackColor = Color.Firebrick;
        }

        private void lblHome_MouseLeave(object sender, EventArgs e)
        {
            lblHome.BackColor = Color.DimGray;
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
            AdminHomeForm home = new AdminHomeForm(userDataTable);
            home.Show();
            this.Hide();
        }

        private void addBranch()
        {
            Branch branch = new Branch()
            {
                Branch_Name = txtBranchName.Text,
                Address = txtAddress.Text,
                UpdatedDate = DateTime.Now
            };
            int rowsAffected = dataAcess.Insert<Branch>(branch, true);

            if (rowsAffected > 0)
            {
                MessageBox.Show("New Branch Added Successfully");
                AdminHomeForm adminHome = new AdminHomeForm(userDataTable);
                adminHome.Show();
                this.Hide();
            }
        }

        private void btnAddBranch_Click(object sender, EventArgs e)
        {
            addBranch();
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addBranch();
                e.SuppressKeyPress = true;
            }
        }

        private void lblAllBranch_Click(object sender, EventArgs e)
        {
            DataTable branchTable = dataAcess.GetData<Branch>("");
            AdminShowForm view = new AdminShowForm(branchTable, (int)Entities.Show.AdminShow.allBranch, userDataTable);
            view.Show();
            this.Hide();
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

        private void txtBranchName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAddress.Focus();
                e.SuppressKeyPress = true;
            }
        }
    }
}
