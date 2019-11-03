using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrgMgmtServer.Models
{
    public class Employee: Person
    {
        public EmployeePosition Position { get; set; }
        public int? ManagerId { get; set; }

    }

    public enum EmployeePosition { FrontEnd = 1, Backend, FullStack, TeamLead, QA, Designer, Product, CTO, COO, CEO }
  
}
