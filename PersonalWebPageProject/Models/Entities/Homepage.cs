using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PersonalWebPageProject.Models.Entities
{
    public class Homepage
    {
        [Key]
        public int ID { get; set; }
        public string Profile { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Definition { get; set; }
        public string Contact { get; set; }
    }
}