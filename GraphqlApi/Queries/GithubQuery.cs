using System;
using GraphqlApi.GraphqlTypes;
using GraphqlApi.Models;
using GraphqlApi.Services;
using GraphQL.Types;

namespace GraphqlApi.Queries
{
    public class GithubQuery : ObjectGraphType
    {
        public GithubQuery(IGithubService githubService)
        {

            Field<GithubUserType>(
                name: "githublogin",
                arguments: new QueryArguments(
                    new QueryArgument<StringGraphType> { Name = "login" }),
                resolve: context =>
                {
                    var login = context.GetArgument<string>("login");
                    return githubService.GetUserAsync(login);
                }
            );
            
            Field<GithubOrganizationType>(
                name: "githubOrganizationName",
                arguments: new QueryArguments(new QueryArgument<StringGraphType> {Name = "githubOrganizationName"}),
                resolve: context =>
                {
                    var orgName = context.GetArgument<string>("githubOrganizationName");
                    return githubService.GetRepositoryAsync(orgName);
                }
            );
        }
    }
}