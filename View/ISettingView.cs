using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeCaseA.View
{
    public interface ISettingView
    {
        string ipaddress { get; set; }
        string portaddress { get; set; }

        event EventHandler SaveIPSettings;
        event EventHandler SavePortSettings;
        event EventHandler LoadIP;
        event EventHandler LoadPort;

        void DisplayIP(string IPaddress);
        void DisplayPort(int portAddress);
    }
}
