using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarcodeCaseA.View
{
    public partial class LoginView : Form, ILoginView
    {
        public LoginView()
        {
            InitializeComponent();
            HandleAction();
            textBoxNik.Focus();
        }

        public string Nik
        {
            get { return textBoxNik.Text; }
            set { textBoxNik.Text = value; }
        }

        public string Password
        {
            get { return textBoxPassword.Text; }
            set { textBoxPassword.Text = value; }
        }

        public bool IsLoginSuccessful { get; private set; }

        public event EventHandler Login;

        public void HideView()
        {
            this.Hide();
        }
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void HandleAction()
        {
            btnLogin.Click += (sender, e) =>
            {
                if (!string.IsNullOrWhiteSpace(Nik))
                {
                    Login?.Invoke(this, EventArgs.Empty);
                }
            };

            btnExit.Click += delegate
            {
                Application.Exit();
            };
        }

        private void textBoxNik_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(Nik))
            {
                Login?.Invoke(this, EventArgs.Empty);
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(Nik))
            {
                Login?.Invoke(this, EventArgs.Empty);
            }
        }

        private void LoginView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
