//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hospital.Databse
{
    using System;
    using System.Collections.Generic;
    
    public partial class Allergy
    {
        public Allergy()
        {
            this.Patients = new HashSet<Patient>();
        }
    
        public long allergy_id { get; set; }
        public string allergy1 { get; set; }
    
        public virtual ICollection<Patient> Patients { get; set; }
    }
}
