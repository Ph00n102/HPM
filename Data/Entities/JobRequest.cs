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

        public DateTime DateRequest { get; set; }

        public string PatientNH {get; set;}
        public string PatientName {get; set;}
        
        public String UserName { get; set; }

        public string FirstName { get; set; }

        
        public string StartPoint { get; set; }

        
        public string Destination { get; set; } 
        
        public string Status { get; set; }

        
        public string Department { get; set; } 

        
        public string MaterialName { get; set; } 

        
        public string UrgentType  { get; set; }

        
        public string PatientType { get; set; } 

        public int PersonId { get; set; }

        
        public DateTime TimeClose { get; set; } 

        
        public DateTime DateClase { get; set; }

        
        public string Remark  {get; set;}
    }

}