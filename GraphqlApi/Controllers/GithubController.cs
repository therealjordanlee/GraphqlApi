using System.Threading.Tasks;
using GraphqlApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace GraphqlApi.Controllers
{
    [Route("/")]
    public class GithubController : Controller
    {
        private IGithubService _githubService;
        public GithubController(IGithubService githubService)
        {
            _githubService = githubService;
        }
        
        [HttpGet("user")]
        public async Task<IActionResult> GetGithubUserAsync([FromQuery]string login)
        {
            var user = await _githubService.GetUserAsync(login);
            return Ok(user);
        }

        [HttpGet("org")]
        public async Task<IActionResult> GetOrganisationAsync([FromQuery] string orgname)
        {
            var organization = await _githubService.GetRepositoryAsync(orgname);
            return Ok(organization);
        }
    }
}