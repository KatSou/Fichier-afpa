//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Classe
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sont_present
    {
        public Nullable<int> quantite_acheter { get; set; }
        public int produit_reference { get; set; }
        public int commande_numero { get; set; }
    
        public virtual Commande Commande { get; set; }
        public virtual Produits Produits { get; set; }
    }
}
