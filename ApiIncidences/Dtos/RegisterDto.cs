using System.ComponentModel.DataAnnotations;

namespace ApiIncidences.Dtos;

    public class RegisterDto
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string UserName { get; set; }
    }
