using BarcodeCaseA.Model;
using BarcodeCaseA.Presenter;
using BarcodeCaseA.Repository;
using BarcodeCaseA.View;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace BarcodeCaseA
{
    public partial class MainForm : Form, IMainForm
    {
        private TabControlPresenter tabControlPresenter;
        private readonly IResultRepository _addRepository;
        private LoginModel _user;

        public MainForm(LoginModel user)
        {
            _user = user;
            InitializeComponent();
            InitializeTabControl();
            HandleAction();
            btnScan.BackColor = Color.FromArgb(34, 40, 43);
            this.FormClosed += MainForm_FormClosed; // Menghubungkan event handler FormClosed
        }

        private void HandleAction()
        {
            btnScan.Click += delegate
            {
                int selectedTabPageIndex = 0;
                tabControlPresenter.ChangeTabPage(selectedTabPageIndex);
                btnScan.BackColor = Color.FromArgb(34, 40, 43);
                btnRecord.BackColor = Color.FromArgb(27, 140, 124);
            };

            btnRecord.Click += delegate
            {
                int selectedTabPageIndex = 1;
                tabControlPresenter.ChangeTabPage(selectedTabPageIndex);
                btnRecord.BackColor = Color.FromArgb(34, 40, 43);
                btnScan.BackColor = Color.FromArgb(27, 140, 124);
            };

            btnSetting.Click += (sender, e) =>
            {
                ISettingView settingView = SettingView.GetInstance();
                SettingPresenter settingPresenter = new SettingPresenter(settingView, new SettingModel());
                (settingView as Form)?.Show();
            };

            btnLogOut.Click += (sender, e) =>
            {
                // Menghentikan tabControlPresenter
                tabControlPresenter.stopPort(this, e);

                // Menyembunyikan view saat ini
                this.Hide();

                // Membuat dan menampilkan form login baru
                ILoginView loginView = new LoginView();
                LoginPresenter loginPresenter = new LoginPresenter(loginView, new LoginRepository());
                loginView.Show();

                // Menutup form saat ini
                this.Close();
            };
        }

        public void InitializeTabControl()
        {
            TabControlView tabControl = new TabControlView(); // Create the user control instance
            TabControlDataPresenter presenterData = new TabControlDataPresenter(tabControl, new ResultRepository(), _user);
            tabControlPresenter = new TabControlPresenter(presenterData); // Inisialisasi variabel instance
            splitContainer1.Panel2.Controls.Add(tabControl);
            tabControl.Dock = DockStyle.Fill;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0) // Pastikan tidak ada form yang terbuka
            {
                Application.Exit();
            }
        }

        // Singleton pattern (open a single form instance)
        private static MainForm instance;
        public static MainForm GetInstance(LoginModel loginModel)
        {
            if (instance == null || instance.IsDisposed)
                instance = new MainForm(loginModel);
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }
    }
}
