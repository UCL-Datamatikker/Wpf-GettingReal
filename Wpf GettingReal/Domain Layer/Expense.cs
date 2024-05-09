using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml.Serialization;

namespace Wpf_GettingReal.Domain_Layer
{
    public class Expense
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int IdNo { get; set; }
        public float Amount { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentStatus { get; set; }

        public void RegisterExpense()
        {
            Date = DateTime.Now;
            Console.WriteLine(Date.ToString());

            Console.WriteLine("Enter description: ");
            Description = Console.ReadLine();

            Random rnd = new Random();
            IdNo = rnd.Next(10000, 99999);

            Console.WriteLine("Enter amount: ");
            Amount = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter payment method: ");
            PaymentMethod = Console.ReadLine();

            Console.WriteLine("Enter payment status: ");
            PaymentStatus = Console.ReadLine();

            SaveExpenseToFile(@"C:\Users\peter\source\repos\UCL-Datamatikker\Wpf-GettingReal\Expenses.txt.txt");
        }
        private void SaveExpenseToFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"Date: {Date}");
                writer.WriteLine($"Description: {Description}");
                writer.WriteLine($"ID: {IdNo}");
                writer.WriteLine($"Amount: {Amount}");
                writer.WriteLine($"Payment Method: {PaymentMethod}");
                writer.WriteLine($"Payment Status: {PaymentStatus}");
                writer.WriteLine();
            }

            Console.WriteLine("Expense registered.");
        }
    }
}
