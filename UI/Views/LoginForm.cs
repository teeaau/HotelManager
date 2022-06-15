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
    public partial class LoginForm : Form
    {
        IViewModel viewModel;
        public LoginForm()
        {
            InitializeComponent();
            viewModel = new LoginViewModel(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
