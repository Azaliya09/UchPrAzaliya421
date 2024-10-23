using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Xml.Linq;
using UchAzaliya.Bases;
using static System.Net.Mime.MediaTypeNames;

namespace UchAzaliya.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegistrationСlient.xaml
    /// </summary>
    public partial class RegistrationСlient : Page
    {
        public ImageStockUser addedImage;
        public RegistrationСlient()
        {
            InitializeComponent();
        }
        public BitmapImage GetImage(byte[] byteImage)
        {
            if (byteImage != null)
            {
                MemoryStream byteStream = new MemoryStream(byteImage);
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.StreamSource = byteStream;
                image.EndInit();
                return image;
            }
            else
                return new BitmapImage(new Uri(@"\Resources\NoPhotoNew.png", UriKind.Relative));
        }

        private void EditImage_Click(object sender, RoutedEventArgs e)
        {
            byte[] currentImage;
            OpenFileDialog openFile = new OpenFileDialog()
            {
                Filter = "*.png|*.png.|*jpg.|*.jpg|*.jpeg|*.jpeg"
            };
            if (openFile.ShowDialog().GetValueOrDefault())
            {
                currentImage = System.IO.File.ReadAllBytes(openFile.FileName);
                ImageStockUser imageStockUser = new ImageStockUser()
                {
                    ImageSource = currentImage,
                };
                if (!App.Connection.ImageStockUser.Any(x => x.ImageSource == currentImage))
                {
                    App.Connection.ImageStockUser.Add(imageStockUser);
                    App.Connection.SaveChanges();
                    addedImage = imageStockUser;
                }
                else
                {
                    addedImage = App.Connection.ImageStockUser.FirstOrDefault(x => x.ImageSource == currentImage);
                }
                ProfileImage.Source = GetImage(imageStockUser.ImageSource);
            }
        }

        private void DeleteImage_Click(object sender, RoutedEventArgs e)
        {
            ProfileImage.Source = new BitmapImage (new Uri("/Resorces/icon.png", UriKind.Relative));
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTb != null && PasswordTb != null && SurnameTb != null && NameTb != null && PatronymicTb != null)
            {
                if (addedImage != null)
                {
                    ImageStockUser newImage = new ImageStockUser()
                    {
                        ImageSource = addedImage.ImageSource,
                    };
                    App.Connection.ImageStockUser.Add(newImage);
                    App.Connection.SaveChanges();
                    int ProfileImage = newImage.Id_Image;
                    User newUser = new User()
                    {
                        Login = LoginTb.Text,
                        Password = PasswordTb.Text,
                        Surname = SurnameTb.Text,
                        Name = NameTb.Text,
                        Patronymic = PatronymicTb.Text,
                        Id_Role = 1,
                        Id_Image = addedImage.Id_Image,
                    };
                    App.Connection.User.Add(newUser);
                    App.Connection.SaveChanges();
                }
                else
                {
                    User newUser = new User()
                    {
                        Login = LoginTb.Text,
                        Password = PasswordTb.Text,
                        Surname = SurnameTb.Text,
                        Name = NameTb.Text,
                        Patronymic = PatronymicTb.Text,
                    };
                    App.Connection.User.Add(newUser);
                    App.Connection.SaveChanges();
                }
                NavigationService.Navigate(new Authtorization());
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!");
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Authtorization());
        }
    }
}
