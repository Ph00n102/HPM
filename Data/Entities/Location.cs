using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace HPM.Data.Entities
{
    public class Location 
    {
        [Key]
        public int LocationId { get; set; }   

         [Required, MaxLength(50), Unicode(false)]
        public string LocationName { get; set; }
        
         [Required, MaxLength(50), Unicode(false)]
        public string Department { get; set; }
    }
}