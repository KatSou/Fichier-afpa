//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BDD
{
    using System;
    using System.Collections.Generic;
    
    public partial class Livrer
    {
        public int bon_livraison_numero { get; set; }
        public string bon_livraison_nom { get; set; }
        public Nullable<int> quantite_livrer { get; set; }
        public int adresse_reference { get; set; }
        public int commande_numero { get; set; }
        public int produit_reference { get; set; }
    
        public virtual Adresse Adresse { get; set; }
        public virtual Commande Commande { get; set; }
        public virtual Produits Produits { get; set; }
    }
}
