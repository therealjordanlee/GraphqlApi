using AutoMapper;
using GraphqlApi.Models;
using Octokit;

namespace GraphqlApi.MapperProfiles
{
    public class GithubUserProfile : Profile
    {
        public GithubUserProfile()
        {
            CreateMap<User, GithubUser>()
                .ForMember(dest => dest.Login, opt => opt.MapFrom((x) => x.Login))
                .ForMember(dest => dest.Url, opt => opt.MapFrom((x) => x.Url))
                .ForMember(dest => dest.Name, opt => opt.MapFrom((x) => x.Name))
                .ForMember(dest => dest.Suspended, opt => opt.MapFrom((x) => x.Suspended));
        }
    }
}