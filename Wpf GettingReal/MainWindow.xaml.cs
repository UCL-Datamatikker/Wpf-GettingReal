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
using Wpf_GettingReal.App_Layer;

namespace Wpf_GettingReal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Controller controller;
        public MainWindow()
        {
            InitializeComponent();

            controller = new Controller();
        }

        private void btnMakeCompany_Click(object sender, RoutedEventArgs e)
        {
            controller.

        }
    }
}