using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace tripProject.Models.Classes
{
    public class contact
    {
        [Key]
        public int ID { get; set; }
        public string nameSurname { get; set; }
        public string mail { get; set; }
        public string subject { get; set; }
        public string message { get; set; }
    }
}