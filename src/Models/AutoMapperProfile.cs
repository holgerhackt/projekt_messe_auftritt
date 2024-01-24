using AutoMapper;
using Models.DTOs;

namespace Models;

public class AutoMapperProfile : Profile
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
        
        CreateMap<User, DataGridUser>()
            .ForMember(dst => dst.AddressId, opt => opt.MapFrom(src => src.Address != null ? src.Address.Id : (int?)null))
            .ForMember(dst => dst.Country, opt => opt.MapFrom(src => src.Address != null ? src.Address.Country : null))
            .ForMember(dst => dst.City, opt => opt.MapFrom(src => src.Address != null ? src.Address.City : null))
            .ForMember(dst => dst.PostalCode, opt => opt.MapFrom(src => src.Address != null ? src.Address.PostalCode : (int?)null))
            .ForMember(dst => dst.Street, opt => opt.MapFrom(src => src.Address != null ? src.Address.Street : null))
            .ForMember(dst => dst.HouseNumber, opt => opt.MapFrom(src => src.Address != null ? src.Address.HouseNumber : null))
            .ForMember(dst => dst.CompanyId, opt => opt.MapFrom(src => src.Company != null ? src.Company.Id : (int?)null))
            .ForMember(dst => dst.CompanyName, opt => opt.MapFrom(src => src.Company != null ? src.Company.Name : null))
            .ForMember(dst => dst.CompanyAddressId, opt => opt.MapFrom(src => src.Company != null && src.Company.Address != null ? src.Company.Address.Id : (int?)null))
            .ForMember(dst => dst.CompanyCountry, opt => opt.MapFrom(src => src.Company != null && src.Company.Address != null ? src.Company.Address.Country : null))
            .ForMember(dst => dst.CompanyCity, opt => opt.MapFrom(src => src.Company != null && src.Company.Address != null ? src.Company.Address.City : null))
            .ForMember(dst => dst.CompanyPostalCode, opt => opt.MapFrom(src => src.Company != null && src.Company.Address != null ? src.Company.Address.PostalCode : (int?)null))
            .ForMember(dst => dst.CompanyStreet, opt => opt.MapFrom(src => src.Company != null && src.Company.Address != null ? src.Company.Address.Street : null))
            .ForMember(dst => dst.CompanyHouseNumber, opt => opt.MapFrom(src => src.Company != null && src.Company.Address != null ? src.Company.Address.HouseNumber : null));

        CreateMap<DataGridUser, User>()
            .ForMember(dst => dst.Address, opt => opt.MapFrom(src => src.AddressId.HasValue ? new Address
            {
                Id = src.AddressId.Value,
                Country = src.Country,
                City = src.City,
                PostalCode = src.PostalCode,
                Street = src.Street,
                HouseNumber = src.HouseNumber
            } : null))
            .ForMember(dst => dst.Company, opt => opt.MapFrom(src => src.CompanyId.HasValue ? new Company
            {
                Id = src.CompanyId.Value,
                Name = src.CompanyName,
                Address = src.CompanyAddressId.HasValue ? new Address
                {
                    Id = src.CompanyAddressId.Value,
                    Country = src.CompanyCountry,
                    City = src.CompanyCity,
                    PostalCode = src.CompanyPostalCode,
                    Street = src.CompanyStreet,
                    HouseNumber = src.CompanyHouseNumber
                } : null
            } : null));
            }
        }

public class AutoMapperConfiguration
{
    public static IMapper Configure()
    {
        var mapperConfiguration = new MapperConfiguration(cfg => { cfg.AddProfile<AutoMapperProfile>(); });

        return mapperConfiguration.CreateMapper();
    }
}