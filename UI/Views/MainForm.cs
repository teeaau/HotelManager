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
    public partial class MainForm : Form
    {
        IViewModel viewModel;
        public MainForm(User user)
        {
            InitializeComponent();
            viewModel = new MainViewModel(this, user);
        }
    }
}
