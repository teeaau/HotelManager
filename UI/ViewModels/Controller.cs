using Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Styles;
using UI.Views;

namespace UI.ViewModels
{
    public class Controller
    {
        MainForm mainForm;
        User currUser;
        ObservableCollection<NavModel> navPermissions;
        ObservableCollection<NavModel> navOpeneds;
        NavModel currNav;
        public Controller(MainForm mainForm, User user)
        {
            this.mainForm = mainForm;
            this.currUser = user;
            LoadAsync();
        }

        async void LoadAsync()
        {
            navPermissions = new ObservableCollection<NavModel>();
            navOpeneds = new ObservableCollection<NavModel>();
            foreach(var permission in currUser.Role.RolePermissions.Select(rp => rp.Permission))
            {
                var _display = permission.permissionDisplay;
                var _name = permission.permissionName;
                var navItem = new NavItemStyle(_display);
                var headerView = new HeaderViewStyle(_display);

                var navModel = new NavModel(navItem, headerView, _name);
                GetEvent(navModel);
                navPermissions.Add(navModel);
                mainForm.pnlNavItem.Controls.Add(navModel.navItem);
            }
        }

        private void GetEvent(NavModel navModel)
        {
            navModel.navItem.btnNavItem.Click += 
                (sender, EventArgs) => { OpenOrFocus_Click(sender, EventArgs, navModel); };
            navModel.headerView.btnTitleView.Click +=
                (sender, EventArgs) => { OpenOrFocus_Click(sender, EventArgs, navModel); };
            navModel.headerView.btnCloseView.Click +=
                (sender, EventArgs) => { BtnCloseView_Click(sender, EventArgs, navModel); };
        }

        private void BtnCloseView_Click(object sender, EventArgs e, NavModel navModel)
        {
            var index = navOpeneds.IndexOf(navModel);
            navOpeneds.Remove(navModel);
            mainForm.pnlHeaderView.Controls.Remove(navModel.headerView);
            var nav = navOpeneds.ElementAtOrDefault(index);
            if (nav == null)
                nav = navOpeneds.ElementAtOrDefault(--index);
            if (nav == null)
            {
                mainForm.pnlViewContent.Controls.Clear();
                return;
            }
            OpenOrFocus(nav);
        }

        private void OpenOrFocus_Click(object sender, EventArgs e, NavModel navModel)
        {
            OpenOrFocus(navModel);
        }

        void OpenOrFocus(NavModel navModel)
        {
            UserControl view;
            if (navModel.nameOfView == "Profile")
                view = new ProfileView(currUser);
            else
                view = GetView(navModel.nameOfView);
            view.Dock = DockStyle.Fill;
            if (!navOpeneds.Contains(navModel))
            {
                navOpeneds.Add(navModel);
                mainForm.pnlHeaderView.Controls.Add(navModel.headerView);
            }
            if(currNav != null)
                currNav.headerView.UnFocusHeader();
            currNav = navModel;
            currNav.headerView.FocusHeader();

            mainForm.pnlViewContent.Controls.Clear();
            mainForm.pnlViewContent.Controls.Add(view);
        }

        UserControl GetView(string nameOfView)
        {
            ObjectHandle objectHandle =
                Activator.CreateComInstanceFrom(Assembly.GetEntryAssembly().Location,
                "UI.Views." + nameOfView + "View");
            return (UserControl)objectHandle.Unwrap();
        }
    }
}
