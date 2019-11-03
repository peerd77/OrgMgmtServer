using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrgMgmtServer.Models
{
    public abstract class DatedEntity : Idable
    {
        public DatedEntity()
        {
            CreateDate = DateTime.Now;
        }
        public string Text { get; set; }
        public DateTime CreateDate { get; private set; }   


    }
}
