using GraphqlApi.Models;
using GraphQL.Types;

namespace GraphqlApi.GraphqlTypes
{
    public class GithubOrganizationType : ObjectGraphType<GithubOrganization>
    {
        public GithubOrganizationType()
        {
            Name = "GithubOrganization";
            Field(x => x.Id).Description("The organization Id");
            Field(x => x.Url).Description("The organization Url");
            Field(x => x.Login).Description("The organization Login");
        }
    }
}