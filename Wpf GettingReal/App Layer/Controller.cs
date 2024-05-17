using Wpf_GettingReal.Domain_Layer;


namespace Wpf_GettingReal.App_Layer
{
    public class Controller
    {
        private List<AccountPlan>? AccountPlanRepo = new List<AccountPlan>();
        private DataHandler dataHandler;
        Company? company;
        

        public Controller()
        {
           
            dataHandler = new DataHandler("AccountPlans.txt", "Company.txt");
            company = dataHandler.GetCompany();
            AccountPlanRepo = company?.GetAllAccountPlans();
        }

        public void CreateCompany(string name, int cvr, string address, int telephone, string email, string password)
        {
            if (company == null)
            {

            
            Company company = new Company(name, cvr, address, telephone, email, password);

            if (AccountPlanRepo != null && AccountPlanRepo.Count > 0)
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

                this.company = company;
            dataHandler.SaveAccountOrCompanyPlan(null, company);
            } else
            {
                return;
            }

        }

        
        public Company? GetCompany()
        {   
            return dataHandler.GetCompany();
        }

        public AccountPlan? GetAccountingYear(int yearId)
        {
            // Retrieve the accounting year from the repository based on its ID
            return company!.GetAccountPlan(yearId);
        }


        public List<AccountPlan> GetAllAccountPlans()
        {
            return company!.GetAllAccountPlans();
        } 


        
        
        public bool ValidateLogin(string email, string password)
        {
            //Recieve company info from datahandler
            Company? company = dataHandler.GetCompany();
            if (company != null && company.Email == email && company.Password == password)
            {
                return true;
            }
            return false;
        }


        public void AddPostingToAccount(int yearId, int accountId, int counterAccountId, Posting posting ) {
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
                  
                    return;
                }
                if (counterAccount == null)
                {
                   
                    return;
                }

                // Posting negativePosting = new Posting(posting.PostingId, posting.Date, posting.Description, -posting.Amount);
                account.AddPosting(posting);
                counterAccount.AddPosting(posting);
                dataHandler.SaveAccountOrCompanyPlan(null, company);
            }
      
        }

        public Company UpdateCompanyInfo(string name, int cvr, string address, int telephone, string email)
        {
            company.UpdateCompanyInfo(name, cvr, address, telephone, email);
            dataHandler.SaveAccountOrCompanyPlan(null, company);

            return company;
        }
    }
}
