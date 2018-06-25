using AutoMapper;
using CMCVirtual.Core.TO;
using CMCVirtual.Extensions;

namespace CMCVirtual.Mappers
{
    internal static class DomainToModelMapping
    {
        public static void ApplyMapping(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Domain.Host, HostTO>()
               .ForMember(dst => dst.Name, opt => opt.MapFrom(src => src.HostName))
               .ForMember(dst => dst.Number, opt => opt.MapFrom(src => src.HostId));

            cfg.CreateMap<Domain.Station, StationTO>();

            cfg.CreateMap<Domain.Station, LoginTO>()
               .ForMember(dst => dst.StationName, opt => opt.MapFrom(src => src.Name))
               .ForMember(dst => dst.StationNumber, opt => opt.MapFrom(src => src.Number));

            cfg.CreateMap<Domain.Step, StepTO>()
               .ForPath(dst => dst.Data.Name  , opt => opt.MapFrom(src => src.Param))
               .ForPath(dst => dst.Data.Prompt, opt => opt.MapFrom(src => src.CodeBig5));

            cfg.CreateMap<Domain.Procedure, ProcedureTO>();

            cfg.CreateMap<Domain.ProcedureParameter, ProcedureParameterTO>()
               .ForMember(dst => dst.Direction, opt => opt.MapFrom(src => src.Direction.ToParameterDirection()))
               .ForMember(dst => dst.Type, opt => opt.MapFrom(src => src.Type.ToParameterType()));
        }
    }
}
