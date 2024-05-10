

namespace Wpf_GettingReal.Domain_Layer
{
    public class AccountPlan
    {
        public List<Account> Accounts;
        public int YearId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Closed { get; set; }


        public AccountPlan(DateTime startDate, DateTime endDate) {
            StartDate = startDate;
            EndDate = endDate;
            Closed = false;
            YearId = startDate.Year;
            Accounts = new List<Account>();

            foreach (AccountType accountId in Enum.GetValues(typeof(AccountType)))
            {

                string accountName = Enum.GetName(typeof(AccountType), accountId)!;
                Account account = new Account(accountId, accountName, 0.0);
                Accounts.Add(account);

            }
        }
    }
}
