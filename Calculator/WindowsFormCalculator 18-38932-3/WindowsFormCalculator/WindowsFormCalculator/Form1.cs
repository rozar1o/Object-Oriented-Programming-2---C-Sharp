using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormCalculator
{
    public partial class Form1 : Form
    {
        double d=0;
        double d1=0;
        string temp;
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (this.txtSresult.Text == "0")
                this.txtSresult.Clear();
            this.txtSresult.Text = this.txtSresult.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (this.txtSresult.Text == "0")
                this.txtSresult.Clear();
            this.txtSresult.Text = this.txtSresult.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (this.txtSresult.Text == "0")
                this.txtSresult.Clear();
            this.txtSresult.Text = this.txtSresult.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (this.txtSresult.Text == "0")
                this.txtSresult.Clear();
            this.txtSresult.Text = this.txtSresult.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (this.txtSresult.Text == "0")
                this.txtSresult.Clear();
            this.txtSresult.Text = this.txtSresult.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (this.txtSresult.Text == "0")
                this.txtSresult.Clear();
            this.txtSresult.Text = this.txtSresult.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (this.txtSresult.Text == "0")
                this.txtSresult.Clear();
            this.txtSresult.Text = this.txtSresult.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (this.txtSresult.Text == "0")
                this.txtSresult.Clear();
            this.txtSresult.Text = this.txtSresult.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (this.txtSresult.Text == "0")
                this.txtSresult.Clear();
            this.txtSresult.Text = this.txtSresult.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (this.txtSresult.Text == "0")
                this.txtSresult.Clear();
            this.txtSresult.Text = this.txtSresult.Text + "9";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
           
            d = Convert.ToDouble(txtSresult.Text);
             temp = "+";
             this.txtSresult.Clear();
           
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            d = Convert.ToDouble(txtSresult.Text);
            temp = "-";
            this.txtSresult.Clear();
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            d = Convert.ToDouble(txtSresult.Text);
            temp = "*";
            this.txtSresult.Clear();
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            d = Convert.ToDouble(txtSresult.Text);
            temp = "/";
            this.txtSresult.Clear();
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                string result="";
                d1 = Convert.ToDouble(txtSresult.Text);
                if (temp == "+")
                {
                    result += d + d1;

                    txtSresult.Text = result;

                }
                else if (temp == "-")
                {
                    result += d - d1;

                    txtSresult.Text = result;
                }
                else if (temp == "*")
                {
                    result += d * d1;

                    txtSresult.Text = result;
                }
                else if(temp == "/")
                {
                    result += d / d1;

                    txtSresult.Text = result;
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show("Error :" + exe.Message);
            }

        }

        private void btnc_Click(object sender, EventArgs e)
        {
            txtSresult.Text = "0";
        }

        private void btnCe_Click(object sender, EventArgs e)
        {
            txtSresult.Text = "0";
        }

        private void btndot_Click(object sender, EventArgs e)
        {


            if (this.txtSresult.Text == "0")
                this.txtSresult.Clear();
            this.txtSresult.Text = this.txtSresult.Text + ".";


        }
    }
}
