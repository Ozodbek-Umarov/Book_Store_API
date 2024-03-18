using Application.DTOs.AuthorDTOs;
using AutoMapper;
using Domain.Entities;

namespace Application.Common;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Author, AuthorDto>()
            .ForMember(dest => dest.ImagePath, opt => opt.MapFrom(src => src.ImageUrl))
            .ReverseMap();

    }
}
