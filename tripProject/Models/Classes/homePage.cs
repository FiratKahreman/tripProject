using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace tripProject.Models.Classes
{
    public class homePage
    {
        [Key]
        public int ID { get; set; }
        public string title { get; set; }
        public string content { get; set; }
    }
}