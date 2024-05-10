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
using Wpf_GettingReal.Domain_Layer;

namespace Wpf_GettingReal.Views
{
    /// <summary>
    /// Interaction logic for StartPage.xaml
    /// </summary>
    public partial class StartPage : Page
    {
        public string CompanyName { get; set; }
        public int CVR { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }

        public StartPage(Company company)
        {
            InitializeComponent();
            CompanyName = company.Name;
            CVR = company.CVR;
            Email = company.Email;
            PhoneNumber = company.Telephone;
            Address = company.Address;

            SetCompanyData();
            
        }

        
        private void SetCompanyData()
        {
            lblName.Content = CompanyName;
            lblCVR.Content = CVR;
            lblEmail.Content = Email;
            lblPhone.Content = PhoneNumber;
            lblAddress.Content = Address;
            
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
          
        }
    }
   
}
