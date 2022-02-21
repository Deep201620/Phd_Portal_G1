using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Phd_portal_G1.Models
{
    public class Student
    {

        [Display(Name = "User Id")]
        [Key]
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public virtual UserInfo user { get; set; }


        [Display(Name = "Enrollment No")]
        [StringLength(12)]
        public long EnrollmentNo { get; set; }

        [Display(Name = "Date of Birth")]
        [DisplayFormat(DataFormatString = "dd-mm-yyyy")]
        public DateTime DateOfBirth { get; set; }


    }
}
