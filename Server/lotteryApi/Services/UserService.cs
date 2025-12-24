using lotteryApi.Models;
using lotteryApi.Repositories;

namespace lotteryApi.Services
{
    public class UserService
    {
        private readonly UserRepository _userRepository =new ();

        public IEnumerable<UserModel> GetUsers()
        {
            return _userRepository.GetUsers();
        }
    }
}
