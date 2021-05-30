using CourierManagement.Entities;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CourierManagement.Employee_GUI
{
    public partial class EmpReceive : Form
    {
        DataTable usersTable,nonRecivedProductsTable,shippedProductsTable,EmployeeTable;
        DataAccess dataAccess = new DataAccess();
        public EmpReceive(DataTable usersTable)
        {
            InitializeComponent();
            this.usersTable = usersTable;
            lblHome.BackColor = Color.Black;
            UserName.Text = usersTable.Rows[0].Field<string>("UserName");
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

        private void EmpReceive_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

        private void lblLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
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

        private void setGridView()
        {
            nonRecivedProductsTable = dataAccess.GetData<Product>($"where Product_State = '{(int)Entities.Product.ProductStateEnum.Not_yet_Received}' and Sending_B_id = '{EmployeeTable.Rows[0].Field<int>("Branch_id")}'");
            shippedProductsTable = dataAccess.GetData<Product>($"where Product_State = '{(int)Entities.Product.ProductStateEnum.Shipped}' and Receiving_B_id = '{EmployeeTable.Rows[0].Field<int>("Branch_id")}'");
            dgvReceiveFromCustomer.DataSource = nonRecivedProductsTable;
            dgvReceiveFromOtherBranch.DataSource = shippedProductsTable;

            dgvReceiveFromCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReceiveFromCustomer.Columns[0].Visible = false;

            dgvReceiveFromOtherBranch.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReceiveFromOtherBranch.Columns[0].Visible = false;
        }
        private void EmpReceive_Load(object sender, EventArgs e)
        {
            EmployeeTable = dataAccess.GetData<Employee>($"where User_id = '{usersTable.Rows[0].Field<int>("Id")}'");
            setGridView();
        }

        private Product setProduct(DataTable productsTable)
        {
            if (productsTable.Rows.Count > 0)
            {
                Product pi = new Product()
                {
                    Id = productsTable.Rows[0].Field<int>("Id"),
                    UpdatedDate = productsTable.Rows[0].Field<DateTime>("UpdatedDate"),
                    Customer_id = productsTable.Rows[0].Field<int>("Customer_id"),
                    Delivery_charge = float.Parse(productsTable.Rows[0][6].ToString()),
                    Description = productsTable.Rows[0].Field<string>("Description"),
                    Release_Date = productsTable.Rows[0].Field<DateTime>("Release_Date"),
                    RecieverEmail = productsTable.Rows[0].Field<string>("RecieverEmail"),
                    PaymentMethod = productsTable.Rows[0].Field<int>("PaymentMethod"),
                    ProductCategory = productsTable.Rows[0].Field<int>("ProductCategory"),
                    ProductType = productsTable.Rows[0].Field<int>("ProductType"),
                    Product_State = (int)Product.ProductStateEnum.Received,
                    Receiving_B_id = productsTable.Rows[0].Field<int>("Receiving_B_id"),
                    Receiving_Manager_id = productsTable.Rows[0].Field<int>("Receiving_Manager_id"),
                    RecieverAddress = productsTable.Rows[0].Field<string>("RecieverAddress"),
                    RecieverContact = productsTable.Rows[0].Field<string>("RecieverContact"),
                    RecieverName = productsTable.Rows[0].Field<string>("RecieverName"),
                    Sending_B_id = productsTable.Rows[0].Field<int>("Sending_B_id"),
                    Sending_Manager_id = usersTable.Rows[0].Field<int>("Id")
                };
                return pi;
            }
            return null;
        }

        private void action_According_Dialog_Result_1(DialogResult dialogResult, DataGridViewCellEventArgs e)
        {
            if (dialogResult == DialogResult.Yes)
            {
                DataTable productsTable = dataAccess.GetData<Product>($"where Customer_id = '{nonRecivedProductsTable.Rows[e.RowIndex][3].ToString()}' and UpdatedDate = '{nonRecivedProductsTable.Rows[e.RowIndex][17].ToString()}'");
                Product pi = setProduct(productsTable);

                int rowsAffected = dataAccess.Insert<Product>(pi, true);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Product Recieved Successfully");
                    setGridView();
                }
                else
                {
                    MessageBox.Show("Something went wrong!!!");
                }

            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Product Sent back to Customer");
            }
        }

        private void dgvReceiveFromCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you Want to Receive the product?", "Product receiving", MessageBoxButtons.YesNo);

            action_According_Dialog_Result_1(dialogResult,e);
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

        private Product setProducts(DataTable productsTable)
        {
            if (productsTable.Rows.Count > 0)
            {
                Product pi = new Product()
                {
                    Id = productsTable.Rows[0].Field<int>("Id"),
                    UpdatedDate = productsTable.Rows[0].Field<DateTime>("UpdatedDate"),
                    Customer_id = productsTable.Rows[0].Field<int>("Customer_id"),
                    Delivery_charge = float.Parse(productsTable.Rows[0][6].ToString()),
                    Description = productsTable.Rows[0].Field<string>("Description"),
                    Release_Date = productsTable.Rows[0].Field<DateTime>("Release_Date"),
                    RecieverEmail = productsTable.Rows[0].Field<string>("RecieverEmail"),
                    PaymentMethod = productsTable.Rows[0].Field<int>("PaymentMethod"),
                    ProductCategory = productsTable.Rows[0].Field<int>("ProductCategory"),
                    ProductType = productsTable.Rows[0].Field<int>("ProductType"),
                    Product_State = (int)Product.ProductStateEnum.Sent_to_destination,
                    Receiving_B_id = productsTable.Rows[0].Field<int>("Receiving_B_id"),
                    Receiving_Manager_id = usersTable.Rows[0].Field<int>("Id"),
                    RecieverAddress = productsTable.Rows[0].Field<string>("RecieverAddress"),
                    RecieverContact = productsTable.Rows[0].Field<string>("RecieverContact"),
                    RecieverName = productsTable.Rows[0].Field<string>("RecieverName"),
                    Sending_B_id = productsTable.Rows[0].Field<int>("Sending_B_id"),
                    Sending_Manager_id = productsTable.Rows[0].Field<int>("Sending_Manager_id")
                };
                return pi;
            }
            return null;
        }

        private void action_According_Dialog_Result_2(DialogResult dialogResult, DataGridViewCellEventArgs e)
        {
            if (dialogResult == DialogResult.Yes)
            {
                DataTable productsTable = dataAccess.GetData<Product>($"where Customer_id = '{shippedProductsTable.Rows[e.RowIndex][3].ToString()}' and UpdatedDate = '{shippedProductsTable.Rows[e.RowIndex][17].ToString()}'");


                Product pi = setProducts(productsTable);
                int rowsAffected = dataAccess.Insert<Product>(pi, true);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Product Recieved Successfully");
                    setGridView();
                }
                else
                {
                    MessageBox.Show("Something went wrong!!!");
                }

            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Product Will remain on the Delivery van!!!");
            }
        }

        private void dgvReceiveFromOtherBranch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you Want to Receive the product?", "Product receiving", MessageBoxButtons.YesNo);

            action_According_Dialog_Result_2(dialogResult,e);
        }


        private void lblLogout_MouseLeave(object sender, EventArgs e)
        {
            lblLogout.BackColor = Color.DeepSkyBlue;
        }
    }
}
