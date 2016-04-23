using Hispital.Services.ServiceInterfaces;
using Hospital.Database;
using Hospital.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hispital.Services.ServiceImplementations
{
    public class DoctorService : IDoctorService
    {
        public string GetDoctor(long doctor_id)
        {
            HospitalDatabaseEntities database = new HospitalDatabaseEntities();

            var resultSet = database.Doctors.Where(doctor => doctor.doctor_id == doctor_id).ToList();

            Hospital.Models.Doctor findedDoctor = new Hospital.Models.Doctor();

            if (resultSet.Count == 1)
            {
                findedDoctor.Map(resultSet.FirstOrDefault());
                return JsonConvert.SerializeObject(findedDoctor);
            }

            return JsonConvert.SerializeObject(new { }); 
        }


        public string GetDoctorsByHospitalId(long hospital_id)
        {
            HospitalDatabaseEntities database = new HospitalDatabaseEntities();
            List<Hospital.Models.Doctor> doctors = new List<Hospital.Models.Doctor>();

            var resultSet = database.Doctors.Where(doctor => doctor.hospital_id == hospital_id).ToList();

            if (resultSet.Count > 0)
            {
                foreach (var doctor in resultSet)
                {
                    Hospital.Models.Doctor temp = new Hospital.Models.Doctor();
                    temp.Map(doctor);
                    doctors.Add(temp);
                }
                return JsonConvert.SerializeObject(doctors);
            }
            return JsonConvert.SerializeObject(new { });
        }

        public string GetAllDoctors()
        {
            HospitalDatabaseEntities database = new HospitalDatabaseEntities();
            List<Hospital.Models.Doctor> doctors = new List<Hospital.Models.Doctor>();

            var resultSet = database.Doctors.ToList();

            if (resultSet.Count > 0)
            {
                foreach (var doctor in resultSet)
                {
                    Hospital.Models.Doctor temp = new Hospital.Models.Doctor();
                    temp.Map(doctor);
                    doctors.Add(temp);
                }
                return JsonConvert.SerializeObject(doctors);
            }
            return JsonConvert.SerializeObject(new { });
        }
    }
}
