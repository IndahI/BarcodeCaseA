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
        private Color defaultColor;
        private string latestReceivedData;
        private string inspectorId;
        private TCPConnection connection;
        private bool indexSelect;
        private bool isInitializing;
        private bool isKeyboardEnabled = true;

        public TabControlView()
        {
            InitializeComponent();
            HandleAction();
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
        }

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
        public bool openPort { get; set; }
        public DateTime SelectedDate => dtFromDate.Value;

        public event EventHandler Judgement;
        public event EventHandler LoadSetup;
        public event EventHandler SelectedModel;
        public event EventHandler SearchFilter;
        public event EventHandler GetOpenPort;

        private bool CheckVariable()
        {
            GetOpenPort?.Invoke(this, EventArgs.Empty);

            if (openPort && indexSelect)
            {
                return true;
            }
            else if (!indexSelect)
            {
                string message = "Pilih Model dulu";
                scanData = "";
                StatusMessage(message);
                ChangeTextBoxColor(Color.Yellow, 3500);
            }
            else if (!openPort)
            {
                string message = "Pilih Port dulu";
                scanData = "";
                StatusMessage(message);
                ChangeTextBoxColor(Color.Yellow, 3500);
            }

            return false;
        }

        public void StatusMessage(string message)
        {
            statusText.Text = message;
        }

        private async void TabControl_Load(object sender, EventArgs e)
        {
            isInitializing = true;
            timer1.Start();
            LoadSetup?.Invoke(sender, e);
            isInitializing = false;
            connection = new TCPConnection(UpdateScanBox);
            await connection.ConnectToServerAsync();
        }

        private void UpdateScanBox(string message)
        {
            if (scanBox.InvokeRequired)
            {
                scanBox.Invoke((MethodInvoker)(() => UpdateScanBox(message)));
            }
            else
            {
                scanBox.Text = message;
            }
            if (scanBox.Text == 'NoRead')
            {
                scanBox.Text == '';
            }
            else if (CheckVariable())
            {
                Judgement?.Invoke(this, EventArgs.Empty);
            }
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

        public void SetDefectListBindingSource2(BindingSource model)
        {
            dataGridView2.DataSource = model;
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

            btnClear.Click += (sender, e) =>
            {
                scanBox.Text = "";
                setModelBox.Text = "";
            };

            btnSearch.Click += (sender, e) =>
            {
                SearchFilter?.Invoke(sender, e);
            };

            panel1.Resize += (sender, e) =>
            {
                jdgText.Size = panel1.ClientSize;
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

            dataGridView2.RowPostPaint += (sender, e) =>
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                int totalRows = dataGridView1.Rows.Count;
                row.Cells["No2"].Value = (totalRows - e.RowIndex).ToString();
                row.Cells["No2"].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            };

            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 18, FontStyle.Bold);
            dataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.ColumnHeadersHeight = 40;
            dataGridView2.DefaultCellStyle.Font = new Font("Arial", 16);
            dataGridView2.RowTemplate.Height = 50;


            timer1.Tick += (sender, e) =>
            {
                timeHeader.Text = DateTime.Now.ToLongTimeString();
                DateHeader.Text = DateTime.Now.ToLongDateString();
            };
        }

        public void ChangePanelColor(Color newColor, int timerInterval)
        {
            BeginInvoke(new Action(() =>
            {
                jdgText.Visible = true;
                if (defaultColor == Color.Empty)
                {
                    defaultColor = panel1.BackColor;
                }

                panel1.BackColor = newColor;

                var revertTimer = new System.Windows.Forms.Timer
                {
                    Interval = timerInterval
                };
                revertTimer.Start();
                revertTimer.Tick += (sender, e) =>
                {
                    panel1.BackColor = defaultColor;
                    scanBox.Clear();
                    revertTimer.Stop();
                    jdgText.Visible = false;
                    isKeyboardEnabled = true;
                };
            }));
        }

        public void ChangeTextBoxColor(Color newColor, int timerInterval)
        {
            BeginInvoke(new Action(() =>
            {
                statusText.BackColor = newColor;
                if (newColor == Color.Green)
                {
                    ChangeLabelsFontColor(Color.White);
                }

                var revertTimer = new System.Windows.Forms.Timer
                {
                    Interval = timerInterval
                };
                revertTimer.Start();
                revertTimer.Tick += (sender, e) =>
                {
                    ChangeLabelsFontColor(SystemColors.WindowText);
                    statusText.BackColor = Color.FromArgb(220, 225, 230);
                    statusText.Text = "";
                    revertTimer.Stop();
                };
            }));
        }

        private void ChangeLabelsFontColor(Color newColor)
        {
            statusText.ForeColor = newColor;
        }

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
    }
}

