using RodinaTurkey.Models.Entitiy;
using System.Linq;
using System.Web.Mvc;

namespace RodinaTurkey.Controllers
{
    public class HomeCarSalesController : Controller
    {
        private readonly RodinaTurkeyEntities db = new RodinaTurkeyEntities();
        public ActionResult List()
        {
            var deger = db.Tbl_Rentcar.Where(x => x.Status == true).ToList();
            return View(deger);
        }
    }
}