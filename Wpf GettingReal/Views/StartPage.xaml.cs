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
using Wpf_GettingReal.App_Layer;
using Wpf_GettingReal.Domain_Layer;

namespace Wpf_GettingReal.Views
{
    /// <summary>
    /// Interaction logic for StartPage.xaml
    /// </summary>
    public partial class StartPage : Page
    {
        private Controller controller;

        public string CompanyName { get; set; }
        public int CVR { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }

        private Controller Controller { get; set; }
        private Company Company { get; set; }

        public StartPage(Company company, Controller controller)
        {
            InitializeComponent();
            this.Company = company;
            this.Controller = controller;
            

            SetCompanyData(company);
            
        }

        public StartPage(Controller controller)
        {
            this.controller = controller;
        }

        private void SetCompanyData()

        {
            CompanyName = company.Name;
            CVR = company.CVR;
            Email = company.Email;
            PhoneNumber = company.Telephone;
            Address = company.Address;

            lblName.Content = CompanyName;
            lblCVR.Content = CVR;
            lblEmail.Content = Email;
            lblPhone.Content = PhoneNumber;
            lblAddress.Content = Address;
            
        }


        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            EditCompanyWindow editCompanyWindow = new EditCompanyWindow(Company);
            editCompanyWindow.ShowDialog();

            if (editCompanyWindow.Success)
            {
                string[] Data = editCompanyWindow.Data;
                Company = Controller.UpdateCompanyInfo(Data[0], int.Parse(Data[1]), Data[2], int.Parse(Data[3]), Data[4]);
                SetCompanyData(Company);
            }
        }
    }
   
}
