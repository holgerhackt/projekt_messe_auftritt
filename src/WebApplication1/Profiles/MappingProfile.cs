using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using WebApplication1.Models;
using WebApplication1.DTOs;

namespace WebApplication1.Profiles;

    
public class MappingProfile:Profile
{
    public MappingProfile()
    {
        //For the GET endpoints
        CreateMap<User, ReturnUserDto>()
            .ForMember(dto => dto.Interests, opt => opt.MapFrom(src => src.UserInterests.Select(ui => ui.Interest))); // It is very important to use the select statement here, because otherwise the whole UserInterest object will be mapped to the InterestDto, which is not what we want.
        CreateMap<Interest, InterestDto>();

        //For the POST endpoint
        CreateMap<AddressDto, Address>();
        CreateMap<CreateUserDto, User>()
            .ForMember(u => u.Address, opt => opt.MapFrom(dto => dto.Address))
            .ForMember(dest => dest.UserInterests,
                opt => opt.Ignore()); // Ignorieren, da es eine benutzerdefinierte Operation ist
        
    }
}