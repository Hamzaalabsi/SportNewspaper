using SportNewspeper_core.DTO.Login;
using SportNewspeper_core.DTO.Match;
using SportNewspeper_core.DTO.News;
using SportNewspeper_core.DTO.Subscription;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportNewspeper_core.IRepo
{
    public interface IAdminReposInterface
    {
        Task<int> CreatNewNews(CreateOrUpdateCompetaitionNews dto);
        Task<int> CreateMach(CreateOrUpdateMatchDTO dto);
        Task<int> UpdateMach(UpdateMatchDTO dto);
        Task<int> DeleteMach(int id);
        Task <List<GetAllSubscribersDTO>>  GetAllSubscribers();
        Task <List <GetSubscrberById>>GetSubscribersById(int id);
        Task<int> CreateSubscription(CreateOrUpdateSupscriptionDTO dto);
        Task<int> UpdateSubscription(CreateOrUpdateSupscriptionDTO dto);
        Task<int> DeleteSubscription(int id);
        public Task<int> Login(LoginDTO dto);
      

    }
}
