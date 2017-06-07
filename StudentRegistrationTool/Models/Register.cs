using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentRegistrationTool.Models
{
    public class Register
    {
        public int Id { get; set; }
        public string UserId { get; set; }

        [Required]
        [Display(Name = "Aanwezig vanaf")]
        public DateTime PresentFrom { get; set; }

        [Required]
        [Display(Name = "Aanwezig tot")]
        public DateTime PresentTill { get; set; }

        [Display(Name = "Opmerking")]
        public string Comment { get; set; }
    }
}