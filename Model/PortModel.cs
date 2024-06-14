using System;

namespace BarcodeCaseA.Model
{
    public class PortModel
    {
        private bool _openPort; // Variabel cadangan untuk properti openPort

        public string PortName { get; set; }

        public bool OpenPort
        {
            get { return _openPort; }
            set
            {
                if (_openPort != value)
                {
                    _openPort = value;
                    if (_openPort)
                    {
                        OnPortOpen(EventArgs.Empty); // Memicu event saat nilai openPort berubah ke true
                    }
                    else
                    {
                        OnPortClose(EventArgs.Empty); // Memicu event saat nilai openPort berubah ke false
                    }
                }
            }
        }

        // Event untuk memberikan sinyal bahwa port telah dibuka atau ditutup
        public event EventHandler PortOpen;
        public event EventHandler PortClose;

        protected virtual void OnPortOpen(EventArgs e)
        {
            PortOpen?.Invoke(this, e);
        }

        protected virtual void OnPortClose(EventArgs e)
        {
            PortClose?.Invoke(this, e);
        }
    }
}
