using SportNewspeper_core.DTO.Login;
using SportNewspeper_core.DTO.Match;
using SportNewspeper_core.DTO.News;
using SportNewspeper_core.IRepo;
using SportNewspeper_core.IService;
using static SportNewspeper_core.Enums.SportNewsPaperEnums;

namespace SportNewspaper_Infra.ServiceImplemantation
{
    public class SharedService : ISharedServiceInterface
    {
        private readonly ISharedReposInterface _repos;
        public SharedService(ISharedReposInterface repos) { _repos = repos; }




        public async Task<List<NewsDetalsDTO>> EuropeFootballNewsDetals(int Id)
        {
            var rsult = await _repos.EuropeFootballNewsDetals();


            return rsult.Where(x => x.Id == Id && x.sports.Equals(Sports.Football) && x.continent.Equals(Continent.Europe)).ToList();
        }



        public async Task<List<MatchDetalsDTO>> FootballMatchDetals(int Id)
        {
            var result = await _repos.FootballMatchDetals();
            return result.Where(x => x.Id == Id).ToList();
        }

        public async Task<List<NewsDetalsDTO>> FootbalNewslDetals(int Id)
        {
            var result = await _repos.FootbalNewslDetals();
            return result.Where(x => x.Id == Id && x.sports.Equals(Sports.Football)).ToList();

        }



        public async Task<List<NewsDTO>> GetAllEuropeFootballNews()
        {
            var result = await _repos.GetAllEuropeFootballNews();

            return result;
        }

        public async Task<List<MatchsDTO>> GetAllFootballMatchs()
        {
            var result = await _repos.GetAllFootballMatchs();
            return result;
        }

        public Task<List<NewsDTO>> GetAllFootballNews()
        {
            var result = _repos.GetAllFootballNews();
            return result;
        }

        public async Task<List<NewsDTO>> GetAllImportantNews()
        {
            var result = await _repos.GetAllImportantNews();

            return result;
        }

        public Task<List<MatchsDTO>> GetAllIportantMatch()
        {
            var result = _repos.GetAllIportantMatch();
            return result;
        }

        public async Task<List<NewsDTO>> getAllNews()
        {
            var result = await _repos.getAllNews();
            return result;
        }

        public Task<List<NewsDTO>> GetAllNewsByCompetaitionName(string CompetaitionName)
        {
            var result = _repos.GetAllNewsByCompetaitionName(CompetaitionName);
            return result;
        }

        public Task<List<NewsDTO>> GetAllNewsByTeamName(string teamName)
        {
            var result = _repos.GetAllNewsByTeamName(teamName);
            return result;
        }

        public async Task<List<NewsDetalsDTO>> ImportantNewsDetals(int Id)
        {
            var result = await _repos.ImportantNewsDetals();
            return result.Where(x => x.Id == Id).ToList();
        }

        public async Task<List<MatchDetalsDTO>> IportantMatchDetals(int Id)
        {
            var result = await _repos.IportantMatchDetals();
            return result.Where(x => x.Id == Id).ToList();
        }




        public Task<int> Login(LoginDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task LogOut(int UserId)
        {
            throw new NotImplementedException();
        }


        public Task RestPasword(RrsetPasswordDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
