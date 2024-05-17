using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_GettingReal.Domain_Layer
{
    public class Posting
    {
        public int PostingId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public string PaymentMethod { get; set; }
        public string Paid { get; set; }



        public Posting(int postingId, DateTime date, string description, double amount, string paymentMethod, string paid)
        {
            PostingId = postingId;
            Date = date;
            Description = description;
            Amount = amount;
            PaymentMethod = paymentMethod;
            Paid = paid;


        }


        public void UpdateDescription(string newDescription)
        {
            Description = newDescription;
        }


    }
}
