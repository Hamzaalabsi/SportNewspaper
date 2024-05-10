using Microsoft.EntityFrameworkCore;
using SportNewspeper_core.Context;
using SportNewspeper_core.DTO.Login;
using SportNewspeper_core.DTO.Match;
using SportNewspeper_core.DTO.News;
using SportNewspeper_core.IRepo;
using SportNewspeper_core.Models;
using static SportNewspeper_core.Enums.SportNewsPaperEnums;

namespace SportNewspaper_Infra.ReposImplemantation
{
    public class SharedRepos : ISharedReposInterface
    {

        private readonly SportNewspaperDbContext _context;
        public SharedRepos (SportNewspaperDbContext context)
        {
            _context = context;
        }
        
                               
    

       

        public async Task<List<NewsDetalsDTO>> EuropeFootballNewsDetals()
        {
            var news=await _context.news.ToListAsync();
            var result=new List<NewsDetalsDTO>();
            foreach (var item in news)
            {
                result.Add(new NewsDetalsDTO()
                {
                     Id = item.Id,
                    Title= item.Title,
                    Description= item.Description,
                    Content= item.Content,
                    ImagePath= item.ImagePath,
                    VedeoPath= item.VedeoPath,
                    PublishTime= item.PublishTime,
                    continent = item.continent,    
                    countries= item.countries,
                    sports= item.sports,    


                });

            }
            return result;

        }

        public async Task<List<MatchDetalsDTO>> FootballMatchDetals()
        {
            var result = await(from team in _context.teams
                               join teamMatch in _context.teamsMatshs on team.Id equals teamMatch.Team.Id
                               join match in _context.matches.Where(x=>x.sports.Equals(Sports.Football)) on teamMatch.Match.Id equals match.Id
                               select new MatchDetalsDTO
                               {
                                   Id = match.Id,
                                   TeamName = team.Name,
                                   StartTime = match.StartTime,
                                   sports=match.sports,
                                   continent = match.continent,
                                   countries=match.countries,
                                   RefereeName=match.RefereeName,
                                   Description=match.Description,
                                   StadiumName=match.StadiumName,   
                                   

                               }).ToListAsync();


            List<MatchDetalsDTO> resultList = result.ToList();
            return resultList;

            
        }

        public async Task<List<NewsDetalsDTO>> FootbalNewslDetals()
        {

            var news = await _context.news.ToArrayAsync();
            var result = new List<NewsDetalsDTO>();
            foreach (var item in news)
            {
                result.Add(new NewsDetalsDTO()
                {
                    Id = item.Id,
                    Title = item.Title,
                    Description = item.Description,
                    Content = item.Content,
                    ImagePath = item.ImagePath,
                    VedeoPath = item.VedeoPath,
                    PublishTime = item.PublishTime,
                    continent = item.continent,
                    countries = item.countries,
                    sports = item.sports,

                });

            }
            return result;
        }




        public async Task<List<NewsDTO>> GetAllEuropeFootballNews()
        {
            var news = await _context.news.Where(x => x.sports.Equals(Sports.Football) && x.continent.Equals(Continent.Europe)).OrderByDescending(x=>x.PublishTime).ToListAsync();
            var result=new List<NewsDTO>();   
            foreach(var item in news)
            {
                result.Add(new NewsDTO()
                {
                    
                    Title= item.Title,
                    Description= item.Description,
                    PublishTime = item.PublishTime,

                });
              
            }
            return result;
        }
         
        public async Task<List<MatchsDTO>> GetAllFootballMatchs()
        {
            var result = await (from team in _context.teams
                                join teamMatch in _context.teamsMatshs on team.Id equals teamMatch.Team.Id
                                join match in _context.matches.Where(x=>x.sports .Equals(Sports.Football)) on teamMatch.Match.Id equals match.Id
                                select new MatchsDTO
                                {
                                   Id= match.Id, 
                                    Name = team.Name,
                                    StartTime = match.StartTime ,
                                   
                                }).ToListAsync();

            
            List<MatchsDTO> resultList = result.ToList();

            return resultList;
        }

        public async Task<List<NewsDTO>> GetAllFootballNews()
        {
            var news=await _context.news.Where(x=>x.sports.Equals(Sports.Football)).ToListAsync();
            var result=new List<NewsDTO>();
            foreach (var item in news)
            {
                result.Add(new NewsDTO()
                {
                    Title = item.Title,
                    Description= item.Description,
                    PublishTime= item.PublishTime,

                });
            }
            return result;
        }

