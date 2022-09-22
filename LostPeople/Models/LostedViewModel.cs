using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace LostPeople.Models
{
    public class LostedViewModel
    {

        public Int32 Id { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public String MoreKnowedLike { get; set; }
        [Required]
        public String SeemLastTime { get; set; }
        [DataType(DataType.Upload)]
        public HttpPostedFileBase ImageUpload { get; set; }
    }
}
