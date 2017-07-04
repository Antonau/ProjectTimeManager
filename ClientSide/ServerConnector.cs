using ClientSide.DataContracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace ClientSide
{
    class ServerConnector
    {
        private static string serverUri = "http://localhost:54116/TimeManagerService.svc/";
        // Operate on Employees
        public static EmployeeContract[] GetAllEmployees()
        {
			//Very important operation
            WebClient proxy = new WebClient();
            string serviceURL = string.Format(serverUri+"GetAllEmployees");
            byte[] data = proxy.DownloadData(serviceURL);
            Stream stream = new MemoryStream(data);
            DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(EmployeeContract[]));
            EmployeeContract[] employees = obj.ReadObject(stream) as EmployeeContract[];
            return employees;
        }

        public static bool PlaceEmployee(string firstName, string lastName)
        {
			//the second 321 important comment
            EmployeeContract employee = new EmployeeContract { FirstName = firstName, LastName = lastName };

            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(EmployeeContract));
            MemoryStream mem = new MemoryStream();
            ser.WriteObject(mem, employee);
            string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);

            WebClient webClient = new WebClient();
            string serviceURL = string.Format(serverUri+"PlaceEmployee");
            //Post
            webClient.Headers["Content-type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            string dataAnswer = webClient.UploadString(serviceURL, "POST", data);
            //Answer
            return dataAnswer == "true" ? true : false;
        }
        public static bool RemoveEmployee(int employeeId)
        {
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(int));
            MemoryStream mem = new MemoryStream();
            ser.WriteObject(mem, employeeId);
            string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);

            WebClient webClient = new WebClient();
            string serviceURL = string.Format(serverUri+"RemoveEmployee");
            //Post
            webClient.Headers["Content-type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            string dataAnswer = webClient.UploadString(serviceURL, "POST", data);
            //Answer
            return dataAnswer == "true" ? true : false;
        }

        // Operate on Projects
        public static ProjectContract[] GetAllProjects()
        {
            WebClient proxy = new WebClient();
            string serviceURL = string.Format(serverUri+"GetAllProjects");
            byte[] data = proxy.DownloadData(serviceURL);
            Stream stream = new MemoryStream(data);
            DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(ProjectContract[]));
            ProjectContract[] projects = obj.ReadObject(stream) as ProjectContract[];
            return projects;
        }

        public static bool PlaceProject(string projectName)
        {
            ProjectContract employee = new ProjectContract { Name = projectName };

            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(ProjectContract));
            MemoryStream mem = new MemoryStream();
            ser.WriteObject(mem, employee);
            string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);

            WebClient webClient = new WebClient();
            string serviceURL = string.Format(serverUri+"PlaceProject");
            //Post
            webClient.Headers["Content-type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            string dataAnswer = webClient.UploadString(serviceURL, "POST", data);
            //Answer
            return dataAnswer == "true" ? true : false;
        }
        public static bool RemoveProject(int projectId)
        {
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(int));
            MemoryStream mem = new MemoryStream();
            ser.WriteObject(mem, projectId);
            string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);

            WebClient webClient = new WebClient();
            string serviceURL = string.Format(serverUri+"RemoveProject");
            //Post
            webClient.Headers["Content-type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            string dataAnswer = webClient.UploadString(serviceURL, "POST", data);
            //Answer
            return dataAnswer == "true" ? true : false;
        }

        // Obtain time
        public static bool ObtainTime (int hoursAmount, int employeeId, int projectId)
        {
            ObtainTimeContract obtainTime = new ObtainTimeContract { HoursAmount = hoursAmount, EmployeeId = employeeId, ProjectId = projectId };

            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(ObtainTimeContract));
            MemoryStream mem = new MemoryStream();
            ser.WriteObject(mem, obtainTime);
            string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);

            WebClient webClient = new WebClient();
            string serviceURL = string.Format(serverUri+"ObtainTime");
            //Post
            webClient.Headers["Content-type"] = "application/json";
            webClient.Encoding = Encoding.UTF8;
            string dataAnswer = webClient.UploadString(serviceURL, "POST", data);
            //Answer
            return dataAnswer == "true" ? true : false;
        }
        public static string[] GetReport ()
        {
            WebClient proxy = new WebClient();
            string serviceURL = string.Format(serverUri+"GetReport");
            byte[] data = proxy.DownloadData(serviceURL);
            Stream stream = new MemoryStream(data);
            DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(string[]));
            String[] report = obj.ReadObject(stream) as String[];
            return report;
        }
    }
}
