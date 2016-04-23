using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Models;

namespace Hispital.Services.ServiceInterfaces
{
    public interface IPatientHistoryService
    {
        string GetHistory(long history_id);

        string GetHistoryByPatientId(long patient_id);

        string GetHistoryByHospitalId(long hospital_id);

        string GetHistoryByDoctorId(long doctor_id);

        string GetHistoryByDate(string date);
    }
}
