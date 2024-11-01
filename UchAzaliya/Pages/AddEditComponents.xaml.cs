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
            if(component.Id_Component != null)
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
            else
            {
                MessageBox.Show("Выребите элемент из списка для редактирования");
            }
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            Component component  = new Component() { IsDeleted = false };
            if (App.Connection.Component.Any(z => z.Id_Component == IDTb.Text))
            {
                MessageBox.Show("Такой артикул уже существует");
            }
            else if (IDTb.Text != "" || NameTb.Text != "" || CountTb != null || SizeTypeCb.SelectedItem != null || PriceTb.Text != null || ProviderCb.SelectedItem != null || WarehouseCb.SelectedItem != null)
            {
                component.Id_Component = IDTb.Text;
                component.Name_Component = NameTb.Text;
                component.Count = int.Parse(CountTb.Text);
                component.Id_SizeType = (SizeTypeCb.SelectedItem as SizeType).Id_SizeType;
                component.Cost = decimal.Parse(PriceTb.Text);
                component.Name_Provider = (ProviderCb.SelectedItem as Provider).Name_Provider;
                component.Id_Warehouse = (WarehouseCb.SelectedItem as Warehouse).Id_Warehuose;

                component = App.Connection.Component.Add(component);
                App.Connection.SaveChanges();
                MessageBox.Show("Новое комплектующее успешно добавлено");
                NavigationService.Navigate(new MaterialsComponentsAccounting());
            }
            else
            {
                MessageBox.Show("Не все поля заполнены");
            }
        }
    }
}
