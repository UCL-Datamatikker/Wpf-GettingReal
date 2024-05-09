using Wpf_GettingReal.Domain_Layer;


namespace Wpf_GettingReal.App_Layer
{
    public class Controller
    {
        private List<AccountPlan> AccountPlanRepo;
        private DataHandler dataHandler;

        public Controller()
        {
            AccountPlanRepo = new List<AccountPlan>();
            dataHandler = new DataHandler("AccountPlans.txt");
        }

        public AccountPlan CreateAccountPlan(DateTime startDate, DateTime endDate)
        {
            // Implement logic to create a new accounting year
            // This might involve initializing the properties and saving it to a data source
            AccountPlan newAccountingYear = new AccountPlan(startDate, endDate);


            // Save the new accounting year to the data source
            dataHandler.SaveAccountPlan(newAccountingYear);

            return newAccountingYear;
        }

        public AccountPlan GetAccountingYear(int yearId)
        {
            // Retrieve the accounting year from the repository based on its ID
            return dataHandler.GetAccountAccountPlan(yearId);
        }

        public List<AccountPlan> GetAllAccountingYears()
        {
            // Retrieve all accounting years from the repository
            return dataHandler.GetAllAccountingYears();
        }

        public void GenerateAnnualReport(AccountPlan year)
        {
            // Implement logic to generate an annual report for the specified accounting year
            // This might involve calculations and formatting of financial data
            // The generated report could be saved to a file or sent via email, for example
            Console.WriteLine($"Generating annual report for accounting year {year.YearId}...");
            
        }

        public void AddPostingToAccount(int yearId, AccountType accountId, AccountType counterAccountId, Posting posting ) {
            AccountPlan accountingYear = GetAccountingYear(yearId);
            Account account = accountingYear.Accounts.Find((a) => a.AccountId == accountId);
            Account counterAccount = accountingYear.Accounts.Find((a) => a.AccountId == counterAccountId);
            if (account == null || counterAccount == null)
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
            dataHandler.SaveAccountPlan(accountingYear);
        }
    }
}
