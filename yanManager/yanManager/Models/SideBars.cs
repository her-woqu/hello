using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XireManager.Models
{
    public class SideBars
    {
        [Key]
        [Required]

        public int Id { get; set; }

        public string Name { get; set; }

        public string Controller { get; set; }

        public string Action { get; set; }
    }
}