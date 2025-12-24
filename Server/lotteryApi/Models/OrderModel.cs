using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lotteryApi.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        [Required]
        public int ParticipantId { get; set; }

        [ForeignKey("ParticipantId")]
        public UserModel Participant { get; set; }


        [Required]
        public int SumPrice { get; set; }
        [Required]
        public DateOnly  DateOrder { get; set; }

        public ICollection<PackageInOrderModel> PackagesInOrder { get; set; } = new List<PackageInOrderModel>();

        public ICollection<GiftInOrderModel> GiftsInOrder { get; set; } = new List<GiftInOrderModel>();

   


    }
}
