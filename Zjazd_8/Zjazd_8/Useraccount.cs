using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Zjazd_8
{
    public class Useraccount
    {
        public int ID { get; set; }
        
        public string username { get; set; }
        public string password { get; set; }
        public DateTime Termaccepted { get; set; }
        public DateTime Accountcreation { get; set; }
    }
}
