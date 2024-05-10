using GettingReal;
using System.Security.Principal;
using System.Windows;
using System.Windows.Controls;
using Wpf_GettingReal;
using Wpf_GettingReal.App_Layer;
using Wpf_GettingReal.Domain_Layer;
using Wpf_GettingReal.Views;

namespace Getting_Real_WPF.Views
{

    public partial class AddIncomePage : Page
    {
        private Controller controller;
        private Company company;

        
        public AddIncomePage(Controller controller)
        { 
           
            InitializeComponent();
            this.controller = controller;
            company = controller.GetCompany()!;
            AddOptionsToCB();
        }

        private void AddOptionsToCB()
        {
            List<string> options = new List<string>();
            List<Account> accounts = [.. company.AccountPlans[0].Accounts];
            foreach (Account account in accounts)
            {
                if (Enum.IsDefined(typeof(AccountType), account.AccountName))
                {
                    int typeValue = (int)(AccountType)Enum.Parse(typeof(AccountType), account.AccountName);
                    string formattedOption = $"{typeValue}, {account.AccountName}";
                    options.Add(formattedOption);
                }
            }
            foreach (string option in options)
            {
                cbAccount.Items.Add(option);
                cbCounterAccount.Items.Add(option);
            }
            List<string> paymentOption = ["Bank Overførsel","Kontant"];
            List<string> paymentStatus = ["Betalt", "Ikke Betalt"];
            foreach (string option in paymentOption)
            {
                cbPaymentOption.Items.Add(option);
                
            }
            foreach(string option in paymentStatus)
            {
                cbPaymentStatus.Items.Add(option);
            }
           

        }
      


        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            
         
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            AccountType accountId = (AccountType)Enum.Parse(typeof(AccountType), cbAccount.Text.Split(", ")[0]);
            AccountType counterAcount = (AccountType)Enum.Parse(typeof(AccountType), cbCounterAccount.Text.Split(", ")[1]);
            Posting posting = new Posting(int.Parse(tbInvoiceNr.Text), DateTime.Parse(dpDate.Text), tbDescription.Text, double.Parse(tbAmount.Text), cbPaymentOption.Text, cbPaymentStatus.Text.ToLower());
            controller.AddPostingToAccount(DateTime.Parse(dpDate.Text).Year, accountId, counterAcount, posting);
        }
    }
}
