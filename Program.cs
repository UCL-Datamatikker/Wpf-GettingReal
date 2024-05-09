using System;

namespace ExpenseTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Expense class
            Expense expense = new Expense();

            // Call the RegisterExpense method to prompt the user to enter expense details
            expense.RegisterExpense();

            // The expense details will be saved to the specified text file automatically

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
