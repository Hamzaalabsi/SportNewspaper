using Microsoft.EntityFrameworkCore;
using SportNewspeper_core.Context;
using SportNewspeper_core.DTO.Login;
using SportNewspeper_core.DTO.Registration;
using SportNewspeper_core.IRepo;
using SportNewspeper_core.Models;

namespace SportNewspaper_Infra.ReposImplemantation
{
    public class UserRepos : IUserReposInterface

    {
        private readonly SportNewspaperDbContext _context;
        public UserRepos(SportNewspaperDbContext context)
        {
            _context = context;
        }


        public async Task<int> Subscribe(UserRegistrationDTO dto)
        {
            try
            {
                var subscriptionRecord = await _context.subscriptions.FirstOrDefaultAsync(x => x.Id == dto.SubscriptionId);

                if (subscriptionRecord == null)
                {
                    throw new Exception("Subscription not found.");
                }

                var user = new User();
                user.Name = dto.Name;
                user.Email = dto.Email;
                user.PhoneNumber = dto.PhoneNumber;
                user.Password = dto.Password;

                _context.Add(user);

                var userSubscription = new UserSubscription();
                userSubscription.User = user;
                userSubscription.Subscription = subscriptionRecord;
                userSubscription.CreationDate = dto.CreationDate;
                _context.Add(userSubscription);

                int result = await _context.SaveChangesAsync();
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }




        }

        public async Task<int> Unsubscribe(int Id)
        {
            try
            {
                var unsubscribe = await _context.users.FindAsync(Id);

                if (unsubscribe == null)
                {
                    throw new Exception("User not found.");
                }

                unsubscribe.IsActive = false;
                _context.Update(unsubscribe);

                int result = await _context.SaveChangesAsync();
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }


        }

        public async Task<int> UserLogin(LoginDTO dTO)
        {
            var user = await _context.users.FirstOrDefaultAsync(x => x.Password == dTO.Password && x.Email == dTO.UserName);

            if (user == null || user.IsActive == false)
            {
                return 0;
            }
            return user.Id;
        }
    }
}
