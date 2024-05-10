namespace Wpf_GettingReal.Domain_Layer
{
    public class Company
    {
        
        public string Name { get; set; }
        public int CVR { get; set; }
        public string Address { get; set; }
        public int Telephone { get; set; }
        public string Email { get; set; }
        public List<AccountPlan> AccountPlans { get; set; }

        

        public Company(string name, int cvr, string address, int telephone, string email)
        {
            Name = name;
            CVR = cvr;
            Address = address;
            Telephone = telephone;
            Email = email;
            AccountPlans = new List<AccountPlan>();


            //int currentYear = DateTime.Now.Year;
            //DateTime lastDayOfYear = new DateTime(currentYear + 1, 1, 1);
            //lastDayOfYear = lastDayOfYear.AddDays(-1);
            //DateTime firstDayOfYear = new DateTime(currentYear, 1, 1);

            //List<AccountPlan> accountPlan = controller.GetAllAccountingYears();

            //if (accountPlan != null )
            //{
            //    foreach (AccountPlan account in accountPlan)
            //    {
            //        AccountPlans.Add(account);
            //    }

            //} else
            //{
            //    CreateAccountPlan(firstDayOfYear, lastDayOfYear);
            //}


        }

        public void CreateAccountPlan(AccountPlan accountPlan)
        {
            // Implement logic to create a new accounting year
            
            AccountPlans.Add(accountPlan);
        }

        //public AccountPlan GetAccountPlan(int yearId)
        //{
        //    // Implement logic to retrieve an accounting year by its ID
        //    return new AccountPlan();
        //}

        public List<AccountPlan> GetAllAccountPlans()
        {
            // Implement logic to retrieve all accounting years for this company
            return AccountPlans;
        }


        //public void GenerateAnnualReport(int year)
        //{
        //    // Implement logic to generate an annual report for the specified accounting year
        //}
    }
}
