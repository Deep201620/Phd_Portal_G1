using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Phd_portal_G1.Models
{

    public class Faculty
    {

        [Key]
        [Display(Name = "User Id")]
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public virtual UserInfo user { get; set; }


        [Display(Name = "Faculty type")]
        public string Faculty_type { get; set; }



    }
}
