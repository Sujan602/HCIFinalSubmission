namespace WinFormsApp5
{
    public partial class frmMainform : Form
    {
        public frmMainform()
        {
            InitializeComponent();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddStudent f2 = new frmAddStudent();
            f2.Show(); // Shows Form2
        }
        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewStudentList sl = new frmViewStudentList();
            sl.Show();
        }

        private void addInstructorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInstructor instructor = new frmInstructor();
            instructor.Show();
        }

        private void editStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditStudent f2 = new frmEditStudent();
            f2.Show();
        }

        private void addAdminsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegister register = new frmRegister();
            register.Show();
        }

        private void addCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCar frmCar = new frmCar();
            frmCar.Show();
        }

        private void studentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmViewStudentList viewStudentList = new frmViewStudentList();
            viewStudentList.Show();
        }

        private void frmMainform_Load(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}