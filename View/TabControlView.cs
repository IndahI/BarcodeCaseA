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
        private void TabControl_Load(object sender, EventArgs e)
        {
            isInitializing = true;
            //toolTip.SetToolTip(label5, "Copyright © 2024 PENS & UNSURYA");
            LoadSetup?.Invoke(sender, e);
            loadSetModel();
            isInitializing = false;
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

        private bool CheckVariable(object sender, KeyEventArgs e)
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
                openPort = true;
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
                row.Cells["No"].Value = (e.RowIndex + 1).ToString();
                row.Cells["No"].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            };
        }
        //Mengubah nilai enumerasi Keys ke representasi string yang sesuai.
        public KeysConverter keysConverter = new KeysConverter();

        //Handle scanning data 
        private void scanBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (CheckVariable(this, e))
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
                //ChangeLabelsFontColor(tabPage1, Color.White);

                // Mengatur timer untuk mengembalikan warna kembali ke default setelah waktu tertentu
                var revertTimer = new System.Windows.Forms.Timer
                {
                    Interval = timerInterval // menggunakan parameter timerInterval
                };
                revertTimer.Start(); // Timer menyal
                revertTimer.Tick += (sender, e) =>
                {
                    //ChangeLabelsFontColor(tabPage1, SystemColors.ControlText);
                    statusText.BackColor = SystemColors.Control; // Mengembalikan ke warna default
                    statusText.Text = "";
                    revertTimer.Stop(); // Timer mati
                   
                };
            }));
        }

        /***
        private void ChangeLabelsFontColor(TabPage tabPage, Color newColor)
        {
            // Loop through each control in the TabPage
            foreach (Control control in tabPage.Controls)
            {
                // Loop through each control in the FlowLayoutPanel
                foreach (Control innerControl in tabPage.Controls)
                {
                    // Check if the inner control is a Label
                    if (innerControl is Label)
                    {
                        Label label = (Label)innerControl;
                        // Change the font color of the label
                        label.ForeColor = newColor;
                    }
                }
            }
        }
        ***/
    }
}

