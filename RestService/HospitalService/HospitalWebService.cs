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
    [ServiceContract]
    public interface HospitalWebService
    {

        // ------------------------------------ Patient Services
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "patient/{id}")]
        string GetPatient(long id);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "patient/{username}/password{password}")]
        string GetPatientByUsernameAndPassword(string username, string password);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "patient/egn/{egn}/password{password}")]
        string GetPatientByEGNAndPassword(string egn, string password);

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "patient/{id}/{gender}/{username}/{password}/{first_name}/{second_name}/{last_name}/{egn}/{age}/{birth_date}")]
        bool AddNewPatient(long id, string gender, string username, string password, string first_name, string second_name, string last_name, string egn, int age, string birth_date);




        // ------------------------------------- Hospital Services
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "hospital/{id}")]
        string GetHospital(long id);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "hospitals")]
        string GetAllHospitals();



        // ------------------------------------- Doctor Services
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "doctor/{id}")]
        string GetDoctor(long id);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "doctor/hospital/{hospital_id}")]
        string GetDoctorsByHospitalId(long hospital_id);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "doctors")]
        string GetAllDoctors();


        // ------------------------------------- Allergies Services
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "allergies")]
        string GetAllAllergies();


        // ------------------------------------- Patient History Services
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "record/{id}")]
        string GetHospitalRecord(long id);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "record/patient/{patient_id}")]
        string GetHospitalRecordByPatientID(long patient_id);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "record/hospital/{hospital_id}")]
        string GetHospitalRecordByHospitalID(long hospital_id);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "record/doctor/{doctor_id}")]
        string GetHospitalRecordByDoctorID(long doctor_id);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "record/date/{date}")]
        string GetHospitalRecordByDate(string date);


        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "record/{id}/{patient_id}/{hospital_id}/{doctor_id}/{reason}/{diagnose}/{date}/{description}")]
        string AddNewHospitalRecord(long id, long patient_id, long hospital_id, long doctor_id, string reason, string diagnose, string date, string description);




        // ------------------------------------- Scheduled visitation Services
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "visitation/{id}")]
        string GetVisitation(long id);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "visitation/patient/{patient_id}")]
        string GetVisitationByPatientID(long patient_id);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "visitation/hospital/{hospital_id}")]
        string GetVisitationByHospitalID(long hospital_id);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "visitation/doctor/{doctor_id}")]
        string GetVisitationByDoctorID(long doctor_id);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "visitation/date/{date}")]
        string GetVisitationByDate(string date);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "visitation/{id}/{patient_id}/{hospital_id}/{doctor_id}/{reason}/{diagnose}/{date}/{description}")]
        string AddNewVisitation(long id, long patient_id, long hospital_id, long doctor_id, string reason, string diagnose, string date, string description);
    }
}
