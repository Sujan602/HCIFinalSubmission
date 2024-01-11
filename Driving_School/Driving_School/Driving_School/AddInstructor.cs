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
    public partial class AddInstructor : Form
    {
        public AddInstructor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem newItem = new ListViewItem(txtFirstName.Text);
            newItem.SubItems.Add(txtLastName.Text);
            newItem.SubItems.Add(cmbGender.Text);
            newItem.SubItems.Add(txtAddress.Text);
            newItem.SubItems.Add(txtContact.Text);
            listView1.Items.Add(newItem);
            Clear();
        }

        public void Clear()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            cmbGender.Text = "";
            txtAddress.Text = "";
            txtContact.Text = "";
        }


        private void AddInstructor_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("FirstName", 140);
            listView1.Columns.Add("LastName", 140);
            listView1.Columns.Add("Gender", 100);
            listView1.Columns.Add("ContactNumber", 140);
            listView1.Columns.Add("Address", 140);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].SubItems[0].Text = txtFirstName.Text;
                listView1.SelectedItems[0].SubItems[1].Text = txtLastName.Text;
                listView1.SelectedItems[0].SubItems[2].Text = cmbGender.Text;
                listView1.SelectedItems[0].SubItems[3].Text = txtContact.Text;
                listView1.SelectedItems[0].SubItems[4].Text = txtAddress.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void listView1_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                txtFirstName.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txtLastName.Text = listView1.SelectedItems[0].SubItems[1].Text;
                cmbGender.Text = listView1.SelectedItems[0].SubItems[2].Text;
                txtContact.Text = listView1.SelectedItems[0].SubItems[3].Text;
                txtAddress.Text = listView1.SelectedItems[0].SubItems[4].Text;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
