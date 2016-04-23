using Hispital.Services.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Models;
using Hospital.Database;
using Newtonsoft.Json;

namespace Hispital.Services.ServiceImplementations
{
    public class PatientHistoryService : IPatientHistoryService
    {
        public string GetHistory(long history_id)
        {
            HospitalDatabaseEntities database = new HospitalDatabaseEntities();

            var ResultSet = database.Histories.Where(history => history.history_id == history_id).ToList();

            Hospital.Models.History requestedHistory = new Hospital.Models.History();
            if (ResultSet.Count == 1)
            {
                requestedHistory.Map(ResultSet.FirstOrDefault());
                return JsonConvert.SerializeObject(requestedHistory); 
            }

            return JsonConvert.SerializeObject(new { });
        }


        public string GetHistoryByPatientId(long patient_id)
        {
            HospitalDatabaseEntities database = new HospitalDatabaseEntities();

            var ResultSet = database.Histories.Where(history => history.patient_id == patient_id).ToList();

            Hospital.Models.History requestedHistory = new Hospital.Models.History();
            if (ResultSet.Count == 1)
            {
                requestedHistory.Map(ResultSet.FirstOrDefault());
                return JsonConvert.SerializeObject(requestedHistory);
            }

            return JsonConvert.SerializeObject(new { });
        }

        public string GetHistoryByHospitalId(long hospital_id)
        {
            HospitalDatabaseEntities database = new HospitalDatabaseEntities();
            List<Hospital.Models.History> histories = new List<Hospital.Models.History>();
            var resultSet = database.Histories.Where(history => history.hospital_id == hospital_id).ToList();

            if (resultSet.Count > 0)
            {
                foreach (var history in resultSet)
                {
                    Hospital.Models.History temp = new Hospital.Models.History();
                    temp.Map(history);
                    histories.Add(temp);
                }
                return JsonConvert.SerializeObject(histories);
            }
            return JsonConvert.SerializeObject(new { });
            
        }

        public string GetHistoryByDoctorId(long doctor_id)
        {
            HospitalDatabaseEntities database = new HospitalDatabaseEntities();
            List<Hospital.Models.History> histories = new List<Hospital.Models.History>();
            var resultSet = database.Histories.Where(history => history.doctor_id == doctor_id).ToList();

            if (resultSet.Count > 0)
            {
                foreach (var history in resultSet)
                {
                    Hospital.Models.History temp = new Hospital.Models.History();
                    temp.Map(history);
                    histories.Add(temp);
                }
                return JsonConvert.SerializeObject(histories);
            }
            return JsonConvert.SerializeObject(new { });
        }

        public string GetHistoryByDate(string date)
        {
            HospitalDatabaseEntities database = new HospitalDatabaseEntities();

            var ResultSet = database.Histories.Where(history => history.date.ToShortDateString().Equals(date)).ToList();

            Hospital.Models.History requestedHistory = new Hospital.Models.History();
            if (ResultSet.Count == 1)
            {
                requestedHistory.Map(ResultSet.FirstOrDefault());
                return JsonConvert.SerializeObject(requestedHistory);
            }

            return JsonConvert.SerializeObject(new { });
        }
    }
}
