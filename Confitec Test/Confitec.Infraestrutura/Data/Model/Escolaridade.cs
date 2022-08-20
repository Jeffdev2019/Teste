using Confitec.Infraestrutura.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confitec.Infraestrutura.Data.Model
{
    [Table("TbEscolaridade")]
    public class Escolaridade : BaseEntity
    {
        [Required]
        [StringLength(50)]
        public string Descricao { get; set; }
        [Required]
        public List<Usuario> Usuario { get; set; }

    }
}
