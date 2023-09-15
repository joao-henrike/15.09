﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _13._09.Domains
{
    [Table("Estudio")]
    public class Estudio

    {
        [Key]
        public Guid IdEstudio { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage ="Nome obrigatorio!")]

        public string? Nome { get; set; }

        //ref.lista de jogos
        public List<Jogo>? Jogo { get; set; }
    }
}
