using FluentValidation.Results;
using RodinaTurkey.Models.Entitiy;
using RodinaTurkey.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web.Mvc;

namespace RodinaTurkey.Controllers
{
    public class ReservationController : Controller
    {
        private readonly RodinaTurkeyEntities db = new RodinaTurkeyEntities();
        private readonly ReservationValidation validation = new ReservationValidation();
        public PartialViewResult ListReser()
        {
            List<SelectListItem> list = (from x in db.Tbl_Pickup
                                         where x.Status == true
                                         select new SelectListItem
                                         {
                                             Value = x.ID.ToString(),
                                             Text = x.PickupLocation
                                         }).ToList();
            ViewBag.dgr = list;
            ViewBag.dgr1 = list;
            List<SelectListItem> listcar = (from x in db.Tbl_Rentcar
                                            where x.Status == true
                                            select new SelectListItem
                                            {
                                                Value = x.ID.ToString(),
                                                Text = x.CarName
                                            }).ToList();
            ViewBag.dgr2 = listcar;
            return PartialView();
        }
        public ActionResult List(Tbl_Reservation p)
        {
            TempData["Veri"] = p;
            var deger = db.Tbl_Rentcar.Find(p.CarID);
            TempData["Sales"] = deger.Sales.ToString();
            return RedirectToAction("Add");
        }

        [HttpGet]
        public ActionResult Add()
        {
            List<SelectListItem> list = (from x in db.Tbl_Pickup
                                         where x.Status == true
                                         select new SelectListItem
                                         {
                                             Value = x.ID.ToString(),
                                             Text = x.PickupLocation
                                         }).ToList();
            ViewBag.dgr = list;
            ViewBag.dgr1 = list;
            List<SelectListItem> listcar = (from x in db.Tbl_Rentcar
                                            where x.Status == true
                                            select new SelectListItem
                                            {
                                                Value = x.ID.ToString(),
                                                Text = x.CarName
                                            }).ToList();
            ViewBag.dgr2 = listcar;
            var deger = TempData["Veri"];
            ViewBag.sales = TempData["Sales"];
            return View(deger);
        }
        [HttpPost]
        public ActionResult Add(Tbl_Reservation p)
        {
            var deger = db.Tbl_Abouts.FirstOrDefault();
            ValidationResult result = validation.Validate(p);
            if (result.IsValid)
            {
                db.Tbl_Reservation.Add(p);
                db.SaveChanges();
                SmtpClient client = new SmtpClient();
                MailMessage message = new MailMessage();
                client.Credentials = new NetworkCredential("dogukandevp@hotmail.com", "48877278690dd");
                client.Port = 587;
                client.Host = "smtp.live.com";
                client.EnableSsl = true;
                message.To.Add(deger.Mail);
                message.From = new MailAddress("dogukandevp@hotmail.com");
                message.Subject = "GELEN YENİ REZERVASYON";
                message.Body =
                    $"{p.NameSurname} KİŞİSİNDEN GELEN REZERVASYON VARDIR LÜTFEN ADMİN PANELİNE GİDİP DETAYLARINA BAKINIZ !! {Environment.NewLine} KİŞİ TELEFONU: {p.Phone} {Environment.NewLine} KİŞİ MAİLİ: {p.Mail} {Environment.NewLine} BAŞLANGIÇ TARİHİ: {p.FirstDate.Value.ToShortDateString()} {Environment.NewLine} BİTİŞ TARİHİ: {p.LastDate.Value.ToShortDateString()} {Environment.NewLine} AÇIKLAMASI: {p.ContentText}";
                client.Send(message);
                return RedirectToAction("List", "Home");
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
    }
}