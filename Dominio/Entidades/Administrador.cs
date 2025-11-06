using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace minimal_api.Dominio.Entidades
{
    public class Administrador
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Nome { get; set; } = default!;

        [Required]
        [MaxLength(255)]
        public string Email { get; set; } = default!;

        [Required]
        public string Senha { get; set; } = default!;
        [Required]
         public string Perfil { get; set; } = default!;
    }
}

