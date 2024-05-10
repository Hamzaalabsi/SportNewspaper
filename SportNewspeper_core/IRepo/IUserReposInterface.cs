using SportNewspeper_core.DTO.Login;
using SportNewspeper_core.DTO.Registration;

namespace SportNewspeper_core.IRepo
{
    public interface IUserReposInterface
    {
        Task<int> Subscribe(UserRegistrationDTO dto);

        Task<int> Unsubscribe(int Id);
        public Task<int> UserLogin(LoginDTO dTO);
    }
}
