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
    
    public partial class tblProject
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblProject()
        {
            this.tblProjToProds = new HashSet<tblProjToProd>();
        }
    
        public int Project_ID { get; set; }
        public string Project_Name { get; set; }
        public int User_ID { get; set; }
        public string Project_Address1 { get; set; }
        public string Project_Address2 { get; set; }
        public int Project_City { get; set; }
        public int Project_State { get; set; }
        public int Project_Size { get; set; }
        public string Client_Name { get; set; }
    
        public virtual tblCity tblCity { get; set; }
        public virtual tblState tblState { get; set; }
        public virtual tblUser tblUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblProjToProd> tblProjToProds { get; set; }
    }
}
