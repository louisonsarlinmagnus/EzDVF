using System.IO;
using System;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;
using EzDVF.Pages;

namespace EzDVF
{
    public static class Convert
    {
        private static readonly string delimiter = ",";
        
        public static Results fromRequestToObjects(string requete, ILogger<IndexModel> __logger)
        {
            string content = RequeteGET.requeteGET(requete, __logger);
            Results listResults = new Results();
            if (!String.IsNullOrEmpty(content))
            {
                listResults = JsonConvert.DeserializeObject<Results>(content);
            }
            return listResults;
        }

        public static void fromResultsToCSV(Results results, string nomFichier)
        {
            using (FileStream file = File.Create(nomFichier))
            { 
                using (StreamWriter writer = new StreamWriter(file))
                {
                    writer.WriteLine("Soruce: " + results.source);
                    writer.WriteLine("Dernière mise à jour: " + results.derniere_maj);
                    writer.WriteLine("License: " + results.licence);
                    writer.WriteLine("date_mutation" + delimiter + "nature_mutation" + delimiter + "valeur_fonciere" + delimiter + "numero_voie" + delimiter + "suffixe_numero" + delimiter +
                    "type_voie" + delimiter + "code_voie" + delimiter + "voie" + delimiter + "code_postal" + delimiter + "commune" + delimiter + "code_departement" + delimiter +
                    "code_commune" + delimiter + "prefixe_section" + delimiter + "section" + delimiter + "numero_plan" + delimiter + "numero_volume" + delimiter + "lot_1" + delimiter +
                    "surface_lot_1" + delimiter + "lot_2" + delimiter + "surface_lot_2" + delimiter + "lot_3" + delimiter + "surface_lot_3" + delimiter + "lot_4" + delimiter +
                    "surface_lot_4" + delimiter + "lot_5" + delimiter + "surface_lot_51" + delimiter + "nombre_lots" + delimiter + "surface_relle_bati" + delimiter +
                    "nombre_pieces_principales" + delimiter + "nature_culture"+ delimiter + "nature_culture_speciale" + delimiter + "surface_terrain");

                    for (int i = 0; i < results.nb_resultats; i++)
                    {
                        writer.WriteLine(results.resultats[i].date_mutation + delimiter + results.resultats[i].nature_mutation + delimiter + results.resultats[i].valeur_fonciere + delimiter +
                        results.resultats[i].numero_voie + delimiter + results.resultats[i].suffixe_numero + delimiter + results.resultats[i].type_voie + delimiter +
                        results.resultats[i].code_voie + delimiter + results.resultats[i].voie + delimiter + results.resultats[i].code_postal + delimiter +
                        results.resultats[i].commune + delimiter + results.resultats[i].code_departement + delimiter + results.resultats[i].code_commune + delimiter +
                        results.resultats[i].prefixe_section + delimiter + results.resultats[i].section + delimiter + results.resultats[i].numero_plan + delimiter +
                        results.resultats[i].numero_volume + delimiter + results.resultats[i].lot_1 + delimiter + results.resultats[i].surface_lot_1 + delimiter +
                        results.resultats[i].lot_2 + delimiter + results.resultats[i].surface_lot_2 + delimiter + results.resultats[i].lot_3 + delimiter +
                        results.resultats[i].surface_lot_3 + delimiter + results.resultats[i].lot_4 + delimiter + results.resultats[i].surface_lot_4 + delimiter +
                        results.resultats[i].lot_5 + delimiter + results.resultats[i].surface_lot_51 + delimiter + results.resultats[i].nombre_lots + delimiter +
                        results.resultats[i].surface_relle_bati + delimiter + results.resultats[i].nombre_pieces_principales + delimiter + results.resultats[i].nature_culture+ delimiter +
                        results.resultats[i].nature_culture_speciale + delimiter + results.resultats[i].surface_terrain);
                    }
                }
            }
        }
    }
}