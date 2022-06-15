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
    public partial class IncomeView : UserControl
    {
        IViewModel viewModel;
        public IncomeView()
        {
            InitializeComponent();
            viewModel = new IncomeViewModel(this);
        }
    }
}
