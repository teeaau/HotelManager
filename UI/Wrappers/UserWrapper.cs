using Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Utils;

namespace UI.Wrappers
{
    public class UserWrapper : ModelWrapper<User>
    {
        public UserWrapper(User model) : base(model)
        {
        }
        public string userId
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
        public string userPassword
        {
            get { return GetValue<string>(); }
            set
            {
                if (value != Model.userPassword)
                {
                    SetValue(Convertor.MD5Hash(value));
                }
                else SetValue(value);
            }
        }
        public string name
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
        public string email
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
        public DateTime? birthday
        {
            get { return GetValue<DateTime?>(); }
            set { SetValue(value); }
        }
        public Bitmap avatar
        {
            get
            {
                return Convertor.ToImage(Model.avatar);
            }
            set
            {
                Model.avatar = Convertor.ToBinaryArray(value);
            }
        }
        public string roleId
        {
            get
            {
                if (Model.roleId == 1)
                    return "Manager";
                else
                    return "Employee";
            }
            set 
            {
                if (value == "Manager")
                    Model.roleId = 1;
                else
                    Model.roleId = 2;
            }
        }
    }
}
