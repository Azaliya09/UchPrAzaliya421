using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using UchAzaliya.Bases;
using Material = UchAzaliya.Bases.Material;

namespace UchAzaliya.Pages
{
    /// <summary>
    /// Логика взаимодействия для MaterialsComponentsAccounting.xaml
    /// </summary>
    public partial class MaterialsComponentsAccounting : Page
    {
        
        private Material selectedMaterial;
        private Component selectedComponent;
        public MaterialsComponentsAccounting()
        {
            InitializeComponent();
            MaterialsLV.ItemsSource = App.Connection.Material.Where(z=>z.IsDeleted == false).ToList();
            ComponentsLV.ItemsSource = App.Connection.Component.Where(z => z.IsDeleted == false).ToList();

            if(App.CorUser.Id_Role == 2 || App.CorUser.Id_Role == 3)
            {
                EditCBtn.Visibility = Visibility.Visible;
                EditMBtn.Visibility = Visibility.Visible;
                AddCBtn.Visibility = Visibility.Visible;
                AddMBtn.Visibility = Visibility.Visible;
                DeleteCBtn.Visibility = Visibility.Visible;
                DeleteMBtn.Visibility = Visibility.Visible;
            }

        }

        private void EditMBtn_Click(object sender, RoutedEventArgs e)
        {
            if(MaterialsLV.SelectedItem != null)
            {
                NavigationService.Navigate(new AddEditMaterials(MaterialsLV.SelectedItem as Material));
            }
            else
            {
                MessageBox.Show("Выберите элемент из списка для редактирования");
            }
        }

        private void AddMBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEditMaterials(new Material ()));
        }
        //проверить удаление с нулевым кол-вом
        //private void DeleteMBtn_Click(object sender, RoutedEventArgs e)
        //{
        //    if (MaterialsLV.SelectedItem != null)
        //    {
        //        var materials = App.Connection.Material;
        //        if (materials.Any(x => x.Count != 0 && x.Id_Material == selectedMaterial.Id_Material))
        //        {
        //            MessageBox.Show("Этот материал нельзя удалить, т.к. он еще хранится на складе");
        //        }
        //        else
        //        {
        //            MessageBoxResult result = MessageBox.Show("Вы действительно желаете удалить этот материал?","Подтверждение удаления", MessageBoxButton.OKCancel,MessageBoxImage.Question);
        //            if (result == MessageBoxResult.OK)
        //            {
        //                // Пользователь нажал "OK"
        //                selectedMaterial.IsDeleted = true;
        //                App.Connection.SaveChanges();
        //                MessageBox.Show("Материал удален");
        //            }
        //            else
        //            {
        //                // Пользователь нажал "Cancel" или закрыл сообщение
        //                MessageBox.Show("Удаление отменено");
        //            }
        //            NavigationService.Navigate(new MaterialsComponentsAccounting());
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Выберите элемент из списка для удаления");
        //    }
        //}

        private void EditCBtn_Click(object sender, RoutedEventArgs e)
        {
            if (ComponentsLV.SelectedItem != null)
            {
                NavigationService.Navigate(new AddEditComponents(ComponentsLV.SelectedItem as Component));
            }
            else
            {
                MessageBox.Show("Выберите элемент из списка для редактирования");
            }
        }

        private void AddCBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEditComponents(new Component()));
        }

        private void DeleteCBtn_Click(object sender, RoutedEventArgs e)
        {
            if(ComponentsLV.SelectedItem != null)
            {
                selectedComponent.IsDeleted = true;
                App.Connection.SaveChanges();
                MessageBox.Show("Комплектующее удалено");
                NavigationService.Navigate(new MaterialsComponentsAccounting());
            }
            else
            {
                MessageBox.Show("Выберите элемент из списка для удаления");
            }
        }

        private void MaterialsLV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //if(MaterialsLV.SelectedItem is Material selectedMatetial)
            //{

            //}
        }

        private void ComponentsLV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void FiltrComCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            IEnumerable<Component> components = App.Connection.Component;

            if (FiltrComCb.SelectedIndex == 0)
            {
                components = components;
            }
            else if(FiltrComCb.SelectedIndex == 1)
            {
                components = components.Where(z => z.Id_Warehouse == 1);
            }
            else if (FiltrComCb.SelectedIndex == 2)
            {
                components = components.Where(z => z.Id_Warehouse == 2); ;
            }
            else if (FiltrComCb.SelectedIndex == 3)
            {
                components = components.Where(z => z.Id_Warehouse == 3); ;
            }
            ComponentsLV.ItemsSource = components.ToList();

            int count = components.Count();
            CompCountTb.Text = $"{components.Count()} из {count}";
            decimal price = 0;
            foreach (var material in components)
                price += (material.Cost == null ? 0 : (decimal)material.Cost);
            CompPriceTb.Text = $"{price}";


        }

        private void FiltrMatCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            IEnumerable<Material> materials = App.Connection.Material;

            if (FiltrMatCb.SelectedIndex == 0)
            {
                materials = materials;
            }
            else if (FiltrMatCb.SelectedIndex == 1)
            {
                materials = materials.Where(z => z.Id_Warehouse == 1);
            }
            else if (FiltrMatCb.SelectedIndex == 2)
            {
                materials = materials.Where(z => z.Id_Warehouse == 2); ;
            }
            else if (FiltrMatCb.SelectedIndex == 3)
            {
                materials = materials.Where(z => z.Id_Warehouse == 3); ;
            }
            MaterialsLV.ItemsSource = materials.ToList();

            int count = materials.Count();
            MaterialCountTb.Text = $"{materials.Count()} из {count}";
            decimal price = 0;
            foreach (var material in materials)
                price += (material.Cost_Material == null ? 0 : (decimal)material.Cost_Material);
            MaterialPriceTb.Text = $"{price}";
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ForUser());
        }
    }
}
