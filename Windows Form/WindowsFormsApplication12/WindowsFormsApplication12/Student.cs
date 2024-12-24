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

namespace WindowsFormsApplication12
{
    public partial class Student : Form
    {
        //LAB02-PC28
        SqlConnection con = new SqlConnection(@"Data Source=LAB02-PC28;Initial Catalog=DBstd;Integrated Security=True");

        public Student()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                string email = txtEmail.Text;
                int PhoneNo = int.Parse(txtPhoneNo.Text);

                string gender;
                if (rbMale.Checked == true)
                    gender = "Male";
                else
                    gender = "Female";

                string grade = cbGrade.Text;

                string query_Save = "INSERT INTO student VALUES ('" + name + "', '" + email + "', " + PhoneNo + ", '" + gender + "', '" + grade + "')";

                con.Open();
                SqlCommand cmd = new SqlCommand(query_Save, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student Saved.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                string email = txtEmail.Text;
                int PhoneNo = int.Parse(txtPhoneNo.Text);
                string grade = cbGrade.Text;

                string query_update = "UPDATE student SET name = '" + name + "', email = '" + email + "', phoneNo = " + PhoneNo + ", grade = '" + grade + "')";

                con.Open();
                SqlCommand cmd = new SqlCommand(query_update, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student Updated.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text;
                string query_update = "DELETE FROM student WHERE email = '" + email + "'";

                con.Open();
                SqlCommand cmd = new SqlCommand(query_update, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student Deleted.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text.Trim();

                if (string.IsNullOrWhiteSpace(email))
                {
                    MessageBox.Show("Please neter an email address and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                else
                {
                    con.Open();

                    string query_select = "SELECT * FROM student WHERE email = '" + email + "'";
                    SqlCommand cmd = new SqlCommand(query_select, con);

                    DataTable dataTable = new DataTable();

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;

                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Student email not found.");
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
