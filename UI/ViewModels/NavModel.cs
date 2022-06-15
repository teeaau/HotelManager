using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Styles;

namespace UI.ViewModels
{
    public class NavModel
    {
        public NavItemStyle navItem { get; set; }
        public HeaderViewStyle headerView { get; set; }
        public string nameOfView { get; set; }

        public NavModel(NavItemStyle navItem, HeaderViewStyle headerView, string nameOfView)
        {
            this.navItem = navItem;
            this.headerView = headerView;
            this.nameOfView = nameOfView;
        }
    }
}
