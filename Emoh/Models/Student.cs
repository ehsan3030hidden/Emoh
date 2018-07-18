using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Emoh.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string Course { get; set; }

        [Required]
        [StringLength(50)]
        public string ImageName { get; set; }

        [Required]
        [StringLength(50)]
        public string SiteUrl { get; set; }

        public bool Gender { get; set; }
    }
}
