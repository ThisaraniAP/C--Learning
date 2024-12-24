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
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAB1-PC-02;Initial Catalog=Employee;Integrated Security=True");

        public Form2()
        {
            InitializeComponent();
        }

        private void FillComboBox()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT empno FROM" + "emp", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "empNo";
            comboBox1.ValueMember = "empNo";
        }
    }
}
