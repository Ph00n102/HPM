using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace HPM.Data.Entities
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }
        
        [Required, MaxLength(20), Unicode(false)]
        public string PatientType { get; set; } 
    } 
}