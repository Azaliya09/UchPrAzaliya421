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
using UchAzaliya.Pages;

namespace UchAzaliya.Pages
{
    /// <summary>
    /// Логика взаимодействия для Authtorization.xaml
    /// </summary>
    public partial class Authtorization : Page
    {
        public Authtorization()
        {
            InitializeComponent();
        }
        private void TextBlock_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegistrationСlient());
        }
    }
}
