using BarcodeCaseA.Model;
using BarcodeCaseA.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeCaseA.Presenter
{
    public class LoginPresenter
    {
        private ILoginView _view;
        private ILoginRepository _repository;

        public LoginPresenter(ILoginView view, ILoginRepository repository)
        {
            _view = view;
            _repository = repository;
            _view.Login += Login;
            this._view.Show();
        }

        private void Login(object sender, EventArgs e)
        {
            string nik = _view.Nik;
            string password = _view.Password;

            LoginModel user = _repository.GetUserByUsername(nik);

            if (user?.Nik != null && user?.Password == password)
            {
                _view.HideView();
                IMainForm mainForm = new MainForm(user);
                (mainForm as Form)?.Show();
            }
            else
            {
                _view.ShowMessage("Invalid username or password");
            }
        }
    }
}
