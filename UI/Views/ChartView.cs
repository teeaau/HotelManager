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
    public partial class ChartView : UserControl
    {
        IViewModel viewModel;
        public ChartView()
        {
            InitializeComponent();
            viewModel = new ChartViewModel(this);
        }
    }
}
