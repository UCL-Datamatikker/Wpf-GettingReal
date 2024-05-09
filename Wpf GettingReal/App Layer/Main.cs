using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_GettingReal.App_Layer
{
    static void Main(string[] args)
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1: Registrér indtægt\n2: Registrér udgift\n3: Opdatér udgift\n4: Opret konto\n5: Registrér virksomhed\n6: Opdater virksomhed");
            int menu = Convert.ToInt32(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    Income.RegisterIncome();
                    break;
                case 2:
                    Expenses.RegisterExpense();
                    break;
                case 3:
                    Expenses.UpdateExpense();
                    break;
                case 4:
                    Account.CreateAccount();
                    break;
                case 5:
                    Company.RegisterCompany();
                    break;
                case 6:
                    Company.UpdateCompany();
                    break;
                default:
                    Console.WriteLine("Fejl 40");
                    break;
            }

            Console.ReadKey();
        }
    }
}
}
