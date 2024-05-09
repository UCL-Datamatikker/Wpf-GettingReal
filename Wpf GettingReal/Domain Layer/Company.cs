using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf_GettingReal.App_Layer;

namespace Wpf_GettingReal.Domain_Layer
{
    public class Company
    {
        
        public string Name { get; set; }
        public string CVR { get; set; }
        public List<AccountPlan> AccountPlans { get; set; }

        private Controller controller;

        public Company(string name, string cvr)
        {
            Name = name;
            CVR = cvr;
            AccountPlans = new List<AccountPlan>();
            controller = new Controller();

            int currentYear = DateTime.Now.Year;
            DateTime lastDayOfYear = new DateTime(currentYear + 1, 1, 1);
            lastDayOfYear = lastDayOfYear.AddDays(-1);
            DateTime firstDayOfYear = new DateTime(currentYear, 1, 1);
            AccountPlan accountPlan = controller.GetAccountingYear(currentYear);
           
            if (accountPlan != null )
            {
                AccountPlans.Add(accountPlan);
            } else
            {
                CreateAccountPlan(firstDayOfYear, lastDayOfYear);
            }
            
            
        }

        public void CreateAccountPlan(DateTime startDate, DateTime endDate)
        {
            // Implement logic to create a new accounting year
            AccountPlan accountPlan = new AccountPlan(startDate, endDate);
            AccountPlans.Add(accountPlan);
        }

        //public AccountingYear GetAccountPlan(int yearId)
        //{
        //    // Implement logic to retrieve an accounting year by its ID
        //    return new AccountingYear();
        //}

        public List<AccountPlan> GetAllAccountPlans()
        {
            // Implement logic to retrieve all accounting years for this company
            return AccountPlans;
        }


        public void GenerateAnnualReport(int year)
        {
            // Implement logic to generate an annual report for the specified accounting year
        }
    }
}
