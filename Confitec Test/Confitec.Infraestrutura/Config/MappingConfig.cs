using AutoMapper;
using Confitec.Infraestrutura.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confitec.Infraestrutura.Config
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
                config.CreateMap<HistoricoEscolaraVO, HistoricoEscolar>();
                config.CreateMap<HistoricoEscolar, HistoricoEscolaraVO>();
            });
            return mappingConfig;
        }

    }
}
