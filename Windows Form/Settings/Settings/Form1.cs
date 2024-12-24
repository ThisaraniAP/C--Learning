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

namespace Settings
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAB1-PC-22;Initial Catalog=employee;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void View()
        {
            try
            {
                string sqlsearch;
                sqlsearch = "Select * from Settings";
                SqlCommand cmd = new SqlCommand(sqlsearch, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                txtDateRange.Text = dr["DateRangein"].ToString();
                dtBeginDate.Text = dr["BeginDate"].ToString();
                dtEndDate.Text = dr["EndDate"].ToString();
                txtNoOfLeaves.Text = dr["NoOfLeaves"].ToString();
                con.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                con.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlUpdate = "update Settings set DateRangein = '" + txtDateRange.Text + "', BeginDate = '" + dtBeginDate.Value + "', EndDate = '" + dtEndDate.Value + "', NoOfLeaves = '" + txtNoOfLeaves.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlUpdate, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Settings updated.");
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                con.Close();
            }
        }
    }
}
