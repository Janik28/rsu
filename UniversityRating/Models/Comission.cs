//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UniversityRating.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comission
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Comission()
        {
            this.MarkTeachersChecks = new HashSet<MarkTeachersCheck>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> Id_Position { get; set; }
        public int Id_User { get; set; }
    
        public virtual Position_Teachers Position_Teachers { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MarkTeachersCheck> MarkTeachersChecks { get; set; }
    }
}