using Hospital.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hispital.Services.ServiceInterfaces
{
    public interface IScheduledVisitationService
    {
        string GetVisitation(long id);

        string GetVisitationByPatientID(long patient_id);

        string GetVisitationByHospitalID(long hospital_id);

        string GetVisitationByDoctorID(long doctor_id);

        string GetVisitationByDate(string date);

        Boolean AddNewVisitation(long id, long patient_id, long hospital_id, long doctor_id, string reason, string diagnose, string date, string description);

    }
}
