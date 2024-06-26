using System.ComponentModel.DataAnnotations;

namespace HPM.Models
{
    public class LoginModel
    {
        [Required]
        public string Username { get; set; }
        [Required, MinLength(5)]
        public string Password { get; set; }
    }

}