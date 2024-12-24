using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication12
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtUN.Text == "esoft" && txtPW.Text == "esoft@123")
            {
                MessageBox.Show("Login Successful.");
                this.Hide();
                MainMenu obj = new MainMenu();
                obj.Show();

            }
            else
                MessageBox.Show("Username or Password incorrect.");
        }
    }
}
