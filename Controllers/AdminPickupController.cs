using RodinaTurkey.Models.Entitiy;
using System.Linq;
using System.Web.Mvc;
using FluentValidation.Results;
using RodinaTurkey.Validation;

namespace RodinaTurkey.Controllers
{
    public class AdminPickupController : Controller
    {
        private readonly RodinaTurkeyEntities db = new RodinaTurkeyEntities();
        private readonly PickupValidation validation = new PickupValidation();
        
        public ActionResult List()
        {
            var deger = db.Tbl_Pickup.ToList();
            return View(deger);
        }

        public PartialViewResult Add()
        {
            return PartialView();
        }

        public ActionResult AddPickup(Tbl_Pickup p)
        {
            ValidationResult result = validation.Validate(p);
            if (result.IsValid)
            {
                p.Status = true;
                db.Tbl_Pickup.Add(p);
                db.SaveChanges();
                return RedirectToAction("List");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View("Add");
            }
        }
        public ActionResult StatusChanged(byte id)
        {
            var deger = db.Tbl_Pickup.Find(id);
            deger.Status = deger.Status != true;
            db.SaveChanges();
            return RedirectToAction("List");
        }
        [HttpGet]
        public ActionResult Update(byte id)
        {
            var deger=db.Tbl_Pickup.Find(id);
            return View(deger);
        }

        [HttpPost]
        public ActionResult Update(Tbl_Pickup p)
        {
            ValidationResult result = validation.Validate(p);
            if (result.IsValid)
            {
                var deger=db.Tbl_Pickup.Find(p.ID);
                deger.PickupLocation=p.PickupLocation;
                deger.Status = p.Status;
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