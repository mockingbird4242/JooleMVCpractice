//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JooleDAL.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblSubcategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblSubcategory()
        {
            this.tblProducts = new HashSet<tblProduct>();
            this.tblTechSpecFilters = new HashSet<tblTechSpecFilter>();
            this.tblTypeFilters = new HashSet<tblTypeFilter>();
        }
    
        public int Subcategory_ID { get; set; }
        public int Category_ID { get; set; }
        public string Subcategory_Name { get; set; }
    
        public virtual tblCategory tblCategory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProduct> tblProducts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTechSpecFilter> tblTechSpecFilters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTypeFilter> tblTypeFilters { get; set; }
    }
}
