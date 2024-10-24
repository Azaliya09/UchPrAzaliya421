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
    /// Логика взаимодействия для MaterialsComponentsAccounting.xaml
    /// </summary>
    public partial class MaterialsComponentsAccounting : Page
    {
        public MaterialsComponentsAccounting()
        {
            InitializeComponent();
        }

        private void EditMBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEditMaterials());
        }

        private void AddMBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEditMaterials());
        }

        private void DeleteMBtn_Click(object sender, RoutedEventArgs e)
        {
            //pam-pam
        }

        private void EditCBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEditComponents());
        }

        private void AddCBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEditComponents());
        }

        private void DeleteCBtn_Click(object sender, RoutedEventArgs e)
        {
            //pohgf
        }
    }
}
