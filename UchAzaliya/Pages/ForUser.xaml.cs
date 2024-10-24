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

namespace UchAzaliya.Pages
{
    /// <summary>
    /// Логика взаимодействия для ForUser.xaml
    /// </summary>
    public partial class ForUser : Page
    {
        public ForUser()
        {
            InitializeComponent();
            if (App.CorUser == null)
            {
                App.ExitBtn.Visibility = Visibility.Hidden;
            }
            else
            {
                App.ExitBtn.Visibility = Visibility.Visible;
            }
        }

        private void ListEmpl_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EmployeeAccounting());
        }
    }
}
