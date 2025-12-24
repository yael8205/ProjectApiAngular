using Home_Fashion.Data;
using lotteryApi.Data;
using lotteryApi.Models;

namespace lotteryApi.Repositories
{
    public class UserRepository
    {
        private readonly LotteryDBContext _lotteryContext= LotteryDBtFactory.CreateContext();

        public IEnumerable<UserModel> GetUsers()
        {
            return _lotteryContext.Users.ToList();
        }

    }
}
