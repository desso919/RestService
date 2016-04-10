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
    public class ClinicService : IClinicService
    {
        public List<HospitalModel> getHospital(string hospital_id)
        {
            HospitalDatabaseEntities database = new HospitalDatabaseEntities();
            List<HospitalModel> hospitals = new List<HospitalModel>();

            long requested_hospital_id = Convert.ToInt64(hospital_id);
            var result = database.Hospitals.Where(hospital => hospital.hospital_id == requested_hospital_id).ToList();

            Hospital.Models.HospitalModel hos = new Hospital.Models.HospitalModel();
            if( result.Count > 0) 
            {
                hos.Map(result.FirstOrDefault());
                hospitals.Add(hos);
            }          
            return hospitals;
        }
    }
}
