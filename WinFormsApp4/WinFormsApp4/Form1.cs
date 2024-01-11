namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String userName, userPassword;
            userName = textBox1.Text;
            userPassword = textBox2.Text;
        }
    }
}