using Microsoft.AspNetCore.Mvc;
using SportNewspeper_core.DTO.Registration;
using SportNewspeper_core.IRepo;

namespace SportNewspaper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserReposInterface _service;
        public UserController(IUserReposInterface service)
        {
            _service = service;
        }
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> Subscribe(UserRegistrationDTO dto)
        {
            var result = await _service.Subscribe(dto);
            return Ok("Created Subscription Successfully");
        }
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> Unsubscribe(int Id)
        {
            var result = await _service.Unsubscribe(Id);
            return Ok("Remove Subscription Successfully");
        }
    }
}
