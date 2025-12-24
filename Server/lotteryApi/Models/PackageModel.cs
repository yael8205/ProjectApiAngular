using System.ComponentModel.DataAnnotations;

namespace lotteryApi.Models
{
    public class PackageModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int QtyClassicCards { get; set; }
        [Required]
        public int QtySpecialCards { get; set; }
        [Required]
        public int QtyPremiumCards { get; set; }
        [Required]
        public int Price { get; set; }

 




    }
}
