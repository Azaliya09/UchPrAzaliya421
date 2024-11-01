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
using UchAzaliya.Pages;
using UchAzaliya.Bases;
using UchAzaliya.Components;

namespace UchAzaliya.Pages
{
    /// <summary>
    /// Логика взаимодействия для Authtorization.xaml
    /// </summary>
    public partial class Authtorization : Page
    {
        private Role role;
        public Authtorization()
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
        private void TextBlock_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegistrationСlient());
        }


        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                User user = App.Connection.User.FirstOrDefault(z => z.Login == LoginTb.Text && z.Password == PasswordPb.Password);
                if (user != null)
                {
                    if (RememberCb.IsChecked == true)
                    {
                        ActiveSession session = new ActiveSession
                        {
                            Login_User = user.Login,
                            Computer_Number = 1
                        };
                        App.Connection.ActiveSession.Add(session);
                        App.Connection.SaveChanges();
                    }
                    App.CorUser = user;
                    MessageBox.Show($"Добро пожаловать, {user.Surname}", "Приветствую", MessageBoxButton.OK, MessageBoxImage.Information);
                    NavigationService.Navigate(new ForUser());
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
