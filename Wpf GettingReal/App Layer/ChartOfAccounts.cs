using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_GettingReal.App_Layer
{
    public class ChartOfAccounts
    {
        DateTime Date = DateTime.Now;
        string Name {  get; set; }

        public ChartOfAccounts(string name)
        {
            Name = name;
        }
    }
}
