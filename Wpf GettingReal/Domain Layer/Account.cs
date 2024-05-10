

namespace Wpf_GettingReal.Domain_Layer
{
    public class Account
    {

        public string AccountName { get; set; }
        public AccountType AccountId { get; set; }
        public double AccountBalance { get; set; }

        public List<Posting> Postings = new List<Posting>();

        public Account(AccountType accountId, string accountName, double balance)
        {

            AccountName = accountName;
            AccountId = accountId;
            AccountBalance = balance;
        }

        public void UpdateBalance(double newAmount)
        {
            AccountBalance = newAmount;
        }

        public void AddPosting(Posting posting)
        {
            Posting existingPosting = Postings.FirstOrDefault(p => p.PostingId == posting.PostingId);
            if (existingPosting != null)
            {
                Console.WriteLine("Invallid Id");
                return;
            }
            Postings.Add(posting);
            UpdateBalance(posting);
        }

        public double GetBalance()
        {
            return AccountBalance;
        }

        public List<Posting> GetAllPostings()
        {
            return Postings; 
        }

        private void UpdateBalance(Posting posting)
        {
            AccountBalance += posting.Amount;
        }
    }
    public enum AccountType
    {
        // Indkomst
        SalgAfVarer = 1010,
        SalgAfYdelser = 1012,
        Renteindtægt = 4310,

        // Udgifter
        VareForbrug = 1310,
        KøbAfYdelserTilSalg = 1312,
        Lønninger = 2210,
        SkattefriKilometergodtgørelse = 2214,
        Personaleudgifter = 2241,
        BiludgifterBrændstof = 3110,
        BiludgifterForsikringVægtafgift = 3120,
        Husleje = 3410,
        ElVarmeVand = 3420,
        RengøringOgVedligeholdelse = 3430,
        Kontorartikler = 3600,
        SmåanskaffelserU33100 = 3617,
        Telefon = 3620,
        Internet = 3621,
        RevisorBogholder = 3640,
        Advokat = 3645,
        Gebyrer = 3628,
        Forsikringer = 3650,
        GebyrerSkat = 3660,
        Renteudgift = 4410,
        RenterSkat = 4420,

        // Aktiver
        Varelager = 5520,
        Kundetilgodehavender = 5600,
        Kontantkasse = 5810,
        Bankkonto = 5820,

        // Passiver
        EgenkapitalPrimo = 6100,
        IndskudtPrivat = 6120,
        HævetPrivat = 6130,
        BSkat = 6138,
        EgenkapitalIAlt = 6199,
        Kassekredit = 6750,
        Leverandørgæld = 6800,
        GældTilSkat = 6830,
        AndenGæld = 6850
    }
}
