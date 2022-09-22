using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LostPeople.Models
{
    [Table("Perdidos")]
    public class Losted
    {
        
        public int Id { get; set; }
        [Required]
        public String Namme { get; set; }
        [Required]
        public String MoreKnowedLike { get; set; }
        [Required]
        public String SeemLastTime { get; set; }
        public byte[] Imagem { get; set; }
        

    }
}
