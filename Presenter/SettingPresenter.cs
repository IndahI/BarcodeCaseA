using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarcodeCaseA.View;
using BarcodeCaseA.Model;

namespace BarcodeCaseA.Presenter
{
    public class SettingPresenter
    {
        private readonly ISettingView _view;
        private readonly SettingModel _model;
        private readonly PortModel _port;
        public SettingPresenter(ISettingView view, SettingModel model, PortModel port)
        {
            _view = view;
            _model = model;
            _port = port;

            _view.SaveIPSettings += SaveIPSettings;
            _view.SavePortSettings += SavePortSettings;
            _view.LoadIP += View_LoadIP;
            _view.LoadPort += View_LoadPort;
            _view.okButton += OkButton;
            _view.cnclButton += CnclButton;
            _view.getPortName += GetPortName;
        }

        private void GetPortName(object sender, EventArgs e)
        {
            _view.portName = _port.PortName;
        }

        private void CnclButton(object sender, EventArgs e)
        {
            _port.PortName = _view.portName;
            _port.OpenPort = false;
        }

        private void OkButton(object sender, EventArgs e)
        {
            _port.PortName = _view.portName;
            _port.OpenPort = true;
        }

        private void View_LoadIP(object sender, EventArgs e)
        {
            string loadedIP = _model.LoadIP();
            _view.DisplayIP(loadedIP);
        }

        private void View_LoadPort(object sender, EventArgs e)
        {
            int loadedPort = _model.LoadPort();
            _view.DisplayPort(loadedPort);
        }

        private void SaveIPSettings(object sender, EventArgs e)
        {
            _model.SaveSettingIP(_view.ipaddress);
        }

        private void SavePortSettings(object sender, EventArgs e)
        {
            _model.SaveSettingPort(_view.portaddress);
        }

    }
}
