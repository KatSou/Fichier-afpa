//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Adresse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Adresse()
        {
            this.Livrer = new HashSet<Livrer>();
        }
    
        public int adresse_reference { get; set; }
        public string client_adresse { get; set; }
        public string client_code_postal { get; set; }
        public string clien_ville { get; set; }
        public string client_facturation_adresse { get; set; }
        public string client_facturation_code_postal { get; set; }
        public string client_facturation_ville { get; set; }
        public string client_livraison_adresse { get; set; }
        public string client_livraison_code_postal { get; set; }
        public string client_livraison_ville { get; set; }
        public Nullable<int> client_reference { get; set; }
    
        public virtual Client Client { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Livrer> Livrer { get; set; }
    }
}
