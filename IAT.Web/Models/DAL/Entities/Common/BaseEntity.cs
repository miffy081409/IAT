using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IAT.Web.Models.DAL.Entities
{
    public class BaseEntity
    {
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
        public EntityStatus RecordStatus { get; set; }

        public enum EntityStatus
        {
            Active,
            Inactive
        }
    }
}
