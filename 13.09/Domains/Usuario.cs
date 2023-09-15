using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mail;

namespace _13._09.Domains
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public Guid IdUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Email obrigatorio!")]
        public string? Email { get; set; }

        [Column(TypeName = "VARCHAR(60)")]
        [Required(ErrorMessage = "senha obrigatoria!")]
        [StringLength(60,MinimumLength =6, ErrorMessage = "Senha de 6 a 60 caracteres!")]
        public string? Senha { get; set; }

        //ref tabela TipoUsuario
        [Required(ErrorMessage ="Tipo do usuario obrigatorio!")]
        public Guid IdTipoUsuario { get; set; }

        [ForeignKey("IdTipoUsuario")]
        public TiposUsuario? TiposUsuario { get; set; }
    }
}
