using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HpViagensApiCsharpe.Model
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string? Nome { get; set; }

        [Required]
        [StringLength(14)]
        public string? Cpf { get; set; }

        [Required]
        public string? Sexo { get; set; }

        [Required]
        [Column(TypeName = "DATE")]
        public DateTime? DataNascimento { get; set; }

        [Required]
        public string? Telefone { get; set; }

        [Required]
        public string? Email { get; set;}

        [Required]
        public string? Senha { get; set; }
    }
}
