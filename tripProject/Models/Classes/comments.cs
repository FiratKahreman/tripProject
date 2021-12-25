using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace tripProject.Models.Classes
{
    public class comments
    {
        [Key]
        public int ID { get; set; }
        public string username { get; set; }
        public string mail { get; set; }
        public string comment { get; set; }
        public int blogID { get; set; }
    }
}