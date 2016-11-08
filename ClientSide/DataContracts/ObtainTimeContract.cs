using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ClientSide.DataContracts
{
    [DataContract]
    public class ObtainTimeContract
    {
        [DataMember]
        public int HoursAmount { get; set; }
        [DataMember]
        public int EmployeeId { get; set; }
        [DataMember]
        public int ProjectId { get; set; }
    }
}