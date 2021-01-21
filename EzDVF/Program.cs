using System;
using Newtonsoft.Json;

namespace EzDVF
{
    class Program
    {
        static void Main(string[] args)
        {
            string content = RequeteGET.requeteGET("code_postal=83430");
            Results listResults = new Results();
            listResults = JsonConvert.DeserializeObject<Results>(content);
            Console.Write(listResults.transactions.Count);
        }
    }
}