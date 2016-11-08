using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServerSide.DataBase
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public virtual List<ElapsedTime> ElapsedTimes { get; set; }
    }
}