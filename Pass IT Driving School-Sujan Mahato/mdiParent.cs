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
    public partial class mdiParent : Form
    {
        private int childFormNumber = 0;

        public static mdiParent mdp;
        public Label currentUser;
        public mdiParent()
        {
            InitializeComponent();
            mdp = this;
            currentUser = lblUser;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void mdiParent_Load(object sender, EventArgs e)
        {

        }
        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddStudent addStd = new frmAddStudent();
            addStd.Show();
        }

        private void addInstructorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddInstructor addInst = new frmAddInstructor();
            addInst.Show();
        }

        private void addCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddCar addC = new frmAddCar();
            addC.Show();
        }

        private void addStudentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAddStudent frmStd = new frmAddStudent();
            frmStd.Show();
        }

        private void addInstructorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAddInstructor frmIns = new frmAddInstructor();
            frmIns.Show();
        }

        private void addCarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAddCar frmCar = new frmAddCar();
            frmCar.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
