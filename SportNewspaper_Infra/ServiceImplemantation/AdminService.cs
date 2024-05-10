using SportNewspeper_core.DTO.Login;
using SportNewspeper_core.DTO.Match;
using SportNewspeper_core.DTO.News;
using SportNewspeper_core.DTO.Subscription;
using SportNewspeper_core.IRepo;
using SportNewspeper_core.IService;

namespace SportNewspaper_Infra.ServiceImplemantation
{
    public class AdminService : IAdminServiceInterface
    {
        private readonly IAdminReposInterface _repos;
        public AdminService(IAdminReposInterface repos)
        {
            _repos = repos;
        }
        public Task<int> CreateMach(CreateOrUpdateMatchDTO dto)
        {
            var result = _repos.CreateMach(dto);
            return result;
        }

        public async Task<int> CreateSubscription(CreateOrUpdateSupscriptionDTO dto)
        {
            var result = await (_repos.CreateSubscription(dto));
            return result;

        }



        public async Task<int> CreatNewNews(CreateOrUpdateCompetaitionNews dto)
        {
            var result = await _repos.CreatNewNews(dto);
            return result;
        }



        public Task<int> DeleteMach(int id)
        {
            var result = _repos.DeleteMach(id);
            return result;
        }

        public Task<int> DeleteSubscription(int id)
        {
            var result = _repos.DeleteSubscription(id);
            return result;
        }




        public Task<List<GetAllSubscribersDTO>> GetAllSubscribers()
        {
            var result = _repos.GetAllSubscribers();
            return result;
        }

        public Task<List<GetSubscrberById>> GetSubscribersById(int id)
        {
            var result = _repos.GetSubscribersById(id);
            return result;
        }

        public Task<int> Login(LoginDTO dto)
        {
            var login = _repos.Login(dto);
            return login;
        }

        public async Task<int> UpdateMach(UpdateMatchDTO dto)
        {
            var result = await _repos.UpdateMach(dto);
            return result;
        }



        public Task<int> UpdateSubscription(CreateOrUpdateSupscriptionDTO dto)
        {
            var result = _repos.UpdateSubscription(dto);
            return result;
        }

    }
}
