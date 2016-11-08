using ServerSide.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServerSide
{
    [ServiceContract]
    public interface ITimeManagerService
    {
        // Operate on Employee
        [OperationContract]
        [WebGet(UriTemplate = "/GetAllEmployees",
            ResponseFormat = WebMessageFormat.Json)]
        EmployeeContract[] GetAllEmployees ();

        [OperationContract]
        [WebInvoke(UriTemplate = "/PlaceEmployee",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json, Method = "POST")]

        bool PlaceEmployee(EmployeeContract employee);
        [OperationContract]
        [WebInvoke(UriTemplate = "/RemoveEmployee",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        bool RemoveEmployee(int employeeId);

        // Operate on Project
        [OperationContract]
        [WebGet(UriTemplate = "/GetAllProjects",
            ResponseFormat = WebMessageFormat.Json)]
        ProjectContract[] GetAllProjects();

        [OperationContract]
        [WebInvoke(UriTemplate = "/PlaceProject",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json, Method = "POST")]

        bool PlaceProject(ProjectContract employee);

        [OperationContract]
        [WebInvoke(UriTemplate = "/RemoveProject",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        bool RemoveProject(int employeeId);
        // Obtain of time
        [OperationContract]
        [WebInvoke(UriTemplate = "/ObtainTime",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json, Method = "POST")]

        bool ObtainTime(ObtainTimeContract obtainTime);
        // GetReport
        [OperationContract]
        [WebGet(UriTemplate = "/GetReport",
            ResponseFormat = WebMessageFormat.Json)]
        string[] GetReport();
    }
}
