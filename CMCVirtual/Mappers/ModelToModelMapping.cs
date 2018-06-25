using AutoMapper;
using CMCVirtual.Core.TO;

namespace CMCVirtual.Mappers
{
    internal static class ModelToModelMapping
    {
        public static void ApplyMapping(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<StationTO, LoginTO>()
               .ForMember(dst => dst.StationName  , opt => opt.MapFrom(src => src.Name))
               .ForMember(dst => dst.StationNumber, opt => opt.MapFrom(src => src.Number));

            cfg.CreateMap<ControllerResultTO, ControllerResultTO<LoginTO>>()
               .ForMember(dst => dst.Exception     , opt => opt.MapFrom(src => src.Exception     ))
               .ForMember(dst => dst.ExecuteMessage, opt => opt.MapFrom(src => src.ExecuteMessage))
               .ForMember(dst => dst.PromptMessage , opt => opt.MapFrom(src => src.PromptMessage ))
               .ForMember(dst => dst.Result        , opt => opt.MapFrom(src => src.Result        ));
        }
    }
}
