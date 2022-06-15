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
    public class ProfileViewModel : IViewModel
    {
        ProfileView profileView;
        UserRepository userRepository = new UserRepository();
        TableStyle<UserWrapper> tableStyle;
        User user;
        UserWrapper currUser;

        public event PropertyChangedEventHandler PropertyChanged;

        public ProfileViewModel(ProfileView profileView, User user)
        {
            this.profileView = profileView;
            this.user = user;
            LoadAsync();
        }

        private async void LoadAsync()
        { 

            currUser = new UserWrapper(user);
            BindingData();
            profileView.btnSave.Click -= BtnSave_Click;
            profileView.btnSave.Click += BtnSave_Click;
            profileView.btnAvatar.Click -= BtnAvatar_Click;
            profileView.btnAvatar.Click += BtnAvatar_Click;
        }

        private void BindingData()
        {
            VMControl.BindingText(profileView.lblId, currUser, "userId");
            VMControl.BindingText(profileView.txbPassword, currUser, "userPassword");
            VMControl.BindingText(profileView.txbName, currUser, "name");
            VMControl.BindingText(profileView.txbEmail, currUser, "email");
            VMControl.BindingValue(profileView.dpkBirthday, currUser, "birthday");
            VMControl.BindingImage(profileView.ptbAvatar, currUser, "avatar");
        }

        private void BtnAvatar_Click(object sender, EventArgs e)
        {
            var of = new OpenFileDialog();
            of.Title = "Select avatar";
            of.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (of.ShowDialog() == DialogResult.OK)
            {
                profileView.ptbAvatar.BackgroundImage = Bitmap.FromFile(of.FileName);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            userRepository.AddOrUpdate(currUser.Model);
            userRepository.Save();
            LoadAsync();
        }
    }
}
