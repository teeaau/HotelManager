using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.ViewModels;

namespace UI.Views
{
    public partial class ProfileView : UserControl
    {
        IViewModel viewModel;
        public ProfileView()
        {
            InitializeComponent();
        }

        public ProfileView(User user) : this()
        {
            viewModel = new ProfileViewModel(this, user);
        }
    }
}
