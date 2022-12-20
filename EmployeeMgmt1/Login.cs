using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeMgmt1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LOGNBtn_Click(object sender, EventArgs e)
        {
            if(UserName.Text == ""|| Password.Text == "")
            {
                MessageBox.Show("Mising Data!!!!!!");

            }
            else if (UserName.Text == "Mohamed" && Password.Text == "Ebrahim")
            {
                Employees obj = new Employees();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong UserName Or Password");
                UserName.Text = "";
                Password.Text = "";

            }
        }

        private void RegsterLbl_Click(object sender, EventArgs e)
        {
            UserName.Text = "";
            Password.Text = "";
        }
    }
}
