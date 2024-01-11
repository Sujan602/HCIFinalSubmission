using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class frmAddInstructor : Form
    {
        public frmAddInstructor()
        {
            InitializeComponent();
        }

        private void frmAddInstructor_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("First Name", 140);
            listView1.Columns.Add("Last Name", 140);
            listView1.Columns.Add("Gender", 110);
            listView1.Columns.Add("Contact Number", 200);
            listView1.Columns.Add("Address", 200);
            listView1.Columns.Add("Email", 140);

            ListViewItem newItem = new ListViewItem("Doug");
            newItem.SubItems.Add("Wegal");
            newItem.SubItems.Add("Male");
            newItem.SubItems.Add("987654");
            newItem.SubItems.Add("Selly Oak");
            newItem.SubItems.Add("doug001@gmail.com");
            listView1.Items.Add(newItem);

            ListViewItem newItem2 = new ListViewItem("Jhon");
            newItem2.SubItems.Add("Walker");
            newItem2.SubItems.Add("Male");
            newItem2.SubItems.Add("0467876");
            newItem2.SubItems.Add("First Avenue");
            newItem2.SubItems.Add("jhonwalker@gmail.com");
            listView1.Items.Add(newItem2);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtFname.Text == "")
            {
                MessageBox.Show("First Name is required");
                txtFname.Focus();
            }
            else if (txtLname.Text == "")
            {
                MessageBox.Show("Last Name is required");
                txtLname.Focus();
            }
            else if (cmbGender.Text == "")
            {
                MessageBox.Show("Gender is required");
                cmbGender.Focus();
            }
            else if (txtContact.Text == "")
            {
                MessageBox.Show("Contact number is required");
                txtContact.Focus();
            }
            else if (txtContact.TextLength < 11)
            {
                MessageBox.Show("Invalid Contact Number");
                txtContact.Focus();
            }
            else if (txtAddress.Text == "")
            {
                MessageBox.Show("Address is required");
                txtAddress.Focus();
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Email is required");
                txtEmail.Focus();
            }
            else
            {
                ListViewItem newItem = new ListViewItem(txtFname.Text);
                newItem.SubItems.Add(txtLname.Text);
                newItem.SubItems.Add(cmbGender.Text);
                newItem.SubItems.Add(txtAddress.Text);
                newItem.SubItems.Add(txtContact.Text);
                newItem.SubItems.Add(txtEmail.Text);
                listView1.Items.Add(newItem);
                MessageBox.Show("Instructor is added successfully!!!");
                Clear();
            }
        }

        public void Clear()
        {
            txtFname.Text = "";
            txtLname.Text = "";
            cmbGender.Text = "";
            txtAddress.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].SubItems[0].Text = txtFname.Text;
                listView1.SelectedItems[0].SubItems[1].Text = txtLname.Text;
                listView1.SelectedItems[0].SubItems[2].Text = cmbGender.Text;
                listView1.SelectedItems[0].SubItems[3].Text = txtContact.Text;
                listView1.SelectedItems[0].SubItems[4].Text = txtAddress.Text;
                listView1.SelectedItems[0].SubItems[5].Text = txtEmail.Text;
            }
            if (txtFname.Text == "")
            {
                MessageBox.Show("First Name is required");
                txtFname.Focus();
            }
            else if (txtLname.Text == "")
            {
                MessageBox.Show("Last Name is required");
                txtLname.Focus();
            }
            else if (cmbGender.Text == "")
            {
                MessageBox.Show("Gender is required");
                cmbGender.Focus();
            }
            else if (txtContact.Text == "")
            {
                MessageBox.Show("Contact number is required");
                txtContact.Focus();
            }
            else if (txtContact.TextLength < 11)
            {
                MessageBox.Show("Invalid Contact Number");
                txtContact.Focus();
            }
            else if (txtAddress.Text == "")
            {
                MessageBox.Show("Address is required");
                txtAddress.Focus();
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Email is required");
                txtEmail.Focus();
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                txtFname.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txtLname.Text = listView1.SelectedItems[0].SubItems[1].Text;
                cmbGender.Text = listView1.SelectedItems[0].SubItems[2].Text;
                txtContact.Text = listView1.SelectedItems[0].SubItems[3].Text;
                txtAddress.Text = listView1.SelectedItems[0].SubItems[4].Text;
                txtEmail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems[0].Remove();
            Clear();
            MessageBox.Show("Instructor record deleted successfully!!!");
        }

        private void txtFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
