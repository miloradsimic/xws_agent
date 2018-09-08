using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XwsAgent.UILayer.ViewModel
{
    public class LoginCredentialsVM : ViewModelBase
    {
        private string email;
        private string password;

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (!String.Equals(email, value))
                {
                    email = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                if(!String.Equals(password, value))
                {
                    password = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }
}
