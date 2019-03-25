using System.Threading.Tasks;
using GraphqlApi.Models;
using Octokit;

namespace GraphqlApi.Services
{
    public interface IGithubService
    {
        Task<GithubUser> GetUserAsync(string login);
        Task<GithubOrganization> GetRepositoryAsync(string orgName);
    }
}