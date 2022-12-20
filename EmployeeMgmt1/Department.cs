using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmployeeMgmt1
{
    public partial class Department : Form
    {
        Function con;
        public Department()
        {
            InitializeComponent();
            con = new Function();
            ListerDepartments();
        }
        private void ListerDepartments()
        {
            string Query = "Select * form DepartmentTb";
            DepList.DataSource = con.GetData(Query);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTb.Text=="")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string Dep = DepNameTb.Text;
                    
                    string Query = "insert into DepartmentTb values('{0}')";
                    Query = string.Format(Query, Dep);
                    con.SetData(Query);
                    ListerDepartments();
                    DepNameTb.Text = "";
                    MessageBox.Show("Patient Added");
                }

            }

            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void DepList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
