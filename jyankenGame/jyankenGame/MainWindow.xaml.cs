using jyankenGame.usecase;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace jyankenGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ResultDecideService resultDecideService;
        public MainWindow()
        {
            InitializeComponent();
            this.resultDecideService = new ResultDecideService();
        }

        /// <summary>
        /// Click the button of rock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.DecodePixelWidth = 500;
            bitmap.CacheOption = BitmapCacheOption.OnLoad;
            bitmap.CreateOptions = BitmapCreateOptions.None;
            if (resultDecideService.ServiceWinGame())
            {
                bitmap.UriSource = new Uri("resources/paper.png", UriKind.Relative);
            }
            else
            {
                bitmap.UriSource = new Uri("resources/scissor.png", UriKind.Relative);
            }
            bitmap.EndInit();

            ResultImage.Source = bitmap;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            if (resultDecideService.ServiceWinGame())
            {
                bitmap.UriSource = new Uri("resources/rock.png", UriKind.Relative);
            }
            else
            {
                bitmap.UriSource = new Uri("resources/paper.png", UriKind.Relative);
            }
            bitmap.EndInit();
            ResultImage.Source = bitmap;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            if (resultDecideService.ServiceWinGame())
            {
                bitmap.UriSource = new Uri("resources/scissor.png", UriKind.Relative);
            }
            else
            {
                bitmap.UriSource = new Uri("resources/rock.png", UriKind.Relative);
            }
            bitmap.EndInit();
            ResultImage.Source = bitmap;
        }
    }
}