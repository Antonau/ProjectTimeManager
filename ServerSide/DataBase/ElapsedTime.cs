using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServerSide.DataBase
{
    public class ElapsedTime
    {
        public int ElapsedTimeId { get; set; }
        public int ProjectId { get; set; }
        public int EmployeeId { get; set; }
        public int Time { get; set; }
    }
}