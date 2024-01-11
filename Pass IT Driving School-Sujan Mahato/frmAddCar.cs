using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class frmAddCar : Form
    {
        public frmAddCar()
        {
            InitializeComponent();
        }

        private void frmAddCar_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Make", 140);
            listView1.Columns.Add("Model", 140);
            listView1.Columns.Add("Year", 110);
            listView1.Columns.Add("License Plate", 200);
            listView1.Columns.Add("Last Servicing Date", 200);
            listView1.Columns.Add("Next Servicing Date", 205);

            ListViewItem newItem = new ListViewItem("Ford");
            newItem.SubItems.Add("Ford Mustang");
            newItem.SubItems.Add("2022");
            newItem.SubItems.Add("AA 23 BCI");
            newItem.SubItems.Add("01/12/2024");
            newItem.SubItems.Add("04/12/2024");
            listView1.Items.Add(newItem);

            ListViewItem newItem2 = new ListViewItem("Toyota");
            newItem2.SubItems.Add("Land Cruiser");
            newItem2.SubItems.Add("2024");
            newItem2.SubItems.Add("N473 BCI");
            newItem2.SubItems.Add("01/22/2024");
            newItem2.SubItems.Add("05/22/2024");
            listView1.Items.Add(newItem2);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMake.Text == "")
            {
                MessageBox.Show("Car Make is required");
                txtMake.Focus();
            }
            else if (txtModel.Text == "")
            {
                MessageBox.Show("Car Model is required");
                txtModel.Focus();
            }
            else if (txtYear.Text == "")
            {
                MessageBox.Show("Car made year is required");
                txtYear.Focus();
            }
            else if (txtLicensePlate.Text == "")
            {
                MessageBox.Show("Car plate number is required");
                txtLicensePlate.Focus();
            }
            else if (txtLicensePlate.TextLength < 5)
            {
                MessageBox.Show("Car plate number is invalid");
                txtLicensePlate.Focus();
            }
            else
            {
                ListViewItem newItem = new ListViewItem(txtMake.Text);
                newItem.SubItems.Add(txtModel.Text);
                newItem.SubItems.Add(txtYear.Text);
                newItem.SubItems.Add(txtLicensePlate.Text);
                newItem.SubItems.Add(dtpLastServicingDate.Text);
                newItem.SubItems.Add(dtpNextServicingDate.Text);
                listView1.Items.Add(newItem);
                MessageBox.Show("Car is added successfully!!!");
                Clear();
            }
        }

        public void Clear()
        {
            txtMake.Text = "";
            txtModel.Text = "";
            txtYear.Text = "";
            txtLicensePlate.Text = "";
            dtpLastServicingDate.Text = "";
            dtpNextServicingDate.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].SubItems[0].Text = txtMake.Text;
                listView1.SelectedItems[0].SubItems[1].Text = txtModel.Text;
                listView1.SelectedItems[0].SubItems[2].Text = txtYear.Text;
                listView1.SelectedItems[0].SubItems[3].Text = txtLicensePlate.Text;
                listView1.SelectedItems[0].SubItems[4].Text = dtpLastServicingDate.Text;
                listView1.SelectedItems[0].SubItems[5].Text = dtpNextServicingDate.Text;
                MessageBox.Show("Record is updated successfully!!!");
                Clear();
            }
            if (txtMake.Text == "")
            {
                MessageBox.Show("Car Make is required");
                txtMake.Focus();
            }
            else if (txtModel.Text == "")
            {
                MessageBox.Show("Car Model is required");
                txtModel.Focus();
            }
            else if (txtYear.Text == "")
            {
                MessageBox.Show("Car made year is required");
                txtYear.Focus();
            }
            else if (txtLicensePlate.Text == "")
            {
                MessageBox.Show("Car plate number is required");
                txtLicensePlate.Focus();
            }
            else if (txtLicensePlate.TextLength < 5)
            {
                MessageBox.Show("Car plate number is invalid");
                txtLicensePlate.Focus();
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                txtMake.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txtModel.Text = listView1.SelectedItems[0].SubItems[1].Text;
                txtYear.Text = listView1.SelectedItems[0].SubItems[2].Text;
                txtLicensePlate.Text = listView1.SelectedItems[0].SubItems[3].Text;
                dtpLastServicingDate.Text = listView1.SelectedItems[0].SubItems[4].Text;
                dtpNextServicingDate.Text = listView1.SelectedItems[0].SubItems[5].Text;
            }
        }

        private void txtMake_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLicensePlate_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtLicensePlate_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems[0].Remove();
            Clear();
            MessageBox.Show("Record deleted successfully!!!");
        }
    }
}
