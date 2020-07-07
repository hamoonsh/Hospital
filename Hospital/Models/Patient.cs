using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospital.Models
{
    public class Patient
    {
        [Required]
        public int Level { get; set; }

        [Required]
        public string MobileNumber { get; set; }

        [Required]
        public int HospitalID { get; set; }

        [Required]
        public int DoctorID { get; set; }

        [Required]
        public bool IsVisited { get; set; }
    }
}