using AutoMapper;

namespace CMCVirtual.Mappers
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(cfg =>
            {
                DomainToModelMapping.ApplyMapping(cfg);
                ModelToDomainMapping.ApplyMapping(cfg);
                ModelToModelMapping.ApplyMapping(cfg);
            });
        }
    }
}
