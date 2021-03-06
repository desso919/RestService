﻿using System.ServiceModel;
using System.ServiceModel.Web;
using System.Collections.Generic;
using Hospital.Models;

namespace RestService
{
    [ServiceContract]
    public interface IHospitalService
    {

        // ------------------------------------ Patient Services
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "patient/{id}")]
        List<Patient> getPatient(string id);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "patient/{username}/password{password}")]
        List<Patient> getUserByUsernameAndPassword(string username, string password);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "patient/egn/{egn}/password{password}")]
        List<Patient> getUserByEGNAndPassword(string egn, string password);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "patient/{id}/{gender}/{username}/{password}/{first_name}/{second_name}/{last_name}/{egn}/{age}/{birth_date}")]
        string AddNewPatient(string id, string gender, string username, string password, string first_name, string second_name, string last_name, string egn, string age, string birth_date);



        // ------------------------------------- Hospital Services
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "hospital/{id}")]
        List<HospitalModel> getHospital(string id);



        // ------------------------------------- Doctor Services
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "doctor/{id}")]
        List<Doctor> getDoctor(string id);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "doctor/hospital/{hospital_id}")]
        List<Doctor> getDoctorByHospitalId(string hospital_id);



        // ------------------------------------- Allergies Services
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "allergies")]
        List<Allergy> getAllAllergies();


        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "allergies/{allergy_id}")]
        string AddNewAllergy(string allergy_id);



        // ------------------------------------- Patient History Services
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "record/{id}")]
        List<History> getHospitalRecord(string id);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "record/patient/{patient_id}")]
        List<History> getHospitalRecordByPatientID(string patient_id);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "record/hospital/{hospital_id}")]
        List<History> getHospitalRecordByHospitalID(string hospital_id);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "record/doctor/{doctor_id}")]
        List<History> getHospitalRecordByDoctorID(string doctor_id);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "record/date/{date}")]
        List<History> getHospitalRecordByDate(string date);


        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "record/{id}/{patient_id}/{hospital_id}/{doctor_id}/{reason}/{diagnose}/{date}/{description}")]
        List<History> addNewHospitalRecord(string id, string patient_id, string hospital_id, string doctor_id, string reason, string diagnose, string date, string description);




        // ------------------------------------- Scheduled visitation Services
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "visitation/{id}")]
        List<ScheduledVisitation> GetVisitation(string id);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "visitation/patient/{patient_id}")]
        List<ScheduledVisitation> GetVisitationByPatientID(string patient_id);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "visitation/hospital/{hospital_id}")]
        List<ScheduledVisitation> GetVisitationByHospitalID(string hospital_id);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "visitation/doctor/{doctor_id}")]
        List<ScheduledVisitation> GetVisitationByDoctorID(string doctor_id);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "visitation/date/{date}")]
        List<ScheduledVisitation> GetVisitationByDate(string date);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "visitation/{id}/{patient_id}/{hospital_id}/{doctor_id}/{reason}/{diagnose}/{date}/{description}")]
        string AddNewVisitation(string id, string patient_id, string hospital_id, string doctor_id, string reason, string diagnose, string date, string description);


    }
}
