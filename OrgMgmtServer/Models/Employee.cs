using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrgMgmtServer.Models
{
    public class Employee: Person
    {
        public EmployeePosition position;
    }

    public enum EmployeePosition { FrontEnd, Backend, FullStack, TeamLead, QA, Designer, Product, CTO, COO, CEO }
  
}
