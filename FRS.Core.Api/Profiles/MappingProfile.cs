using AutoMapper;
using FRS.Core.Api.Dtos;
using FRS.Core.Domain.Entities;

namespace FRS.Core.Api.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Lpmaster, SubjectDto>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Requestor, opt => opt.MapFrom(src => src.Requestor))
            .ForMember(dest => dest.Reference, opt => opt.MapFrom(src => src.Reference))
            .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Sexrace))
            .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.Fname))
            .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.Lname))
            .ForMember(dest => dest.MiddleName, opt => opt.MapFrom(src => src.Mname))
            .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.City))
            .ForMember(dest => dest.State, opt => opt.MapFrom(src => src.State))
            .ForMember(dest => dest.Zip, opt => opt.MapFrom(src => src.Zip))
            .ForMember(dest => dest.RecDate, opt => opt.MapFrom(src => src.RecDate))
            .ForMember(dest => dest.Ssno, opt => opt.MapFrom(src => src.Ssno))
            .ForMember(dest => dest.County, opt => opt.MapFrom(src => src.County1))
            .ForMember(dest => dest.Client, opt => opt.MapFrom(src => src.CompCode))
            .ForMember(dest => dest.Aka, opt => opt.MapFrom(src => src.Aka));
        }
    }
}
