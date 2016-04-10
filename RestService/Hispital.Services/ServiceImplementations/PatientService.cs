using Hispital.Services.ServiceInterfaces;
using Hospital.Database;
using Hospital.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hispital.Services.ServiceImplementations
{
    public class PatientService : IPatientService
    {
        public List<Hospital.Models.Patient> GetAllPatients(string id)
        {
            HospitalDatabaseEntities database = new HospitalDatabaseEntities();
            List<Hospital.Database.Patient> DatabasePatients = new List<Hospital.Database.Patient>();
            List<Hospital.Models.Patient> ModelPatients = new List<Hospital.Models.Patient>();

            long patient_id = Convert.ToInt64(id);
            var result = database.Patients.Where(p => p.patient_id == patient_id).ToList();
            DatabasePatients = result;

            Hospital.Models.Patient pat = new Hospital.Models.Patient();
            pat.Map(DatabasePatients.FirstOrDefault()); 

            ModelPatients.Add(pat);
            return ModelPatients;
        }
    }
}
