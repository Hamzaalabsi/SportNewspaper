using SportNewspeper_core.DTO.Login;
using SportNewspeper_core.DTO.Registration;
using SportNewspeper_core.IRepo;
using SportNewspeper_core.IService;

namespace SportNewspaper_Infra.ServiceImplemantation
{
    public class UserService : IUserServiceInterface
    {
        private readonly IUserReposInterface _repos;
        public UserService(IUserReposInterface repos)
        {
            _repos = repos;
        }



        public Task<int> Subscribe(UserRegistrationDTO dto)
        {
            var result = _repos.Subscribe(dto);
            return result;
        }



        public Task<int> Unsubscribe(int Id)
        {
            var rsult = _repos.Unsubscribe(Id);
            return rsult;
        }

        public Task<int> UserLogin(LoginDTO dTO)
        {
            var result = _repos.UserLogin(dTO);
            return result;
        }
    }
}
