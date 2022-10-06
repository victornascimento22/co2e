using AutoMapper;
using co2e.DataObjectTransfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace co2e.Mapper
{
    public class ConstituentGasesMappingProfile : Profile
    {

        public ConstituentGasesMappingProfile()
        {
            //origem >> destino
            CreateMap<ConstituentGasesDTO, ConstituentGasesMapper>()
            .ForMember(dest => dest.co2e_total, map => map.MapFrom(src => src.co2e_total))
            .ForMember(dest => dest.co2e_other, map => map.MapFrom(src => src.co2e_other))
            .ForMember(dest => dest.co2, map => map.MapFrom(src => src.co2))
            .ForMember(dest => dest.ch4, map => map.MapFrom(src => src.ch4))
            .ForMember(dest => dest.n2o, map => map.MapFrom(src => src.n2o))
            .ReverseMap();


        }


    }
}
