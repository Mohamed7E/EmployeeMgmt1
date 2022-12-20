using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmployeeMgmt1
{
    public partial class Employees : Form
    {
        Function con;

        public Employees()
        {
            InitializeComponent();
            con = new Function();
            ShowEmp();
            GetDepartment();
        }
        private void ShowEmp()
        {
            string Query = "Select * form EmployeeTb";
            EmployeeList.DataSource = con.GetData(Query);
        }
        private void GetDepartment()
        {
            string Query = "select * from DepartmentTb";
            DepCb.DisplayMember = con.GetData(Query).Columns["DepName"].ToString();
            DepCb.ValueMember = con.GetData(Query).Columns["DepId"].ToString();
            DepCb.DataSource = con.GetData(Query);
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EmpNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpNameTb.Text == "" || GenCb.SelectedIndex==-1|| DepCb.SelectedIndex==-1 || DailySalTb.Text=="") 
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string Name= EmpNameTb.Text;
                    string Gender= GenCb.SelectedItem.ToString();
                    int Dep= Convert.ToInt32( DepCb.SelectedValue.ToString());
                    string DOB= DORTb.Value.ToString();
                    string JDate= JDaTeTb.Value.ToString();
                    int Salary=Convert.ToInt32( DailySalTb.Text);

                    string Query = "insert into EmployeeTbl values('{0}','{1}','{2}','{3}','{4}',{5})";
                    Query = string.Format(Query, Name, Gender,Dep, DOB, JDate, Salary);
                    con.SetData(Query);
                    ShowEmp();
                    
                    MessageBox.Show("Employee Added");
                    EmpNameTb.Text = "";
                    GenCb.SelectedIndex = -1;
                    DepCb.SelectedIndex = -1;
                    DailySalTb.Text = "";
                }

            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
