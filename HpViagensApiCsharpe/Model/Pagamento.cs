using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HpViagensApiCsharpe.Model
{
    [Table("Pagamento")]
    public class Pagamento
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "DATE")]
        public DateTime? DataPagamento {  get; set; }

        [Required]
        public decimal? ValorPag {  get; set; }

        [Required]
        public string? FormaPag {  get; set; }

        [Required]
        public int? Parcela {  get; set; }
    }
}
