using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confitec.WebAPI.Infra.Data.Model
{
    [Table("TbUsuario")]
    public class Usuario 
    {
        
        [Key]
        public int IdUsuario { get; set; }
        [Required]
        [StringLength(50)]
        public string Nome { get; set; }
        [Required]
        [StringLength(50)]
        public string SobreNome { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        [Required]
        public DateTime DataNascimento { get; set; }
        public int? EscolaridadeId { get; set; }
        public Escolaridade? Escolaridade { get; set; }
        public int? HistoricoEscolarId { get; set; }
        public HistoricoEscolar? Historico { get; set; }


    }
}
