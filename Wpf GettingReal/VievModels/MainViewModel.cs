using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf_GettingReal.App_Layer;
using Wpf_GettingReal.Domain_Layer;

namespace Getting_Real_WPF.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {


        ObservableCollection<AccountPlan> accountPlansCollection;
        Controller controller;

        public MainViewModel(Controller controller) {
            this.controller = controller;
            accountPlansCollection = new ObservableCollection<AccountPlan>();

            List<AccountPlan> accountPlans = controller.GetAllAccountPlans();

            foreach(AccountPlan AP in accountPlans)
            {
                accountPlansCollection.Add(AP);
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
