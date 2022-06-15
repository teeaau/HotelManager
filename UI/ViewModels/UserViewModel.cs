using BLL.Repositories;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Styles;
using UI.Utils;
using UI.Views;
using UI.Wrappers;

namespace UI.ViewModels
{
    public class UserViewModel : IViewModel
    {
        UserView userView;
        UserRepository userRepository = new UserRepository();
        List<UserWrapper> users;
        TableStyle<UserWrapper> tableStyle;
        UserWrapper currUser;

        public UserViewModel(UserView userView)
        {
            this.userView = userView;
            LoadAsync();
        }

        private async void LoadAsync()
        {
            var _user = await userRepository.GetIncludeAsync();

            users = new List<UserWrapper>();
            foreach (var model in _user)
            {
                var wrapper = new UserWrapper(model);
                users.Add(wrapper);
            }
            LoadDataTable();
            currUser = new UserWrapper(new User() { roleId = 2 });
            BindingData();
            userView.btbnAdd.Click -=
                (sender, EventArgs) => { BtnEdit_Click(sender, EventArgs, currUser); };
            userView.btbnAdd.Click +=
                (sender, EventArgs) => { BtnEdit_Click(sender, EventArgs, currUser); };
            userView.btnClose.Click -= BtnClose_Click;
            userView.btnClose.Click += BtnClose_Click;
            userView.btnSave.Click -= BtnSave_Click;
            userView.btnSave.Click += BtnSave_Click;
            userView.btnAvatar.Click -= BtnAvatar_Click;
            userView.btnAvatar.Click += BtnAvatar_Click;
        }

        private void BindingData()
        {
            VMControl.BindingText(userView.txbId, currUser, "userId");
            VMControl.BindingText(userView.txbPassword, currUser, "userPassword");
            VMControl.BindingText(userView.txbName, currUser, "name");
            VMControl.BindingText(userView.txbEmail, currUser, "email");
            VMControl.BindingValue(userView.dpkBirthday, currUser, "birthday");
            VMControl.BindingImage(userView.ptbAvatar, currUser, "avatar");
            VMControl.BindingText(userView.cbbRole, currUser, "roleId");
        }

        private void BtnAvatar_Click(object sender, EventArgs e)
        {
            var of = new OpenFileDialog();
            of.Title = "Select avatar";
            of.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (of.ShowDialog() == DialogResult.OK)
            {
                userView.ptbAvatar.BackgroundImage = Bitmap.FromFile(of.FileName);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            userRepository.AddOrUpdate(currUser.Model);
            userRepository.SaveAsync();
            userView.pnlEdit.Visible = false;
            LoadAsync();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            currUser = new UserWrapper(new User() { roleId = 2 });
            BindingData();
            userView.pnlEdit.Visible = false;
        }

        private void LoadDataTable()
        {
            var haeders = new List<string>() 
            { "ID", "Password", "Họ và tên", "Email", "Ngày sinh", "Ảnh", "Chức vụ" };
            tableStyle = new TableStyle<UserWrapper>(haeders, users, canEdit:true);

            foreach (var row in tableStyle.rows)
            {
                row.btnEdit.Click -=
                    (sender, EventArgs) => { BtnEdit_Click(sender, EventArgs, row.Model); };
                row.btnEdit.Click +=
                    (sender, EventArgs) => { BtnEdit_Click(sender, EventArgs, row.Model); };
                row.btnRemove.Click -=
                    (sender, EventArgs) => { BtnRemove_Click(sender, EventArgs, row.Model); };
                row.btnRemove.Click +=
                    (sender, EventArgs) => { BtnRemove_Click(sender, EventArgs, row.Model); };
            }



            userView.pnlTable.Controls.Clear();
            userView.pnlTable.Controls.Add(tableStyle);
        }

        private void BtnRemove_Click(object sender, EventArgs eventArgs, UserWrapper model)
        {
            var user = model.Model;
            userRepository.Remove(user);
            userRepository.Save();
            LoadAsync();
        }

        private void BtnEdit_Click(object sender, EventArgs eventArgs, UserWrapper model)
        {
            currUser = model;
            BindingData();
            userView.pnlEdit.Visible = true;
        }
    }
}
