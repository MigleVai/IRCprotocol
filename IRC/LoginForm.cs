using System;
using System.Windows.Forms;

namespace IRC
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        public string NickName { get; set; }
        public string RealName { get; set; }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new ChatForm(nickTextBox.Text, realTextBox.Text);
            form.Closed += (s, args) => Close();
            form.Show();
        }
    }
}
