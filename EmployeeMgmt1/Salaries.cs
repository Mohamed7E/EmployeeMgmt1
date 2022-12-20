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
        int DSal = 0;
        string period = "";
        private void GetSalary()
        {
            string Query = "select EmpSal from EmployeeTbl Where EmpId ={0}";
            Query = string.Format(Query, EmpCb.SelectedValue.ToString());
           
            foreach(DataRow dr in con.GetData(Query).Rows)
            {
                DSal = Convert.ToInt32(dr["EmpName"].ToString());
            }
            //MessageBox.Show("" + DSal);
        }
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Salaries_Load(object sender, EventArgs e)
        {

        }

        private void EmpCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetSalary();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                period = periodTb.Value.Date.Month.ToString() + "-" + periodTb.Value.Date.Year.ToString();
                int Amount = DSal * Convert.ToInt32(DaysTb.Text);
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message); 
            }
           
        }
    }
}
