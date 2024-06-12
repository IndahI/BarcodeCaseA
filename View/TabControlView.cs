using System;
using System.Data;
using System.IO.Ports;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BarcodeCaseA.View
{
    public partial class TabControlView : UserControl, ITabControl
    {

        //Variabel yang digunakan
        private Color defaultColor;
        private string latestReceivedData;
        private string inspectorId;
        private TCPConnection connection;
        //private ToolTip toolTip;
        private bool openPort, indexSelect = false;
        private bool isInitializing;
        private bool isKeyboardEnabled = true;
        private SerialPort serialPort;

        public TabControlView()
        {

            InitializeComponent();
            HandleAction();
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            //toolTip = new ToolTip();
        }


        //variabel
        public string scanData
        {
            get { return scanBox.Text; }
            set { scanBox.Text = value; }
        }

        public List<string> setModel
        {
            get => setModelBox.DataSource as List<string>;
            set => setModelBox.DataSource = value;
        }
        public string serialNumber
        {
            get { return selectIdText.Text; }
            set { selectIdText.Text = value; }
        }
        public string judgementData
        {
            get { return jdgText.Text; }
            set { jdgText.Text = value; }
        }

        public string portName
        {
            get { return portBox.Text; }
            set { portBox.Text = value; }
        }

        public string status
        {
            get { return statusText.Text; }
            set { statusText.Text = value; }
        }

        public string inspector
        {
            get { return textBoxInspector.Text; }
            set { textBoxInspector.Text = value; }
        }

        public string InspectorId
        {
            get { return inspectorId; }
            set { inspectorId = value; }
        }

        public DateTime SelectedDate => dtFromDate.Value;

        //event
        public event EventHandler Judgement;
        public event EventHandler okClickedButton;
        public event EventHandler cnclClickedButton;
        public event EventHandler LoadSetup;
        public event EventHandler SelectedModel;
        public event EventHandler SearchFilter;

        public void StatusMessage(string message)
        {
            statusText.Text = message;
        }
        private async void TabControl_Load(object sender, EventArgs e)
        {
            isInitializing = true;
            timer1.Start();
            //toolTip.SetToolTip(label5, "Copyright © 2024 PENS & UNSURYA");
            LoadSetup?.Invoke(sender, e);
            loadSetModel();
            isInitializing = false;
            connection = new TCPConnection(UpdateScanBox);
            await connection.ConnectToServerAsync();
        }

        private void UpdateScanBox(string message)
        {
            // Invoke UI updates on the UI thread
            if (scanBox.InvokeRequired)
            {
                scanBox.Invoke((MethodInvoker)(() => UpdateScanBox(message)));
            }
            else
            {
                scanBox.Text = message;
            }
            if (CheckVariable())
            {
                Judgement?.Invoke(this, EventArgs.Empty);
            }
        }

        private void loadSetModel()
        {
            portBox.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            portBox.Items.AddRange(ports);
        }

        public void SelectTabPageByIndex(int data)
        {
            if (data >= 0 && data < tabControl1.TabPages.Count)
            {
                tabControl1.SelectedIndex = data;
            }
        }

        public void SetDefectListBindingSource(BindingSource model)
        {
            dataGridView1.DataSource = model;
        }

        private bool CheckVariable()
        {
            if (openPort && indexSelect)
            {
                return true;
            }
            else if (!indexSelect)
            {
                string message = "Pilih Model dulu";
                scanBox.Text = "";
                StatusMessage(message);
                ChangeTextBoxColor(Color.Yellow, 3500);
            }
            else if (!openPort)
            {
                string message = "Pilih Port dulu";
                scanBox.Text = "";
                StatusMessage(message);
                ChangeTextBoxColor(Color.Yellow, 3500);
            }

            return false;
        }

        private void HandleAction()
        {
            setModelBox.SelectedIndexChanged += (sender, e) =>
            {
                if (!isInitializing)
                {
                    indexSelect = true;
                    SelectedModel?.Invoke(sender, e);
                    scanBox.Focus();
                }
            };

            btnOpen.Click += (sender, e) =>
            {
                okClickedButton?.Invoke(sender, e);
                if (portBox.Text != "")
                {
                    openPort = true;
                }
                scanBox.Focus();
            };

            btnClose.Click += (sender, e) =>
            {
                cnclClickedButton?.Invoke(sender, e);
                openPort = false;
            };

            btnClear.Click += delegate
            {
                scanBox.Text = "";
                setModelBox.Text = "";
            };

            btnRefresh.Click += (sender, e) =>
            {
                portBox.Text = "";
                loadSetModel();
            };

            btnSearch.Click += (sender, e) =>
            {
                SearchFilter?.Invoke(sender, e);
            };

            dataGridView1.RowPostPaint += (sender, e) =>
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int totalRows = dataGridView1.Rows.Count;
                row.Cells["No"].Value = (totalRows - e.RowIndex).ToString();
                row.Cells["No"].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            };

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 18, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersHeight = 40;

            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 16);
            dataGridView1.RowTemplate.Height = 50;

            timer1.Tick += delegate
            {
                timeHeader.Text = DateTime.Now.ToLongTimeString();
                DateHeader.Text = DateTime.Now.ToLongDateString();
            };
        }
        //Mengubah nilai enumerasi Keys ke representasi string yang sesuai.
        public KeysConverter keysConverter = new KeysConverter();

        //Handle scanning data 
        private void scanBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (CheckVariable())
            {
                if (isKeyboardEnabled)
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        e.SuppressKeyPress = true;
                        BeginInvoke(new Action(() =>
                        {
                            Judgement?.Invoke(sender, e);
                            isKeyboardEnabled = false;
                        }));
                    }
                    else
                    {
                        string character = new KeysConverter().ConvertToString(e.KeyCode);
                        latestReceivedData += character;
                    }
                }
                else
                {
                    e.SuppressKeyPress = true;
                }
            }

        }

        //Mengganti warna background form jika sudah dievaluasi
        public void ChangePanelColor(Color newColor, int timerInterval)
        {
            BeginInvoke(new Action(() =>
            {
                jdgText.Visible = true;
                if (defaultColor == Color.Empty)
                {
                    defaultColor = panel1.BackColor;
                }

                // Mengubah warna background form 
                panel1.BackColor = newColor;

                // Mengatur timer untuk mengembalikan warna kembali ke default setelah waktu tertentu
                var revertTimer = new System.Windows.Forms.Timer
                {
                    Interval = timerInterval // menggunakan parameter timerInterval
                };
                revertTimer.Start(); // Timer menyal
                revertTimer.Tick += (sender, e) =>
                {
                    panel1.BackColor = defaultColor; // Mengembalikan ke warna default
                    scanBox.Clear();
                    revertTimer.Stop(); // Timer mati
                    jdgText.Visible = false;
                    isKeyboardEnabled = true; //Mengembalikan ke loop scan agar bisa menerima input keyboard kembali
                };
            }));
        }

        public void ChangeTextBoxColor (Color newColor, int timerInterval)
        {
            BeginInvoke(new Action(() =>
            {
                // Mengubah warna background form 
                statusText.BackColor = newColor;
                if (newColor == Color.Green) 
                { ChangeLabelsFontColor(Color.White); }

                // Mengatur timer untuk mengembalikan warna kembali ke default setelah waktu tertentu
                var revertTimer = new System.Windows.Forms.Timer
                {
                    Interval = timerInterval // menggunakan parameter timerInterval
                };
                revertTimer.Start(); // Timer menyala
                revertTimer.Tick += (sender, e) =>
                {
                    ChangeLabelsFontColor(SystemColors.WindowText);
                    statusText.BackColor = Color.FromArgb(220, 225, 230); // Mengembalikan ke warna default
                    statusText.Text = "";
                    revertTimer.Stop(); // Timer mati
                   
                };
            }));
        }

        
        private void ChangeLabelsFontColor(Color newColor)
        {
            statusText.ForeColor = newColor;
        }
        
    }
}

