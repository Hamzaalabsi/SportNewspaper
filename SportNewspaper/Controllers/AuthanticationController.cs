using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SportNewspeper_core.DTO.Login;
using SportNewspeper_core.IService;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SportNewspaper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthanticationController : ControllerBase
    {
        private readonly IAdminServiceInterface _Service;
        private readonly IUserServiceInterface _UserService;
        public AuthanticationController(IUserServiceInterface userService, IAdminServiceInterface service)
        {
            _UserService = userService;
            _Service = service;
        }


        [HttpPost]
        [Route("[Action]")]
        public async Task<IActionResult> Login(LoginDTO dto)
        {
            var Admin = await _Service.Login(dto);
            var user = await _UserService.UserLogin(dto);
            if (Admin > 0 || user > 0)
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenKey = Encoding.UTF8.GetBytes("xcvbnl[poiuytrewdfghjkp.,mnbgfredhjiop[';liuytrfghjkp[");
                if (user > 0)
                {
                    var tokenDescriptior = new SecurityTokenDescriptor
                    {

                        Subject = new ClaimsIdentity(new Claim[]
                             {

                                   new Claim("UserId", user.ToString()) ,
                                     new Claim("UserType","User")

                             }),
                        Expires = DateTime.Now.AddMinutes(120),
                        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey),
                    SecurityAlgorithms.HmacSha256Signature)
                    };
                    var token = tokenHandler.CreateToken(tokenDescriptior);
                    return Ok(tokenHandler.WriteToken(token));

                }
                else
                {
                    var tokenDescriptior = new SecurityTokenDescriptor
                    {

                        Subject = new ClaimsIdentity(new Claim[]
                        {

                            new Claim("UserId", Admin.ToString()) ,
                            new Claim("UserType","Admin")

                        }),
                        Expires = DateTime.Now.AddMinutes(120),
                        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey)
                        , SecurityAlgorithms.HmacSha256Signature)
                    };
                    var token = tokenHandler.CreateToken(tokenDescriptior);
                    return Ok(tokenHandler.WriteToken(token));
                }
                    
            }
            else
            {
                return Unauthorized("invalid tokin");
            }
        }
    }
}
