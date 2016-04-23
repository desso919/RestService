using Hispital.Services.ServiceInterfaces;
using Hospital.Database;
using Newtonsoft.Json;
using System.Linq;

namespace Hispital.Services.ServiceImplementations
{
    public class PatientService : IPatientService
    {
        public string GetPatient(long patient_id)
        {
            HospitalDatabaseEntities database = new HospitalDatabaseEntities();         

            var resultSet = database.Patients.Where(patient => patient.patient_id == patient_id).ToList();

            Hospital.Models.Patient returnedPatient = new Hospital.Models.Patient();
            if (resultSet.Count == 1)
            {
                returnedPatient.Map(resultSet.FirstOrDefault());
                return JsonConvert.SerializeObject(returnedPatient);
            }

            return JsonConvert.SerializeObject(new { });
        }


        public string GetPatientByUsernameAndPassword(string username, string password)
        {
            HospitalDatabaseEntities database = new HospitalDatabaseEntities();

            var resultSet = database.Patients.Where(patient => patient.username.Equals(username) && patient.password.Equals(password)).ToList();

            Hospital.Models.Patient returnedPatient = new Hospital.Models.Patient();
            if (resultSet.Count == 1)
            {
                returnedPatient.Map(resultSet.FirstOrDefault());
                return JsonConvert.SerializeObject(returnedPatient);
            }

            return JsonConvert.SerializeObject(new { });
        }

        public string GetPatientByEGNAndPassword(string egn, string password)
        {
            HospitalDatabaseEntities database = new HospitalDatabaseEntities();

            var resultSet = database.Patients.Where(patient => patient.username.Equals(egn) && patient.password.Equals(password)).ToList();

            Hospital.Models.Patient returnedPatient = new Hospital.Models.Patient();
            if (resultSet.Count == 1)
            {
                returnedPatient.Map(resultSet.FirstOrDefault());
                return JsonConvert.SerializeObject(returnedPatient);
            }

            return JsonConvert.SerializeObject(new { });
        }
    }
}
