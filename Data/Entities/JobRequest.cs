using Azure.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.ComponentModel.DataAnnotations;

namespace HPM.Data.Entities
{
    public class JobRequest
    {
        [Key]
        public int JobId { get; set; }  

        [Required, MaxLength(8), Unicode(false)]
        public DateTime DateRequest { get; set; }

        [Required, MaxLength(8), Unicode(false)]
        public DateTime TimeRequest { get; set; }   

        [Required, MaxLength(10), Unicode(false)]
        public String UserName { get; set; }

        [Required, MaxLength(50), Unicode(false)]
        public string FirstName { get; set; }

        [Required, MaxLength(30), Unicode(false)]
        public string StartPoint { get; set; }

        [Required, MaxLength(30), Unicode(false)]
        public string Destination { get; set; } 
        [Required, MaxLength(20), Unicode(false)]
        public string Status { get; set; }

        [Required, MaxLength(50), Unicode(false)]
        public string Department { get; set; } 

        [MaxLength(100), Unicode(false)]
        public string MaterialName { get; set; } 

        [ MaxLength(20), Unicode(false)]
        public string UrgentType  { get; set; }

        [MaxLength(20), Unicode(false)]
        public string PatientType { get; set; } 

        [MaxLength(8), Unicode(false)]
        public int PersonId { get; set; }

        [MaxLength(8), Unicode(false)]
        public DateTime TimeClose { get; set; } 

        [MaxLength(8), Unicode(false)]
        public DateTime DateClase { get; set; }

        [MaxLength(200), Unicode(false)]
        public string Remark  {get; set;}
    }

}