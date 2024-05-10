using SportNewspeper_core.Context;
using SportNewspeper_core.DTO.Login;
using SportNewspeper_core.DTO.Match;
using SportNewspeper_core.DTO.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportNewspeper_core.IRepo
{
    public interface ISharedReposInterface
    {
       
       

        Task <int>Login(LoginDTO dto);
        Task LogOut(int UserId);
        Task RestPasword(RrsetPasswordDTO dto);
        Task<List<NewsDTO>> GetAllImportantNews();
        Task<List<NewsDetalsDTO>> ImportantNewsDetals();
        Task <List<NewsDTO>> getAllNews();
        
        Task<List<NewsDTO>> GetAllFootballNews();
        Task<List<NewsDTO>> GetAllNewsByCompetaitionName(string teamName);
        Task<List<NewsDTO>> GetAllNewsByTeamName(string teamName);
        Task<List<NewsDetalsDTO>> EuropeFootballNewsDetals();
        Task<List<NewsDTO>> GetAllEuropeFootballNews();
        Task<List<NewsDetalsDTO>> FootbalNewslDetals();
        Task<List<MatchsDTO>> GetAllFootballMatchs();
        Task<List<MatchDetalsDTO>> FootballMatchDetals();
        Task<List<MatchsDTO>> GetAllIportantMatch();
        Task<List<MatchDetalsDTO>> IportantMatchDetals();
       


    }
}
