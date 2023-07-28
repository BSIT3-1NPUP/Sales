using Sales;

namespace LoginSignUp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UserIcon_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UserInputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserColon_Click(object sender, EventArgs e)
        {

        }

        private void PasswordInputBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            SignUpForm fsignup = new SignUpForm();
            fsignup.Show();
            this.Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }
    }
}