using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IAT.Web.Models.DAL.Entities
{
    public class User : BaseEntity
    {
        [Key]
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public byte[] Image { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Middlename { get; set; }
        public string Fullname => $"{this.Firstname} {this.Middlename} {this.Lastname}";
    }
}
