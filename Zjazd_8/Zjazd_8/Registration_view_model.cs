using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zjazd_8
{
    class Registration_view_model : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string login;
        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                if (login != value)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Login"));
                    login = value;
                }
            }
        }
        public string Password { get; set; }
        public string Reapetedpassword { get; set; }
        public bool Termaccepted { get; set; } = false;
        public DateTime Birth { get; set; }

    }
}
