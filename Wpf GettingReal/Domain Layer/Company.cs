namespace Wpf_GettingReal.Domain_Layer
{
    public class Company
    {
        //Variablerne og deres startvñrdier
        private string _name = "";
        private int _cvr = 0;
        private string _address = "";
        private int _phoneNo = 0;
        private string _email = "";
        #region
        //Adgang til at ændre og læse variablerne
        string Name { get { return _name; } set { _name = value; } }
        int CVR { get { return _cvr; } set { _cvr = value; } }
        string Address { get { return _address; } set { _address = value; } }
        int PhoneNo { get { return _phoneNo; } set { _phoneNo = value; } }
        string Email { get { return _email; } set { _email = value; } }
        #endregion
        // Konstruktør 
        public Company(string name, int cvr, string address, int phoneNo, string email)
        {
            Name = name;
            CVR = cvr;
            Address = address;
            PhoneNo = phoneNo;
            Email = email;
        }


        //Metode til at opdaterer de eksisterende oplysninger, de interne felter opdateres med nye værdier
        public void UpdateCompanyInfo(string sdsds, int cvr, string address, int phoneNo, string email)
        {
            Name = sdsds;
            CVR = cvr;
            Address = address;
            PhoneNo = phoneNo;
            Email = email;
        }


        //Company CreateCompany = new Company("Hi ApS", 34325, "Findmig veh 49", 20452347, "info@Hi.com");
        

        //CreateCompany.UpdateCompanyInfo("Hi ApS", 34325, "Findmig vej 49", 20452347, "info@Hi.com")  

    }
}
