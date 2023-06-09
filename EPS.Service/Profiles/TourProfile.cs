﻿using AutoMapper;
using EPS.Data.Entities;
using EPS.Service.Dtos.ImageBlog;
using EPS.Service.Dtos.Tour;
using EPS.Service.Dtos.TourDetail;
using System.Globalization;

namespace EPS.Service.Profiles
{
    public class TourProfileDtoToEntity : Profile
    {
        public TourProfileDtoToEntity()
        {
            CreateMap<TourCreateDto, tour>();
            CreateMap<TourUpdateDto, tour>();
            CreateMap<DetailTourCreateDto, detail_tour>();
            CreateMap<DetailTourUpdateDto, detail_tour>();
            CreateMap<ImageCreateDto, image>();
        }
    }

    public class TourProfileEntityToDto : Profile
    {
        public TourProfileEntityToDto()
        {
            CreateMap<tour, TourGridDto>()
                .ForMember(dest => dest.created_timeStr, mo => mo.MapFrom(src => src.created_time.ToString("dd/M/yyyy", CultureInfo.InvariantCulture)))
                 .ForMember(dest => dest.updated_timeStr, mo => mo.MapFrom(src => src.updated_time.ToString("dd/M/yyyy", CultureInfo.InvariantCulture)))
                 .ForMember(dest => dest.background_image, mo => mo.MapFrom(src => "http://192.168.1.3:5001/uploads/" + src.background_image));

            CreateMap<detail_tour, TourDetailDto>();

            CreateMap<tour, TourDetailDto>()
                           .ForMember(dest => dest.created_timeStr, mo => mo.MapFrom(src => src.created_time.ToString("dd/M/yyyy", CultureInfo.InvariantCulture)))
                            .ForMember(dest => dest.updated_timeStr, mo => mo.MapFrom(src => src.updated_time.ToString("dd/M/yyyy", CultureInfo.InvariantCulture)));

        }
    }
}
