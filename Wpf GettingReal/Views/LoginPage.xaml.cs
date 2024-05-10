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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Wpf_GettingReal.Views;
using Wpf_GettingReal.App_Layer;
using Wpf_GettingReal.Domain_Layer;
using Wpf_GettingReal;

namespace Wpf_GettingReal.Views
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        private Controller controller;
        private MainWindow mainWindow;
        public LoginPage(MainWindow mainWindow, Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
            this.mainWindow = mainWindow;
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string email = tbLoginEmail.Text;
            string password = tbLoginPassword.Text;

            bool loginSuccess = controller.ValidateLogin(email, password);

            if (loginSuccess)
            {
                Company company = controller.GetCompany();
                if (company != null)
                {
                    mainWindow.Main.NavigationService.Navigate(new StartPage(company));
                }
                
            }
            else
            {
                MessageBox.Show("Forkert email eller password - prøv igen");
            }
        }
    }
}
