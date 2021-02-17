using System.Collections.Generic;

namespace EzDVF
{
    public class Results
    {
        public string source {get; set;}
        public string derniere_maj {get; set;}
        public string licence {get; set;}
        public float? nb_resultats {get; set;}
        public List<Transaction> resultats {get; set;}
    }
}