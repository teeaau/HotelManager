using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Utils;
using UI.Views;

namespace UI.ViewModels
{
    public class MainViewModel : IViewModel
    {
        MainForm mainForm;
        User currUser;
        public MainViewModel(MainForm mainForm, User user)
        {
            this.mainForm = mainForm;
            this.currUser = user;
            LoadAsync();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        async void LoadAsync()
        {
            Controller controller = new Controller(mainForm, currUser);
        }
    }
}
