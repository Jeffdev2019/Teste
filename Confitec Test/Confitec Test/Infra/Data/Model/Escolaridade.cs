using Confitec.WebAPI.Infra.Data.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Confitec.WebAPI.Infra.Data.Model
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
