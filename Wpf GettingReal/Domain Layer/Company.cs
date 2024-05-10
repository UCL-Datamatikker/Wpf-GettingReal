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
        }

        public void CreateAccountPlan(AccountPlan accountPlan)
        {    
            AccountPlans.Add(accountPlan);
        }

        public AccountPlan? GetAccountPlan(int yearId)
        {
            if (AccountPlans == null || AccountPlans.Count == 0)
            {
             
                return null;

            }
            else if (AccountPlans.Find(ap => ap.YearId == yearId) == null)
            {
               
                return null;
            }
            else
            {
                AccountPlan? accountPlan = AccountPlans.Find(ap => ap.YearId == yearId);
                return accountPlan;
            }
        }

        public List<AccountPlan> GetAllAccountPlans()
        {
            return AccountPlans;
        }

        public void UpdateCompanyInfo(string name, int cvr, string address, int telephone, string email)
        {
            Name = name;
            CVR = cvr;
            Address = address;
            Telephone = telephone;
            Email = email;
        }


        //public void GenerateAnnualReport(int year)
        //{
        //    // Implement logic to generate an annual report for the specified accounting year
        //}
    }
}
