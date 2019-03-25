using System.Threading.Tasks;
using GraphqlApi.Queries;
using GraphqlApi.Services;
using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Mvc;

namespace GraphqlApi.Controllers
{
    [Route("/graphql")]
    public class GraphQlController : Controller
    {
        private IGithubService _githubService;
        public GraphQlController(IGithubService githubService)
        {
            _githubService = githubService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] GraphQlQuery query)
        {
            var schema = new Schema {Query = new GithubUserQuery(_githubService)};
            var result = await new DocumentExecuter().ExecuteAsync(x =>
            {
                x.Schema = schema;
                x.Query = query.Query;
                x.Inputs = query.Variables;
            });
            if (result.Errors?.Count > 0)
            {
                return BadRequest();
            }

            return Ok(result);
        }
    }
}