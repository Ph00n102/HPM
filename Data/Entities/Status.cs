using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace HPM.Data.Entities
{
    public class Status
    {
        [Key]
        public int StatusId { get; set; }   
        
         [Required, MaxLength(50), Unicode(false)]
        public string StatusName { get; set; }
    }
}