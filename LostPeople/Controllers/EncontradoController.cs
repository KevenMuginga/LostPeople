using LostPeople.App_Data;
using LostPeople.Models;
using System;
using System.IO;
using System.Linq;
using System.Web.Mvc;

namespace LostPeople.Controllers
{
    public class EncontradoController : Controller
    {
        private readonly LostDbContext _context = new LostDbContext();
        public ActionResult Index()
        {
            var find = _context.Finds.ToList();
            return View(find);
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(FindedViewModel model)
        {
            var imageType = new String[]
            {
                "image/gif",
                "image/jpeg",
                "image/pjpeg",
                "image/png"
            };

            if (model.ImageUpload == null || model.ImageUpload.ContentLength == 0)
            {
                ModelState.AddModelError("ImageUpload", "Este campo é obrigatorio");
            }
            else if (!imageType.Contains(model.ImageUpload.ContentType))
            {
                ModelState.AddModelError("ImageUpload", "Este campo é obrigatorio");
            }

            if (ModelState.IsValid)
            {
                var finded = new Finded();
                finded.Namme = model.Name;
                finded.MoreKnowedLike = model.MoreKnowedLike;
                finded.NumberWho = model.NumberWho;
                finded.PlaceHeIsNow = model.PlaceHeIsNow;

                using (var binaryReader = new BinaryReader(model.ImageUpload.InputStream))
                    finded.Imagem = binaryReader.ReadBytes(model.ImageUpload.ContentLength);
                                                                                
                _context.Finds.Add(finded);
                _context.SaveChanges();
                return RedirectToAction("Index", "Encontrado");
            }

            _context.SaveChanges();
            return View(model);
        }
    }
}
