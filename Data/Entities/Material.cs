using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace HPM.Data.Entities
{
    public class Material 
    {
        [Key]
        public int MaterialId { get; set; }

        [Required, MaxLength(50), Unicode(false)]
        public string MaterialName { get; set; }
        
        [Required, MaxLength(50), Unicode(false)]
        public string Department { get; set; }
    }
}