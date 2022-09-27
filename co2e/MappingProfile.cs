﻿using AutoMapper;
using co2e.DataObjectTransfer;
using co2e.Models;
using co2e.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace co2e
{
    public class MappingProfile : Profile
    {

        public MappingProfile()
        {
             
            //origem >>>> destino
            CreateMap<ApiClimatiqDTO, ApiResponseMapper>()
            .ForMember(dest => dest.Co2e, map => map.MapFrom(src => src.Co2e))
            .ForMember(dest => dest.Co2eCalculationMethod, map => map.MapFrom(src => src.Co2eCalculationMethod))
            .ForMember(dest => dest.Co2eCalculationOrigin, map => map.MapFrom(src => src.Co2eCalculationOrigin))
            .ForMember(dest => dest.Co2eUnit, map => map.MapFrom(src => src.Co2eUnit))
            .ForMember(dest => dest.ConstituentGases, map => map.MapFrom(src => src.ConstituentGases))
            .ForMember(dest => dest.EmissionFactor, map => map.MapFrom(src => src.EmissionFactor))
            .ReverseMap();

        }

    }
}
