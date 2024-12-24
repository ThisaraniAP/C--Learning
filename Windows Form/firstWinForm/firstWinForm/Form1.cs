using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "Sam" && textBox2.Text == "abc123")
            {
                MessageBox.Show("Username and password is correct", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Username and password is incorrect", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
