using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace tripProject.Models.Classes
{
    public class blog
    {
        [Key]
        public int ID { get; set; }
        public string title { get; set; }
        public DateTime date { get; set; }
        public string content { get; set; }
        public string blogImage { get; set; }
    }
}