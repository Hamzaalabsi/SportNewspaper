using Microsoft.AspNetCore.Mvc;
using SportNewspeper_core.IService;

namespace SportNewspaper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SharedController : ControllerBase
    {
        private readonly ISharedServiceInterface _service;
        public SharedController(ISharedServiceInterface service)
        {
            _service = service;
        }
        [HttpGet]
        [Route("[Action]")]
        public async Task<IActionResult> GetAllImportantNews()
        {
            var result = await _service.GetAllImportantNews();
            return Ok(result);
        }
        [HttpGet]
        [Route("[Action]")]
        public async Task<IActionResult> EuropeFootballNewsDetals(int Id)
        {
            var result = await _service.EuropeFootballNewsDetals(Id);

            return Ok(result);
        }
        [HttpGet]
        [Route("[Action]")]
        public async Task<IActionResult> GetAllEuropeFootballNews()
        {
            var result = await _service.GetAllEuropeFootballNews();
            return Ok(result);
        }
        [HttpGet]
        [Route("[Action]")]
        public async Task<IActionResult> GetAllFootballNews()
        {
            var result = await _service.GetAllFootballNews();
            return Ok(result);
        }
        [HttpGet]
        [Route("[Action]")]
        public async Task<IActionResult> FootballNewsDetals(int id)
        {
            var result = await _service.FootbalNewslDetals(id); ;
            return Ok(result);
        }
        [HttpGet]
        [Route("[Action]")]
        public async Task<IActionResult> getAllNews()
        {
            var result = await _service.getAllNews(); ;
            return Ok(result);
        }
        [HttpGet]
        [Route("[Action]")]
        public async Task<IActionResult> ImportantNewsDetals(int Id)
        {
            var result = await _service.ImportantNewsDetals(Id);
            return Ok(result);
        }
        [HttpGet]
        [Route("[Action]")]
        public async Task<IActionResult> GetAllFootballMatchs()
        {
            var result = await _service.GetAllFootballMatchs();
            return Ok(result);
        }
        [HttpGet]
        [Route("[Action]")]
        public async Task<IActionResult> FootballMatchDetals(int Id)
        {
            var result = await _service.FootballMatchDetals(Id);
            return Ok(result);
        }
       
        [HttpGet]
        [Route("[Action]")]
        public async Task<IActionResult> GetAllIportantMatch()
        {
            var result = await _service.GetAllFootballMatchs();
            return Ok(result);
        }
        [HttpGet]
        [Route("[Action]")]
        public async Task<IActionResult> IportantMatchDetals(int Id)
        {
            var result = await _service.IportantMatchDetals(Id);
            return Ok(result);
        }
        [HttpGet]
        [Route("[Action]")]
        public async Task<IActionResult> GetAllNewsByCompetaitionName(string CompetaitionName)
        {
            var result = await _service.GetAllNewsByCompetaitionName(CompetaitionName);
            return Ok(result);
        }
        [HttpGet]
        [Route("[Action]")]
        public async Task<IActionResult> GetAllNewsByTeamName(string teamName)
        {
            var result = await _service.GetAllNewsByTeamName(teamName);
            if (result == null)
            {
                return NotFound();
            }
            else { return Ok(result); }
            
        }



    }
}
