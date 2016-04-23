using Hispital.Services.ServiceInterfaces;
using Hospital.Database;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hispital.Services.ServiceImplementations
{
    public class ScheduledVisitationService : IScheduledVisitationService
    {
        public string GetVisitation(long id)
        {
            HospitalDatabaseEntities database = new HospitalDatabaseEntities();

            var resultSet = database.Scheduled_visitations.Where(visitation => visitation.visitation_id == id).ToList();

            Hospital.Models.ScheduledVisitation findedVisitation = new Hospital.Models.ScheduledVisitation();
            if (resultSet.Count > 0)
            {
                findedVisitation.Map(resultSet.FirstOrDefault());
                return JsonConvert.SerializeObject(findedVisitation);
            }
            return JsonConvert.SerializeObject(new { });
        }

        public string GetVisitationByPatientID(long patient_id)
        {
            HospitalDatabaseEntities database = new HospitalDatabaseEntities();
            var resultSet = database.Scheduled_visitations.Where(visitation => visitation.patient_id == patient_id).ToList();
            Hospital.Models.ScheduledVisitation findedVisitation = new Hospital.Models.ScheduledVisitation();
            if (resultSet.Count > 0)
            {
                findedVisitation.Map(resultSet.FirstOrDefault());
                return JsonConvert.SerializeObject(findedVisitation);
            }
            return JsonConvert.SerializeObject(new { });
        }

        public string GetVisitationByHospitalID(long hospital_id)
        {
            HospitalDatabaseEntities database = new HospitalDatabaseEntities();
            var resultSet = database.Scheduled_visitations.Where(visitation => visitation.hospital_id == hospital_id).ToList();
            Hospital.Models.ScheduledVisitation findedVisitation = new Hospital.Models.ScheduledVisitation();
            if (resultSet.Count > 0)
            {
                findedVisitation.Map(resultSet.FirstOrDefault());
                return JsonConvert.SerializeObject(findedVisitation);
            }
            return JsonConvert.SerializeObject(new { });
        }

        public string GetVisitationByDoctorID(long doctor_id)
        {
            HospitalDatabaseEntities database = new HospitalDatabaseEntities();
            var resultSet = database.Scheduled_visitations.Where(visitation => visitation.doctor_id == doctor_id).ToList();
            Hospital.Models.ScheduledVisitation findedVisitation = new Hospital.Models.ScheduledVisitation();
            if (resultSet.Count > 0)
            {
                findedVisitation.Map(resultSet.FirstOrDefault());
                return JsonConvert.SerializeObject(findedVisitation);
            }
            return JsonConvert.SerializeObject(new { });
        }

        public string GetVisitationByDate(string date)
        {
            HospitalDatabaseEntities database = new HospitalDatabaseEntities();

            var ResultSet = database.Scheduled_visitations.Where(history => history.plan_date.ToShortDateString().Equals(date)).ToList();

            Hospital.Models.ScheduledVisitation requestedVisitation = new Hospital.Models.ScheduledVisitation();
            if (ResultSet.Count == 1)
            {
                requestedVisitation.Map(ResultSet.FirstOrDefault());
                return JsonConvert.SerializeObject(requestedVisitation);
            }

            return JsonConvert.SerializeObject(new { });
        }

        public bool AddNewVisitation(long id, long patient_id, long hospital_id, long doctor_id, string reason, string diagnose, string date, string description)
        {
            throw new NotImplementedException();
        }
    }
}
