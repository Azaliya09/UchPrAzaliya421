using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using UchAzaliya.Bases;
using UchAzaliya.Windows;

namespace UchAzaliya.Pages
{
    /// <summary>
    /// Логика взаимодействия для EmployeeAccounting.xaml
    /// </summary>
    public partial class EmployeeAccounting : Page
    {
        private Worker selectedWorker;
        public EmployeeAccounting()
        {
            InitializeComponent();
            WorkersListView.ItemsSource = App.Connection.Worker.Where(z=>z.IsDeleted == false).ToList();   
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();
            Worker worker = new Worker() { IsDeleted = false};
            Address address = new Address();

            string[] FIO = FullNameTb.Text.Split(' ');
            if (FIO.Length < 3)
            {
                MessageBox.Show("ФИО не заполнили полностью!");
                return;
            }
            user.Name = FIO[0];
            user.Surname = FIO[1];
            user.Patronymic = FIO[2];

            worker.DateBorn = DateB.SelectedDate;

            string[] AddressS = AddressTb.Text.Split(' ');
            if (AddressS.Length < 3)
            {
                MessageBox.Show("Адрес не заполнили полностью!");
                return;
            }
            address.City = AddressS[0];
            address.Street = AddressS[1];
            address.HouseNumber = AddressS[2];

            worker.Education = EducationTb.Text;
            worker.Qualification = QualificationTb.Text;

            new RegUserWindow(user, worker, address).ShowDialog();
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if(WorkersListView.SelectedItem != null)
            {
                selectedWorker.IsDeleted = true;
                App.Connection.SaveChanges();
                MessageBox.Show("Работник уволен");
                NavigationService.Navigate(new EmployeeAccounting());
            }
            else
            {
                MessageBox.Show("Выберите элемент из списка, а затем удалите");
            }
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {

            if(WorkersListView.SelectedItem != null)
            {
                selectedWorker.IsDeleted = false;

                string[] FIO = FullNameTb.Text.Split(' ');
                if(FIO.Length < 3)
                {
                    MessageBox.Show("ФИО не заполнили полностью!");
                    return;
                }
                selectedWorker.User.Name = FIO[0];
                selectedWorker.User.Surname = FIO[1];
                selectedWorker.User.Patronymic = FIO[2];

                selectedWorker.DateBorn = DateB.SelectedDate;

                string[] AddressS = AddressTb.Text.Split(' ');
                if (AddressS.Length < 3)
                {
                    MessageBox.Show("Адрес не заполнили полностью!");
                    return;
                }
                selectedWorker.Address.City = AddressS[0];
                selectedWorker.Address.Street = AddressS[1];
                selectedWorker.Address.HouseNumber = AddressS[2];

                selectedWorker.Education = EducationTb.Text;
                selectedWorker.Qualification = QualificationTb.Text;


                App.Connection.SaveChanges();
                MessageBox.Show("Данные обновлены");
            }
            else
            {
                MessageBox.Show("Выберите элемент из списка, а затем внесите изменения");
            }
                NavigationService.Navigate(new EmployeeAccounting());
        }

        private void WorkersListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (WorkersListView.SelectedItem is Worker selectedWorker)
            {
                FullNameTb.Text = selectedWorker.User.FullName;
                DateB.Text = selectedWorker.DateBorn.ToString();
                AddressTb.Text = selectedWorker.Address.FullAddress;
                EducationTb.Text = selectedWorker.Education;
                QualificationTb.Text = selectedWorker.Qualification;
                OperationsTb.Text = selectedWorker.Operations;
                this.selectedWorker = selectedWorker;
            }
        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            FullNameTb.Text = string.Empty;
            DateB.SelectedDate = null;
            AddressTb.Text = string.Empty;
            EducationTb.Text = string.Empty;
            QualificationTb.Text = string.Empty;
            OperationsTb.Text = string.Empty;
        }
    }
}
