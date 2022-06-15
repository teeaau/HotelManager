﻿using System;
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
    public partial class NavItemStyle : UserControl
    {
        public NavItemStyle(string displayNav)
        {
            InitializeComponent();
            btnNavItem.Text = displayNav;
        }
    }
}
