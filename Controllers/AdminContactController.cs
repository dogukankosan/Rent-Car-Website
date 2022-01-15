using RodinaTurkey.Models.Entitiy;
using System.Linq;
using System.Web.Mvc;

namespace RodinaTurkey.Controllers
{
    public class AdminContactController : Controller
    {
        private readonly RodinaTurkeyEntities db = new RodinaTurkeyEntities();
        [Authorize]
        public ActionResult List()
        {
            var deger = db.Tbl_Contact.ToList();
            return View(deger);
        }

        public ActionResult Delete(short id)
        {
            var deger = db.Tbl_Contact.Find(id);
            db.Tbl_Contact.Remove(deger);
            db.SaveChanges();
            return RedirectToAction("List");
        }
    }
}