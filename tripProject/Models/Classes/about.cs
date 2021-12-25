using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace tripProject.Models.Classes
{
    public class about
    {
        [Key]
        public int ID { get; set; }
        public string imgLink { get; set; }
        public string content { get; set; }
    }
}