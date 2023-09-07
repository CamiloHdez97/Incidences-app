using ApiIncidences.Dtos;
using Domain;
using AutoMapper;

namespace ApiIncidences.Profiles;

    public class MappingPofiles : Profile
    {
      public MappingPofiles(){
        CreateMap<Country, CountryDto>().ReverseMap().ForMember(o => o.Regions,d => d.Ignore());
        CreateMap<Region, RegionDto>().ReverseMap().ForMember(i => i.Cities,d => d.Ignore());
        CreateMap<City, CityDto>().ReverseMap();
        CreateMap<Person, PersonDto>().ReverseMap();
        CreateMap<Incidence, IncidenceDto>().ReverseMap();

        // CreateMap<Person, PersonxIncidenceDto>().ReverseMap();
        // CreateMap<Region, RegionxCityDto>().ReverseMap();
        // CreateMap<Country, CountryXRegDto>().ReverseMap();
      }
    }
