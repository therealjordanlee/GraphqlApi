using System.Threading.Tasks;
using AutoMapper;
using GraphqlApi.Models;
using Octokit;

namespace GraphqlApi.Services
{
    public class GithubService : IGithubService
    {
        private IGitHubClient _githubClient;
        private IMapper _mapper;
        
        public GithubService(IGitHubClient githubClient, IMapper mapper)
        {
            _githubClient = githubClient;
            _mapper = mapper;
        }

        public async Task<GithubUser> GetUserAsync(string login)
        {
            var githubUser = await _githubClient.User.Get(login);

            var githubUserResult = _mapper.Map<GithubUser>(githubUser);
            return githubUserResult;
        }

        public async Task<GithubOrganization> GetRepositoryAsync(string orgName)
        {
            var githubRepository = await _githubClient.Organization.Get(orgName);
            var githubRepositoryResult = _mapper.Map<GithubOrganization>(githubRepository);
            return githubRepositoryResult;
        }
    }
}