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
    
    public partial class Fournit
    {
        public Nullable<int> quantite_produit_fournit { get; set; }
        public int produit_reference { get; set; }
        public int fournisseur_reference { get; set; }
    
        public virtual Fournisseur Fournisseur { get; set; }
        public virtual Produits Produits { get; set; }
    }
}
