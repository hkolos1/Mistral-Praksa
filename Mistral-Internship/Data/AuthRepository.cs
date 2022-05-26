using Mistral_Internship.Models;
using System.Threading.Tasks;

namespace Mistral_Internship.Data
{
    public class AuthRepository : IAuthRepository
    {
        public Task<ServiceResponse<string>> Login(string username, string password)
        {
            throw new System.NotImplementedException();
        }

        public Task<ServiceResponse<int>> Register(User user, string password)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UserExists(string username)
        {
            throw new System.NotImplementedException();
        }

        Task<ServiceResponse<string>> IAuthRepository.Login(string username, string password)
        {
            throw new System.NotImplementedException();
        }

        Task<bool> IAuthRepository.UserExists(string username)
        {
            throw new System.NotImplementedException();
        }
    }
}
