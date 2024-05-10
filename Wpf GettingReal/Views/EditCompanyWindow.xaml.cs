using System.Windows;
using Wpf_GettingReal.Domain_Layer;

namespace Wpf_GettingReal.Views
{

    public partial class EditCompanyWindow : Window
    {
        public string[] Data;
        public bool Success { get; set; }
       
        public EditCompanyWindow(Company company)
        {
            
            InitializeComponent();
            Data = [company.Name, company.CVR.ToString(), company.Address, company.Telephone.ToString(), company.Email];
            btnOpdate.IsEnabled = false;
            FillInputs();
        }

        private void FillInputs()
        {
            btnOpdate.IsEnabled = true;
            tbName.Text = Data[0].ToString();
            tbCVR.Text = Data[1].ToString();
            tbAddr.Text = Data[2].ToString();
            tbPhone.Text = Data[3].ToString();
            tbEmail.Text = Data[4].ToString();
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

        private void btnOpdate_Click(object sender, RoutedEventArgs e)
        {
            SetCompanyProperties();
            Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void tb_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            EnableOpdateBtn();
        }

        private void EnableOpdateBtn()
        {
            if (tbName.Text != "" && tbAddr.Text != "" && tbCVR.Text != "" && tbEmail.Text != "" && tbPhone.Text != "")
            {
                btnOpdate.IsEnabled = true;
            }
            else
            {
                btnOpdate.IsEnabled = false;
            }
        }
    }
}
