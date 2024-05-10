using System.Windows;
using System.Windows.Controls;
using Wpf_GettingReal.App_Layer;
using Wpf_GettingReal.Domain_Layer;

namespace Wpf_GettingReal.Views
{
    /// <summary>
    /// Interaction logic for NoCompanyPage.xaml
    /// </summary>
    public partial class NoCompanyPage : Page
    {
        MainWindow MainWindow;
        Controller controller;
        public NoCompanyPage(Controller controller, MainWindow MainWindow)
        {
            InitializeComponent();
            this.controller = controller;
            this.MainWindow = MainWindow;
        }

        private void btnMakeCompany_Click(object sender, RoutedEventArgs e)
        {
            CreateCompanyWindow CreateCompanyWindow = new CreateCompanyWindow(MainWindow);
            Opacity = 0.4;
            CreateCompanyWindow.ShowDialog();
            Opacity = 1.0;
            if (CreateCompanyWindow.Success)
            {
                string[] companyData = CreateCompanyWindow.Data;
                controller.CreateCompany(companyData[0], int.Parse(companyData[1]), companyData[2], int.Parse(companyData[3]), companyData[4]);
                Company? company = controller.GetCompany();

                MainWindow.Main.Content = new StartPage(company!, controller);
                MainWindow.EnableButtons();
            }


        }
    }
}
