using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Connecting2DB
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAB1-PC-02;Initial Catalog=Employee;Integrated Security=True");
        public Form1()
        {
            
            InitializeComponent();
        }

        private void FillComboBox()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT empno FROM" + "emp", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbEmpNo.DataSource = dt;
            cbEmpNo.DisplayMember = "empNo";
            cbEmpNo.ValueMember = "empNo";
        }

        private void clear()
        {
            cbEmpNo.Text = "";
            txtName.Clear();
            rbtnMale.Checked = false;
            rbtnFemale.Checked = false;
            dtDOB.Text = "";
            txtSalary.Clear();
            cbEmpNo.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlsearch;
                sqlsearch = "Select * from emp where empNo = '" + cbEmpNo.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlsearch, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtName.Text = dr["empName"].ToString();
                    dtDOB.Text = dr["empDOB"].ToString();
                    txtSalary.Text = dr["empSalary"].ToString();
                    if (dr["empGender"].Equals("M"))
                        rbtnMale.Checked = true;
                    else
                        rbtnFemale.Checked = true;
                }
                else
                {
                    MessageBox.Show("Employee not found.");
                    clear();
                }
                con.Close();
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message);
                con.Close();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                string gen;
                if (rbtnMale.Checked == true)
                    gen = "M";
                else
                    gen = "F";
                string sqlInsert;
                sqlInsert = "insert into emp (empNo, empName, empGender, empDOB, empSalary) values ('" + cbEmpNo.Text + "', '" + txtName.Text + "', '" + gen + "', '" + dtDOB.Value + "', '" + txtSalary.Text + "')";
                SqlCommand cmd = new SqlCommand(sqlInsert, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record inserted.");
                clear();
                con.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                con.Close();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string gen;
                if (rbtnMale.Checked == true)
                    gen = "M";
                else
                    gen = "F";
                string sqlUpdate;
                sqlUpdate = "update emp set empName = '" + txtName.Text + "', empGender = '" + gen + "', empDOB = '" + dtDOB.Value + "', empSalary = '" + txtSalary.Text + "' where empNo = '" + txtEmpNo.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlUpdate, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record updated.");
                clear();
                con.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sqlDelete;
                sqlDelete = "Delete from emp where empNo = '" + cbEmpNo.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlDelete, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee record deleted");
            }
            clear();
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeDataSet.emp' table. You can move, or remove it, as needed.
            this.empTableAdapter.Fill(this.employeeDataSet.emp);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 ft = new Form2();
            ft.Show();
        }
    }
}
