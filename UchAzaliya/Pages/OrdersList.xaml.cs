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
    /// Логика взаимодействия для OrdersList.xaml
    /// </summary>
    public partial class OrdersList : Page
    {
        private Order selectedOrder;
        public OrdersList()
        {
            InitializeComponent();
            OrdersLV.ItemsSource = App.Connection.Order.Where(x=>x.IsDeleted == false).ToList();
        }

        private void StatusCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            IEnumerable<Order> orders = App.Connection.Order;

            if (StatusCb.SelectedIndex == 0)
            {
                orders = orders;
            }
            else if (StatusCb.SelectedIndex == 1)
            {
                orders = orders.Where(z => z.Id_Status == 1 || z.Id_Status == 3 || z.Id_Status == 4);
            }
            else if (StatusCb.SelectedIndex == 2)
            {
                orders = orders.Where(z => z.Id_Status == 8 || z.Id_Status == 9); ;
            }
            else if (StatusCb.SelectedIndex == 3)
            {
                orders = orders.Where(z => z.Id_Status == 5 || z.Id_Status == 6 || z.Id_Status == 7); ;
            }
            else if (StatusCb.SelectedIndex == 4)
            {
                orders = orders.Where(z => z.Id_Status == 2); ;
            }
            OrdersLV.ItemsSource = orders.ToList();
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if(OrdersLV.SelectedItem != null)
            {
                selectedOrder.IsDeleted = true;
                App.Connection.SaveChanges();
                MessageBox.Show("Заказ удален");
                NavigationService.Navigate(new OrdersList());
            }
            else
            {
                MessageBox.Show("Выберите заказ из списка для удаления");
            }    
        }
    }
}
