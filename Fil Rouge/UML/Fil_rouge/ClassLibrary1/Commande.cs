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
    
    public partial class Commande
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Commande()
        {
            this.Livrer = new HashSet<Livrer>();
            this.Sont_present = new HashSet<Sont_present>();
        }
    
        public int commande_numero { get; set; }
        public string commande_etat { get; set; }
        public string facture { get; set; }
        public Nullable<System.DateTime> date_facturation { get; set; }
        public Nullable<System.DateTime> commande_date { get; set; }
        public Nullable<int> client_reference { get; set; }
        public Nullable<int> code_reduction { get; set; }
        public Nullable<int> commercial_matricule { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Commercial Commercial { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Livrer> Livrer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sont_present> Sont_present { get; set; }
    }
}
