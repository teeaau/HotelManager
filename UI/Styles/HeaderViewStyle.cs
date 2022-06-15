using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Styles
{
    public partial class HeaderViewStyle : UserControl
    {
        public HeaderViewStyle(string displayHeader)
        {
            InitializeComponent();
            btnTitleView.Text = displayHeader;
        }

        public void FocusHeader()
        {
            this.btnTitleView.BackgroundColor = Color.FromArgb(0, 173, 181);
        }

        public void UnFocusHeader()
        {
            this.btnTitleView.BackgroundColor = Color.FromArgb(57, 62, 70);
        }
    }
}
