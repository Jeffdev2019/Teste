using Confitec.WebAPI.Infra.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confitec.WebAPI.Infra.Data.Model
{
    [Table("TbHistoricoEscolar")]
    public class HistoricoEscolar : BaseEntity
    {
        [Required]
        [StringLength(15)]
        public string Formato { get; set; }
        [Required]
        [StringLength(50)]
        public string Nome { get; set; }
        [Required]
        public List<Usuario> Usuario { get; set; }
    }
}
