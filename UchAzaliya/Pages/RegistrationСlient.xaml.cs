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
using UchAzaliya.Bases;

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
            ProfileImage.Source = null;
        }
    }
}
