using System;
using Newtonsoft.Json;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace EzDVF
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            string content = RequeteGET.requeteGET("code_postal=83430");
            Results listResults = new Results();
            if (!String.IsNullOrEmpty(content))
            {
                listResults = JsonConvert.DeserializeObject<Results>(content);
                /* for (int i = 0; i < listResults.nb_resultats; i++)
                {
                    Console.WriteLine(listResults.resultats[i].numero_plan);
                } */
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}