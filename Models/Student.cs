using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndDeveloperAssessment.Models
{
    public class Student
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [Display(Name="School")]
        public int? SchoolId { get; set; }
        public School School { get; set; }
        [Required]
        public string Major { get; set; }
        [Display(Name="Active")]
        public Boolean IsActive { get; set; }
        [Required]
        [Display(Name="Date Modified")]
        public DateTime DateModified { get; set; }
    }
}
