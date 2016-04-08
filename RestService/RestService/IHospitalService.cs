using System.ServiceModel;
using System.ServiceModel.Web;

namespace RestService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IHospitalService" in both code and config file together.
    [ServiceContract]
    public interface IHospitalService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "patient/{id}")]
        string getPatient(string id);

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "hospital/{id}")]
        string getHospital(string id);

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "doctor/{id}")]
        string getDoctor(string id);

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "username/{patient_username}")]
        string getPatientByUsername(string patient_username);

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "logon/{patient_username}/password/{password}")]
        string logonPatient(string patient_username, string password);


        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "record/{patient_id}")]
        string getHospitalRecord(string patient_id);
    }
}
