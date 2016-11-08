using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ClientSide.DataContracts
{
    [DataContract]
    public class ProjectContract
    {
        [DataMember]
        public int ProjectId { get; set; }
        [DataMember]
        public string Name { get; set; }
    }
}