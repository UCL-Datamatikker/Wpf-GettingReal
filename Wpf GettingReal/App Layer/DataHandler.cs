using Newtonsoft.Json;
using System.IO;
using Wpf_GettingReal.Domain_Layer;

namespace Wpf_GettingReal.App_Layer
{
    public class DataHandler
    {

        private List<AccountPlan> AccountPlans = new List<AccountPlan>(); 
        private Company? company;

        
        private string companyFilePath;
        public DataHandler( string companyFilePath)
        {

            
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
              
                return null;
               
            }
            else if (AccountPlans.Find(ap => ap.YearId == yearId) == null)
            {
                
                return null;
            } else
            {
                AccountPlan? accountPlan = AccountPlans.Find(ap => ap.YearId == yearId);
                return accountPlan;
            }
            
        }

       

        public void SaveCompanyPlan(Company? company)
        {
            
            if (company != null)
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
                    
                    Console.WriteLine("JSON file not found. Creating new file...");
                    File.WriteAllText(companyFilePath, "{}"); 
                }
            
            

            
        }
    }
}
