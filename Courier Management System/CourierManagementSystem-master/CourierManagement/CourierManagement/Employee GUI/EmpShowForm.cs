using CourierManagement.Employee_GUI;
using CourierManagement.Entities;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CourierManagement
{
    public partial class EmpShowForm : Form
    {
        DataAccess dataAccess = new DataAccess();
        DataTable usersTable,productsTable,emoployeeTable;
        Show show;
        public EmpShowForm(DataTable usersTable,DataTable productsTable,int showValue)
        {
            InitializeComponent();
            this.usersTable = usersTable;
            this.productsTable = productsTable;
            this.show.employeeShow = showValue;
            UserName.Text = usersTable.Rows[0].Field<string>("UserName");
            selectBackColor();
        }

        private void selectBackColor()
        {
            if(show.employeeShow != (int)Entities.Show.EmployeeShow.serviceHistory)
            {
                lblHome.BackColor = Color.Black;
            }
            else if(show.employeeShow == (int)Entities.Show.EmployeeShow.serviceHistory)
            {
                lblServiceHistory.BackColor = Color.Black;
            }
        }

        private void EmpViewCust_SerHistory_FormClosed(object sender, FormClosedEventArgs e)
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

        private void lblEditProfile_Click(object sender, EventArgs e)
        {
            EmpEditForm edit = new EmpEditForm(usersTable);
            edit.Show();
            this.Hide();
        }

        private void lblHome_MouseEnter(object sender, EventArgs e)
        {
            if (show.employeeShow == (int)Entities.Show.EmployeeShow.serviceHistory)
            {
                lblHome.BackColor = Color.Black;
            }
        }

        private void lblProfile_MouseEnter(object sender, EventArgs e)
        {
            lblProfile.BackColor = Color.Black;
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
            if (show.employeeShow == (int)Entities.Show.EmployeeShow.serviceHistory)
            {
                lblHome.BackColor = Color.DeepSkyBlue;
            }
        }

        private void lblProfile_MouseLeave(object sender, EventArgs e)
        {
            lblProfile.BackColor = Color.DeepSkyBlue;
        }

        private void lblEditProfile_MouseLeave(object sender, EventArgs e)
        {
            lblEditProfile.BackColor = Color.DeepSkyBlue;
        }

        private void lblLogout_MouseLeave(object sender, EventArgs e)
        {
            lblLogout.BackColor = Color.DeepSkyBlue;
        }

        private void setGridView()
        {
            if(show.employeeShow == (int)Entities.Show.EmployeeShow.varifyCustomers || show.employeeShow == (int)Entities.Show.EmployeeShow.serviceHistory || show.employeeShow == (int)Entities.Show.EmployeeShow.viewCustomers)
            {
                DataGridViewShow.DataSource = productsTable;
                DataGridViewShow.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            } 
            else if(show.employeeShow == (int)Entities.Show.EmployeeShow.shippedOrders)
            {
                productsTable = dataAccess.GetData<Product>($"where Product_State = '{(int)Entities.Product.ProductStateEnum.Received}' and Sending_B_id = '{emoployeeTable.Rows[0].Field<int>("Branch_id")}'");
                DataGridViewShow.DataSource = productsTable;
                DataGridViewShow.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            else if(show.employeeShow == (int)Entities.Show.EmployeeShow.releasedOrders)
            {
                productsTable = dataAccess.GetData<Product>($"where Product_State = '{(int)Entities.Product.ProductStateEnum.Sent_to_destination}' and Receiving_B_id = '{emoployeeTable.Rows[0].Field<int>("Branch_id")}'");
                DataGridViewShow.DataSource = productsTable;
                DataGridViewShow.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }

        private Product setProduct(DataTable productTable)
        {

            if (productTable.Rows.Count > 0)
            {
                Product product = new Product()
                {
                    Id = productTable.Rows[0].Field<int>("Id"),
                    UpdatedDate = productTable.Rows[0].Field<DateTime>("UpdatedDate"),
                    Customer_id = productTable.Rows[0].Field<int>("Customer_id"),
                    Delivery_charge = float.Parse(productTable.Rows[0][6].ToString()),
                    Description = productTable.Rows[0].Field<string>("Description"),
                    Release_Date = productTable.Rows[0].Field<DateTime>("Release_Date"),
                    RecieverEmail = productTable.Rows[0].Field<string>("RecieverEmail"),
                    PaymentMethod = productTable.Rows[0].Field<int>("PaymentMethod"),
                    ProductCategory = productTable.Rows[0].Field<int>("ProductCategory"),
                    ProductType = productTable.Rows[0].Field<int>("ProductType"),
                    Product_State = (int)Product.ProductStateEnum.Shipped,
                    Receiving_B_id = productTable.Rows[0].Field<int>("Receiving_B_id"),
                    Receiving_Manager_id = productTable.Rows[0].Field<int>("Receiving_Manager_id"),
                    RecieverAddress = productTable.Rows[0].Field<string>("RecieverAddress"),
                    RecieverContact = productTable.Rows[0].Field<string>("RecieverContact"),
                    RecieverName = productTable.Rows[0].Field<string>("RecieverName"),
                    Sending_B_id = productTable.Rows[0].Field<int>("Sending_B_id"),
                    Sending_Manager_id = usersTable.Rows[0].Field<int>("Id")
                };
                return product;
            }
            return null;
        }

        private Product setProducts(DataTable productTable)
        {

            if (productTable.Rows.Count > 0)
            {
                Product product = new Product()
                {
                    Id = productTable.Rows[0].Field<int>("Id"),
                    UpdatedDate = productTable.Rows[0].Field<DateTime>("UpdatedDate"),
                    Customer_id = productTable.Rows[0].Field<int>("Customer_id"),
                    Delivery_charge = float.Parse(productTable.Rows[0][6].ToString()),
                    Description = productTable.Rows[0].Field<string>("Description"),
                    Release_Date = DateTime.Now,
                    RecieverEmail = productTable.Rows[0].Field<string>("RecieverEmail"),
                    PaymentMethod = productTable.Rows[0].Field<int>("PaymentMethod"),
                    ProductCategory = productTable.Rows[0].Field<int>("ProductCategory"),
                    ProductType = productTable.Rows[0].Field<int>("ProductType"),
                    Product_State = (int)Product.ProductStateEnum.Released,
                    Receiving_B_id = productTable.Rows[0].Field<int>("Receiving_B_id"),
                    Receiving_Manager_id = productTable.Rows[0].Field<int>("Receiving_Manager_id"),
                    RecieverAddress = productTable.Rows[0].Field<string>("RecieverAddress"),
                    RecieverContact = productTable.Rows[0].Field<string>("RecieverContact"),
                    RecieverName = productTable.Rows[0].Field<string>("RecieverName"),
                    Sending_B_id = productTable.Rows[0].Field<int>("Sending_B_id"),
                    Sending_Manager_id = usersTable.Rows[0].Field<int>("Id")
                };
                return product;
            }
            return null;
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

        private void lblServiceHistory_Click(object sender, EventArgs e)
        {
            string sql = $"select * from Product where Sending_Manager_id = '{usersTable.Rows[0].Field<int>("Id")}' or Receiving_Manager_id = '{usersTable.Rows[0].Field<int>("Id")}'";
            DataTable productsTable = dataAccess.Execute(sql);

            EmpShowForm es = new EmpShowForm(usersTable, productsTable, (int)Entities.Show.EmployeeShow.serviceHistory);
            es.Show();
            this.Hide();
        }

        public enum searchShippedOrdersBy
        {
            CustomersName,
            CustomersContact,
            RecieverName,
            RecieverContact,
            BranchName
        }

        public enum searchReleasedOrdersBy
        {
            RecieverName,
            RecieverContact,
            BranchName
        }
        public enum searchCustomersBy
        {
            Name,
            Address,
            Contact
        }

        private void search()
        {
            if (show.employeeShow == (int)Entities.Show.EmployeeShow.shippedOrders)
            {
                if (cmbPosition.SelectedIndex == (int)searchShippedOrdersBy.CustomersName)
                {
                    string sql = $"select p.* FROM Product as p,Customers as c WHERE c.Name LIKE '%{txtSearchBy.Text}%' and p.Product_State = '{(int)Entities.Product.ProductStateEnum.Received}' and p.Sending_B_id = '{emoployeeTable.Rows[0].Field<int>("Branch_id")}' and c.User_id = p.Customer_id";
                    DataTable productsTable = dataAccess.Execute(sql);
                    DataGridViewShow.DataSource = productsTable;
                }
                else if (cmbPosition.SelectedIndex == (int)searchShippedOrdersBy.CustomersContact)
                {
                    string sql = $"select p.* FROM Product as p,Customers as c WHERE c.Contact LIKE '%{txtSearchBy.Text}%' and p.Product_State = '{(int)Entities.Product.ProductStateEnum.Received}' and p.Sending_B_id = '{emoployeeTable.Rows[0].Field<int>("Branch_id")}' and c.User_id = p.Customer_id";
                    DataTable productsTable = dataAccess.Execute(sql);
                    DataGridViewShow.DataSource = productsTable;
                }
                else if (cmbPosition.SelectedIndex == (int)searchShippedOrdersBy.RecieverName)
                {
                    string sql = $"select * FROM Product WHERE RecieverName LIKE '%{txtSearchBy.Text}%' and Product_State = '{(int)Entities.Product.ProductStateEnum.Received}' and Sending_B_id = '{emoployeeTable.Rows[0].Field<int>("Branch_id")}'";
                    DataTable productsTable = dataAccess.Execute(sql);
                    DataGridViewShow.DataSource = productsTable;
                }
                else if (cmbPosition.SelectedIndex == (int)searchShippedOrdersBy.RecieverContact)
                {
                    string sql = $"select * FROM Product WHERE RecieverContact LIKE '%{txtSearchBy.Text}%' and Product_State = '{(int)Entities.Product.ProductStateEnum.Received}' and Sending_B_id = '{emoployeeTable.Rows[0].Field<int>("Branch_id")}'";
                    DataTable productsTable = dataAccess.Execute(sql);
                    DataGridViewShow.DataSource = productsTable;
                }
                else if (cmbPosition.SelectedIndex == (int)searchShippedOrdersBy.BranchName)
                {
                    string sql = $"select * FROM Product as p,Branch_Info as b WHERE Branch_Name LIKE '%{txtSearchBy.Text}%' and p.Product_State = '{(int)Entities.Product.ProductStateEnum.Received}' and p.Sending_B_id = '{emoployeeTable.Rows[0].Field<int>("Branch_id")}' b.Id = p.Sending_B_id";
                    DataTable productsTable = dataAccess.Execute(sql);
                    DataGridViewShow.DataSource = productsTable;
                }

            }
            else if(show.employeeShow == (int)Entities.Show.EmployeeShow.releasedOrders)
            {
                if (cmbPosition.SelectedIndex == (int)searchReleasedOrdersBy.RecieverName)
                {
                    string sql = $"select * FROM Product WHERE RecieverName LIKE '%{txtSearchBy.Text}%' and Product_State = '{(int)Entities.Product.ProductStateEnum.Sent_to_destination}' and Receiving_B_id = '{emoployeeTable.Rows[0].Field<int>("Branch_id")}'";
                    DataTable productsTable = dataAccess.Execute(sql);
                    DataGridViewShow.DataSource = productsTable;
                }
                else if (cmbPosition.SelectedIndex == (int)searchReleasedOrdersBy.RecieverContact)
                {
                    string sql = $"select * FROM Product WHERE RecieverContact LIKE '%{txtSearchBy.Text}%' and Product_State = '{(int)Entities.Product.ProductStateEnum.Sent_to_destination}' and Receiving_B_id = '{emoployeeTable.Rows[0].Field<int>("Branch_id")}'";
                    DataTable productsTable = dataAccess.Execute(sql);
                    DataGridViewShow.DataSource = productsTable;
                }
                else if (cmbPosition.SelectedIndex == (int)searchReleasedOrdersBy.BranchName)
                {
                    string sql = $"select * FROM Product as p,Branch_Info as b WHERE Branch_Name LIKE '%{txtSearchBy.Text}%' and p.Product_State = '{(int)Entities.Product.ProductStateEnum.Sent_to_destination}' and p.Receiving_B_id = '{emoployeeTable.Rows[0].Field<int>("Branch_id")}' b.Id = p.Receiving_B_id";
                    DataTable productsTable = dataAccess.Execute(sql);
                    DataGridViewShow.DataSource = productsTable;
                }
            }
            else if(show.employeeShow == (int)Entities.Show.EmployeeShow.viewCustomers)
            {
                if (cmbPosition.SelectedIndex == (int)searchCustomersBy.Name)
                {
                    string sql = $"select * FROM Customers WHERE Name LIKE '%{txtSearchBy.Text}%' and Is_verified = '{true}'";
                    DataTable customersTable = dataAccess.Execute(sql);
                    DataGridViewShow.DataSource = customersTable;
                }
                else if (cmbPosition.SelectedIndex == (int)searchCustomersBy.Address)
                {
                    string sql = $"select * FROM Customers WHERE Address LIKE '%{txtSearchBy.Text}%' and Is_verified = '{true}'";
                    DataTable customersTable = dataAccess.Execute(sql);
                    DataGridViewShow.DataSource = customersTable;
                }
                else if (cmbPosition.SelectedIndex == (int)searchCustomersBy.Contact)
                {
                    string sql = $"select * FROM Customers WHERE Contact LIKE '%{txtSearchBy.Text}%' and Is_verified = '{true}'";
                    DataTable customersTable = dataAccess.Execute(sql);
                    DataGridViewShow.DataSource = customersTable;
                }
            }
        }

        private void txtSearchBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            search();
        }

        private void setComboBox()
        {
            if(show.employeeShow == (int)Entities.Show.EmployeeShow.varifyCustomers)
            {
                lblSearch.Visible = false;
                cmbPosition.Visible = false;
                txtSearchBy.Visible = false;
            }
            else if(show.employeeShow == (int)Entities.Show.EmployeeShow.shippedOrders)
            {
                cmbPosition.Items.Add("Sender Name");
                cmbPosition.Items.Add("Sender Contact");
                cmbPosition.Items.Add("Receiver Name");
                cmbPosition.Items.Add("Receiver Contact");
                cmbPosition.Items.Add("Destination Branch");
                cmbPosition.SelectedIndex = 0;
            }
            else if(show.employeeShow == (int)Entities.Show.EmployeeShow.releasedOrders)
            {
                cmbPosition.Items.Add("Receiver Name");
                cmbPosition.Items.Add("Receiver Contact");
                cmbPosition.Items.Add("Sending Branch");
                cmbPosition.SelectedIndex = 0;
            }
            else if(show.employeeShow == (int)Entities.Show.EmployeeShow.viewCustomers)
            {
                cmbPosition.Items.Add("Name");
                cmbPosition.Items.Add("Address");
                cmbPosition.Items.Add("Contact");
                cmbPosition.SelectedIndex = 0;
            }
            else if(show.employeeShow == (int)Entities.Show.EmployeeShow.serviceHistory)
            {
                lblSearch.Visible = false;
                cmbPosition.Visible = false;
                txtSearchBy.Visible = false;
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {
            search();
        }

        private void lblServiceHistory_MouseEnter(object sender, EventArgs e)
        {
            if (show.employeeShow != (int)Entities.Show.EmployeeShow.serviceHistory)
            {
                lblServiceHistory.BackColor = Color.Black;
            }
        }

        private void lblServiceHistory_MouseLeave(object sender, EventArgs e)
        {
            if (show.employeeShow != (int)Entities.Show.EmployeeShow.serviceHistory)
            {
                lblServiceHistory.BackColor = Color.DeepSkyBlue;
            }
        }

        private void selectAction(DataGridViewCellEventArgs e)
        {
            if (show.employeeShow == (int)Entities.Show.EmployeeShow.varifyCustomers)
            {
                int i = (int)DataGridViewShow.Rows[e.RowIndex].Cells[4].Value;
                EmpVerifyCust ec = new EmpVerifyCust(usersTable, i);
                ec.Show();
                this.Hide();
            }
            else if (show.employeeShow == (int)Entities.Show.EmployeeShow.shippedOrders)
            {
                DialogResult dialogResult = MessageBox.Show("Do you Want to Ship the product?", "Product receiving", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //MessageBox.Show();
                    DataTable productsTable = dataAccess.GetData<Product>($"where Customer_id = '{this.productsTable.Rows[e.RowIndex][3].ToString()}' and UpdatedDate = '{this.productsTable.Rows[e.RowIndex][17].ToString()}'");
                    Product products = setProduct(productsTable);
                    int rowsAffected = dataAccess.Insert<Product>(products, true);
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product Shipped Successfully ");
                        setGridView();
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong!!!");
                    }

                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Product did not shipped!!!");

                }
            }
            else if (show.employeeShow == (int)Entities.Show.EmployeeShow.releasedOrders)
            {
                DialogResult dialogResult = MessageBox.Show("Do you Want to Release the product?", "Product receiving", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //MessageBox.Show();
                    DataTable productsTable = dataAccess.GetData<Product>($"where Customer_id = '{this.productsTable.Rows[e.RowIndex][3].ToString()}' and UpdatedDate = '{this.productsTable.Rows[e.RowIndex][17].ToString()}'");
                    Product product = setProducts(productsTable);
                    int rowsAffected = dataAccess.Insert<Product>(product, true);
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product Released Successfully ");
                        setGridView();
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong!!!");
                    }

                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Product did not released!!!");

                }
            }
            else if (show.employeeShow == (int)Entities.Show.EmployeeShow.viewCustomers)
            {
                DialogResult dialogResult = MessageBox.Show("Do you Want to Delete the Customer Account?", "Account deleting", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string id = DataGridViewShow.Rows[e.RowIndex].Cells[3].Value.ToString();
                    int rowsAffected = dataAccess.Delete("Customers", "User_Id", id);
                    if (rowsAffected > 0)
                    {
                        rowsAffected = dataAccess.Delete("Users", "Id", id);
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Account Deleted Successfully");
                            setGridView();
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
            else if (show.employeeShow == (int)Entities.Show.EmployeeShow.serviceHistory)
            {
                MessageBox.Show("Product Relased on :" + DataGridViewShow.Rows[e.RowIndex].Cells[17].Value.ToString());
            }
        }


        private void DataGridViewShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectAction(e);
        }

        private void EmpShowForm_Load(object sender, EventArgs e)
        {
            emoployeeTable = dataAccess.GetData<Employee>($"where User_id = '{usersTable.Rows[0].Field<int>("Id")}'");
            setGridView();
            setComboBox();
        }
    }
}
