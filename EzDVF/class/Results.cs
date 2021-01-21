using System.Collections.Generic;

namespace EzDVF
{
    public class Results
    {
        public Results()
        {
            source = "";
            derniere_maj = "";
            licence = "";
            nb_resultats = 0;
            //transaction = new Transaction();
            transactions = new List<Transaction>();
            for (int i = nb_resultats; i < nb_resultats; i++)
            {
                transactions.Add(new Transaction());
            }
        }
        public string source {get; set;}
        public string derniere_maj {get; set;}
        public string licence {get; set;}
        public int nb_resultats {get; set;}
        //public Transaction transaction {get; set;}
        public List<Transaction> transactions {get; set;}
    }
}