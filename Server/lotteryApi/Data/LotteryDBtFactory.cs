
using lotteryApi.Data;
using Microsoft.EntityFrameworkCore;

namespace Home_Fashion.Data
{
    public class LotteryDBtFactory
    {
        private const string ConnectionString = "Server=DESKTOP-PKVNNGR;DataBase=LotteryDB;Integrated Security=SSPI;" +
       // private const string ConnectionString = "Server=Srv2\\pupils;DataBase=LotteryDB;Integrated Security=SSPI;" +

 "Persist Security Info=False;TrustServerCertificate=true";
        public static LotteryDBContext CreateContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<LotteryDBContext>();
            optionsBuilder.UseSqlServer(ConnectionString);
            return new LotteryDBContext(optionsBuilder.Options);
        }
    }
}

