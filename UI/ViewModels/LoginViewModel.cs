using BLL;
using BLL.Repositories;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Utils;
using UI.Views;

namespace UI.ViewModels
{
    public class LoginViewModel : IViewModel
    {
        LoginForm loginForm;
        UserRepository userRepository = new UserRepository();
        List<User> users;

        public event PropertyChangedEventHandler PropertyChanged;

        public LoginViewModel(LoginForm loginForm)
        {
            this.loginForm = loginForm;
            LoadAsync();
        }

        private async void LoadAsync()
        {
            var _users = await userRepository.GetIncludeAsync();
            users = new List<User>(_users);
            loginForm.btnLogin.Click += BtnLogin_Click;
            loginForm.btnMinimize.Click += BtnMinimize_Click;
            loginForm.btnClose.Click += BtnClose_Click;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            loginForm.Close();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            loginForm.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            var _userId = loginForm.txbID.Text;
            var _userPassword = loginForm.txbPassword.Text;

            if(_userId == string.Empty)
            {
                loginForm.lblError.Text = "ID không tồn tại";
                return;
            }

            var _user = users.FirstOrDefault(u => u.userId == _userId);
            if(_user == null)
            {
                loginForm.lblError.Text = "ID không tồn tại";
            }
            else
            {
                var passHashed = Convertor.MD5Hash(_userPassword);
                if(passHashed != _user.userPassword)
                {
                    loginForm.lblError.Text = "Password không chính xác";
                }
                else
                {
                    MainForm mainForm = new MainForm(_user);
                    mainForm.FormClosing += MainForm_FormClosing;
                    loginForm.Hide();
                    mainForm.Show();
                }
            }
        }

        private void MainForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            loginForm.txbID.Text = null;
            loginForm.txbPassword.Text = null;
            loginForm.lblError.Text = null;
            loginForm.Show();
        }
    }
}
