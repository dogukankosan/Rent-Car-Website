using FluentValidation.Results;
using RodinaTurkey.Models.Entitiy;
using RodinaTurkey.Validation;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace RodinaTurkey.Controllers
{
    public class AdminRentContentController : Controller
    {
        private readonly RodinaTurkeyEntities db = new RodinaTurkeyEntities();
        private readonly RentContextValidation Validation = new RentContextValidation();
        [Authorize]
        public ActionResult List()
        {
            var deger = db.Tbl_RentContent.ToList();
            return View(deger);
        }
        public ActionResult Delete(byte id)
        {
            var deger = db.Tbl_RentContent.Find(id);
            db.Tbl_RentContent.Remove(deger);
            db.SaveChanges();
            return RedirectToAction("List");
        }
        public ActionResult StatusChanged(byte id)
        {
            var deger = db.Tbl_RentContent.Find(id);
            deger.Status = deger.Status != true;
            db.SaveChanges();
            return RedirectToAction("List");
        }
        [Authorize]
        [HttpGet]
        public ActionResult Update(short id)
        {
            var deger = db.Tbl_RentContent.Find(id);
            List<SelectListItem> list = (from x in db.Tbl_RentCategory
                                         where x.Status == true
                                         select new SelectListItem
                                         {
                                             Value = x.ID.ToString(),
                                             Text = x.RentCategory
                                         }).ToList();
            ViewBag.dgr = list;
            return View(deger);
        }
        [HttpPost]
        public ActionResult Update(Tbl_RentContent p)
        {
            ValidationResult result = Validation.Validate(p);
            if (result.IsValid)
            {
                var deger = db.Tbl_RentContent.Find(p.ID);
                deger.UserName = p.UserName;
                deger.Mail = p.Mail;
                deger.Status = p.Status;
                deger.RentID = p.RentID;
                deger.Date = p.Date;
                deger.Image = p.Image;
                deger.ContextText = p.ContextText;
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