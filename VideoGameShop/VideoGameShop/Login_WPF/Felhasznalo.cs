//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Login_WPF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Felhasznalo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Felhasznalo()
        {
            this.Rendeles = new HashSet<Rendele>();
        }
    
        public int Felhasznaloid { get; set; }
        public string Felhasznalonev { get; set; }
        public string Jelszo { get; set; }
        public int Jogosultsag_Jogosultsagid { get; set; }
    
        public virtual Jogosultsag Jogosultsag { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rendele> Rendeles { get; set; }
    }
}
