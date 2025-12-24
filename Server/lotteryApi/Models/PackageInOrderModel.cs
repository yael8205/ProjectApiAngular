using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace lotteryApi.Models
{
    public class PackageInOrderModel
    {
        public int Id { get; set; }
        [Required]
        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public OrderModel Order { get; set; }
        [Required]
        public int packageId { get; set; }
        [ForeignKey("packageId")]

        public PackageModel package { get; set; }

        public ICollection<GiftInOrderModel> GiftsInPackage { get; set; } = new List<GiftInOrderModel>();

        [Required]
        public int PriceAtPurchase { get; set; }
    }
}
