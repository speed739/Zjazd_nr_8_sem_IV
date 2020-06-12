using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Zjazd_8
{
    class DB
    {
        public void Add_user(Useraccount user)
        {
            MessageBox.Show("Uzytkownik " + user.username + " został dodany do bazy !", "Info", MessageBoxButton.OK);
            
        }
    }
}
