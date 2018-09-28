//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShowRoom.Data.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Model
    {
        public int ModelId { get; set; }
        public string Name { get; set; }
        public string Annee { get; set; }
        public int Puissance { get; set; }
        public int Reservoir { get; set; }
        public int BoiteVitesse { get; set; }
        public int FreinageUrgence { get; set; }
        public float VitesseMax { get; set; }
        public float Poix { get; set; }
        public float Prix { get; set; }
        public int Autonomie { get; set; }
        public float Cons_Ville { get; set; }
        public float Cons_Route { get; set; }
        public float Cons_Autoroute { get; set; }
        public int CC { get; set; }
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

        public int CarburantId { get; set; }
        public int TransmissionID { get; set; }
        public int PayFabrication { get; set; }
        public int MarqueId { get; set; }
        public int TypeVoitureId { get; set; }

        public virtual Carburant Carburant { get; set; }
        public virtual Marque Marque { get; set; }
        public virtual Pays Pays { get; set; }
        public virtual Transmission Transmission { get; set; }
        public virtual TypeVoiture TypeVoiture { get; set; }
    }
}