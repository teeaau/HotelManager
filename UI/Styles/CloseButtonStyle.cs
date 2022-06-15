using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Styles
{
    public class CloseButtonStyle : RoundBorderButtonStyle
    {
        public CloseButtonStyle()
        {
            BorderColor = Color.FromArgb(153, 180, 209);
            BorderSize = 2;
            Size = new Size(30, 30);
            Image = new Bitmap(Properties.Resources.icons8_close_50, new Size(15, 15));
            ForeColor = Color.FromArgb(153, 180, 209);
            BorderRadius = 15;
        }
    }
}
