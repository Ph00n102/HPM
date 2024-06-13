using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace HPM.Data.Entities
{
    public class Authentication
    {
        [Key]
        public int AuthId {get; set;}

        [Required, MaxLength(10), Unicode(false)]
        public string UserName { get; set; }    

        [Required, MaxLength(10), Unicode(false)]
        public string Password { get; set; }

        [MaxLength(50), Unicode(false)]
        public string Department { get; set; }  

        [MaxLength(30), Unicode(false)]
        public string UserRole { get; set; }    

        [MaxLength(8), Unicode(false)]
        public DateTime DateLogin { get; set; } 

        [MaxLength(8), Unicode(false)]
        public DateTime TimeLogin   { get; set; }

        [MaxLength(8), Unicode(false)]
        public DateTime DateLogout  { get; set; }

        [MaxLength(8), Unicode(false)]
        public DateTime TimeLogout { get; set; }  

        [MaxLength(50), Unicode(false)]
        public string FirstName { get; set; }  

        [MaxLength(50), Unicode(false)] 
        public string LastName { get; set; }  

        [MaxLength(10), Unicode(false)]  
        public string PhoneNumber { get; set; } 

        [MaxLength(10), Unicode(false)]
        public string FlagStatus { get; set; }  

        [MaxLength(8), Unicode(false)]
        public DateTime DateCreate { get; set; }    
    }
}