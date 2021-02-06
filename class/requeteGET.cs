using System;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace EzDVF_IHM
{
      class RequeteGET
    {
        // On défini le lien vers l'api source
        public static string sourceURL = "http://api.cquest.org/dvf?";

        public static string requeteGET(string suiteURL)
        {
            string fullURL = sourceURL + suiteURL;
            // On créer la requète
            try
            {
                WebRequest request = WebRequest.Create(fullURL);
                WebResponse response = request.GetResponse();

                using (Stream dataStream = response.GetResponseStream())
                using(StreamReader sr = new StreamReader(dataStream))

                {
                    
                    string content = sr.ReadToEnd();

                    response.Close();
                    return(content);
                }
            }
            catch (System.Exception)
            {
                Console.WriteLine("Erreur d'accès a la base de donnée");
                return "";
            }
            // On stock la réponse


            
        }
    }
}