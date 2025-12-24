using lotteryApi.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lotteryApi.Dtos
{
    public class GiftInCartDto
    {
        [Required]
        public int GiftId { get; set; }
        public int CartId { get; set; }
        [Required]
        public int Qty { get; set; } = 1;
    }
}
