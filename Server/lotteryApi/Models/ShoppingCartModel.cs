using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lotteryApi.Models
{
    public class ShoppingCartModel
    {
        public int Id { get; set; }
        [Required]
        public int ParticipantId { get; set; }

        [ForeignKey("ParticipantId")]
        public UserModel Participant { get; set; }

        [Required]
        public int SumPrice { get; set; }

        public ICollection<PackageInCartModel> PackagesInShoppingCart { get; set; } = new List<PackageInCartModel>();
        public ICollection<GiftInCartModel> GiftsInShoppingCart { get; set; } = new List<GiftInCartModel>();
    }
}
