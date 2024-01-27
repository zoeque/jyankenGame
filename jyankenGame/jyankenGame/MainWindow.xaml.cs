using jyankenGame.usecase;
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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (resultDecideService.ServiceWinGame())
            {
                ResultLabel.Content = "パー";
            }
            else
            {
                ResultLabel.Content = "チョキ";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (resultDecideService.ServiceWinGame())
            {
                ResultLabel.Content = "グー";
            }
            else
            {
                ResultLabel.Content = "パー";
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (resultDecideService.ServiceWinGame())
            {
                ResultLabel.Content = "チョキ";
            }
            else
            {
                ResultLabel.Content = "グー";
            }
        }
    }
}