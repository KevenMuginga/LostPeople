//using LostPeople.App_Data;
//using LostPeople.Models;
//using System.Linq;
//using System.Web.Mvc;

//namespace LostPeople.Controllers
//{
//    public class ContaController : Controller
//    {
//        private readonly LostDbContext _ctx = new LostDbContext();

//        [HttpGet]
//        public ActionResult Login()
//        {
//            return View();
//        }

//        [HttpPost]
//        public ActionResult Login(LoginVM model)
//        {
//            var usuario = _ctx.Users.FirstOrDefault(u => u.Email.ToLower() == model.Email.ToLower());

//            if (usuario == null)

//                ModelState.AddModelError("Email", "Email invalido");

            

//            if (ModelState.IsValid)
//            {
//                return RedirectToAction("Index", "Home");
//            }

//            return View(model);
//        }
//    }
//}
