using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Models
{
    public class ScheduledVisitation
    {
        public long VisitationId { get; set; }

        public long PatientId { get; set; }

        public long HospitalId { get; set; }

        public long DoctorId { get; set; }

        public string Reason { get; set; }

        public string Description { get; set; }

        public string Date { get; set; }

        public void Map(Hospital.Database.Scheduled_visitations other)
        {
            VisitationId = other.visitation_id;
            PatientId = other.patient_id;
            HospitalId = other.hospital_id;
            DoctorId = other.doctor_id;
            Reason = other.reson;
            Description = other.description;
            Date = other.plan_date.ToShortDateString();
        }
    }
}
