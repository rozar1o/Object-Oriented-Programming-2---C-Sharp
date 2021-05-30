using CourierManagement.Employee_GUI;
using CourierManagement.Entities;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CourierManagement
{
    public partial class EmpHomeForm : Form
    {
        DataTable usersTable,EmployeeTable;
        DataAccess dataAccess = new DataAccess();
        public EmpHomeForm(DataTable usersTable)
        {
            InitializeComponent();
            this.usersTable = usersTable;
            lblHome.BackColor = Color.Black;
            UserName.Text = usersTable.Rows[0].Field<string>("UserName");
        }

        private void EmpHomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void EmpHomeForm_Load(object sender, EventArgs e)
        {
            EmployeeTable = dataAccess.GetData<Employee>($"where User_id = '{usersTable.Rows[0].Field<int>("Id")}'");
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

        private void lblViewCustomers_MouseEnter(object sender, EventArgs e)
        {
            lblViewCustomers.ForeColor = Color.White;
        }

        private void lblReceiveOrder_MouseEnter(object sender, EventArgs e)
        {
            lblReceiveOrder.ForeColor = Color.White;
        }

        private void lblAddCustomers_MouseEnter(object sender, EventArgs e)
        {
            lblAddCustomers.ForeColor = Color.White;
        }

        private void lblVerifyCustomer_MouseEnter(object sender, EventArgs e)
        {
            lblVerifyCustomer.ForeColor = Color.White;
        }

        private void lblShipOrder_MouseEnter(object sender, EventArgs e)
        {
            lblShipOrder.ForeColor = Color.White;
        }

        private void lblReleaseOrder_MouseEnter(object sender, EventArgs e)
        {
            lblReleaseOrder.ForeColor = Color.White;
        }

        private void lblHelpLine_MouseEnter(object sender, EventArgs e)
        {
            lblHelpLine.ForeColor = Color.White;
        }

        private void lblTermCondition_MouseEnter(object sender, EventArgs e)
        {
            lblTermCondition.ForeColor = Color.White;
        }

        private void lblViewCustomers_MouseLeave(object sender, EventArgs e)
        {
            lblViewCustomers.ForeColor = Color.Black;
        }

        private void lblReceiveOrder_MouseLeave(object sender, EventArgs e)
        {
            lblReceiveOrder.ForeColor = Color.Black;
        }

        private void lblAddCustomers_MouseLeave(object sender, EventArgs e)
        {
            lblAddCustomers.ForeColor = Color.Black;
        }

        private void lblVerifyCustomer_MouseLeave(object sender, EventArgs e)
        {
            lblVerifyCustomer.ForeColor = Color.Black;
        }

        private void lblShipOrder_MouseLeave(object sender, EventArgs e)
        {
            lblShipOrder.ForeColor = Color.Black;
        }

        private void lblReleaseOrder_MouseLeave(object sender, EventArgs e)
        {
            lblReleaseOrder.ForeColor = Color.Black;
        }

        private void lblHelpLine_MouseLeave(object sender, EventArgs e)
        {
            lblHelpLine.ForeColor = Color.Black;
        }

        private void lblTermCondition_MouseLeave(object sender, EventArgs e)
        {
            lblTermCondition.ForeColor = Color.Black;
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            LoginForm logout = new LoginForm();
            logout.Show();
            this.Hide();
        }

        private void lblViewCustomersIcon_Click(object sender, EventArgs e)
        {
            DataTable customersTable = dataAccess.GetData<Customers>($"where Is_verified = '{true}'");
            EmpShowForm sh = new EmpShowForm(usersTable,customersTable, (int)Entities.Show.EmployeeShow.viewCustomers);
            sh.Show();
            this.Hide();
        }

        private void lblViewCustomers_Click(object sender, EventArgs e)
        {
            DataTable customersTable = dataAccess.GetData<Customers>($"where Is_verified = '{true}'");
            EmpShowForm sh = new EmpShowForm(usersTable,customersTable,(int)Entities.Show.EmployeeShow.viewCustomers);
            sh.Show();
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

            EmpShowForm es = new EmpShowForm(usersTable,productsTable, (int)Entities.Show.EmployeeShow.serviceHistory);
            es.Show();
            this.Hide();
        }

        private void lblEditProfile_Click(object sender, EventArgs e)
        {
            EmpEditForm edit = new EmpEditForm(usersTable);
            edit.Show();
            this.Hide();
        }

        private void Receive()
        {
            EmpReceive rec = new EmpReceive(usersTable);
            rec.Show();
            this.Hide();
        }

        private void lblReceiveOrderIcon_Click(object sender, EventArgs e)
        {
            Receive();
        }

        private void lblVerifyCustomerIcon_Click(object sender, EventArgs e)
        {
            DataTable customersTable = dataAccess.GetData<Customers>($"where Is_verified = '{false}'");
            EmpShowForm es = new EmpShowForm(usersTable,customersTable, (int)Entities.Show.EmployeeShow.varifyCustomers);
            es.Show();
            this.Hide();
        }

        private void lblShipOrderIcon_Click(object sender, EventArgs e)
        {
            DataTable productsTable = dataAccess.GetData<Product>($"where Product_State = '{(int)Product.ProductStateEnum.Received}' and Sending_B_id = '{EmployeeTable.Rows[0].Field<int>("Branch_id")}'"); ;
            if (productsTable.Rows.Count > 0)
            {
                EmpShowForm es = new EmpShowForm(usersTable,productsTable, (int)Entities.Show.EmployeeShow.shippedOrders);
                es.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No Product to ship");
            }
        }

        private void lblReleaseOrderIcon_Click(object sender, EventArgs e)
        {
            DataTable productsTable = dataAccess.GetData<Product>($"where Product_State = '{(int)Product.ProductStateEnum.Sent_to_destination}' and Receiving_B_id = '{EmployeeTable.Rows[0].Field<int>("Branch_id")}'");
            if (productsTable.Rows.Count > 0)
            {
                EmpShowForm es = new EmpShowForm(usersTable,productsTable, (int)Entities.Show.EmployeeShow.releasedOrders);
                es.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No Product to ship");
            }
        }

        private void lblReleaseOrder_Click(object sender, EventArgs e)
        {
            DataTable productsTable = dataAccess.GetData<Product>($"where Product_State = '{(int)Product.ProductStateEnum.Sent_to_destination}' and Receiving_B_id = '{EmployeeTable.Rows[0].Field<int>("Branch_id")}'");
            if (productsTable.Rows.Count > 0)
            {
                EmpShowForm es = new EmpShowForm(usersTable,productsTable, (int)Entities.Show.EmployeeShow.releasedOrders);
                es.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No Product to ship");
            }
        }

        private void lblShipOrder_Click(object sender, EventArgs e)
        {
            DataTable productsTable = dataAccess.GetData<Product>($"where Product_State = '{(int)Product.ProductStateEnum.Received}' and Sending_B_id = '{EmployeeTable.Rows[0].Field<int>("Branch_id")}'");
            if(productsTable.Rows.Count>0)
            { 
                EmpShowForm es = new EmpShowForm(usersTable,productsTable, (int)Entities.Show.EmployeeShow.shippedOrders);
                es.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No Product to ship");
            }
        }

        private void lblVerifyCustomer_Click(object sender, EventArgs e)
        {
            DataTable customersTable = dataAccess.GetData<Customers>($"where Is_verified = '{false}'");
            EmpShowForm es = new EmpShowForm(usersTable,customersTable, (int)Entities.Show.EmployeeShow.varifyCustomers);
            es.Show();
            this.Hide();
        }

        private void lblReceiveOrder_Click(object sender, EventArgs e)
        {
            Receive();
        }

        public void addCUst()
        {
            EmpAddCust EmployeeAddCustomer = new EmpAddCust(usersTable);
            EmployeeAddCustomer.Show();
            this.Hide();
        }
        private void lblAddCustomersIcon_Click(object sender, EventArgs e)
        {
            addCUst();
        }

        private void lblAddCustomers_Click(object sender, EventArgs e)
        {
            addCUst();
        }

        public void helpline()
        {
            EmpHelpline help = new EmpHelpline(usersTable);
            help.Show();
            this.Hide();
        }
        private void lblHelpLineIcon_Click(object sender, EventArgs e)
        {
            helpline();
        }

        public void terms()
        {
            EmpTermCondition tr = new EmpTermCondition(usersTable);
            tr.Show();
            this.Hide();
        }

        private void lblTermConditionIcon_Click(object sender, EventArgs e)
        {
            terms();
        }

        private void lblTermCondition_Click(object sender, EventArgs e)
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

        private void lblHelpLine_Click(object sender, EventArgs e)
        {
            helpline();
        }
    }
}
