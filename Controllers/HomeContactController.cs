using FluentValidation.Results;
using RodinaTurkey.Models.Entitiy;
using RodinaTurkey.Validation;
using System;
using System.Web.Mvc;

namespace RodinaTurkey.Controllers
{
    public class HomeContactController : Controller
    {
        private readonly RodinaTurkeyEntities db = new RodinaTurkeyEntities();
        private readonly ContactValidation Validation = new ContactValidation();
        public ActionResult List()
        {
            return View();
        }
        public ActionResult Add(Tbl_Contact p)
        {
            ValidationResult result = Validation.Validate(p);
            if (result.IsValid)
            {
                p.Date = DateTime.Now;
                db.Tbl_Contact.Add(p);
                db.SaveChanges();
                return RedirectToAction("List");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
        }
    }
}