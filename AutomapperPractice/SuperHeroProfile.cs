using AutoMapper;

namespace AutomapperPractice
{
    public class SuperHeroProfile : Profile
    {
        public SuperHeroProfile()
        {
            CreateMap<SuperHero, SuperHeroDto>();
            CreateMap<SuperHeroDto, SuperHero>();
        }
    }
}
