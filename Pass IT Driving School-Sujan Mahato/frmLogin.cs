namespace WinFormsApp6
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Sujan" && txtPassword.Text == "Sujan")
            {
                mdiParent mdiParent = new mdiParent();
                mdiParent.Show();
                mdiParent.mdp.currentUser.Text = txtUsername.Text;
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!!");
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
