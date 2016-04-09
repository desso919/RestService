using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestService
{
    public class ViewModel
    {
        PatientEntities conn = new PatientEntities();

        private List<Patient> patient = new List<Patient>();
        public List<Patient> Patients
        {
            get { return patient;  }
            set { patient = value; }
        }

        public void getPatientFromDB()
        {
            var result = (from patient in conn.Patients
                          where patient.username.Contains("desso")
                          select patient).ToList();
            this.Patients = result;
        }
    }
}