using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IAT.Web.Models.DAL.Entities
{
    public class App : BaseEntity
    {
        [Key]
        public int AppID { get; set; }
        public string AppName { get; set; }
        public byte[] Icon { get; set; }
    }
}
