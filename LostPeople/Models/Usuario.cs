using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LostPeople.Models
{
    //[Table(nameof(Usuario))]
    public class Usuario
    {
        [Key]
        public int id { get; set; }
        [Required, Column(TypeName = "varchar"), StringLength(100)]
        public String Email { get; set; }
        [Required, Column(TypeName = "varchar"), StringLength(100)]
        public String Senha { get; set; }
        [Required, Column(TypeName = "varchar"), StringLength(100)]
        public String Nome { get; set; }

    }
}
