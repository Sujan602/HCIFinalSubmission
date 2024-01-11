using System.Collections.Generic;
using System.Resources;

namespace ViewData
{
    public partial class Form1 : Form
    {
        public List<StudentRecord> StudentRecords;
        public Form1()
        {
            StudentRecords = GetStudents();
            InitializeComponent();
        }

        private List<StudentRecord> GetStudents()
        {
            var l = new List<StudentRecord>();
            l.Add(new StudentRecord()
            {
                StudentId = 2,
                FirstName = "Sujan2",
                LastName = "Mahato2",
                Email = "sujan12@gmail.com",
                Phone = "9876543",
                Gender = "Male"
            });
            l.Add(new StudentRecord()
            {
                StudentId = 3,
                FirstName = "Sujan33",
                LastName = "Mahato3",
                Email = "sujan12@gmail.com",
                Phone = "9876543",
                Gender = "Male"
            });
            l.Add(new StudentRecord()
            {
                StudentId = 4,
                FirstName = "Sujan4",
                LastName = "Mahato4",
                Email = "sujan12@gmail.com",
                Phone = "9876543",
                Gender = "Male"
            });
            l.Add(new StudentRecord()
            {
                StudentId = 5,
                FirstName = "Sujan5",
                LastName = "Mahato5",
                Email = "sujan12@gmail.com",
                Phone = "9876543",
                Gender = "Male"
            });
            return l;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var sRecord = this.StudentRecords;
            dataGridView1.DataSource = sRecord;
            dataGridView1.Columns["StudentId"].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var selectedStudent = dataGridView1.SelectedRows[0].DataBoundItem as StudentRecord;
                txtStudentId.Text = selectedStudent.StudentId.ToString();
                txtFirstName.Text = selectedStudent.FirstName.ToString();
                txtLastName.Text = selectedStudent.LastName.ToString();
                txtEmail.Text = selectedStudent.Email.ToString();
                txtPhone.Text = selectedStudent.Phone.ToString();
                txtGender.Text = selectedStudent.Gender.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some Error:" + ex.Message + "  -  " + ex.Source);
            }
        }
    }
}