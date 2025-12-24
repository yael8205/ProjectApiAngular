using lotteryApi.Enums;
using System.ComponentModel.DataAnnotations;

namespace lotteryApi.Dtos
{
    public class UserDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Password { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, Phone]
        public string Phone { get; set; }

        public string? Adress { get; set; }
        [Required]
        public UserRoleEnum role { get; set; } = UserRoleEnum.Participant;
    }
}
