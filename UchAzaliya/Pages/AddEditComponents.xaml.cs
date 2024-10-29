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
using UchAzaliya.Bases;

namespace UchAzaliya.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddEditComponents.xaml
    /// </summary>
    public partial class AddEditComponents : Page
    {
        private Component selComp;
        public AddEditComponents(Component component)
        {
            InitializeComponent();
            SizeTypeCb.ItemsSource = App.Connection.SizeType.ToList();
            ProviderCb.ItemsSource = App.Connection.Provider.ToList();
            WarehouseCb.ItemsSource = App.Connection.Warehouse.ToList();
            selComp = component;
            DataContext = component;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MaterialsComponentsAccounting());
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            if(selComp != null)
            {
                App.Connection.SaveChanges();
                MessageBox.Show("Данные обновлены");
                NavigationService.Navigate(new MaterialsComponentsAccounting());

            }
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            //добавление компонента
        }
    }
}
