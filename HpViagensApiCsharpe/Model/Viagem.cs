using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HpViagensApiCsharpe.Model
{
    [Table("Viagem")]
    public class Viagem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Origem { get; set; }

        [Required]
        public string? Destino { get; set; }

        [Required]
        [Column(TypeName = "DATE")]
        public DateTime? DataIda { get; set; }

        [Required]
        [Column(TypeName = "DATE")]
        public DateTime? DataVolta { get; set; }
    }
}
