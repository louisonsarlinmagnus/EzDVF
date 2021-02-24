using System;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;
using EzDVF.Pages;

namespace EzDVF
{
      class RequeteGET
    {
        // On défini le lien vers l'api source
        public static string sourceURL = "http://api.cquest.org/dvf?";

        public static string requeteGET(string suiteURL, ILogger<IndexModel> __logger)
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
                __logger.LogError(suiteURL + ": error while processing the GET Request");
                return "";
            }
            // On stock la réponse


            
        }
    }
}