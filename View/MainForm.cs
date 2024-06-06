using BarcodeCaseA.Model;
using BarcodeCaseA.Presenter;
using BarcodeCaseA.Repository;
using System.Drawing.Printing;
using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using BarcodeCaseA.View;
using BarcodeCaseA.Properties;

namespace BarcodeCaseA
{
    public partial class MainForm : Form, IMainForm
    {
        private TabControlPresenter tabControlPresenter;
        private readonly IResultRepository _addRepository;
        public MainForm()
        {
            InitializeComponent();
            InitializeTabControl();
            HandleAction();
            btnScan.BackColor = Color.FromArgb(0, 173, 181);
        }

        private void HandleAction()
        {
            btnScan.Click += delegate
            {
                int selectedTabPageIndex = 0;
                tabControlPresenter.ChangeTabPage(selectedTabPageIndex);
                btnScan.BackColor = Color.FromArgb(0, 173, 181);
                btnRecord.BackColor = Color.FromArgb(34, 40, 43);
            };

            btnRecord.Click += delegate
            {
                int selectedTabPageIndex = 1;
                tabControlPresenter.ChangeTabPage(selectedTabPageIndex);
                btnRecord.BackColor = Color.FromArgb(0, 173, 181);
                btnScan.BackColor = Color.FromArgb(34, 40, 43);
            };

            btnLogOut.Click += (sender,e) =>
            {
                tabControlPresenter.stopPort(this, e);
                ILoginView loginView = new LoginView();
                LoginPresenter loginPresenter = new LoginPresenter(loginView, new LoginRepository());
                (loginView as Form)?.Show();
                this.Hide();
            };
        }

        public void InitializeTabControl()
        {
            TabControlView tabControl = new TabControlView(); // Create the user control instance
            tabControlPresenter = new TabControlPresenter(tabControl, new ResultRepository()); // Inisialisasi variabel instance
            splitContainer1.Panel2.Controls.Add(tabControl);
            tabControl.Dock = DockStyle.Fill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
