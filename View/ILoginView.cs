using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeCaseA.View
{
    public interface ILoginView
    {
        string Nik { get; }
        string Password { get; }
        bool IsLoginSuccessful { get; }

        void ShowMessage(string message);
        void Show();
        void HideView();

        event EventHandler Login;
    }
}
