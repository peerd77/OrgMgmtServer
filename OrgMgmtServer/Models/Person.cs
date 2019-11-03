using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrgMgmtServer.Models
{
    public abstract class Person: Idable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
