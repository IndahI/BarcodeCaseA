using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeCaseA.View
{
    public interface ITabControl
    {
        public string scanData { get; set; }
        public List<string> setModel { get; set; }
        public string serialNumber { get;  set; }
        public string judgementData { get; set; }
        public string portName { get; set; }
        public string status { get; set; }
        DateTime SelectedDate { get; }

        event EventHandler Judgement;
        event EventHandler okClickedButton;
        event EventHandler cnclClickedButton;
        event EventHandler LoadSetup;
        event EventHandler SelectedModel;
        event EventHandler SearchFilter;

        void StatusMessage(string message);
        void SelectTabPageByIndex(int data);
        void SetDefectListBindingSource(BindingSource model);
        void ChangePanelColor(Color newColor, int timerInterval);
        void ChangeTextBoxColor(Color newColor, int timerInterval);
    }
}
