using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ClientSide.DataContracts
{
    [DataContract]
    public class EmployeeContract
    {
        [DataMember]
        public int EmployeeId { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
    }
}