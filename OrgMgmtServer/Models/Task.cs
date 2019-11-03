using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrgMgmtServer.Models
{
    public class Task : DatedEntity
    {
        public DateTime DueDate { get; set; }
        public int EmployeeID { get; set; }
    }
}
