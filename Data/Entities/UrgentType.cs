using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace HPM.Data.Entities
{
    public class UrgentType
    {
         [Key]
        public int UrgentId { get; set; }  
         
        [Required, MaxLength(50), Unicode(false)]
        public string UrgentName { get; set; }  
    }
}
  