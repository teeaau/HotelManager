using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Styles
{
    public class AddButtonStyle : RoundBorderButtonStyle
    {
        public AddButtonStyle()
        {
            BorderColor = Color.FromArgb(153, 180, 209);
            BorderSize = 2;
            Size = new Size(80, 40);
            Image = new Bitmap(Properties.Resources.icons8_plus_math_50, new Size(20, 20));
            TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            Font = new Font("Consolas", 14, FontStyle.Bold);
            ForeColor = Color.FromArgb(153, 180, 209);
        }
    }
}
