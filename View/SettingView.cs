using BarcodeCaseA.Presenter;
using BarcodeCaseA.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarcodeCaseA.View
{
    public partial class SettingView : Form, ISettingView
    {
        private SerialPort serialPort;
        public SettingView()
        {
            InitializeComponent();
            HandleAction();
        }

        public string ipaddress
        {
            get => textBoxIP.Text;
            set => textBoxIP.Text = value;
        }
        public string portaddress
        {
            get { return textBoxPort.Text; }
            set { textBoxPort.Text = value; }
        }

        public string portName
        {
            get { return portBox.Text; }
            set { portBox.Text = value; }
        }

        public event EventHandler SaveIPSettings;
        public event EventHandler SavePortSettings;
        public event EventHandler LoadIP;
        public event EventHandler LoadPort;
        public event EventHandler okButton;
        public event EventHandler cnclButton;
        public event EventHandler getPortName;

        private void loadSetModel()
        {
            portBox.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            portBox.Items.AddRange(ports);
        }

        public void DisplayIP(string IPaddress)
        {
            textBoxIP.Text = IPaddress;
        }

        public void DisplayPort(int Port)
        {
            textBoxPort.Text = Port.ToString();
        }

        private void HandleAction()
        {
            btnOpen.Click += (sender, e) =>
            {
                if (portBox.Text != "")
                {
                    okButton?.Invoke(sender, e);
                    //openPort = true;
                }
            };

            btnClose.Click += (sender, e) =>
            {
                cnclButton?.Invoke(sender, e);
                //openPort = false;
            };

            btnRefresh.Click += (sender, e) =>
            {
                portBox.Text = "";
                loadSetModel();
            };

            textBoxIP.TextChanged += (sender, e) =>
            {
                SaveIPSettings?.Invoke(this, EventArgs.Empty);
            };

            textBoxPort.TextChanged += (sender, e) =>
            {
                SavePortSettings?.Invoke(this, EventArgs.Empty);
            };

            btnConnect.Click += (sender, e) =>
            {
                ILoginView loginView = new LoginView();
                LoginPresenter loginPresenter = new LoginPresenter(loginView, new LoginRepository());
                (loginView as Form)?.Show();
                this.Close();
            };
        }

        private static SettingView instance;
        public static SettingView GetInstance()
        {
            if (instance == null || instance.IsDisposed)
                instance = new SettingView();
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }

        private void SettingView_Load(object sender, EventArgs e)
        {
            loadSetModel();
            getPortName?.Invoke(this, EventArgs.Empty);
            LoadIP?.Invoke(this, EventArgs.Empty);
            LoadPort?.Invoke(this, EventArgs.Empty);
        }
    }
}
