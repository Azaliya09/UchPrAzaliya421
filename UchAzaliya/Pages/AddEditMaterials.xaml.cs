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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UchAzaliya.Bases;
using Material = UchAzaliya.Bases.Material;

namespace UchAzaliya.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddEditMaterials.xaml
    /// </summary>
    public partial class AddEditMaterials : Page
    {
        private Material selMat;
        public AddEditMaterials(Material material)
        {
            InitializeComponent();
            SizeTypeCb.ItemsSource = App.Connection.SizeType.ToList();
            ProviderCb.ItemsSource = App.Connection.Provider.ToList();
            WarehouseCb.ItemsSource = App.Connection.Warehouse.ToList();
            selMat = material;
            DataContext = material;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MaterialsComponentsAccounting());
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            Material material = new Material() { IsDeleted = false };
            //условие на айдишник
            //if (IDTb.Text == App.Connection.Material.Id_Material.ToString())
            //{
            //    MessageBox.Show("Такой артикул уже существует");
            //}
            material.Id_Material = IDTb.Text;
            material.Name_Material = NameTb.Text;
            material.Count = int.Parse(CountTb.Text);
            material.Id_SizeType = (SizeTypeCb.SelectedItem as SizeType).Id_SizeType;
            material.Cost_Material = decimal.Parse(PriceTb.Text);
            material.Name_Provider = (ProviderCb.SelectedItem as Provider).Name_Provider;
            material.Id_Warehouse = (WarehouseCb.SelectedItem as Warehouse).Id_Warehuose;

            material = App.Connection.Material.Add(material);
            App.Connection.SaveChanges();
            MessageBox.Show("Новый материал успешно добавлен");
            NavigationService.Navigate(new MaterialsComponentsAccounting());
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            if(selMat != null)
            {
                App.Connection.SaveChanges();
                MessageBox.Show("Данные обновлены");
                NavigationService.Navigate(new MaterialsComponentsAccounting());
            }

        }
    }
}
