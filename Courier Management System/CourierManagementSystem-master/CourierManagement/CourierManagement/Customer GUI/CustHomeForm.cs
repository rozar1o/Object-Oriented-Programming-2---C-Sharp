using CourierManagement.Customer_GUI;
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
    public partial class CustHomeForm : Form
    {
        DataTable usersTable;
        DataAccess dataAccess = new DataAccess();
        public CustHomeForm(DataTable usersTable)
        {
            InitializeComponent();
            this.usersTable = usersTable;
            lblHome.BackColor = Color.Blue;
            label10.Text = usersTable.Rows[0].Field<string>("UserName");
        }

        private void setLables()
        {
            DataTable customersTable;
            customersTable = dataAccess.GetData<Customers>($"where User_Id = '{usersTable.Rows[0].Field<int>("Id")}'");
            if (customersTable.Rows.Count > 0)
            {
                lblName.Text = "Name: " + customersTable.Rows[0].Field<string>("Name");
                lblEmail.Text = "Email: " + usersTable.Rows[0].Field<string>("EmailAddress");
                lblPhone.Text = "Phone No: " + customersTable.Rows[0].Field<string>("Contact");
                lblAddress.Text = "Address: " + customersTable.Rows[0].Field<string>("Address");
            }
            else
            {
                lblName.Text = "Name: ???";
                lblEmail.Text = "Email: ???";
                lblPhone.Text = "Phone No: ???";
                lblAddress.Text = "Address: ???";
                MessageBox.Show("Something Went Wrong!!!");
            }
        }

        private void CustHomeForm_Load(object sender, EventArgs e)
        {
            setLables();
        }

        private void CustHomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

        private void lblDeleteAcc_MouseLeave(object sender, EventArgs e)
        {
            lblDeleteAcc.BackColor = Color.FromArgb(0, 0, 64);
        }

        private void lblLogout_MouseLeave(object sender, EventArgs e)
        {
            lblLogout.BackColor = Color.FromArgb(0, 0, 64);
        }

        private void lblNewDelivery_MouseEnter(object sender, EventArgs e)
        {
            lblNewDelivery.ForeColor = Color.White;
        }

        private void lblHelpLine_MouseEnter(object sender, EventArgs e)
        {
            lblHelpLine.ForeColor = Color.White;
        }

        private void lblTermsAndCondition_MouseEnter(object sender, EventArgs e)
        {
            lblTermsAndCondition.ForeColor = Color.White;
        }

         private void lblNewDelivery_MouseLeave(object sender, EventArgs e)
        {
            lblNewDelivery.ForeColor = Color.DarkBlue;
        }

        private void lblHelpLine_MouseLeave(object sender, EventArgs e)
        {
            lblHelpLine.ForeColor = Color.DarkBlue;
        }

        private void lblTermsAndCondition_MouseLeave(object sender, EventArgs e)
        {
            lblTermsAndCondition.ForeColor = Color.DarkBlue;
        }
        private void lblEditProfile_MouseLeave(object sender, EventArgs e)
        {
            lblEditProfile.BackColor = Color.FromArgb(0, 0, 64);
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            LoginForm logout = new LoginForm();
            logout.Show();
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
        public void NewDel()
        {
            CustOrderForm customerOrder = new CustOrderForm(usersTable);
            customerOrder.Show();
            this.Hide();
        }

        private void lblNewDeliveryIcon_Click(object sender, EventArgs e)
        {
            NewDel();
        }

        private void lblNewDelivery_Click(object sender, EventArgs e)
        {
            NewDel();
        }

        public void terms()
        {
            CustTermCondition termsAndCondition = new CustTermCondition(usersTable);
            termsAndCondition.Show();
            this.Hide();
        }
        private void lblTermsAndConditionsIcon_Click(object sender, EventArgs e)
        {
            terms();
        }

        private void lblTermsAndCondition_Click(object sender, EventArgs e)
        {
            terms();
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

        private void lblHelpLine_Click(object sender, EventArgs e)
        {
            DataTable EmployeeTable = dataAccess.GetData<Employee>($"where Branch_id = '{1}' and Designation = '{(int)Employee.DesignationEnum.Manager}'");
            MessageBox.Show("Please Call this number for further Info: "+EmployeeTable.Rows[0].Field<string>("Contact"));
        }

        private void lblHelpLineIcon_Click(object sender, EventArgs e)
        {
            DataTable EmployeeTable = dataAccess.GetData<Employee>($"where Branch_id = '{1}' and Designation = '{(int)Employee.DesignationEnum.Manager}'");
            MessageBox.Show("Please Call this number for further Info: " + EmployeeTable.Rows[0].Field<string>("Contact"));
        }

        private void lblDeleteAcc_MouseLeave_1(object sender, EventArgs e)
        {
            lblDeleteAcc.BackColor = Color.FromArgb(0, 0, 64);
        }

        private void lblSerHistory_MouseEnter_1(object sender, EventArgs e)
        {
            lblSerHistory.BackColor = Color.Blue;
        }

        private void lblSerHistory_MouseLeave_1(object sender, EventArgs e)
        {
            lblSerHistory.ForeColor = Color.DarkBlue;
        }
    }
}
