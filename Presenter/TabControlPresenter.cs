using BarcodeCaseA.Model;
using BarcodeCaseA.Repository;
using BarcodeCaseA.View;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Windows.Forms;

namespace BarcodeCaseA.Presenter
{
    public class TabControlPresenter
    {
        private readonly ITabControl _view;
        private readonly SetModel _model;
        private readonly PortModel _port;
        private IEnumerable<CaseModel> _casemodel;
        private readonly IResultRepository _resultRepository;
        private BindingSource _dataBindingSource;
        private BindingSource _dataBindingSource2;
        private SerialPort serialPort;
        public string selectedName, message;

        public TabControlPresenter(TabControlDataPresenter data)
        {
            _view = data.View;
            _resultRepository = data.ResultRepository;
            _port = data.PortModel;
            _model = new SetModel();
            _dataBindingSource = new BindingSource();
            _dataBindingSource2 = new BindingSource();

            _view.InspectorId = data.User.Nik;
            _view.inspector = data.User.Name;

            LoadDataGridView();

            _port.PortOpen += startPort;
            _port.PortClose += stopPort;

            _view.Judgement += judgement;
            _view.LoadSetup += LoadSetup;
            _view.SelectedModel += SelectedModel;
            _view.SearchFilter += SearchFilter;
            _view.GetOpenPort += GetOpenPort;
        }

        public void GetOpenPort(object sender, EventArgs e)
        {
            _view.openPort = _port.OpenPort;
        }

        public void ChangeTabPage(int index)
        {
            _view.SelectTabPageByIndex(index);
        }

        public void SearchFilter(object sender, EventArgs e)
        {
            _casemodel = _resultRepository.GetFilter(_view.SelectedDate);
            _dataBindingSource2.DataSource = _casemodel;
            _view.SetDefectListBindingSource(_dataBindingSource2);
        }

        private void LoadDataGridView()
        {
            _view.SetDefectListBindingSource(_dataBindingSource);
            _view.SetDefectListBindingSource2(_dataBindingSource);
            _casemodel = _resultRepository.GetAll();
            _dataBindingSource.DataSource = _casemodel;
        }

        private void SelectedModel(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            string location = comboBox?.SelectedItem as string;

            if (comboBox?.SelectedItem != null)
            {
                selectedName = comboBox.SelectedItem.ToString();
                _view.serialNumber = _model.GetModelId(selectedName);
            }
        }

        private void LoadSetup(object sender, EventArgs e)
        {
            List<string> setModelNames = _model.GetSetModel();
            _view.setModel = setModelNames;
        }

        private void InitializeSerialPort()
        {
            serialPort = new SerialPort
            {
                PortName = _port.PortName,
                BaudRate = 115200,
                Parity = Parity.None,
                StopBits = StopBits.One,
                DataBits = 8,
                Handshake = Handshake.None
            };
        }

        private void startPort(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_port.PortName))
            {
                if (serialPort == null || !serialPort.IsOpen)
                {
                    try
                    {
                        InitializeSerialPort();
                        serialPort.Open();
                        message = "Port serial tersambung";
                        _view.StatusMessage(message);
                        _view.ChangeTextBoxColor(Color.Green, 1000);
                    }
                    catch (Exception ex)
                    {
                        message = "Error opening serial port: \n" + ex.Message;
                        _view.StatusMessage(message);
                        _view.ChangeTextBoxColor(Color.Yellow, 3500);
                    }
                }
                else
                {
                    message = "Port telah terbuka";
                    _view.StatusMessage(message);
                    _view.ChangeTextBoxColor(Color.Yellow, 3500);
                }
            }
            else
            {
                message = "Port belum dipilih";
                _view.StatusMessage(message);
                _view.ChangeTextBoxColor(Color.Yellow, 3500);
            }
        }

        public void stopPort(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
                message = "Port serial diputus";
                _view.StatusMessage(message);
                _view.ChangeTextBoxColor(Color.Green, 1000);
                _port.PortName = "";
            }
            else
            {
                message = "Serial port belum diinisialisasi atau sudah ditutup";
                _view.StatusMessage(message);
                _view.ChangeTextBoxColor(Color.Yellow, 3500);
            }
        }

        // Pembanding scan dengan barcode data
        private void judgement(object sender, EventArgs e)
        {
            _view.serialNumber = _view.serialNumber.Trim();

            if (_view.serialNumber == _view.scanData)
            {
                serialPort.Write("OK"); //Mengirim data ke serial
                _view.judgementData = "OK";
                _view.ChangePanelColor(Color.Green, 1500);
            }
            else
            {
                serialPort.Write("NG");//Mengirim data ke serial
                _view.judgementData = "NG";
                _view.ChangePanelColor(Color.Red, 3500);
            }
            CreateModel();
        }

        public void CreateModel()
        {
            DateTime currentDate = DateTime.Now; // Tanggal dan waktu saat tombol ditekan
            string formattedDate = currentDate.ToString("yyyy-MM-dd HH:mm:ss"); // Format tanggal dan waktu

            var model = new CaseModel
            {
                Date = formattedDate,
                ModelNumber = selectedName,
                GlobalCodeId = _view.serialNumber,
                ScanResult = _view.scanData,
                Adjustment = _view.judgementData,
                ModelCode = _model.GetModelCode(selectedName),
                InspectorId = _view.InspectorId
            };

            var result = _resultRepository.addData(model);
            if (result.success)
            {
                message = "Data berhasil disimpan.";
                _view.StatusMessage(message);
                _view.ChangeTextBoxColor(Color.Green, 1000);
            }
            else
            {
                message = result.errorMessage;
                _view.StatusMessage(message);
                _view.ChangeTextBoxColor(Color.Yellow, 3500);
            }
            LoadDataGridView();
        }

        public void UnassociateViewEvents()
        {
            _port.PortOpen -= startPort;
            _port.PortClose -= stopPort;

            _view.Judgement -= judgement;
            _view.LoadSetup -= LoadSetup;
            _view.SelectedModel -= SelectedModel;
            _view.SearchFilter -= SearchFilter;
            _view.GetOpenPort -= GetOpenPort;
        }
    }
}
