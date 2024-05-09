using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_GettingReal.App_Layer
{
    public class Appendix
    {
        DateTime Date = DateTime.Now;
        string Type {  get; set; }
        float Amount { get; set; }
        int Account { get; set; }
        int CounterAccount { get; set; }
        int Reference { get; set; }

        public Appendix(string type, float amount, int account, int counterAccount, int reference)
        {
            Type = type;
            Amount = amount;
            Account = account;
            CounterAccount = counterAccount;
            Reference = reference;
        }
    }
}
