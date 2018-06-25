using AutoMapper;
using CMCVirtual.Core.TO;

namespace CMCVirtual.Mappers
{
    internal static class ModelToDomainMapping
    {
        public static void ApplyMapping(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<HostTO, Domain.Host>()
               .ForMember(dst => dst.HostName, opt => opt.MapFrom(src => src.Name))
               .ForMember(dst => dst.HostId, opt => opt.MapFrom(src => src.Number));

            cfg.CreateMap<StationTO, Domain.Station>();

            cfg.CreateMap<StepTO, Domain.Step>()
               .ForMember(dst => dst.Param, opt => opt.MapFrom(src => src.Data.Name))
               .ForMember(dst => dst.CodeBig5, opt => opt.MapFrom(src => src.Data.Prompt));

            cfg.CreateMap<ProcedureTO, Domain.Procedure>();

            cfg.CreateMap<ProcedureParameterTO, Domain.ProcedureParameter>();
        }
    }
}
