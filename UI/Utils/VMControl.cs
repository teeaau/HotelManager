using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Utils
{
    public static class VMControl
    {
        public static void BindingText(Control ctrl, object dataSource, string dataMember)
        {
            ctrl.DataBindings.Clear();
            ctrl.DataBindings.Add("Text", dataSource, dataMember, true, DataSourceUpdateMode.OnPropertyChanged);
        }

        public static void BindingValue(Control ctrl, object dataSource, string dataMember)
        {
            ctrl.DataBindings.Clear();
            ctrl.DataBindings.Add("Value", dataSource, dataMember, true, DataSourceUpdateMode.OnPropertyChanged);
        }

        public static void BindingImage(Control ctrl, object dataSource, string dataMember)
        {
            ctrl.DataBindings.Clear();
            ctrl.DataBindings.Add("BackgroundImage", dataSource, dataMember, true, DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}
