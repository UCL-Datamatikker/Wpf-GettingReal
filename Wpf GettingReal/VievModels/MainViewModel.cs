﻿using System.Collections.ObjectModel;
using System.ComponentModel;
using Wpf_GettingReal.App_Layer;
using Wpf_GettingReal.Domain_Layer;

namespace Getting_Real_WPF.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {


        private ObservableCollection<AccountPlan> _accountPlansCollection;
        public ObservableCollection<AccountPlan> AccountPlansCollection
        {
            get
            {
                return _accountPlansCollection;
            }
            set
            {
                _accountPlansCollection = value;
                OnPropertyChanged(nameof(AccountPlansCollection));
            }
        }

        private AccountPlan _selectedAccountPlan;
        public AccountPlan SelectedAccountPlan
        {
            get { return _selectedAccountPlan; }
            set
            {
                _selectedAccountPlan = value;
                OnPropertyChanged(nameof(SelectedAccountPlan));
                foreach (var account in _selectedAccountPlan.Accounts)
                {
                    AccountCollection.Add(account);
                }
            }
        }

        private ObservableCollection<Account> _accountCollection;
        public ObservableCollection<Account> AccountCollection
        {
            get
            {
                return _accountCollection;
            }
            set
            {
                _accountCollection = value;
                OnPropertyChanged(nameof(AccountCollection));
            }
        }

        private Account _selectedAccount;
        public Account SelectedAccount
        {
            get { return _selectedAccount; }
            set
            {
                _selectedAccount = value;
                OnPropertyChanged(nameof(SelectedAccount));
                foreach (var posting in _selectedAccount.Postings)
                {
                    PostingCollection.Add(posting);
                }
            }
        }

        private ObservableCollection<Posting> _postingCollection;
        public ObservableCollection<Posting> PostingCollection
        {
            get
            {
                return _postingCollection;
            }
            set
            {
                _postingCollection = value;
                OnPropertyChanged(nameof(PostingCollection));
            }
        }

        private Posting _selectedPosting;
        public Posting SelectedPosting
        {
            get { return _selectedPosting; }
            set
            {
                _selectedPosting = value;
                OnPropertyChanged(nameof(SelectedPosting));

            }
        }

        public Controller controller;

        public MainViewModel() {
            this.controller = new Controller();
            AccountPlansCollection = new ObservableCollection<AccountPlan>();
            AccountCollection = new ObservableCollection<Account>();
            PostingCollection = new ObservableCollection<Posting>();
            List<AccountPlan> accountPlans = controller.GetAllAccountPlans();

            if (accountPlans != null)
            {
                foreach (AccountPlan AP in accountPlans)
                {
                    AccountPlansCollection.Add(AP);
                }
            }
            
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
