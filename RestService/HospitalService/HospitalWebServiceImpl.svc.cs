using Hispital.Services.ServiceImplementations;
using Hispital.Services.ServiceInterfaces;
using Hospital.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HospitalService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HospitalWebServiceImpl" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select HospitalWebServiceImpl.svc or HospitalWebServiceImpl.svc.cs at the Solution Explorer and start debugging.
    public class HospitalWebServiceImpl : HospitalWebService
    {
        //---------------------------------------- Pateint Services
        public string GetPatient(long id)
        {
            IPatientService patientService = new PatientService();
            return patientService.GetPatient(id);
        }

        public string GetPatientByUsernameAndPassword(string username, string password)
        {
            IPatientService patientService = new PatientService();
            return patientService.GetPatientByUsernameAndPassword(username, password);
        }

        public string GetPatientByEGNAndPassword(string egn, string password)
        {
            throw new System.NotImplementedException();
        }


        public string AddNewPatient(long id, string gender, string username, string password, string first_name, string second_name, string last_name, string egn, int age, string birth_date)
        {
            throw new System.NotImplementedException();
        }


        //-------------------------------- Hospital Services
        public string GetHospital(long id)
        {
            IClinicService clinicService = new ClinicService();
            return clinicService.GetHospital(id);
        }

        public string GetAllHospitals()
        {
            IClinicService clinicService = new ClinicService();
            return clinicService.GetAllHospitals();
        }


        // -------------------------------- Doctor Services
        public string GetDoctor(long id)
        {
            IDoctorService clinicService = new DoctorService();
            return clinicService.GetDoctor(id);
        }

        public string GetDoctorsByHospitalId(long hospital_id)
        {
            IDoctorService clinicService = new DoctorService();
            return clinicService.GetDoctorsByHospitalId(hospital_id);
        }

        public string GetAllDoctors()
        {
            IDoctorService clinicService = new DoctorService();
            return clinicService.GetAllDoctors();
        }

        // -------------------------------- Patient History Services
        public string GetHospitalRecord(long id)
        {
            IPatientHistoryService patientHistoryService = new PatientHistoryService();
            return patientHistoryService.GetHistory(id);

        }

        public string GetHospitalRecordByPatientID(long id)
        {
            IPatientHistoryService patientHistoryService = new PatientHistoryService();
            return patientHistoryService.GetHistoryByPatientId(id);
        }

        public string GetHospitalRecordByHospitalID(long hospital_id)
        {
            IPatientHistoryService patientHistoryService = new PatientHistoryService();
            return patientHistoryService.GetHistoryByHospitalId(hospital_id);
        }

        public string GetHospitalRecordByDoctorID(long doctor_id)
        {
            IPatientHistoryService patientHistoryService = new PatientHistoryService();
            return patientHistoryService.GetHistoryByDoctorId(doctor_id);
        }

        public string GetHospitalRecordByDate(string date)
        {
            IPatientHistoryService patientHistoryService = new PatientHistoryService();
            return patientHistoryService.GetHistoryByDate(date);
        }

        public string AddNewHospitalRecord(long id, long patient_id, long hospital_id, long doctor_id, string reason, string diagnose, string date, string description)
        {
            throw new NotImplementedException();
        }


        // -------------------------------  Allergy Services
        public string GetAllAllergies()
        {
            IAllergyService service = new AllergyService();
            return service.getAllAllergies();
        }


        // ---------------------------------- Visitation Services
        public string GetVisitation(long id)
        {
            IScheduledVisitationService service = new ScheduledVisitationService();
            return service.GetVisitation(id);
        }

        public string GetVisitationByPatientID(long id)
        {
            IScheduledVisitationService service = new ScheduledVisitationService();
            return service.GetVisitationByPatientID(id);
        }

        public string GetVisitationByHospitalID(long hospital_id)
        {
            IScheduledVisitationService service = new ScheduledVisitationService();
            return service.GetVisitationByHospitalID(hospital_id);
        }

        public string GetVisitationByDoctorID(long doctor_id)
        {
            IScheduledVisitationService service = new ScheduledVisitationService();
            return service.GetVisitationByDoctorID(doctor_id);
        }

        public string GetVisitationByDate(string date)
        {
            IScheduledVisitationService service = new ScheduledVisitationService();
            return service.GetVisitationByDate(date);
        }

        public string AddNewVisitation(long id, long patient_id, long hospital_id, long doctor_id, string reason, string diagnose, string date, string description)
        {
            throw new NotImplementedException();
        }


        bool HospitalWebService.AddNewPatient(long id, string gender, string username, string password, string first_name, string second_name, string last_name, string egn, int age, string birth_date)
        {
            throw new NotImplementedException();
        }
    }
}
