using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confitec.WebAPI.Aplication.ValueObjects
{
    public class HistoricoEscolarVO
    {
        public int IdHistoricoEscolar { get; set; }
        public string Formato { get; set; }
        public string Nome { get; set; }
        public string FileBase64 { get; set; }
    }
}
