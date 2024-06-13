using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace HPM.Data.Entities
{
    public class Authentication
    {
        [Key]
        public int AuthId {get; set;}

        [Required, MaxLength(10)]
        public string UserName { get; set; }    

        [Required, MaxLength(10)]
        public string Password { get; set; }

        [MaxLength(50), Unicode(false)]
        public string Department { get; set; }  

        [MaxLength(30), Unicode(false)]
        public string UserRole { get; set; }    

       
        public DateTime DateLogin { get; set; } 

        
        public DateTime TimeLogin   { get; set; }

        
        public DateTime DateLogout  { get; set; }

       
        public DateTime TimeLogout { get; set; }  

       
        public string FirstName { get; set; }  

        
        public string LastName { get; set; }  

       
        public string PhoneNumber { get; set; } 

        
        public string FlagStatus { get; set; }  

       
        public DateTime DateCreate { get; set; }    
    }
}