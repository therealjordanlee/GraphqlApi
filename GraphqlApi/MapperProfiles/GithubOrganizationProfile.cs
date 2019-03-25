using AutoMapper;
using GraphqlApi.Models;
using Octokit;

namespace GraphqlApi.MapperProfiles
{
    public class GithubOrganizationProfile : Profile
    {
        public GithubOrganizationProfile()
        {
            CreateMap<Organization, GithubOrganization>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom((x) => x.Id))
                .ForMember(dest => dest.Url, opt => opt.MapFrom((x) => x.Url))
                .ForMember(dest => dest.Login, opt => opt.MapFrom((x) => x.Login));
        }
    }
}