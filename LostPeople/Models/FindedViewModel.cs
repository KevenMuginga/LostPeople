using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace LostPeople.Models
{
    public class FindedViewModel
    {
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public String MoreKnowedLike { get; set; }
        [Required]
        public String PlaceHeIsNow { get; set; }
        [Required]
        public int NumberWho { get; set; }
        [Required]
        public HttpPostedFileBase ImageUpload { get; set; }
    }
}
