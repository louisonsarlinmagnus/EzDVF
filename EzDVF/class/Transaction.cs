namespace EzDVF
{
    public class Transaction
    {
        public Transaction ()
        {
            code_service_ch = "pouet";
            reference_document = "pouet";
            articles_1 = "pouet";
            articles_2 = "pouet";
            articles_3 = "pouet";
            articles_4 = "pouet";
            articles_5 = "pouet";
            numero_disposition = "pouet";
            date_mutation = "pouet";
            nature_mutation = "pouet";
            valeur_fonciere = 0;
            numero_voie = "pouet";
            suffixe_numero = "pouet";
            type_voie = "pouet";
            code_voie = "pouet";
            voie = "pouet";
            code_postal = "pouet";
            commune = "pouet";
            code_departement = "pouet";
            code_commune = "pouet";
            prefixe_section = "pouet";
            section = "pouet";
            numero_plan = "pouet";
            numero_volume = "pouet";
            lot_1 = "pouet";
            surface_lot_1 = "pouet";
            lot_2 = "pouet";
            surface_lot_2 = "pouet";
            lot_3 = "pouet";
            surface_lot_3 = "pouet";
            lot_4 = "pouet";
            surface_lot_4 = "pouet";
            lot_5 = "pouet";
            surface_lot_51 = "pouet";
            nombre_lots = "pouet";
            code_type_local = "pouet";
            type_local = "pouet";
            identifiant_local = "pouet";
            surface_relle_bati = 0;
            nombre_pieces_principales = 0;
            nature_culture = "pouet";
            nature_culture_speciale = "pouet";
            surface_terrain = 0;
            lat = 0;
            lon = 0;
            geom = new Geom();
        }
        
        public override string ToString()
        {
            return  (code_service_ch + "," +
                    reference_document + "," +
                    articles_1 + "," +
                    articles_2 + "," +
                    articles_3 + "," +
                    articles_4 + "," +
                    articles_5 + "," +
                    numero_disposition + "," +
                    date_mutation + "," +
                    nature_mutation + "," +
                    valeur_fonciere + "," +
                    numero_voie + "," +
                    suffixe_numero + "," +
                    type_voie + "," +
                    code_voie + "," +
                    voie + "," +
                    code_postal + "," +
                    commune + "," +
                    code_departement + "," +
                    code_commune + "," +
                    prefixe_section + "," +
                    section + "," +
                    numero_plan + "," +
                    numero_volume + "," +
                    lot_1 + "," +
                    surface_lot_1 + "," +
                    lot_2 + "," +
                    surface_lot_2 + "," +
                    lot_3 + "," +
                    surface_lot_3 + "," +
                    lot_4 + "," +
                    surface_lot_4 + "," +
                    lot_5 + "," +
                    surface_lot_51 + "," +
                    nombre_lots + "," +
                    code_type_local + "," +
                    type_local + "," +
                    identifiant_local + "," +
                    surface_relle_bati + "," +
                    nombre_pieces_principales + "," +
                    nature_culture + "," +
                    nature_culture_speciale + "," +
                    surface_terrain + "," +
                    lat + "," +
                    lon);
        }
        
        public string code_service_ch {get; set;}
        public string reference_document {get; set;}
        public string articles_1 {get; set;}
        public string articles_2 {get; set;}
        public string articles_3 {get; set;}
        public string articles_4 {get; set;}
        public string articles_5 {get; set;}
        public string numero_disposition {get; set;}
        public string date_mutation {get; set;}
        public string nature_mutation {get; set;}
        public int valeur_fonciere {get; set;}
        public string numero_voie {get; set;}
        public string suffixe_numero {get; set;}
        public string type_voie {get; set;}
        public string code_voie {get; set;}
        public string voie {get; set;}
        public string code_postal {get; set;}
        public string commune {get; set;}
        public string code_departement {get; set;}
        public string code_commune {get; set;}
        public string prefixe_section {get; set;}
        public string section {get; set;}
        public string numero_plan {get; set;}
        public string numero_volume {get; set;}
        public string lot_1 {get; set;}
        public string surface_lot_1 {get; set;}
        public string lot_2 {get; set;}
        public string surface_lot_2 {get; set;}
        public string lot_3 {get; set;}
        public string surface_lot_3 {get; set;}
        public string lot_4 {get; set;}
        public string surface_lot_4 {get; set;}
        public string lot_5 {get; set;}
        public string surface_lot_51 {get; set;}
        public string nombre_lots {get; set;}
        public string code_type_local {get; set;}
        public string type_local {get; set;}
        public string identifiant_local {get; set;}
        public int surface_relle_bati {get; set;}
        public int nombre_pieces_principales {get; set;}
        public string nature_culture {get; set;}
        public string nature_culture_speciale {get; set;}
        public int surface_terrain {get; set;}
        public int lat {get; set;}
        public int lon {get; set;}
        public Geom geom {get; set;}
    }
}