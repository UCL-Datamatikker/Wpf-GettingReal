using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_GettingReal.App_Layer
{
    public class Income
    {
        DateTime Date;
        public int Id { get; set; }
        public double Amount { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentStatus { get; set; }

        public static int Count;

        public Income(double amount, string paymentMethod, string paymentStatus)
        {
            Id = Count + 1;
            Date = DateTime.Now;
            Amount = amount;
            PaymentMethod = paymentMethod;
            PaymentStatus = paymentStatus;

            Count++;
        }
        public override string ToString()
        {
            return $"{Id}, {Date}, {Amount}, {PaymentMethod}, {PaymentStatus}";
        }
        public static void RegisterIncome()
        {
            Console.Write("Registrér indkomst.\n\nIndtast beløb: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Intast betalingsmetode: ");
            string method = Console.ReadLine();
            Console.WriteLine("Indtast status på betaling: ");
            string status = Console.ReadLine();

            Income income = new Income(amount, method, status);
            Console.Clear();
            Console.WriteLine("Faktura no.: " + income.Id + "\nTid: " + income.Date + "\nBeløb: " + income.Amount + "\nBetalingsmetode: " + income.PaymentMethod + "\nBetalingsstatus: " + income.PaymentStatus);

            string filePath = @"C:\Users\ivark\Desktop\Datamatiker Online\Projects\GettingReal\Income.txt";

            File.WriteAllText(filePath, income.ToString() + Environment.NewLine);
        }

    }
}
