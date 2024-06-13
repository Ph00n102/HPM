using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace HPM.Data.Entities
{
    public class Person 
    {
        [Key]
        public int PersonId { get; set; }

        [Required, MaxLength(50), Unicode(false)]
        public string FirstName { get; set; } 

        [Required, MaxLength(50), Unicode(false)]
        public string LastName { get; set; }   
         
        [Required, MaxLength(50), Unicode(false)]
        public string Position  { get; set; }
    
    }
}