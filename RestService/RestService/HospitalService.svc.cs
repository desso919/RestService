using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RestService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HospitalService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select HospitalService.svc or HospitalService.svc.cs at the Solution Explorer and start debugging.
    public class HospitalService : IHospitalService
    {
        public string getPatient(string id)
        {
            return "Patient id is: " + id;
        }

        public string getHospital(string id)
        {
            return "Hospital id is: " + id;
        }

        public string getDoctor(string id)
        {
            return "Doctor id is: " + id;
        }

       public string getPatientByUsername(string patient_username)
        {
            return "Patient Username is: " + patient_username;
        }

        public string logonPatient(string patient_username, string password)
        {
            return "Username is: " + patient_username + " and password is" + password;
        }

        public string getHospitalRecord(string patient_id)
        {
            return "Hospital record for patient: " + patient_id;
        }
    }
}
