using System;
using System.ComponentModel.DataAnnotations;

namespace LostPeople.Models
{
    public class LoginVM
    {
        [Required(ErrorMessage = "O {0} é obrigatorio"), StringLength(50, ErrorMessage ="O Limite de {0} é {1} ")]
        public String Senha { get; set; }
        [Required(ErrorMessage = "O {0} é obrigatorio"), StringLength(50)]
        public String Email { get; set; }
        public bool Logado { get; set; }
        public String ReturnUrl { get; set; }
    }
}