        public async Task<List<NewsDTO>> GetAllImportantNews()
        {
           var news = await _context.news.Where(x=>x.IsImportant==true).OrderByDescending(x => x.PublishTime). ToListAsync();
            var result = new List<NewsDTO>();
            foreach ( var item in news )
            {
                result.Add(new NewsDTO()
                {
                    Title = item.Title,
                    Description = item.Description,
                    PublishTime = item.PublishTime,
                    
                });
            }
            return result;
            
             

           

           
        }

        public async Task<List<MatchsDTO>> GetAllIportantMatch()
        {
            var match = await (from team in _context.teams
                        join
                       TeamMatsh in _context.teamsMatshs on team.Id equals TeamMatsh.Team.Id
                        join Match in _context.matches.Where(X=>X.IsImportant==true) on TeamMatsh.Match.Id equals Match.Id
                        select new MatchsDTO()
                        {
                            Id= Match.Id,
                            Name=team.Name,
                            StartTime=Match.StartTime


                        }).ToListAsync();
            var result = new List<MatchsDTO>();
            result=match.ToList();
            return result;
        }

        public async Task<List<NewsDTO>> getAllNews()
        {
        var news=await _context.news.ToArrayAsync();
            var result = new List<NewsDTO>();
            foreach ( var item in news )
            {
                result.Add(new NewsDTO()
                {
                 Title=item.Title,
                Description=item.Description,
                PublishTime=item.PublishTime,
                });
            }
            return result;
        }

        public async Task<List<NewsDTO>> GetAllNewsByCompetaitionName(string CompetaitionName)
        {
            var news = await (from News in _context.news.OrderByDescending(x => x.PublishTime)
                              join
                      Competaition in _context.competaitions.Where(x=>x.Name.Contains(CompetaitionName)) on News.Competaition.Id equals Competaition.Id
                       select new NewsDTO()
                       {
                           Id = Competaition.Id,
                           Title=News.Title,
                           Description = News.Description,  
                           PublishTime=News.PublishTime,
                       }).ToListAsync();
            var result = new List<NewsDTO>();
            result=news.ToList();
            return result;
        }

        public async Task<List<NewsDTO>> GetAllNewsByTeamName(string teamName)
        {
            try
            {

                var news = await (from News in _context.news.OrderByDescending(x=>x.PublishTime)
                                  join
                                 TeamNews in _context.teamNews on News.Id equals TeamNews.News.Id
                                  join Team in _context.teams.Where(x => x.Name.Contains(teamName)) on TeamNews.Team.Id equals Team.Id
                                  select new NewsDTO()
                                  {
                                      PublishTime = News.PublishTime,
                                      Id = Team.Id,
                                      Title = News.Title,
                                      Description = News.Description,
                                  }).ToListAsync();
                
                var result = new List<NewsDTO>();
                result = news.ToList();
                return result;

            }catch (Exception ex) { throw new Exception(ex.Message); }  

        }

        public async Task<List<NewsDetalsDTO>> ImportantNewsDetals()
        {
           var News= await _context.news.Where(x=>x.IsImportant==true).OrderByDescending(x=>x.PublishTime).ToListAsync();
            var result = new List<NewsDetalsDTO>();
            foreach ( var item in News )
            {
                result.Add(new NewsDetalsDTO()
                {
                    Id = item.Id,
                    Title=item.Title,
                    Description= item.Description,
                    PublishTime=item.PublishTime,
                    continent  = item.continent,
                    Content=item.Content,
                    ImagePath=item.ImagePath,
                    VedeoPath=item.VedeoPath,
                    countries= item.countries,
                    sports=item.sports,
                });
            }
            return result;
        }

        public async Task<List<MatchDetalsDTO>> IportantMatchDetals()
        {

            var match = await(from team in _context.teams
                              join
                             TeamMatsh in _context.teamsMatshs on team.Id equals TeamMatsh.Team.Id
                              join Match in _context.matches.Where(X => X.IsImportant == true) on TeamMatsh.Match.Id equals Match.Id
                              select new MatchDetalsDTO()
                              {
                                  Id = Match.Id,
                                  TeamName = team.Name,
                                  StartTime = Match.StartTime,
                                  Description = Match.Description,
                                  continent= Match.continent,
                                  countries= Match.countries,
                                  sports= Match.sports,
                                  StadiumName = Match.StadiumName,
                                  RefereeName = Match.RefereeName,
                                    
                                 


                              }).ToListAsync();
            var result = new List<MatchDetalsDTO>();
            result = match.ToList();
            return result;
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
