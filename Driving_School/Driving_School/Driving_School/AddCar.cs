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
    public partial class AddCar : Form
    {
        public AddCar()
        {
            InitializeComponent();
        }

        private void AddCar_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Make", 140);
            listView1.Columns.Add("Model", 140);
            listView1.Columns.Add("Year", 100);
            listView1.Columns.Add("Licence Plate", 140);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem newItem = new ListViewItem(txtmake.Text);
            newItem.SubItems.Add(txtmodel.Text);
            newItem.SubItems.Add(txtyear.Text);
            newItem.SubItems.Add(txtlicenceeplate.Text);
            listView1.Items.Add(newItem);
            Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].SubItems[0].Text = txtmake.Text;
                listView1.SelectedItems[0].SubItems[1].Text = txtmodel.Text;
                listView1.SelectedItems[0].SubItems[2].Text = txtyear.Text;
                listView1.SelectedItems[0].SubItems[3].Text = txtlicenceeplate.Text;
            }
        }
        public void Clear()
        {
            txtmake.Text = "";
            txtmodel.Text = "";
            txtyear.Text = "";
            txtlicenceeplate.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
