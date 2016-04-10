using System.ServiceModel;
using System.ServiceModel.Web;
using System.Collections.Generic;
using Hospital.Models;

namespace RestService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IHospitalService" in both code and config file together.
    [ServiceContract]
    public interface IHospitalService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate= "patient/{id}")]
        List<Patient> getPatient(string id);

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "hospital/{id}")]
        List<HospitalModel> getHospital(string id);

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "doctor/{id}")]
        List<Doctor> getDoctor(string id);

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "username/{patient_username}")]
        string getPatientByUsername(string patient_username);

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "logonPatient/{patient_username}")]
        string logonPatient(string patient_username);

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "record/{patient_id}")]
        string getHospitalRecord(string patient_id);
    }
}
