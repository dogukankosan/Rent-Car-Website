using FluentValidation.Results;
using RodinaTurkey.Models.Entitiy;
using RodinaTurkey.Validation;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace RodinaTurkey.Controllers
{
    public class AdminCarController : Controller
    {
        private readonly RodinaTurkeyEntities db = new RodinaTurkeyEntities();
        private readonly RentCarValidation validation = new RentCarValidation();
        [Authorize]
        public ActionResult List()
        {
            var deger = db.Tbl_Rentcar.ToList();
            return View(deger);
        }
        public ActionResult Delete(byte id)
        {
            var deger = db.Tbl_Rentcar.Find(id);
            db.Tbl_Rentcar.Remove(deger);
            db.SaveChanges();
            return RedirectToAction("List");
        }
        public ActionResult StatusChanged(byte id)
        {
            var deger = db.Tbl_Rentcar.Find(id);
            deger.Status = deger.Status != true;
            db.SaveChanges();
            return RedirectToAction("List");
        }
        public PartialViewResult RentCarrAdd()
        {
            List<SelectListItem> list = (from x in db.Tbl_RentCategory
                                         where x.Status == true
                                         select new SelectListItem
                                         {
                                             Value = x.ID.ToString(),
                                             Text = x.RentCategory
                                         }).ToList();
            ViewBag.dgr = list;
            return PartialView();
        }
        public ActionResult Add(Tbl_Rentcar p)
        {
            ValidationResult result = validation.Validate(p);
            if (result.IsValid)
            {
                p.Status = true;
                db.Tbl_Rentcar.Add(p);
                db.SaveChanges();
                return RedirectToAction("List");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View("RentCarrAdd");
            }
        }
        [Authorize]
        [HttpGet]
        public ActionResult Update(byte id)
        {
            var deger = db.Tbl_Rentcar.Find(id);
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
        public ActionResult Update(Tbl_Rentcar p)
        {
            ValidationResult result = validation.Validate(p);
            if (result.IsValid)
            {
                var deger = db.Tbl_Rentcar.Find(p.ID);
                deger.CarName = p.CarName;
                deger.CarImage = p.CarImage;
                deger.Status = p.Status;
                deger.RentCagegoryID = p.RentCagegoryID;
                deger.Sales = p.Sales;
                deger.About = p.About;
                deger.Oil = p.Oil;
                deger.Gerbox = p.Gerbox;
                deger.Km = p.Km;
                deger.ChairCount = p.ChairCount;
                deger.Luggage = p.Luggage;
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