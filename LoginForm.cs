using System.Collections.Generic;
using System.Windows.Forms;

namespace UniApp2
{
    public partial class LoginForm : Form
    {
        public readonly Dictionary<string, string> Accounts;

        public LoginForm()
        {
            InitializeComponent();

            Accounts = new Dictionary<string, string>();
        }

        private void LoginButton_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(UserLabel.Text) || string.IsNullOrEmpty(PassLabel.Text))
                return;

            if (Accounts.TryGetValue(UserLabel.Text, out var outPass))
            {
                if (string.Equals(PassLabel.Text, outPass))
                {
                    MessageBox.Show(@"Logged in!");
                    return;
                }
            }

            MessageBox.Show(@"Bad creds!");
        }

        private void SignUpButton_Click(object sender, System.EventArgs e)
        {
            var signup = new SignUpForm(this);
            signup.ShowDialog();
        }
    }
}
