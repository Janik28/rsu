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
    
    public partial class Status_Doc_Facility
    {
        public int Id { get; set; }
        public string Link_Doc { get; set; }
        public int Id_Mark_Facility { get; set; }
        public string Name { get; set; }
        public string FileType { get; set; }
        public Nullable<decimal> FileContent { get; set; }
    
        public virtual Mark_Facility Mark_Facility { get; set; }
    }
}
