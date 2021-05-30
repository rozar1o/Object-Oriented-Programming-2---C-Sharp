
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
    public partial class AdminHomeForm : Form
    {
        DataTable userTable;
        DataAccess dataAccess = new DataAccess();

        public AdminHomeForm(DataTable userTable)
        {
            InitializeComponent();
            lblHome.BackColor = Color.Firebrick;
            this.userTable = userTable;
            lblUserName.Text = userTable.Rows[0].Field<string>("UserName");
        }

        private void AdminHomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblWorkerList_Click(object sender, EventArgs e)
        {
            WorkerList((int)Entities.Show.AdminShow.workerList);
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

        private void lblSolveWorkerProblem_MouseEnter(object sender, EventArgs e)
        {
            lblSolveWorkerProblem.ForeColor = Color.White;
        }

        private void lblAddWorker_MouseEnter(object sender, EventArgs e)
        {
            lblAddWorker.ForeColor = Color.White;
        }

        private void lblWorkerList_MouseEnter(object sender, EventArgs e)
        {
            lblWorkerList.ForeColor = Color.White;
        }

        private void lblWorkerList_MouseLeave(object sender, EventArgs e)
        {
            lblWorkerList.ForeColor = Color.Black;
        }

        private void lblAddWorker_MouseLeave(object sender, EventArgs e)
        {
            lblAddWorker.ForeColor = Color.Black;
        }

        private void lblSolveWorkerProblem_MouseLeave(object sender, EventArgs e)
        {
            lblSolveWorkerProblem.ForeColor = Color.Black;
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void lblAddBranch_Click(object sender, EventArgs e)
        {
            AdminAddBranchForm adminAdd = new AdminAddBranchForm(userTable);
            adminAdd.Show();
            this.Hide();
        }
        public void WorkerList(int i)
        {
            DataTable employeeTable = dataAccess.GetData<Employee>("");
            AdminShowForm AdminShow = new AdminShowForm(employeeTable,i,userTable);
            AdminShow.Show();
            this.Hide();
        }
        public void AddWorker()
        {
            AdminAddWorkerForm adminAddWorker = new AdminAddWorkerForm(userTable);
            adminAddWorker.Show();
            this.Hide();
        }

        private void lblWorkerListIcon_Click(object sender, EventArgs e)
        {
            WorkerList((int)Entities.Show.AdminShow.workerList);
        }

        private void lblSolveWorkerProblemIcon_Click(object sender, EventArgs e)
        {
            string sql = $"select e.User_Id,e.Name,e.Contact,ep.Problem from Employee as e, Employee_Problem as ep where e.User_Id = ep.User_id";
            DataTable problemTable = dataAccess.Execute(sql);
            AdminShowForm adminShow = new AdminShowForm(problemTable, (int)Entities.Show.AdminShow.workerProblem, userTable);
            adminShow.Show();
            this.Hide();
        }

        private void lblSolveWorkerProblem_Click(object sender, EventArgs e)
        {
            string sql = $"select e.User_Id,e.Name,e.Contact,ep.Problem from Employee as e, Employee_Problem as ep where e.User_Id = ep.User_id";
            DataTable problemTable = dataAccess.Execute(sql);
            AdminShowForm adminShow = new AdminShowForm(problemTable, (int)Entities.Show.AdminShow.workerProblem, userTable);
            adminShow.Show();
            this.Hide();
        }

        private void lblAddWorkerIcon_Click(object sender, EventArgs e)
        {
            AddWorker();
        }

        private void lblAddWorker_Click(object sender, EventArgs e)
        {
            AddWorker();
        }

        private void lblAllBranch_Click(object sender, EventArgs e)
        {
            DataTable BranchTable = dataAccess.GetData<Branch>("");
            AdminShowForm adminShow = new AdminShowForm(BranchTable, (int)Entities.Show.AdminShow.allBranch, userTable);
            adminShow.Show();
            this.Hide();
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            if(this.WindowState != FormWindowState.Minimized)
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
