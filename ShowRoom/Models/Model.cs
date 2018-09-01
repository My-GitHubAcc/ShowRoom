//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShowRoom.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Model
    {
        public int Id { get; set; }
        public string Model_ { get; set; }
        public Nullable<int> Marque { get; set; }
        public Nullable<int> TypeVoiture { get; set; }
        public string Annee { get; set; }
        public Nullable<int> Puissance { get; set; }
        public Nullable<float> Reservoir { get; set; }
        public Nullable<int> BoiteVitesse { get; set; }
        public Nullable<float> FreinageUrgence { get; set; }
        public Nullable<float> VitesseMax { get; set; }
        public Nullable<float> Poix { get; set; }
        public Nullable<float> Prix { get; set; }
        public Nullable<int> Autonomie { get; set; }
        public Nullable<float> Cons_Ville { get; set; }
        public Nullable<float> Cons_Route { get; set; }
        public Nullable<float> Cons_Autoroute { get; set; }
        public Nullable<int> CC { get; set; }
        public Nullable<int> Carburant { get; set; }
        public Nullable<int> Transmission { get; set; }
        public Nullable<int> PayFabrication { get; set; }
        public string Boite_Auto { get; set; }
        public string Manuelle_robotisee { get; set; }
        public string Airbags_rideaux { get; set; }
        public string ESP { get; set; }
        public string Capteurs_Pluie { get; set; }
        public string Luminosite { get; set; }
        public string Radars_parking_avant { get; set; }
        public string Radars_parking_Arriere { get; set; }
        public string Jantes_Alliage { get; set; }
        public string Peinture_Metallisee { get; set; }
        public string Système_de_navigation { get; set; }
        public string Ecran_Tactile { get; set; }
        public string Climatisation_Manuelle { get; set; }
        public string Climatisation_Automatique { get; set; }
        public string Radio_CD { get; set; }
        public string Prise_USB { get; set; }
        public string Sellerie_cuir { get; set; }
        public string Selerie_Cuir_Integral { get; set; }
        public string Sièges_Chauffants { get; set; }
        public string Banquette_AR_fraction { get; set; }
        public string Banquette_AR_coulissante { get; set; }
        public string Rétros_electriques { get; set; }
        public string Clé_mains_libres { get; set; }
        public string Toit_ouvrant_electrique { get; set; }
        public string Vitre_fixe { get; set; }
        public string Vitres_electriques_Avant { get; set; }
        public string Vitres_electriques_Arriere { get; set; }
        public string ABS { get; set; }
    
        public virtual Carburant IdCarburant { get; set; }
        public virtual Marque IdMarque { get; set; }
        public virtual Pays Pays { get; set; }
        public virtual Transmission IdTransmission { get; set; }
        public virtual TypeVoiture IdTypeVoiture { get; set; }
    }
}
