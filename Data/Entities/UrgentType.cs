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
    public class UrgentTypeService
    {
        private List<UrgentType> _u;
        public UrgentTypeService()
        {
            _u = new List<UrgentType>
            {
                new UrgentType{UrgentId = 10, UrgentName = "IPD"},
                new UrgentType{UrgentId = 20, UrgentName = "OPD"},
            };
        }

    }
}
  