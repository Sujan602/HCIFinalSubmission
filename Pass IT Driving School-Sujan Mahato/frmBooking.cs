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
    public partial class frmBooking : Form
    {
        public static frmBooking booking;
        public Label studentFname, studentLname;
        public frmBooking()
        {
            InitializeComponent();
            booking = this;
            studentFname = lblStudentFname;
            studentLname = lblStudentLname;
        }

        private void frmBooking_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("First Name", 125);
            listView1.Columns.Add("Last Name", 125);
            listView1.Columns.Add("Course Type", 200);
            listView1.Columns.Add("Booking Date", 180);
            listView1.Columns.Add("Booking Hour", 170);
            listView1.Columns.Add("Instructor", 120);

            ListViewItem newItem = new ListViewItem("Sakriya");
            newItem.SubItems.Add("Khadka");
            newItem.SubItems.Add("Introductory");
            newItem.SubItems.Add("10/01/2024");
            newItem.SubItems.Add("2");
            newItem.SubItems.Add("Doug");
            listView1.Items.Add(newItem);

            ListViewItem newItem2 = new ListViewItem("Trilochan");
            newItem2.SubItems.Add("Lohani");
            newItem2.SubItems.Add("Standard");
            newItem2.SubItems.Add("12/01/2024");
            newItem2.SubItems.Add("1.5");
            newItem2.SubItems.Add("Jhon");
            listView1.Items.Add(newItem2);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbCourseType.Text == "")
            {
                MessageBox.Show("Course Type is required");
                cmbCourseType.Focus();
            }
            else if (cmbCourseType.Text == "")
            {
                MessageBox.Show("Course Type is required");
                cmbCourseType.Focus();
            }
            else
            {
                ListViewItem newItem = new ListViewItem(lblStudentFname.Text);
                newItem.SubItems.Add(lblStudentLname.Text);
                newItem.SubItems.Add(cmbCourseType.Text);
                newItem.SubItems.Add(dtpBookingDate.Text);
                newItem.SubItems.Add(bookinghour.Text);
                newItem.SubItems.Add(cmInstructor.Text);
                listView1.Items.Add(newItem);
                MessageBox.Show("Booking completed successfully!!!");
                Clear();
            }
        }
        public void Clear()
        {
            lblStudentFname.Text = "";
            lblStudentLname.Text = "";
            cmbCourseType.Text = "";
            dtpBookingDate.Text = "";
            bookinghour.Text = "";
            cmInstructor.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].SubItems[2].Text = cmbCourseType.Text;
                listView1.SelectedItems[0].SubItems[3].Text = dtpBookingDate.Text;
                listView1.SelectedItems[0].SubItems[4].Text = bookinghour.Text;
                listView1.SelectedItems[0].SubItems[5].Text = cmInstructor.Text;
                MessageBox.Show("Record is updated successfully!!!");
                Clear();
            }
            else if (cmbCourseType.Text == "")
            {
                MessageBox.Show("Course Type is required");
                cmbCourseType.Focus();
            }
            else if (dtpBookingDate.Text == "")
            {
                MessageBox.Show("Booking Date is required");
                dtpBookingDate.Focus();
            }
            else if (bookinghour.Text == "")
            {
                MessageBox.Show("Booking Hour is required");
                bookinghour.Focus();
            }
            else if (cmInstructor.Text == "")
            {
                MessageBox.Show("Instructor is required");
                cmInstructor.Focus();
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                lblStudentFname.Text = listView1.SelectedItems[0].SubItems[0].Text;
                lblStudentLname.Text = listView1.SelectedItems[0].SubItems[1].Text;
                cmbCourseType.Text = listView1.SelectedItems[0].SubItems[2].Text;
                dtpBookingDate.Text = listView1.SelectedItems[0].SubItems[3].Text;
                bookinghour.Text = listView1.SelectedItems[0].SubItems[4].Text;
                cmInstructor.Text = listView1.SelectedItems[0].SubItems[5].Text;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems[0].Remove();
            Clear();
            MessageBox.Show("Record deleted successfully!!!");
        }
    }
}
