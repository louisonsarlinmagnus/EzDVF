namespace EzDVF
{
    public class Transaction
    {
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
        public float? valeur_fonciere {get; set;}
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
        public float? surface_relle_bati {get; set;}
        public float? nombre_pieces_principales {get; set;}
        public string nature_culture {get; set;}
        public string nature_culture_speciale {get; set;}
        public float? surface_terrain {get; set;}
        public float? lat {get; set;}
        public float? lon {get; set;}
        public Geom geom {get; set;}
    }
}