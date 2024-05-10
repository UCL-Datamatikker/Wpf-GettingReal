using Getting_Real_WPF;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Getting_Real_WPF.ViewModels
{
    //public class IncomeViewModel : INotifyPropertyChanged
    //{
    //    private int amount = 0;
    //    private int invoiceId = 0;
    //    private DateTime date = DateTime.MinValue;
    //    private ObservableCollection<AccountType> accountOptions;
    //    private AccountType account = AccountType.Advokat;
    //    private PaymentMethod paymentMethod = PaymentMethod.Bank;
    //    private bool paymentStatus = false;

    //    public int Amount
    //    {
    //        get { return amount; }
    //        set
    //        {
    //            if (amount != value)
    //            {
    //                amount = value;
    //                OnPropertyChanged(nameof(Amount));
    //            }
    //        }
    //    }
                
    //    public int InvoiceId
    //    {
    //        get { return invoiceId; }
    //        set
    //        {
    //            if (invoiceId != value)
    //            {
    //                invoiceId = value;
    //                OnPropertyChanged(nameof(InvoiceId));
    //            }
    //        }
    //    }
    //    public DateTime Date
    //    {
    //        get { return date; }
    //        set
    //        {
    //            if (date != value)
    //            {
    //                date = value;
    //                OnPropertyChanged(nameof(Date));
    //            }
    //        }
    //    }

    //    public AccountType Account
    //    {
    //        get { return account; }
    //        set
    //        {
    //            if (account != value)
    //            {
    //                account = value;
    //                OnPropertyChanged(nameof(account));
    //            }
    //        }
    //    }

    //    public ObservableCollection<AccountType> AccountOptions
    //    {
    //        get { return accountOptions; }
    //        set
    //        {
    //            return;
    //        }
    //    }


    //    public IncomeViewModel()
    //    {
    //        Amount = 0;

    //        AccountOptions = new ObservableCollection<AccountType>();
    //        Account = AccountType.Bankkonto;
    //    }


    //    public event PropertyChangedEventHandler PropertyChanged;

    //    protected void OnPropertyChanged(string propertyName)
    //    {
    //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    //    }
    //}
}
