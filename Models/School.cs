using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndDeveloperAssessment.Models
{
    public class School
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name="Address 1")]
        public string Address1 { get; set; }
        [Display(Name="Address 2")]
        public string Address2 { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        [Display(Name="Zip Code")]
        public string ZipCode { get; set; }
    }
}
