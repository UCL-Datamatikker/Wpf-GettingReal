using Getting_Real_WPF.ViewModels;
using System.Windows.Controls;

namespace Wpf_GettingReal.Views
{

    public partial class AccountOverviewPage : Page
    {


        public AccountOverviewPage()
        {
            InitializeComponent();
            MainViewModel mvm = new MainViewModel();
            DataContext = mvm;

        }
    }
}
