using System.ComponentModel.DataAnnotations;

namespace ApiIncidences.Dtos;

    public class AddRoleDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Role { get; set; }
        [Required]
        public string Password { get; set; }
    }
