
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lotteryApi.Models
{
    public class PackageInCartModel
    {

        public int Id { get; set; }
        [Required]
        public int CartId { get; set; }

        [ForeignKey("CartId")]
        public ShoppingCartModel ShoppingCart { get; set; }
        [Required]
        public int packageId { get; set; }
        [ForeignKey("packageId")]

        public PackageModel package { get; set; }

        public ICollection<GiftInCartModel> GiftsInPackage { get; set; } = new List<GiftInCartModel>();
    }
}
