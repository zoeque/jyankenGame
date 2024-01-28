using jyankenGame.usecase;
using System.Windows;
using System.Windows.Media.Imaging;

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
            Uri? uri = null;
            if (resultDecideService.ServiceWinGame())
            {
                uri = new Uri("resources/paper.png", UriKind.Relative);
            }
            else
            {
                uri = new Uri("resources/scissor.png", UriKind.Relative);
            }
            var bitmap = new BitmapImage(uri); 
            ResultImage.Source = bitmap;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Uri? uri = null;
            if (resultDecideService.ServiceWinGame())
            {
                uri = new Uri("resources/rock.png", UriKind.Relative);
            }
            else
            {
                uri = new Uri("resources/paper.png", UriKind.Relative);
            }
            var bitmap = new BitmapImage(uri);
            ResultImage.Source = bitmap;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Uri? uri = null;
            if (resultDecideService.ServiceWinGame())
            {
                uri = new Uri("resources/scissor.png", UriKind.Relative);
            }
            else
            {
                uri = new Uri("resources/rock.png", UriKind.Relative);
            }
            var bitmap = new BitmapImage(uri);
            ResultImage.Source = bitmap;
        }
    }
}