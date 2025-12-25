using lotteryApi.Models;
using System.ComponentModel.DataAnnotations;

namespace lotteryApi.Dtos
{
    public class DonorDto
    {
        public string? Tz { get; set; } = string.Empty;
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required, Phone]
        public string Phone { get; set; } = string.Empty;
        [Required, EmailAddress]
        public string Email { get; set; }= string.Empty;
    }
    public class UpdateDonorDto
    {

        public string? Tz { get; set; }
    
        public string? Name { get; set; }
     
        public string? Phone { get; set; }
      
        public string? Email { get; set; }
    }
}
