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
      public class StatusService
    {
        private List<Status> _u;
        public StatusService()
        {
            _u = new List<Status>
            {
                new Status{StatusId = 10, StatusName = "รอจ่ายงาน"},
                new Status{StatusId = 30, StatusName = "กำลังไป"},
                new Status{StatusId = 40, StatusName = "รอยืนยัน"},
                new Status{StatusId = 50, StatusName = "ยืนยันงานสำเร็จ"},
                new Status{StatusId = 60, StatusName = "รอเรียกงานเปล"},

            };
        }

    }
}

