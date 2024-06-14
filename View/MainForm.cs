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
        private LoginModel _user;
        private readonly PortModel _portModel;

        public MainForm(LoginModel user)
        {
            _user = user;
            _portModel = new PortModel();
            InitializeComponent();
            InitializeTabControl();
            HandleAction();
            btnScan.BackColor = Color.FromArgb(34, 40, 43);
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
                SettingPresenter settingPresenter = new SettingPresenter(settingView, new SettingModel(), _portModel);
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
            if (tabControlPresenter != null)
            {
                tabControlPresenter.UnassociateViewEvents(); // Tambahkan ini untuk menghapus event handler yang ada
            }

            TabControlView tabControl = new TabControlView(); // Create the user control instance
            TabControlDataPresenter presenterData = new TabControlDataPresenter(tabControl, new ResultRepository(), _user, _portModel);
            tabControlPresenter = new TabControlPresenter(presenterData); // Inisialisasi variabel instance
            splitContainer1.Panel2.Controls.Add(tabControl);
            tabControl.Dock = DockStyle.Fill;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
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
                instance._user = loginModel; // Set new user
                instance.InitializeTabControl();
            }
            return instance;
        }
    }
}
