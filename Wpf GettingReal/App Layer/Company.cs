using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal
{
    public class Company
    {
        public string Name { get; set; }
        public int Cvr { get; set; }
        public string Address { get; set; }
        public int Telephone { get; set; }
        public string Email { get; set; }

        public Company(string name, int cvr, string address, int telephone, string email)
        {
            Name = name;
            Cvr = cvr;
            Address = address;
            Telephone = telephone;
            Email = email;
        }

        public static void RegisterCompany()
        {

        }

        public static void UpdateCompany()
        {

        }
    }
}
