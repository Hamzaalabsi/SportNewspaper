using Microsoft.EntityFrameworkCore;
using SportNewspeper_core.Context;
using SportNewspeper_core.DTO.Login;
using SportNewspeper_core.DTO.Match;
using SportNewspeper_core.DTO.News;
using SportNewspeper_core.DTO.Subscription;
using SportNewspeper_core.IRepo;
using SportNewspeper_core.Models;


namespace SportNewspaper_Infra.ReposImplemantation
{
    public class AdminRepos : IAdminReposInterface

    {
        private readonly SportNewspaperDbContext _db;
        public AdminRepos(SportNewspaperDbContext db)
        {
            _db = db;
        }

        public async Task<int> CreateMach(CreateOrUpdateMatchDTO dto)
        {


            var record1 = await _db.teams.FirstOrDefaultAsync(x => x.Id == dto.FirstTeamId);
            var record2 = await _db.teams.FirstOrDefaultAsync(x => x.Id == dto.SecondTeamId);

            if (record1 != null && record2 != null && dto.FirstTeamId != dto.SecondTeamId)
            {

                Match p = new Match();
                p.StartTime = dto.StartTime;
                p.StadiumName = dto.StadiumName;
                p.RefereeName = dto.RefereeName;
                p.continent = dto.continent;
                p.countries = dto.countries;
                p.Description = dto.Description;
                p.sports = dto.sports;
                p.IsImportant = dto.IsImportant;
                _db.Add(p);

                TeamMatsh firstTeam = new TeamMatsh();
                firstTeam.Match = p;
                firstTeam.Team = record1;
                _db.Add(firstTeam);
                TeamMatsh secondTeam = new TeamMatsh();
                secondTeam.Match = p;
                secondTeam.Team = record2;
                _db.Add(secondTeam);

                int result = await _db.SaveChangesAsync();

                return result;
            }
            throw new Exception("One or both of the teams could not be found.");

        }

        public async Task<int> CreateSubscription(CreateOrUpdateSupscriptionDTO dto)
        {
            try
            {
                var subscription = new Subscription();
                subscription.Price = dto.Price;
                subscription.Description = dto.Description;
                subscription.subscriptionType = dto.subscriptionType;
                _db.Add(subscription);

                int result = await _db.SaveChangesAsync();
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Input Erorr");
            }
        }



        public async Task<int> CreatNewNews(CreateOrUpdateCompetaitionNews dto)
        {
            try
            {
                var comepaition= await _db.competaitions.FirstOrDefaultAsync(x=>x.Id==dto.CompaitionId);
                var team = await _db.teams.FirstOrDefaultAsync(x=>x.Id==dto.TeamId);
                if (comepaition == null|| team== null)
                {
                    
                    throw new  Exception();
                }
                var news = new News();
                news.Title = dto.Title;
                news.Description = dto.Description;
                news.VedeoPath = dto.VedeoPath;
                news.countries = dto.countries;
                news.continent = dto.continent;
                news.PublishTime = dto.PublishTime;
                news.ImagePath = dto.ImagePath;
                news.IsImportant = dto.IsImportant;
                news.Content = dto.Content;
                news.sports = dto.sports;
                news.Competaition = comepaition;
                _db.Add(news);
                var teamNews= new TeamNews();
                teamNews.Team = team;
                teamNews.News = news;
                _db.Add(teamNews);




                int result = await _db.SaveChangesAsync();
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Competition or team  not found");
            }
        }


        public async Task<int> DeleteMach(int id)
        {
            if (_db.matches.Any(x => x.Id == id))
            {
                var result = _db.matches.Find(id);
                _db.Remove(result);
                var x = await _db.SaveChangesAsync();
                return x;
            }
            throw new KeyNotFoundException("not found match to remove");

        }

        public async Task<int> DeleteSubscription(int id)
        {
            if (_db.subscriptions.Any(x => x.Id == id))
            {
                var result = _db.matches.Find(id);
                _db.Remove(result);
                var x = await _db.SaveChangesAsync();
                return x;
            }
            throw new KeyNotFoundException("not found match to remove");


        }



        public async Task<List<GetAllSubscribersDTO>> GetAllSubscribers()
        {
            try
            {
                var subscribers = await (from User in _db.users
                                         join UserSubscription in _db.userSubscriptions on User.Id equals UserSubscription.User.Id
                                         join Subscription in _db.subscriptions on UserSubscription.Subscription.Id equals Subscription.Id
                                         select new GetAllSubscribersDTO
                                         {
                                             Id = Subscription.Id,
                                             subscriptionType = Subscription.subscriptionType,
                                             UserName = User.Name,

                                         }).ToArrayAsync();
                var result = subscribers.ToList();
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Input erorr");
            }

        }

        public async Task<List<GetSubscrberById>> GetSubscribersById(int id)
        {
            var subscribers = await (from User in _db.users.Where(x => x.Id == id)
                                     join UserSubscription in _db.userSubscriptions on User.Id equals UserSubscription.User.Id
                                     join Subscription in _db.subscriptions on UserSubscription.Subscription.Id equals Subscription.Id
                                     select new GetSubscrberById
                                     {
                                         Id = Subscription.Id,
                                         subscriptionType = Subscription.subscriptionType,
                                         Name = User.Name,
                                         Email = User.Email,
                                         Description = Subscription.Description,
                                         Price = Subscription.Price,

                                     }).ToArrayAsync();
            var result = new List<GetSubscrberById>();
            result = subscribers.ToList();
            return result;
        }

        public async Task<int> Login(LoginDTO dto)
        {
            try
            {
                var login = await _db.admins.FirstOrDefaultAsync(x => x.Email == dto.UserName && x.Password == dto.Password);

                if (login == null)
                {
                    return 0;
                }
                else
                {
                    return login.Id;
                }
            }
            catch (Exception ex)
            {
                {
                    throw new Exception(ex.Message);
                }
            }
        }
        public async Task<int> UpdateMach(UpdateMatchDTO dto)
        {
            try
            {
                var match = await _db.matches.FindAsync(dto.Id);

                if (match == null)
                {
                    throw new Exception("Match not found.");
                }

                match.StadiumName = dto.StadiumName;
                match.IsImportant = dto.IsImportant;
                match.RefereeName = dto.RefereeName;

                _db.matches.Update(match);
                int record = await _db.SaveChangesAsync();
                return record;
            }
            catch (Exception ex)
            {
                { throw new Exception(ex.Message); }

            }
        }
        public async Task<int> UpdateSubscription(CreateOrUpdateSupscriptionDTO dto)
        {
            try
            {
                var subscription = await _db.subscriptions.FindAsync(dto.Id);

                if (subscription == null)
                {
                    throw new Exception("Subscription not found.");
                }

                subscription.subscriptionType = dto.subscriptionType;
                subscription.Price = dto.Price;
                subscription.Description = dto.Description;

                _db.subscriptions.Update(subscription);
                int record = await _db.SaveChangesAsync();
                return record;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

