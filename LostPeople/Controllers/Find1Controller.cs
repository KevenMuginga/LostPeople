using LostPeople.App_Data;
using LostPeople.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace LostPeople.Controllers
{
    public class Find1Controller : Controller
    {
        private readonly LostDbContext _context = new LostDbContext();
        public ActionResult Index()
        {
            var finded = _context.Finds.ToList();
            return View(finded);
        }

        [HttpPost]
        public ActionResult Add(Finded finded)
        {
            if (ModelState.IsValid)
            {
                _context.Finds.Add(finded);
            }

            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
