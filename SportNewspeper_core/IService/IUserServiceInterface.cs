using SportNewspeper_core.DTO.Login;
using SportNewspeper_core.DTO.Registration;
using SportNewspeper_core.DTO.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportNewspeper_core.IService
{
    public interface IUserServiceInterface
    {
        public Task<int> UserLogin(LoginDTO dTO);
        Task<int> Subscribe (UserRegistrationDTO dto);

        Task<int> Unsubscribe (int Id );
    }
}
