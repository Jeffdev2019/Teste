using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Confitec.WebAPI.Infra.Data.Model
{
    [Table("TbEscolaridade")]
    public class Escolaridade     
    {
        [Key]
        public int IdEscolaridade { get; set; }
        [Required]
        [StringLength(50)]
        public string Descricao { get; set; }
        [Required]
        public List<Usuario> Usuarios { get; set; }

    }
}
