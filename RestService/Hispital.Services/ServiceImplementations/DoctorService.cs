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
    public class DoctorService : IDoctorService
    {
        public List<Hospital.Models.Doctor> getDoctor(string doctor_id)
        {
            HospitalDatabaseEntities database = new HospitalDatabaseEntities();
            List<Hospital.Models.Doctor> doctors = new List<Hospital.Models.Doctor>();

            long requested_doctor_id = Convert.ToInt64(doctor_id);
            var result = database.Doctors.Where(doctor => doctor.hospital_id == requested_doctor_id).ToList();

            Hospital.Models.Doctor requested_doctor = new Hospital.Models.Doctor();
            if (result.Count > 0)
            {
                requested_doctor.Map(result.FirstOrDefault());
                doctors.Add(requested_doctor);
            }
            return doctors;
        }
    }
}
