﻿using System;
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
            if(App.CorUser.Id_Role ==1)
            {
                ListOrder.Visibility = Visibility.Visible;
            }
            else if(App.CorUser.Id_Role ==3 || App.CorUser.Id_Role == 4 || App.CorUser.Id_Role == 5)
            {
                ListOrder.Visibility = Visibility.Visible;
                MatComp.Visibility = Visibility.Visible;
            }
            else if(App.CorUser.Id_Role == 2)
            {
                ListEmpl.Visibility = Visibility.Visible;
                ListOrder.Visibility = Visibility.Visible;
                MatComp.Visibility = Visibility.Visible;
                Workshops.Visibility = Visibility.Visible;
            }

        }

        private void ListEmpl_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EmployeeAccounting());
        }

        private void MatComp_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MaterialsComponentsAccounting());
        }

        private void ListOrder_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OrdersList());
            
        }

        private void Workshops_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Workshops());
        }
    }
}
