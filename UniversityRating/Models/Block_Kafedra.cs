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
    
    public partial class Block_Kafedra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Block_Kafedra()
        {
            this.Category_Kafedra = new HashSet<Category_Kafedra>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string CodeName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Category_Kafedra> Category_Kafedra { get; set; }
    }
}
