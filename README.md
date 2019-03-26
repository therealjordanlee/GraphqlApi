# Graphql API
An asp.net core API which queries the GithubAPI and makes the data available through Graphql.

This uses the awesome [graphql-dotnet](https://github.com/graphql-dotnet/graphql-dotnet) package as the graphql server.

## Usage
If running locally, browse to https://localhost:5001/graphql/

__Sample Query:__

```
query JordanQuery($login: String, $orgname:String) {
  githublogin(login: $login) {
    login
    url
  }
  githubOrganizationName(githubOrganizationName: $orgname){
    id
    url
  }
}
```

__Variables__
```
{
  "login": "therealjordanlee",
  "orgname": "Microsoft"
}
```
