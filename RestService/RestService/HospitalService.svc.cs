
using System.Collections.Generic;
using Hospital.Models;
using Hispital.Services.ServiceImplementations;


namespace RestService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HospitalService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select HospitalService.svc or HospitalService.svc.cs at the Solution Explorer and start debugging.
    public class HospitalService : IHospitalService
    {
        public List<Patient> getPatient(string id)
        {
            PatientService patientService = new PatientService();
            return patientService.GetAllPatients(id);
        }

        public List<HospitalModel> getHospital(string id)
        {
            ClinicService clinicService = new ClinicService();
            return clinicService.getHospital(id);
        }

        public List<Doctor> getDoctor(string id)
        {
            DoctorService clinicService = new DoctorService();
            return clinicService.getDoctor(id);
        }

       public string getPatientByUsername(string patient_username)
        {
            return "Patient Username is: " + patient_username;
        }

        public string logonPatient(string patient_username)
        {
            return "Loggon user is: " + patient_username;
        }

        public string getHospitalRecord(string patient_id)
        {
            return "Hospital record for patient: " + patient_id;
        }
    }
}
