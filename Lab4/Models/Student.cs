using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Last Name")]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

        //this is a calculated field from: LastName and FirstName
        public string FullName { get { return LastName + ", " + FirstName; } }
        // for Navigational properties you define in Community and Student models, name both Membership, and make sure that they navigate to CommunityMembership
        public CommunityMembership Membership { get; set; }
    }
}
