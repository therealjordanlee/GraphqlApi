using GraphqlApi.Models;
using GraphQL.Types;

namespace GraphqlApi.GraphqlTypes
{
    public class GithubUserType : ObjectGraphType<GithubUser>
    {
        public GithubUserType()
        {
            Name = "GithubUser";

            Field(x => x.Login).Description("The login of the user");
            Field(x => x.Name).Description("The name of the user");
            Field(x => x.Url).Description("The Url of the user");
            Field(x => x.Suspended).Description("Is the user account suspended");
        }
    }
}