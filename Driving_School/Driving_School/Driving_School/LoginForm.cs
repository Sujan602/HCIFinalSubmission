using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_School
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text=="admin"&& txtUsername.Text == "admin")
            {
                MainForm mf = new MainForm();
                mf.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }
    }
}
