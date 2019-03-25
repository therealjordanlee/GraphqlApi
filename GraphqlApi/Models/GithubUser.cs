namespace GraphqlApi.Models
{
    public class GithubUser
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public bool Suspended { get; set; }
    }
}