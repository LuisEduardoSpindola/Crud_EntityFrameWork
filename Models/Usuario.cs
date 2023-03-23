using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exercicio_Crud.Models
{

    [Table("Usuarios")]

    public class Usuario
    {
        [Column("id")]
        [Display(Name = "ID")]
        public long Id { get; set; }

        [Column("nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("email")]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
