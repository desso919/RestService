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
    public class ClinicService : IClinicService
    {
        public string GetHospital(long hospital_id)
        {
            HospitalDatabaseEntities database = new HospitalDatabaseEntities();

            var resultSet = database.Hospitals.Where(hospital => hospital.hospital_id == hospital_id).ToList();

            Hospital.Models.HospitalModel findedHospital = new Hospital.Models.HospitalModel();
            if (resultSet.Count == 1) 
            {
                findedHospital.Map(resultSet.FirstOrDefault());
                return JsonConvert.SerializeObject(findedHospital);
            }

            return JsonConvert.SerializeObject(new { }); ;
        }


        public string GetAllHospitals()
        {
            HospitalDatabaseEntities database = new HospitalDatabaseEntities();
            List<Hospital.Models.HospitalModel> hospitals = new List<Hospital.Models.HospitalModel>();

            var resultSet = database.Hospitals.ToList();

            if (resultSet.Count > 0)
            {
                foreach (var hospital in resultSet)
                {
                    Hospital.Models.HospitalModel tempHospital = new Hospital.Models.HospitalModel();
                    tempHospital.Map(hospital);
                    hospitals.Add(tempHospital);
                }
                return JsonConvert.SerializeObject(hospitals);
            }
            return JsonConvert.SerializeObject(new { });
        }
    }
}
