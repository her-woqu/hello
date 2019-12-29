using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XireManager.Models
{
    public class ActionLinks
    {
        [Key]
        [Required]

        public int Id { get; set; }


        [Required]
        [StringLength(20)]
        public string Name { get; set; }


        [Required]
        [StringLength(20)]
        public string Controller { get; set; }

        [Required]
        [StringLength(20)]
        public string Action { get; set; }

    }
}
