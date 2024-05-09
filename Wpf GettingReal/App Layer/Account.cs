using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_GettingReal.App_Layer
{
    public class Account
    {
        string Name {  get; set; }
        string Type {  get; set; }
        float AccountNo { get; set; }

        public Account(string name, string type, float account)
        {
            Name = name;
            Type = type;
            AccountNo = account;
        }

        public static void CreateAccount()
        {

        }
    }
}
