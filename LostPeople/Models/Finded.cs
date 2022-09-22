using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LostPeople.Models
{
    [Table("Encontrados")]
    public class Finded
    {
        
        public int Id { get; set; }
        [Required]
        public String Namme { get; set; }
        [Required]
        public String MoreKnowedLike { get; set; }
        [Required]
        public String PlaceHeIsNow { get; set; }
        [Required]
        public int NumberWho { get; set; }
        [Required]
        public byte[] Imagem { get; set; }



    }
}
