using System;
using System.Windows.Forms;

namespace UniApp2
{
    public partial class SignUpForm : Form
    {
        private readonly LoginForm _lf;

        public SignUpForm(LoginForm lf)
        {
            InitializeComponent();

            _lf = lf;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UsernameEntry.Text) || string.IsNullOrEmpty(PasswordEntry.Text))
                return;

            if (_lf.Accounts.ContainsKey(UsernameEntry.Text))
            {
                MessageBox.Show(@"Account already exists!");
                return;
            }

            _lf.Accounts.Add(UsernameEntry.Text, PasswordEntry.Text);

            Close();
        }
    }
}
