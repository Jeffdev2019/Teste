using AutoMapper;
using Confitec.WebAPI.Aplication.ValueObjects;
using Confitec.WebAPI.Infra.Data.Model;


namespace Confitec.WebAPI.Aplication.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<UsuarioVO, Usuario>();
                config.CreateMap<Usuario, UsuarioVO>();
                config.CreateMap<EscolaridadeVO, Escolaridade>();
                config.CreateMap<Escolaridade, EscolaridadeVO>();
                config.CreateMap<HistoricoEscolarVO, HistoricoEscolar>();
                config.CreateMap<HistoricoEscolar, HistoricoEscolarVO>();
            });
            return mappingConfig;
        }

    }
}
