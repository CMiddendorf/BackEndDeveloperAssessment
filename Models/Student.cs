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
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public School School { get; set; }
        public string Major { get; set; }
        public Boolean IsActive { get; set; }
        public DateTime DateModified { get; set; }
    }
}
