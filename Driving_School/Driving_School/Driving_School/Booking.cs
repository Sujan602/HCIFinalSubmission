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
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("StudentName", 140);
            listView1.Columns.Add("InstructorName", 140);
            listView1.Columns.Add("CourseType", 100);
            listView1.Columns.Add("BookingDate", 140);
            listView1.Columns.Add("BookingTime", 140);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem newItem = new ListViewItem(cmbstudentName.Text);
            newItem.SubItems.Add(cmbinstructor.Text);
            newItem.SubItems.Add(coursetype.Text);
            newItem.SubItems.Add(dtpdate.Text);
            newItem.SubItems.Add(dtptime.Text);
            listView1.Items.Add(newItem);
            Clear();
        }
        public void Clear()
        {
            cmbstudentName.Text = "";
            cmbinstructor.Text = "";
            coursetype.Text = "";
            dtpdate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            dtptime.Text = DateTime.UtcNow.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].SubItems[0].Text = cmbstudentName.Text;
                listView1.SelectedItems[0].SubItems[1].Text = cmbinstructor.Text;
                listView1.SelectedItems[0].SubItems[2].Text = coursetype.Text;
                listView1.SelectedItems[0].SubItems[3].Text = dtpdate.Text;
                listView1.SelectedItems[0].SubItems[4].Text = dtptime.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
