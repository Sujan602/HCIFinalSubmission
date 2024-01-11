using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class frmInstructor : Form
    {
        public frmInstructor()
        {
            InitializeComponent();
        }

        private void txtfname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtlname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtcontactno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtfname.Text = string.Empty;
            txtlname.Text = string.Empty;
            txtaddress.Text = string.Empty;
            txtcontactno.Text = string.Empty;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtfname.Text.Length == 0)
            {
                MessageBox.Show("First Name cannot be blank!!!");
                txtfname.Focus();
            }
            else if (txtlname.Text.Length == 0)
            {
                MessageBox.Show("Last Name cannot be blank!!!");
                txtfname.Focus();
            }
            else if (txtaddress.Text.Length == 0)
            {
                MessageBox.Show("Student address cannot be blank!!!");
                txtaddress.Focus();
            }
            else if (txtcontactno.Text.Length == 0)
            {
                MessageBox.Show("Student Contact number cannot be blank!!!");
                txtcontactno.Focus();
            }
            if (Regex.IsMatch(txtEmail.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase) == true)
            {
                MessageBox.Show("Invalid Email!!!");
                txtEmail.Focus();
            }
        }
    }
}
