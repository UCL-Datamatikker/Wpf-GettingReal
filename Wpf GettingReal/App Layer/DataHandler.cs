using Newtonsoft.Json;
using System.IO;
using Wpf_GettingReal.Domain_Layer;

namespace Wpf_GettingReal.App_Layer
{
    public class DataHandler
    {

        private List<AccountPlan> AccountPlans = new List<AccountPlan>(); // Simulated data storage

        private string filePath; // File path for storing JSON data

        public DataHandler(string filePath)
        {

            this.filePath = filePath;
            LoadDataFromJsonFile();

        }



        public AccountPlan GetAccountAccountPlan(int yearId)
        {
            // Retrieve the accounting year from the data storage based on its ID
            if (AccountPlans.Count == 0) Console.WriteLine("Repo is empty");
            if (AccountPlans.Find(year => year.YearId == yearId) == null) Console.WriteLine("Not Found!");

            return AccountPlans.Find(year => year.YearId == yearId);
        }

        public List<AccountPlan> GetAllAccountingYears()
        {
            return AccountPlans;
        }

        public void SaveAccountPlan(AccountPlan year)
        {
            // Save the accounting year to the data storage

            SaveDataToJsonFile(year);
        }

        private void SaveDataToJsonFile(AccountPlan year)
        {
            // Check if the year's ID already exists in the list
            AccountPlan existingYear = AccountPlans.FirstOrDefault(y => y.YearId == year.YearId);

            if (existingYear != null)
            {
                existingYear = year;
            }
            else
            {
                // If the year doesn't exist, add it to the list
                AccountPlans.Add(year);
            }

            // Serialize the list of accounting years to JSON format
            string jsonData = JsonConvert.SerializeObject(AccountPlans, Formatting.Indented);

            // Write the JSON data to the file
            File.WriteAllText(filePath, jsonData);
        }

        private void LoadDataFromJsonFile()
        {
            if (File.Exists(filePath))
            {
                // Read JSON data from the file
                string jsonData = File.ReadAllText(filePath);

                // Deserialize JSON data to list of accounting years
                AccountPlans = JsonConvert.DeserializeObject<List<AccountPlan>>(jsonData);
            }
            else
            {
                // Handle case when the JSON file does not exist
                // For example, you might create a new JSON file or log an error message
                Console.WriteLine("JSON file not found. Creating new file...");
                File.WriteAllText(filePath, "[]"); // Create a new empty JSON file
            }
        }
    }
}
