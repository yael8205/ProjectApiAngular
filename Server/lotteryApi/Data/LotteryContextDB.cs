using lotteryApi.Models;
using Microsoft.EntityFrameworkCore;

namespace lotteryApi.Data
{
    public class LotteryDBContext : DbContext
    {
        public LotteryDBContext(DbContextOptions<LotteryDBContext> options):base(options) { }

        public DbSet<DonorModel>Donors { get; set; }

        public DbSet<GiftModel> Gifts { get; set; }

        public DbSet<UserModel> Users { get; set; }

        public DbSet<GiftInOrderModel> GiftsInOrder { get; set; }

        public DbSet<GiftInCartModel> GiftsInCart { get; set; }

        public DbSet<OrderModel> Orders { get; set; }
        public DbSet<PackageModel> Packages { get; set; }

        public DbSet<ShoppingCartModel> ShoppingCarts { get; set; }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<OrderModel>()
        //        .HasMany(o => o.Packages)
        //        .WithMany();
        //}
    }
}
