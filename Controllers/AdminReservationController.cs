using RodinaTurkey.Models.Entitiy;
using System;
using System.Linq;
using System.Web.Mvc;

namespace RodinaTurkey.Controllers
{
    public class AdminReservationController : Controller
    {
        private readonly RodinaTurkeyEntities db = new RodinaTurkeyEntities();
        [Authorize]
        public ActionResult List()
        {
            var deger = db.Tbl_Reservation.ToList();
            return View(deger);
        }
        [Authorize]
        public ActionResult Delete(Int16 id)
        {
            var deger = db.Tbl_Reservation.Find(id);
            db.Tbl_Reservation.Remove(deger);
            db.SaveChanges();
            return RedirectToAction("List");
        }
    }
}