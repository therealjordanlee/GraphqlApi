using AutoMapper;
using GraphiQl;
using GraphqlApi.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Octokit;

namespace GraphqlApi
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper();
            services.AddMvc();
            services.AddScoped<IGithubService, GithubService>();
            services.AddSingleton<IGitHubClient>(new GitHubClient(new ProductHeaderValue("GraphqlApi")));
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
            app.UseGraphiQl("/graphql");
        }
    }
}