using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourierManagement.Customer_GUI
{
    public partial class CustTermCondition : Form
    {
        DataTable usersTable;
        DataAccess dataAccess = new DataAccess();
        public CustTermCondition(DataTable usersTable)
        {
            InitializeComponent();
            this.usersTable = usersTable;
            lblHome.BackColor = Color.Blue;
            lblUserName.Text = usersTable.Rows[0].Field<string>("UserName");
        }

        private void CustTermCondition_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            CustHomeForm home = new CustHomeForm(usersTable);
            home.Show();
            this.Hide();
        }

        private void lblTrackOrder_Click(object sender, EventArgs e)
        {
            CustTrackForm track = new CustTrackForm(usersTable);
            track.Show();
            this.Hide();
        }

        private void lblSerHistory_Click(object sender, EventArgs e)
        {
            CustSerForm custser = new CustSerForm(usersTable);
            custser.Show();
            this.Hide();
        }

        private void lblEditProfile_Click(object sender, EventArgs e)
        {
            CustEditForm edit = new CustEditForm(usersTable);
            edit.Show();
            this.Hide();
        }

        private void lblTrackOrder_MouseEnter(object sender, EventArgs e)
        {
            lblTrackOrder.BackColor = Color.Blue;
        }

        private void lblSerHistory_MouseEnter(object sender, EventArgs e)
        {
            lblSerHistory.BackColor = Color.Blue;
        }

        private void lblEditProfile_MouseEnter(object sender, EventArgs e)
        {
            lblEditProfile.BackColor = Color.Blue;
        }

        private void lblDeleteAcc_MouseEnter(object sender, EventArgs e)
        {
            lblDeleteAcc.BackColor = Color.Blue;
        }

        private void lblLogout_MouseEnter(object sender, EventArgs e)
        {
            lblLogout.BackColor = Color.Blue;
        }

        private void lblTrackOrder_MouseLeave(object sender, EventArgs e)
        {
            lblTrackOrder.BackColor = Color.FromArgb(0, 0, 64);
        }

        private void lblSerHistory_MouseLeave(object sender, EventArgs e)
        {
            lblSerHistory.BackColor = Color.FromArgb(0, 0, 64);
        }

        private void lblEditProfile_MouseLeave(object sender, EventArgs e)
        {
            lblEditProfile.BackColor = Color.FromArgb(0, 0, 64);
        }

        private void lblDeleteAcc_MouseLeave(object sender, EventArgs e)
        {
            lblDeleteAcc.BackColor = Color.FromArgb(0, 0, 64);
        }

        private void lblLogout_MouseLeave(object sender, EventArgs e)
        {
            lblLogout.BackColor = Color.FromArgb(0, 0, 64);
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            LoginForm logout = new LoginForm();
            logout.Show();
            this.Hide();
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

        private void Action_According_Dialog_Result(DialogResult dialogResult)
        {
            if (dialogResult == DialogResult.Yes)
            {
                string id = usersTable.Rows[0].Field<int>("Id").ToString();
                int rowsAffected = dataAccess.Delete("Customers", "User_Id", id);
                if (rowsAffected > 0)
                {
                    rowsAffected = dataAccess.Delete("Users", "Id", id);
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Account Deleted Successfully");
                        LoginForm lf = new LoginForm();
                        lf.Show();
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
        }

        private void lblDeleteAcc_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you Want to Delete the Customer Account?", "Account deleting", MessageBoxButtons.YesNo);

            Action_According_Dialog_Result(dialogResult);
        }
    }
}
