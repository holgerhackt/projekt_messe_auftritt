using AutoMapper;
using Models.DTOs;
namespace Models;


public class AutoMapperProfile: Profile
{
    public AutoMapperProfile()
    {
        CreateMap<User, UserDto>()
            .ForMember(dst => dst.AddressId, opt => opt.Ignore())
            .ForMember(dst => dst.Address, opt => opt.MapFrom(src => src.Address))
            .ForMember(dst => dst.Interests, opt => opt.MapFrom(src => src.Interests.Select(i => i.Id)));
        CreateMap<UserDto, User>()
            .ForMember(dst => dst.Interests, opt => opt.Ignore()); //Because of manual mapping
        
        CreateMap<Address, AddressDto>();
        CreateMap<AddressDto, Address>();

        CreateMap<Company, CompanyDto>();
        CreateMap<CompanyDto, Company>();
    }
}

public class AutoMapperConfiguration
{
    public static IMapper Configure()
    {
        var mapperConfiguration = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile<AutoMapperProfile>();
        });

        return mapperConfiguration.CreateMapper();
    }
}

