using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeCaseA.View
{
    public interface ITabControl
    {
        string scanData { get; set; }
        List<string> setModel { get; set; }
        string serialNumber { get;  set; }
        string judgementData { get; set; }
        string status { get; set; }
        string inspector { get; set; }
        string InspectorId { get; set; }

        bool openPort { get; set; }

        DateTime SelectedDate { get; }

        event EventHandler Judgement;
        event EventHandler LoadSetup;
        event EventHandler SelectedModel;
        event EventHandler SearchFilter;
        event EventHandler GetOpenPort;

        void StatusMessage(string message);
        void SelectTabPageByIndex(int data);
        void SetDefectListBindingSource(BindingSource model);
        void SetDefectListBindingSource2(BindingSource model);
        void ChangePanelColor(Color newColor, int timerInterval);
        void ChangeTextBoxColor(Color newColor, int timerInterval);
    }
}
