using FluentValidation.Results;
using RodinaTurkey.Models.Entitiy;
using RodinaTurkey.Validation;
using System.Linq;
using System.Web.Mvc;

namespace RodinaTurkey.Controllers
{
    public class AdminAboutController : Controller
    {
        private readonly RodinaTurkeyEntities db = new RodinaTurkeyEntities();
        private readonly AboutValidation validation = new AboutValidation();
        [Authorize]
        public ActionResult List()
        {
            var deger = db.Tbl_Abouts.ToList();
            return View(deger);
        }
        [Authorize]
        public PartialViewResult Update()
        {
            var deger = db.Tbl_Abouts.Find(2);
            return PartialView(deger);
        }
        public ActionResult UpdateAdd(Tbl_Abouts p)
        {
            ValidationResult result = validation.Validate(p);
            if (result.IsValid)
            {
                var deger = db.Tbl_Abouts.Find(p.ID);
                deger.UserName = p.UserName;
                deger.Image = p.Image;
                deger.CompanyName = p.CompanyName;
                deger.CompanyImage = p.CompanyImage;
                deger.Adress = p.Adress;
                deger.Mail = p.Mail;
                deger.Phone = p.Phone;
                deger.Video = p.Video;
                db.SaveChanges();
                return RedirectToAction("List");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View("Update");
            }
        }
    }
}