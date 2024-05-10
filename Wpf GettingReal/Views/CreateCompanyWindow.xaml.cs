using System.Windows;
using Wpf_GettingReal.Domain_Layer;

namespace Wpf_GettingReal
{
    public partial class CreateCompanyWindow : Window
    {

        public string[] Data;
        public bool Success {  get; set; }

        public CreateCompanyWindow(Window parent)
        {
            
            Owner = parent;
            InitializeComponent();
            Data = new string[5];
            btnOK.IsEnabled = false; 
        }

        private void SetCompanyProperties()
        {
            if (tbName.Text != "" && tbAddr.Text != "" && tbCVR.Text != "" && tbEmail.Text != "" && tbPhone.Text != "")
            {
                Data[0] = tbName.Text;
                Data[1] = tbCVR.Text;
                Data[2] = tbAddr.Text;
                Data[3] = tbPhone.Text;
                Data[4] = tbEmail.Text;

                Success = true;
            }
            else
            {
                
               Close();
            }

        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            SetCompanyProperties();
            
            Close();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            
            Close();
        }

        private void tb_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            EnableOkBtn();
        }

        private void EnableOkBtn()
        {
            if (tbName.Text != "" && tbAddr.Text != "" && tbCVR.Text != "" && tbEmail.Text != "" && tbPhone.Text != "")
            {
                btnOK.IsEnabled = true;
            }
            else
            {
                btnOK.IsEnabled = false;
            }
        }

        
    }
}
