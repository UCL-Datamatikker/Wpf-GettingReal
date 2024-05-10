using Wpf_GettingReal.Domain_Layer;


namespace Wpf_GettingReal.App_Layer
{
    public class Controller
    {
        private List<AccountPlan> AccountPlanRepo;
        private DataHandler dataHandler;
        Company? company;
        

        public Controller()
        {
           
            dataHandler = new DataHandler("AccountPlans.txt", "Company.txt");
            AccountPlanRepo = dataHandler.GetAllAccountingYears();
            company = dataHandler.GetCompany();
        }

        public void CreateCompany(string name, int cvr, string address, int telephone, string email)
        {
            if (company == null)
            {

            
            Company company = new Company(name, cvr, address, telephone, email);

            if (AccountPlanRepo.Count > 0 )
            {
                foreach (AccountPlan plan in AccountPlanRepo)
                {
                    company.CreateAccountPlan(plan);
                }
            } else
            {
                int currentYear = DateTime.Now.Year;
                DateTime lastDayOfYear = new DateTime(currentYear + 1, 1, 1);
                lastDayOfYear = lastDayOfYear.AddDays(-1);
                DateTime firstDayOfYear = new DateTime(currentYear, 1, 1);


                AccountPlan accountPlan = new AccountPlan(firstDayOfYear, lastDayOfYear);
                company.CreateAccountPlan(accountPlan);
            }


            dataHandler.SaveAccountOrCompanyPlan(null, company);
            } else
            {
                return;
            }

        }

        public AccountPlan CreateAccountPlan(DateTime startDate, DateTime endDate)
        {
            // Implement logic to create a new accounting year
            // This might involve initializing the properties and saving it to a data source
            AccountPlan newAccountPlan = new AccountPlan(startDate, endDate);


            // Save the new accounting year to the data source
            dataHandler.SaveAccountOrCompanyPlan(newAccountPlan, null);

            return newAccountPlan;
        }

        public Company? GetCompany()
        {
            return dataHandler.GetCompany();
        }

        public AccountPlan? GetAccountingYear(int yearId)
        {
            // Retrieve the accounting year from the repository based on its ID
            return dataHandler.GetAccountAccountPlan(yearId);
        }

        public List<AccountPlan> GetAllAccountingYears()
        {
              return dataHandler.GetAllAccountingYears();
        }

     

        public void AddPostingToAccount(int yearId, AccountType accountId, AccountType counterAccountId, Posting posting ) {
            AccountPlan? accountingYear = GetAccountingYear(yearId);
            if ( accountingYear == null )
            {
                return ;
            } else
            {
                Account? account = accountingYear.Accounts.Find((a) => a.AccountId == accountId);
                Account? counterAccount = accountingYear.Accounts.Find((a) => a.AccountId == counterAccountId);
                if (account == null)
                {
                    Console.WriteLine("Konto ikke Fundet!");
                    return;
                }
                if (counterAccount == null)
                {
                    Console.WriteLine("Modkonto ikke fundet!");
                    return;
                }

                // Posting negativePosting = new Posting(posting.PostingId, posting.Date, posting.Description, -posting.Amount);
                account.AddPosting(posting);
                counterAccount.AddPosting(posting);
                dataHandler.SaveAccountOrCompanyPlan(accountingYear, null);
            }
            
            
            
        }
    }
}
