using BarcodeCaseA.Model;
using BarcodeCaseA.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeCaseA.Presenter
{
    public class TabControlDataPresenter
    {
        public ITabControl View { get; }
        public IResultRepository ResultRepository { get; }
        public LoginModel User { get; }

        public TabControlDataPresenter(ITabControl view, IResultRepository resultRepository, LoginModel user)
        {
            View = view;
            ResultRepository = resultRepository;
            User = user;
        }
    }
}
