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
                DSal = Convert.ToInt32(dr["EmpSal"].ToString());
            }
            //MessageBox.Show("" + DSal);
            if (DaysTb.Text == "")
            {
                AmountTb.Text = "Rs" + (d * DSal);
            }
            else if (Convert.ToInt32(DaysTb.Text) > 31)
            {
                MessageBox.Show("Days Can Not Be Greater Then 31");
            }
            else
            {
                d = Convert.ToInt32(DaysTb.Text);
                AmountTb.Text = "Rs" + (d * DSal);

            }
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
        int d = 1;
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (EmpCb.SelectedIndex == -1 || DaysTb.Text == "" || periodTb.Text == "")
                {
                    MessageBox.Show("Missing Data!!!!!!");
                }
                else
                {
                    period = periodTb.Value.Date.Month.ToString() + "-" + periodTb.Value.Date.Year.ToString();
                    int Amount = DSal * Convert.ToInt32(DaysTb.Text);
                    int Days = Convert.ToInt32(DaysTb.Text);
               

                    string Query = "insert into salaryTbl values({0},{1},'{2}',{3},'{4}')";
                    Query = string.Format(Query, EmpCb.SelectedValue.ToString(), Days, period, Amount,DateTime.Today.Date);
                    con.SetData(Query);
                    Showsalary();

                    MessageBox.Show("Employee Added");
                    DaysTb.Text = "";
                  
                }
                
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message); 
            }
           
        }

        private void LogoutLbl_Click(object sender, EventArgs e)
        {
           Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Employees obj = new Employees();
            obj.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Department obj = new Department();
            obj.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Salaries obj = new Salaries();
            obj.Show();
            this.Hide();
        }
    }
}
