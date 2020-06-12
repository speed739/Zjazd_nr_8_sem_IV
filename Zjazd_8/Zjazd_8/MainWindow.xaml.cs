using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Zjazd_8
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Registration_view_model reg_model = new Registration_view_model();
        private DB db_con = new DB();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = reg_model;
        }
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            reg_model.Termaccepted = true;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (reg_model.Password != reg_model.Reapetedpassword)
            {
                MessageBox.Show("Password is diffrent", "Error", MessageBoxButton.OK);
                return;
            }
            if (reg_model.Termaccepted != true)
            {
                MessageBox.Show("U must check Termaccept", "Error", MessageBoxButton.OK);
                return;
            }
            var user = new Useraccount()
            {
                username = reg_model.Login,
                password = reg_model.Password,
                Termaccepted = DateTime.Today,
                Accountcreation = DateTime.Today
            };
            db_con.Add_user(user);
            reg_model.Login = null;
            reg_model.Password = "";
            reg_model.Reapetedpassword = "";
        }
    }
}

