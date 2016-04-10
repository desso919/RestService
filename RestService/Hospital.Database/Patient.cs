//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hospital.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Patient
    {
        public Patient()
        {
            this.Histories = new HashSet<History>();
            this.Scheduled_visitations = new HashSet<Scheduled_visitations>();
        }
    
        public long patient_id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string first_name { get; set; }
        public string second_name { get; set; }
        public string last_name { get; set; }
        public int age { get; set; }
        public Nullable<System.DateTime> birth_date { get; set; }
        public long gender_id { get; set; }
        public Nullable<long> allergy_id { get; set; }
    
        public virtual Allergy Allergy { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual ICollection<History> Histories { get; set; }
        public virtual ICollection<Scheduled_visitations> Scheduled_visitations { get; set; }
    }
}
