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
                    MessageBox.Show("Department Added");
                }

            }

            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        int Key = 0;
        private void DepList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DepNameTb.Text = DepList.SelectedRows[0].Cells[1].Value.ToString();
            
            if (DepNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(DepList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string Dep = DepNameTb.Text;

                    string Query = "Update DepartmentTb  set DepName='{0}' where DepId={1}";
                    Query = string.Format(Query, Dep,Key);
                    con.SetData(Query);
                    ListerDepartments();
                    DepNameTb.Text = "";
                    MessageBox.Show("Department Update");
                }

            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void DeletBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string Dep = DepNameTb.Text;

                    string Query = "Delete from DepartmentTb  where DepId={0}";
                    Query = string.Format(Query, Key);
                    con.SetData(Query);
                    ListerDepartments();
                    DepNameTb.Text = "";
                    MessageBox.Show("Department Deleteee");
                }

            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void EmpLbl_Click(object sender, EventArgs e)
        {
            Employees obj = new Employees();
            obj.Show();
            this.Hide();
        }
    }
}
