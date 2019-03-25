using System;
using GraphqlApi.GraphqlTypes;
using GraphqlApi.Models;
using GraphqlApi.Services;
using GraphQL.Types;

namespace GraphqlApi.Queries
{
    public class GithubUserQuery : ObjectGraphType
    {
        public GithubUserQuery(IGithubService githubService)
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
        }
    }
}