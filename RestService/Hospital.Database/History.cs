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
    
    public partial class History
    {
        public long history_id { get; set; }
        public long patient_id { get; set; }
        public long hospital_id { get; set; }
        public long doctor_id { get; set; }
        public string reson { get; set; }
        public string dignose { get; set; }
        public System.DateTime date { get; set; }
        public string description { get; set; }
    
        public virtual Doctor Doctor { get; set; }
        public virtual Hospital Hospital { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
