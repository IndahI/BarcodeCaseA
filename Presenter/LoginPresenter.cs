using BarcodeCaseA.Model;
using BarcodeCaseA.View;
using Microsoft.VisualBasic.Logging;
using System;
using System.Windows.Forms;

namespace BarcodeCaseA.Presenter
{
    public class LoginPresenter
    {
        private ILoginView _Loginview;
        private ILoginRepository _repository;

        public LoginPresenter(ILoginView view, ILoginRepository repository)
        {
            _Loginview = view;
            _repository = repository;
            _Loginview.Login += Login;
            this._Loginview.Show();
        }

        private void Login(object sender, EventArgs e)
        {
            string nik = _Loginview.Nik;
            string password = _Loginview.Password;

            // Membuat instance baru dari LoginModel untuk setiap pencarian login
            LoginModel user = _repository.GetUserByUsername(nik);

            if (user != null)
            {

                bool isPasswordValid = BCrypt.Net.BCrypt.Verify(password, user.Password);
                if (isPasswordValid)
                {
                    _Loginview.HideView();
                    IMainForm mainForm = MainForm.GetInstance(user);
                    mainForm.Show();
                }
                else
                {
                    _Loginview.ShowMessage("Invalid username or password");
                }

            }
            else
            {
                _Loginview.ShowMessage("User not found");
            }
        }
    }
}
