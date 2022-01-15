using PagedList;
using RodinaTurkey.Models.Entitiy;
using RodinaTurkey.Validation;
using System;
using System.Linq;
using System.Web.Mvc;

namespace RodinaTurkey.Controllers
{
    public class HomeCarController : Controller
    {
        private readonly RodinaTurkeyEntities db = new RodinaTurkeyEntities();
        private readonly RentContextValidation validation = new RentContextValidation();

        public ActionResult ListCar(byte page = 1)
        {
            var deger = db.Tbl_Rentcar.Where(x => x.Status == true).ToList().ToPagedList(page, 6);
            return View(deger);
        }

        public ActionResult GetById(byte id)
        {
            try
            {
                var deger = db.Tbl_Rentcar.Where(x => x.Status == true & x.ID == id).FirstOrDefault();
                return View(deger);
            }
            catch (Exception e)
            {
                Response.Write("<script lang='JavaScript'>alert('" + e.Message + "');</script>");
                return View();
            }

        }
        public PartialViewResult GetByContent(byte id)
        {
            TempData["Veri"] = id;
            var deger = db.Tbl_RentContent.Where(x => x.Status == true & x.RentID == id).ToList();
            ViewBag.dgr = db.Tbl_RentContent.Count(x => x.Status == true & x.RentID == id);
            return PartialView(deger);
        }

        public PartialViewResult ContentAdd()
        {
            return PartialView();
        }

        public ActionResult Add(Tbl_RentContent p)
        {
            p.RentID = (byte)TempData["Veri"];
            p.Status = false;
            p.Image = "https://cdn3.iconfinder.com/data/icons/business-avatar-1/512/1_avatar-512.png";
            p.Date = DateTime.Now;
            db.Tbl_RentContent.Add(p);
            db.SaveChanges();
            return RedirectToAction("GetById", new { id = p.RentID });
        }

        public PartialViewResult NavFooter()
        {
            var deger = db.Tbl_Rentcar.Where(x => x.Status == true).OrderByDescending(x => x.ID).Take(3).ToList();
            return PartialView(deger);
        }
    }
}