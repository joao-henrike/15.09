using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _13._09.Domains
{
    [Table("Jogo")]
    public class Jogo
    {
        [Key]
        public Guid IdJogo { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Nome do jogo obrigatorio"!)]

        public string? Nome { get; set; }

        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "Data de lançamento do jogo obrigatoria!")]

        public DateTime Datalancamento { get; set; }

        [Column(TypeName = "DECIMAL(4,2)")]
        [Required(ErrorMessage = "Preço do jogo obrigatorio!")]

        public decimal preco { get; set; }

        //ref.tabela estudio {get;set;}
        public Guid IdEstudio { get; set; }

        [ForeignKey("IdEstudio")]
        public Estudio? Estudio { get; set; }
    }
}