
using System.Collections.Generic;
using Hospital.Models;
using Hispital.Services.ServiceImplementations;
using Hispital.Services.ServiceInterfaces;


namespace RestService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HospitalService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select HospitalService.svc or HospitalService.svc.cs at the Solution Explorer and start debugging.
    public class HospitalService : IHospitalService
    {
        // Pateint Services
        public List<Patient> getPatient(string id)
        {
            PatientService patientService = new PatientService();
            return patientService.GetAllPatients(id);
        }

        public List<Patient> getUserByUsernameAndPassword(string username, string password)
        {
            throw new System.NotImplementedException();
        }

        public List<Patient> getUserByEGNAndPassword(string egn, string password)
        {
            throw new System.NotImplementedException();
        }


        public string AddNewPatient(string id, string gender, string username, string password, string first_name, string second_name, string last_name, string egn, string age, string birth_date)
        {
            throw new System.NotImplementedException();
        }


        // Hospital Services
        public List<HospitalModel> getHospital(string id)
        {
            ClinicService clinicService = new ClinicService();
            return clinicService.getHospital(id);
        }


        // Doctor Services
        public List<Doctor> getDoctor(string id)
        {
            DoctorService clinicService = new DoctorService();
            return clinicService.getDoctor(id);
        }

        public List<Doctor> getDoctorByHospitalId(string _hospital_id)
        {
            throw new System.NotImplementedException();
        }


        // Patient History Services
        public List<History> getHospitalRecord(string id)
        {
            PatientHistoryService patientHistoryService = new PatientHistoryService();
            return patientHistoryService.getHistory(id);
            
        }

        public List<History> getHospitalRecordByPatientID(string id)
        {
            PatientHistoryService patientHistoryService = new PatientHistoryService();
            return patientHistoryService.getHistoryByPatientId(id);
        }


        public List<History> getHospitalRecordByHospitalID(string hospital_id)
        {
            throw new System.NotImplementedException();
        }

        public List<History> getHospitalRecordByDoctorID(string doctor_id)
        {
            throw new System.NotImplementedException();
        }

        public List<History> getHospitalRecordByDate(string date)
        {
            throw new System.NotImplementedException();
        }

        public List<History> addNewHospitalRecord(string id, string patient_id, string hospital_id, string doctor_id, string reason, string diagnose, string date, string description)
        {
            throw new System.NotImplementedException();
        }



          // Allergy Services
        public List<Allergy> getAllAllergies()
        {
            IAllergyService service = new AllergyService();
            return service.getAllAllergies();
        }

        public string AddNewAllergy(string allergy_id)
        {
            throw new System.NotImplementedException();
        }



        // Visitation Services
        public List<ScheduledVisitation> GetVisitation(string id)
        {
            IScheduledVisitationService service = new ScheduledVisitationService();
            return service.GetVisitation(id);
        }

        public List<ScheduledVisitation> GetVisitationByPatientID(string id)
        {
            IScheduledVisitationService service = new ScheduledVisitationService();
            return service.GetVisitationByPatientID(id);
        }

        public List<ScheduledVisitation> GetVisitationByHospitalID(string hospital_id)
        {
            throw new System.NotImplementedException();
        }

        public List<ScheduledVisitation> GetVisitationByDoctorID(string doctor_id)
        {
            throw new System.NotImplementedException();
        }

        public List<ScheduledVisitation> GetVisitationByDate(string date)
        {
            throw new System.NotImplementedException();
        }

        public string AddNewVisitation(string id, string patient_id, string hospital_id, string doctor_id, string reason, string diagnose, string date, string description)
        {
            throw new System.NotImplementedException();
        }
    }
}
