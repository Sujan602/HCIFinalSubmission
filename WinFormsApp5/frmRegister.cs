using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtFname.Text.Length == 0)
            {
                MessageBox.Show("First Name cannot be blank!!");
                txtFname.Focus();
            }
            else if (txtLname.Text.Length == 0)
            {
                MessageBox.Show("Last Name cannot be blank!!");
                txtLname.Focus();
            }
            else if (txtEmail.Text.Length == 0)
            {
                MessageBox.Show("Email cannot be blank!!");
                txtEmail.Focus();
            }
            else if (txtPhone.Text.Length == 0)
            {
                MessageBox.Show("Phone Number cannot be blank!!");
                txtPhone.Focus();
            }
            else
            {
                MessageBox.Show("Record is Saved");
                txtEmail.Text = "";
                txtPhone.Text = "";
                txtLname.Text = "";
                txtFname.Text = "";
                cmbRole.Text = "";
                txtFname.Focus();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
