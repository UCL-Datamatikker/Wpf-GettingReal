using Newtonsoft.Json;
using System.IO;
using Wpf_GettingReal.Domain_Layer;

namespace Wpf_GettingReal.App_Layer
{
    public class DataHandler
    {

        private List<AccountPlan>? AccountPlans = new List<AccountPlan>(); // Simulated data storage
        private Company? company;

        private string accountFilePath; // File path for storing JSON data
        private string companyFilePath;
        public DataHandler(string accountFilePath, string companyFilePath)
        {

            this.accountFilePath = accountFilePath;
            this.companyFilePath = companyFilePath;

            LoadDataFromJsonFile();

        }

        public Company? GetCompany()
        {
            return company;
        }


        public AccountPlan? GetAccountAccountPlan(int yearId)
        {
            // Retrieve the accounting year from the data storage based on its ID
            if (AccountPlans.Count == 0)
            {
                Console.WriteLine("Repo is empty");
                AccountPlans = null;
                return null;
               
            }
            else if (AccountPlans.Find(ap => ap.YearId == yearId) == null)
            {
                Console.WriteLine("Not Found!");
                return null;
            } else
            {
                AccountPlan accountPlan = AccountPlans.Find(ap => ap.YearId == yearId);
                return accountPlan;
            }
            
        }

        public List<AccountPlan> GetAllAccountingYears()
        {
            return AccountPlans;
        }

        public void SaveAccountOrCompanyPlan(AccountPlan? accountPlan, Company? company)
        {
            // Save the accounting year to the data storage
            if(accountPlan != null)
            {
                SaveDataToJsonFile(accountPlan);
            } else if (company != null)
            {
                SaveCompany(company);
            }
            
        }
        private void SaveCompany(Company company)
        {
            this.company = company;

            string jsonData = JsonConvert.SerializeObject(company, Formatting.Indented);
            File.WriteAllText(companyFilePath, jsonData);
        }

        private void SaveDataToJsonFile(AccountPlan accountPlan)
        {
            // Check if the year's ID already exists in the list
            AccountPlan existingAccountPlan = AccountPlans.FirstOrDefault(ap => ap.YearId == accountPlan.YearId);

            if (existingAccountPlan != null)
            {
                existingAccountPlan = accountPlan;
            }
            else
            {
                // If the year doesn't exist, add it to the list
                AccountPlans.Add(accountPlan);
            }

            // Serialize the list of accounting years to JSON format
            string jsonData = JsonConvert.SerializeObject(AccountPlans, Formatting.Indented);

            // Write the JSON data to the file
            File.WriteAllText(accountFilePath, jsonData);
        }

        private void LoadDataFromJsonFile()
        {
          
                if (File.Exists(companyFilePath))
                {
                    // Read JSON data from the file
                    string jsonData = File.ReadAllText(companyFilePath);

                    // Deserialize JSON data
                    if (jsonData != null && jsonData != "{}")
                    {
                        company = JsonConvert.DeserializeObject<Company>(jsonData);
                    } else { company = null; }
                   

                }
                else
                {
                    // Handle case when the JSON file does not exist
                    // For example, you might create a new JSON file or log an error message
                    Console.WriteLine("JSON file not found. Creating new file...");
                    File.WriteAllText(companyFilePath, "{}"); // Create a new empty JSON file
                }
            
            

            if (File.Exists(accountFilePath))
            {
                // Read JSON data from the file
                string jsonData = File.ReadAllText(accountFilePath);

                // Deserialize JSON data to list of accounting years
                AccountPlans = JsonConvert.DeserializeObject<List<AccountPlan>>(jsonData);
            }
            else
            {
                // Handle case when the JSON file does not exist
                // For example, you might create a new JSON file or log an error message
                Console.WriteLine("JSON file not found. Creating new file...");
                File.WriteAllText(accountFilePath, "[]"); // Create a new empty JSON file
            }
        }
    }
}
