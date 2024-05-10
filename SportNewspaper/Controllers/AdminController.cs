using Microsoft.AspNetCore.Mvc;
using SportNewspeper_core.DTO.Match;
using SportNewspeper_core.DTO.News;
using SportNewspeper_core.DTO.Subscription;
using SportNewspeper_core.IService;
using System.IdentityModel.Tokens.Jwt;

namespace SportNewspaper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminServiceInterface _service;
        public AdminController(IAdminServiceInterface service)
        {
            _service = service;
        }
      

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateMach(CreateOrUpdateMatchDTO dto, string token)
        {
            
            String toke = "Bearer " + token;
            var jwtEncodedString = toke.Substring(7);
            var tokendec = new JwtSecurityToken(jwtEncodedString: jwtEncodedString);

            DateTime dateTime = DateTime.UtcNow;
            DateTime expires = tokendec.ValidTo;
            string userRole = tokendec.Claims.FirstOrDefault(c => c.Type == "UserType")?.Value;

            if (expires <= dateTime || userRole != "Admin")
            {
                return Unauthorized("Invalid  token");
            }
            else
            {
                var result = await _service.CreateMach(dto);
                return Ok(result);
            }

        }
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateMach(UpdateMatchDTO dto,string token)
        {

            String toke = "Bearer " + token;
            var jwtEncodedString = toke.Substring(7);
            var tokendec = new JwtSecurityToken(jwtEncodedString: jwtEncodedString);

            DateTime dateTime = DateTime.UtcNow;
            DateTime expires = tokendec.ValidTo;
            string userRole = tokendec.Claims.FirstOrDefault(c => c.Type == "UserType")?.Value;

            if (expires <= dateTime || userRole != "Admin")
            {
                return Unauthorized("Invalid  token");
            }
            else
            {
                var result = await _service.UpdateMach(dto);
                if (result > 0)
                {
                    return Ok(result);
                }
                else return NotFound("Input erorr");
            }
        }
        [HttpDelete]
        [Route("[action]")]
        public async Task<IActionResult> DeleteMach(int id ,string token)
        {

            String toke = "Bearer " + token;
            var jwtEncodedString = toke.Substring(7);
            var tokendec = new JwtSecurityToken(jwtEncodedString: jwtEncodedString);

            DateTime dateTime = DateTime.UtcNow;
            DateTime expires = tokendec.ValidTo;
            string userRole = tokendec.Claims.FirstOrDefault(c => c.Type == "UserType")?.Value;

            if (expires <= dateTime || userRole != "Admin")
            {
                return Unauthorized("Invalid  token");
            }
            else
            {
                var result = await _service.DeleteMach(id);
                return Ok("Delete Match successfully");
            }
        }
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateSubscription(CreateOrUpdateSupscriptionDTO dto, string token)
        {

            String toke = "Bearer " + token;
            var jwtEncodedString = toke.Substring(7);
            var tokendec = new JwtSecurityToken(jwtEncodedString: jwtEncodedString);

            DateTime dateTime = DateTime.UtcNow;
            DateTime expires = tokendec.ValidTo;
            string userRole = tokendec.Claims.FirstOrDefault(c => c.Type == "UserType")?.Value;

            if (expires <= dateTime || userRole != "Admin")
            {
                return Unauthorized("Invalid  token");
            }
            else
            {
                var result = await _service.CreateSubscription(dto);
                return Ok("create new supscription successfully");
            }
        }
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreatNewNews(CreateOrUpdateCompetaitionNews dto, string token)
        {

            String toke = "Bearer " + token;
            var jwtEncodedString = toke.Substring(7);
            var tokendec = new JwtSecurityToken(jwtEncodedString: jwtEncodedString);

            DateTime dateTime = DateTime.UtcNow;
            DateTime expires = tokendec.ValidTo;
            string userRole = tokendec.Claims.FirstOrDefault(c => c.Type == "UserType")?.Value;

            if (expires <= dateTime || userRole != "Admin")
            {
                return Unauthorized("Invalid  token");
            }
            else
            {
                var result = await _service.CreatNewNews(dto);
                return Ok("create new News successfully");
            }
        }
        [HttpDelete]
        [Route("[action]")]
        public async Task<IActionResult> DeleteSubscription(int id, string token)
        {

            String toke = "Bearer " + token;
            var jwtEncodedString = toke.Substring(7);
            var tokendec = new JwtSecurityToken(jwtEncodedString: jwtEncodedString);

            DateTime dateTime = DateTime.UtcNow;
            DateTime expires = tokendec.ValidTo;
            string userRole = tokendec.Claims.FirstOrDefault(c => c.Type == "UserType")?.Value;

            if (expires <= dateTime || userRole != "Admin")
            {
                return Unauthorized("Invalid  token");
            }
            else
            {
                var result = await _service.DeleteSubscription(id);
                return Ok("Delete  successfully");
            }
        }
        [HttpGet]
        [Route("[Action]")]
        public async Task<IActionResult> GetAllSubscribers( string token)

        {

            String toke = "Bearer " + token;
            var jwtEncodedString = toke.Substring(7);
            var tokendec = new JwtSecurityToken(jwtEncodedString: jwtEncodedString);

            DateTime dateTime = DateTime.UtcNow;
            DateTime expires = tokendec.ValidTo;
            string userRole = tokendec.Claims.FirstOrDefault(c => c.Type == "UserType")?.Value;

            if (expires <= dateTime || userRole != "Admin")
            {
                return Unauthorized("Invalid  token");
            }
            else
            {
                var result = await _service.GetAllSubscribers();
                return Ok(result);
            }
        }
        [HttpGet]
        [Route("[Action]")]
        public async Task<IActionResult> GetSubscribersById(int id, string token)
        {

            String toke = "Bearer " + token;
            var jwtEncodedString = toke.Substring(7);
            var tokendec = new JwtSecurityToken(jwtEncodedString: jwtEncodedString);

            DateTime dateTime = DateTime.UtcNow;
            DateTime expires = tokendec.ValidTo;
            string userRole = tokendec.Claims.FirstOrDefault(c => c.Type == "UserType")?.Value;

            if (expires <= dateTime || userRole != "Admin")
            {
                return Unauthorized("Invalid  token");
            }
            else
            {
                var result = await _service.GetSubscribersById(id);
                return Ok(result);
            }
        }
        [HttpPut]
        [Route("[Action]")]
        public async Task<IActionResult> UpdateSubscription(CreateOrUpdateSupscriptionDTO dto, string token)
        {

            String toke = "Bearer " + token;
            var jwtEncodedString = toke.Substring(7);
            var tokendec = new JwtSecurityToken(jwtEncodedString: jwtEncodedString);

            DateTime dateTime = DateTime.UtcNow;
            DateTime expires = tokendec.ValidTo;
            string userRole = tokendec.Claims.FirstOrDefault(c => c.Type == "UserType")?.Value;

            if (expires <= dateTime || userRole != "Admin")
            {
                return Unauthorized("Invalid  token");
            }
            else
            {
                var result = await _service.UpdateSubscription(dto);
                return Ok("Update New Subcription Successfolly");
            }
        }
    }
}
