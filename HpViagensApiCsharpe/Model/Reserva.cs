using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace HpViagensApiCsharpe.Model
{
    [Table("Reserva")]
    public class Reserva
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "DATE")]
        public DateTime? DataReserva { get; set; }

        public int? ClienteId {  get; set; }
        public int? ViagemId { get; set; }
        public int? PagamentoId { get; set; }

        [JsonIgnore]       
        public Cliente? Cliente { get; set; }
        [JsonIgnore]
        public Viagem? Viagem { get; set; }
        [JsonIgnore]
        public Pagamento? Pagamento { get; set; }

    }
}
