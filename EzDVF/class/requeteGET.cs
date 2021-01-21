using System;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace EzDVF
{
      class RequeteGET
    {
        // On défini le lien vers l'api source
        public static string sourceURL = "http://api.cquest.org/dvf?";

        public static string requeteGET(string suiteURL)
        {
            string fullURL = sourceURL + suiteURL;
            // On créer la requète
            WebRequest request = WebRequest.Create(fullURL);
            // On stock la réponse
            WebResponse response = request.GetResponse();


            using (Stream dataStream = response.GetResponseStream())
            using(StreamReader sr = new StreamReader(dataStream))

            {
                
                string content = sr.ReadToEnd();

                response.Close();
                return(content);
            }
        }
    }
}