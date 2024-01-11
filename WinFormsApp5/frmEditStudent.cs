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
    public partial class frmEditStudent : Form
    {
        public frmEditStudent()
        {
            InitializeComponent();
        }

        private void frmEditStudent_Load(object sender, EventArgs e)
        {
            Object[] studentDataList = new Object[] {"Sujan","Mahato","Male","sujan@gmail.com","9876543","Birmingham Selly Oak" };
            dataGridView1.Rows.Add(studentDataList);
        }
    }
}
