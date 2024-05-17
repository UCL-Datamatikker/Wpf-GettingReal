using System.IO;

namespace GettingReal
{
    public class Expenses
    {
        DateTime Date;
        public string Description {  get; set; }
        public int Id { get; set; }
        public double Amount { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentStatus { get; set; }

        public static int Count;

        public Expenses(double amount, string paymentMethod, string paymentStatus, string description)
        {
            Id = Count + 1;
            Date = DateTime.Now;
            Description = description;
            Amount = amount;
            PaymentMethod = paymentMethod;
            PaymentStatus = paymentStatus;

            Count++;
        }
        public override string ToString()
        {
            return $"{Id}, {Date}, {Description}, {Amount}, {PaymentMethod}, {PaymentStatus}";
        }
        public static void RegisterExpense()
        {
            Console.WriteLine("Registrér udgift.\n\nIndtast beskrivelse: ");
            string description = Console.ReadLine();
            Console.Write("Indtast beløb: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Intast betalingsmetode: ");
            string method = Console.ReadLine();
            Console.WriteLine("Indtast status på betaling: ");
            string status = Console.ReadLine();

            Expenses expense = new Expenses(amount, method, status, description);
            Console.Clear();
            Console.WriteLine("ID: " + expense.Id + "\nTid: " + expense.Date + "\nBeskrivelse: " + expense.Description + "\nBeløb: " + expense.Amount + "\nBetalingsmetode: " + expense.PaymentMethod + "\nBetalingsstatus: " + expense.PaymentStatus);
            
            string filePath = @"C:\Users\ivark\Desktop\Datamatiker Online\Projects\GettingReal\Expenses.txt";

            File.WriteAllText(filePath, expense.ToString() + Environment.NewLine);
        }

        public static void UpdateExpense()
        {

        }
    }
}
