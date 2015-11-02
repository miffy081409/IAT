using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IAT.Web.Models.DAL.Entities
{
    public class AppException : BaseEntity
    {
        [Key]
        public int AppExcetionID { get; set; }
        public string AppName { get; set; }
        public DateTime Date { get; set; }
        public string ExceptionTitle { get; set; }
        public string ExceptionMessage { get; set; }
        public string ExceptionStackTrace { get; set; }
    }
}
