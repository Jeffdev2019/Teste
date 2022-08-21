using Confitec.WebAPI.Infra.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confitec.WebAPI.Aplication.ValueObjects
{
    public class UsuarioVO
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public int HistoricoEscolarId { get; set; }
        public HistoricoEscolarVO HistoricoEscolar { get; set; }
        public int EscolaridadeId { get; set; }
        public EscolaridadeVO Escolaridade { get; set; }
    }
}
