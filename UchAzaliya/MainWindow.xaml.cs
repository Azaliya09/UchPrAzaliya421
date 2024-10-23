using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
using UchAzaliya.Bases;
using UchAzaliya.Pages;

namespace UchAzaliya
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            App.ExitBtn = ExitBTN;
            if(App.CorUser == null)
            {
                ExitBTN.Visibility = Visibility.Hidden;
            }
            else
            {
                ExitBTN.Visibility = Visibility.Visible;
            }
            if (CheckRemember()!=null)
            {
                ActiveSession user = CheckRemember();
                App.CorUser = App.Connection.User.Where(z => z.Login == user.Login_User).FirstOrDefault();
                MyFrame.Navigate(new ForUser());
            }
            else
            {
                MyFrame.Navigate(new Authtorization());
            }
        }

        public ActiveSession CheckRemember()
        {
            ActiveSession session = App.Connection.ActiveSession.FirstOrDefault(z => z.Computer_Number == 1 && z.Login_User != null);
            if (session != null)
                return session;
            return null;
        }

        private void ExitBTN_Click(object sender, RoutedEventArgs e)
        {
            ActiveSession session = App.Connection.ActiveSession.FirstOrDefault(z => z.Computer_Number == 1 && z.Login_User != null);
            App.CorUser = null;
            if (session != null)
                App.Connection.ActiveSession.Remove(session);
            App.Connection.SaveChanges();
            MyFrame.Navigate(new Authtorization());
        }
    }
}
