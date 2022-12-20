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
            try
            { 
                string Query = "Select * form EmployeeTbl";
                EmployeeList.DataSource = con.GetData(Query);
            }
            catch(Exception)
            {
                throw;
            }
          }
        private void GetDepartment()
        {
            string Query = "select * from DepartmentTb";
            DepCb.DisplayMember = con.GetData(Query).Columns["DepName"].ToString();
            DepCb.ValueMember = con.GetData(Query).Columns["DepId"].ToString();
            DepCb.DataSource = con.GetData(Query);
        }
        int Key = 0;
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpNameTb.Text = EmployeeList.SelectedRows[0].Cells[1].Value.ToString();
            GenCb.Text = EmployeeList.SelectedRows[0].Cells[2].Value.ToString();
            DepCb.SelectedValue = EmployeeList.SelectedRows[0].Cells[3].Value.ToString();
            DORTb.Text = EmployeeList.SelectedRows[0].Cells[4].Value.ToString();
            JDaTeTb.Text = EmployeeList.SelectedRows[0].Cells[5].Value.ToString();
           DailySalTb.Text = EmployeeList.SelectedRows[0].Cells[6].Value.ToString();


            if (EmpNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(EmployeeList.SelectedRows[0].Cells[0].Value.ToString());
            }
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

        private void UpDateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpNameTb.Text == "" || GenCb.SelectedIndex == -1 || DepCb.SelectedIndex == -1 || DailySalTb.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string Name = EmpNameTb.Text;
                    string Gender = GenCb.SelectedItem.ToString();
                    int Dep = Convert.ToInt32(DepCb.SelectedValue.ToString());
                    string DOB = DORTb.Value.ToString();
                    string JDate = JDaTeTb.Value.ToString();
                    int Salary = Convert.ToInt32(DailySalTb.Text);

                    string Query = "Update  EmployeeTbl set EmpName='{0}',EmpGen='{1}',EmpDep='{2}',EmpDOB='{3}',EmpJDate='{4}',EmpSal={5} where EmpId={6}";
                    Query = string.Format(Query, Name, Gender, Dep, DOB, JDate, Salary,Key);
                    con.SetData(Query);
                    ShowEmp();

                    MessageBox.Show("Employee Update ");
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

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Key==0)
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                  

                    string Query = "Delete from   EmployeeTbl where EmpId={0}";
                    Query = string.Format(Query,  Key);
                    con.SetData(Query);
                    ShowEmp();

                    MessageBox.Show("Employee Delete ");
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

        private void label8_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Employees obj = new Employees();
            obj.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Department obj = new Department();
            obj.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Salaries obj = new Salaries();
            obj.Show();
            this.Hide();
        }
    }
}
