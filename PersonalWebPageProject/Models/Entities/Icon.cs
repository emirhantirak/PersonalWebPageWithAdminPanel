using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PersonalWebPageProject.Models.Entities
{
    public class Icon
    {
        [Key]
        public int ID { get; set; }
        public string IconPic { get; set; }
        public string Link { get; set; }
    }
}