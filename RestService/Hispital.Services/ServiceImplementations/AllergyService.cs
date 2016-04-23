using Hispital.Services.ServiceInterfaces;
using Hospital.Database;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hispital.Services.ServiceImplementations
{
    public class AllergyService : IAllergyService
    {
        public string getAllAllergies()
        {
            HospitalDatabaseEntities database = new HospitalDatabaseEntities();
            List<Hospital.Models.Allergy> allergies = new List<Hospital.Models.Allergy>();

            var resultSet = database.Allergies.Select(allergy => allergy).ToList();

            if (resultSet.Count > 0)
            {
                foreach (var history in resultSet)
                {
                    Hospital.Models.Allergy allergy = new Hospital.Models.Allergy();
                    allergy.Map(history);
                    allergies.Add(allergy);
                }
                return JsonConvert.SerializeObject(allergies);
            }
            return JsonConvert.SerializeObject(new { });
        }

        public bool AddNewAllergy(string allergy)
        {
            HospitalDatabaseEntities database = new HospitalDatabaseEntities();
            //Allergy newAllergy = new Allergy(allergy);
           // var resultSet = database.Allergies.Add(newAllergy);
            return true;
        }
    }
}
