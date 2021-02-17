using System.Text;
using System.IO;

namespace EzDVF
{
    public static class Convert
    {
        public static bool saveCSV(string path, Results results)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            using (FileStream fs = File.Create(path))
            {
                string header = "code_service_ch,reference_document,articles_1,articles_2,articles_3,articles_4,articles_5,numero_disposition,date_mutation,nature_mutation,valeur_fonciere,numero_voie,suffixe_numero,type_voie,code_voie,voie,code_postal,commune,code_departement,code_commune,prefixe_section,section,numero_plan,numero_volume,lot_1,surface_lot_1,lot_2,surface_lot_2,lot_3,surface_lot_3,lot_4,surface_lot_4,lot_5,surface_lot_51,nombre_lots,code_type_local,type_local,identifiant_local,surface_relle_bati,nombre_pieces_principales,nature_culture,nature_culture_speciale,surface_terrain,lat,lon";
                AddText(fs, header);
                for (int i = 0; i < results.nb_resultats; i++)
                {
                    AddText(fs, results.resultats.ToString());
                }
            }
            
            return false;
        }
        private static void AddText(FileStream fs, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }
    }
}