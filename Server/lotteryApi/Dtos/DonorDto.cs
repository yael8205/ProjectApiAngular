using lotteryApi.Models;
using System.ComponentModel.DataAnnotations;

namespace lotteryApi.Dtos
{
    public class DonorDto
    {
        public string? Tz { get; set; }
        [Required]
        public string Name { get; set; }
        [Required, Phone]
        public string Phone { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
    }
    public class UpdateDonorDto
    {
        public int Id { get; set; }

        public string? Tz { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required, Phone]
        public string? Phone { get; set; }
        [Required, EmailAddress]
        public string? Email { get; set; }
    }
}
