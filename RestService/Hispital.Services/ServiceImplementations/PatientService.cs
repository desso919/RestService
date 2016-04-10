using Hispital.Services.ServiceInterfaces;
using Hospital.Databse;
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
        public List<Hospital.Models.Patient> GetAllPatients()
        {
            HospitalDatabaseEntities database = new HospitalDatabaseEntities();
            List<Hospital.Databse.Patient> DatabasePatients = new List<Hospital.Databse.Patient>();
            List<Hospital.Models.Patient> ModelPatients = new List<Hospital.Models.Patient>();
      
            var result = (from patient in database.Patients               
                          select patient).ToList();
            DatabasePatients = result;

            ModelPatients[0].Map(DatabasePatients[0]);
            return ModelPatients;
        }
    }
}
