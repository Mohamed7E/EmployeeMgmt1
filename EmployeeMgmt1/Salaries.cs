using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmployeeMgmt1
{
    public partial class Salaries : Form
    {
        Function con;
        public Salaries()
        {
            InitializeComponent();
            con = new Function();
            Showsalary();
            GetEmployees();


        }
        private void Showsalary()
        {
            try {
                string Query = "Select * form salaryTbl";
                SalaryList.DataSource = con.GetData(Query);
            }
            catch(Exception)
            {
                throw;
            }
            
        }
        private void GetEmployees ()
        {
            string Query = "select * from EmployeeTbl";
            EmpCb.DisplayMember = con.GetData(Query).Columns["EmpName"].ToString();
            EmpCb.ValueMember = con.GetData(Query).Columns["EmpId"].ToString();
            EmpCb.DataSource = con.GetData(Query);
        }
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Salaries_Load(object sender, EventArgs e)
        {

        }
    }
}
