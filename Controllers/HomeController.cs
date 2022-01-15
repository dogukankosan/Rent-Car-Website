using RodinaTurkey.Models.Entitiy;
using System.Linq;
using System.Web.Mvc;
namespace RodinaTurkey.Controllers
{
    public class HomeController : Controller
    {
        private readonly RodinaTurkeyEntities db = new RodinaTurkeyEntities();

        public ActionResult List()
        {
            ViewBag.carcount = db.Tbl_Rentcar.Count(x => x.Status == true);
            ViewBag.categorycount = db.Tbl_RentCategory.Count(x => x.Status == true);
            var deger = db.Tbl_Rentcar.Where(x => x.Status == true).OrderByDescending(x => x.ID).ToList();
            ViewBag.video = db.Tbl_Abouts.Select(x => x.Video).FirstOrDefault();
            return View(deger);
        }

        public PartialViewResult Content()
        {
            var deger = db.Tbl_RentContent.Where(x => x.Status == true).ToList();
            return PartialView(deger);
        }
    }
}