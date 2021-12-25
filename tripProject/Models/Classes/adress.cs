using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace tripProject.Models.Classes
{
    public class adress
    {
        [Key]
        public int ID { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public string Adress { get; set; }
        public string mail { get; set; }
        public string phone { get; set; }
        public string location { get; set; }
    }
}