using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginSignUp
{
    public partial class SignUpForm : Form
    {
        UserDataForm fgrid = new UserDataForm();
        public SignUpForm()
        {
            InitializeComponent();
            
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void SUbackBTTN_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm flogin = new LoginForm();
            flogin.Show();
        }

        private void SignButtonUp_Click(object sender, EventArgs e)
        {
            fgrid.AccDGV.Rows.Add(UserRegTxtBx.Text, PassRegTxtBx.Text);
            this.Close();
            LoginForm flogin = new LoginForm();
            flogin.Show();
        }
    }
}
