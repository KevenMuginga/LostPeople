using LostPeople.App_Data;
using LostPeople.Models;
using System;
using System.Net;
using System.IO;
using System.Linq;
using System.Web.Mvc;

namespace LostPeople.Controllers
{

    public class LostController : Controller
    {
        private readonly LostDbContext _ctx = new LostDbContext();

        public ActionResult Index()
        {
            var losted = _ctx.Losts.ToList();
            return View(losted);
        }


        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(LostedViewModel model)
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
                ModelState.AddModelError("ImageUpload", "Este Campo é obrigatorio");
            }
            else if (!imageType.Contains(model.ImageUpload.ContentType))
            {
                ModelState.AddModelError("ImageUpload", "Choose a image PNG, GIF or JPEG");
            }

            if (ModelState.IsValid)
            {

                var lost = new Losted();
                lost.Namme = model.Name;
                lost.MoreKnowedLike = model.MoreKnowedLike;
                lost.SeemLastTime = model.SeemLastTime;

                using (var binaryRead = new BinaryReader(model.ImageUpload.InputStream))
                    lost.Imagem = binaryRead.ReadBytes(model.ImageUpload.ContentLength);

                _ctx.Losts.Add(lost);
                _ctx.SaveChanges();
                ViewBag.Message = "Foi ";
                return RedirectToAction("Index");


            }
            ViewBag.Message = "Error ";
            return View(model);
        }

    }
}
