using Getting_Real_WPF.Views;
using System.Windows;
using Wpf_GettingReal.App_Layer;
using Wpf_GettingReal.Domain_Layer;
using Wpf_GettingReal.Views;

namespace Wpf_GettingReal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        Controller controller;
        Company? company;
        public MainWindow()
        {
            InitializeComponent();
            controller = new Controller();
            company = controller.GetCompany();
            if (company != null)
            {
                Main.Content = new StartPage(company, controller);
                
            } else
            {
                btnCompany.IsEnabled = false;
                btnExpense.IsEnabled = false;
                btnIncome.IsEnabled = false;
                Main.Content = new NoCompanyPage(controller, this);
            }
        }

        public void EnableButtons()
        {
            btnCompany.IsEnabled = true;
            btnIncome.IsEnabled = true;
            btnExpense.IsEnabled = true;
        }

        private void btnCompany_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new StartPage(company!, controller);
        }

        private void btnIncome_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new AddIncomePage(controller);
        }

        private void btnExpense_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new AddExpensePage();
        }

        //private void btnMakeCompany_Click(object sender, RoutedEventArgs e)
        //{
        //    CreateCompanyWindow CreateCompanyWindow = new CreateCompanyWindow(this);
        //    Opacity = 0.4;
        //    CreateCompanyWindow.ShowDialog();
        //    Opacity = 1.0;
        //    if (CreateCompanyWindow.Success)
        //    {
        //        string[] companyData = CreateCompanyWindow.Data;
        //        controller.CreateCompany(companyData[0], int.Parse(companyData[1]), companyData[2], int.Parse(companyData[3]), companyData[4]);
        //    }

        //}
    }
}