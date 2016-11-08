using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServerSide.DataBase
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }

        public virtual List<ElapsedTime> ElapsedTimes { get; set; }
    }
}