using FluentValidation.Results;
using RodinaTurkey.Models.Entitiy;
using RodinaTurkey.Validation;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;

namespace RodinaTurkey.Controllers
{
    public class CategoryCarController : Controller
    {
        private readonly RodinaTurkeyEntities db = new RodinaTurkeyEntities();
        private readonly CategoryCarValidation validation = new CategoryCarValidation();
        [Authorize]
        public ActionResult List()
        {
            var deger = db.Tbl_RentCategory.ToList();
            return View(deger);
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("List", "Home");
        }
        public ActionResult Delete(byte id)
        {
            var deger = db.Tbl_RentCategory.Find(id);
            db.Tbl_RentCategory.Remove(deger);
            db.SaveChanges();
            return RedirectToAction("List");
        }
        public ActionResult StatusChanged(byte id)
        {
            var deger = db.Tbl_RentCategory.Find(id);
            deger.Status = deger.Status != true;
            byte falsetrue = default;
            falsetrue = (byte)(deger.Status == true ? 1 : 0);
            db.Database.ExecuteSqlCommand("update Tbl_Rentcar set Status=" + falsetrue + "  where RentCagegoryID=" + id + "");
            db.SaveChanges();
            return RedirectToAction("List");
        }
        [Authorize]
        public PartialViewResult CategoryAdd()
        {
            return PartialView();
        }
        public ActionResult Add(Tbl_RentCategory p)
        {
            ValidationResult result = validation.Validate(p);
            if (result.IsValid)
            {
                p.Status = true;
                db.Tbl_RentCategory.Add(p);
                db.SaveChanges();
                return RedirectToAction("List");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View("CategoryAdd");
            }
        }
        [Authorize]
        [HttpGet]
        public ActionResult Update(byte id)
        {
            var deger = db.Tbl_RentCategory.Find(id);
            return View(deger);
        }
        [HttpPost]
        public ActionResult Update(Tbl_RentCategory p)
        {
            ValidationResult result = validation.Validate(p);
            if (result.IsValid)
            {
                var deger = db.Tbl_RentCategory.Find(p.ID);
                deger.RentCategory = p.RentCategory;
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