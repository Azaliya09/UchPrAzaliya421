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
using System.Windows.Shapes;
using UchAzaliya.Bases;
using UchAzaliya.Pages;

namespace UchAzaliya.Windows
{
    /// <summary>
    /// Логика взаимодействия для RegUserWindow.xaml
    /// </summary>
    public partial class RegUserWindow : Window
    {
        private User user;
        private Worker worker;
        private Address address;
        private string[] processes;
        public RegUserWindow(User user, Worker worker, Address address, string[] processes)
        {
            InitializeComponent();
            this.user = user;
            this.worker = worker;
            this.address = address;
            this.processes = processes;
            RoleCb.ItemsSource = App.Connection.Role.Where(x => x.Id_Role != 1).ToList();
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            if(LoginTb.Text == "" || PasswordTb.Text == "" || RoleCb.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не заполнили все поля!");
                return;
            }
            if(App.Connection.User.Any(x => x.Login == LoginTb.Text))
            {
                MessageBox.Show("Такой логин уже есть!");
                return;
            }

            user.Login = LoginTb.Text;
            user.Password = PasswordTb.Text;
            user.Id_Role = (RoleCb.SelectedItem as Role).Id_Role;
            user = App.Connection.User.Add(user);
            worker.Login = user.Login;
            App.Connection.Worker.Add(worker);
            App.Connection.Address.Add(address);
            worker.Id_Address = address.Id_Address;
            App.Connection.SaveChanges();

            if (processes.Length > 0)
            {
                for (int i = 0; i < processes.Length; i++)
                {
                    string pro = processes[i].Trim();
                    if (!App.Connection.CreatingProcess.Any(x => x.Process_Name == pro))
                        App.Connection.CreatingProcess.Add(new CreatingProcess() { Process_Name = pro });
                    App.Connection.WorkerProcess.Add(new WorkerProcess() { Login_Worker = worker.Login, Name_Process = pro });
                }
                App.Connection.SaveChanges();
            }

            App.mainWindow.MyFrame.Navigate(new EmployeeAccounting());
            this.Close();
            MessageBox.Show("Сотрудник успешно добавлен!");
        }
    }
}
