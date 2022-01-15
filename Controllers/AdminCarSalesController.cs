using RodinaTurkey.Models.Entitiy;
using System;
using System.Linq;
using System.Web.Mvc;
using FluentValidation.Results;
using RodinaTurkey.Validation;

namespace RodinaTurkey.Controllers
{
    public class AdminCarSalesController : Controller
    {
        private readonly RodinaTurkeyEntities db = new RodinaTurkeyEntities();
        private readonly SalesValidation validation = new SalesValidation();
        [HttpGet]
        public ActionResult Update(Int16 id)
        {
            var deger = db.Tbl_SalesList.FirstOrDefault(x => x.ID == id);
            return View(deger);
        }
        [HttpPost]
        public ActionResult Update(Tbl_SalesList p)
        {
            ValidationResult result = validation.Validate(p);
            if (result.IsValid)
            {
                var deger = db.Tbl_SalesList.Find(p.ID);
                deger.FifftenThrisDay = p.FifftenThrisDay;
                deger.FiveFifftenDay = p.FiveFifftenDay;
                deger.OneFiveDay = p.OneFiveDay;
                deger.ThirsdayPlus = p.ThirsdayPlus;
                db.SaveChanges();
                return RedirectToAction("List", "AdminCar");
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