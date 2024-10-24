using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using UchAzaliya.Bases;

namespace UchAzaliya
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static TransporterBaseEntities2 Connection = new TransporterBaseEntities2();
        public static User CorUser;
        public static Button ExitBtn;
        public static MainWindow mainWindow;
    }
}
