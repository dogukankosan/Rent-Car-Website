using FluentValidation.Results;
using RodinaTurkey.Models.Entitiy;
using RodinaTurkey.Validation;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;

namespace RodinaTurkey.Controllers
{
    public class LoginController : Controller
    {
        private readonly RodinaTurkeyEntities db = new RodinaTurkeyEntities();
        private readonly LoginValidation Validation = new LoginValidation();

        [HttpGet]
        public ActionResult Log()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Log(Tbl_Login p)
        {
            ValidationResult result = Validation.Validate(p);
            if (result.IsValid)
            {
                var deger = db.Tbl_Login.Take(1).FirstOrDefault();
                if (Encription.Descryption(deger.UserName) == p.UserName & Encription.Descryption(deger.Password) == p.Password)
                {
                    FormsAuthentication.SetAuthCookie(p.UserName, false);
                    Session["UserName"] = p.UserName.ToString();
                    return RedirectToAction("List", "CategoryCar");
                }
                else
                {
                    Response.Write("<script lang='JavaScript'>alert('HATALI GİRİŞ YAPILDI LÜTFEN TEKRAR DENEYİNİZ !!');</script>");
                    return View();
                }
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
        [Authorize]
        [HttpGet]
        public ActionResult LoginUpdate(byte id = 1)
        {
            var deger = db.Tbl_Login.Find(id);
            deger.UserName=Encription.Descryption(deger.UserName);
            deger.Password = Encription.Descryption(deger.Password);
            return View(deger);
        }
        [HttpPost]
        public ActionResult LoginUpdate(Tbl_Login p)
        {
            ValidationResult result = Validation.Validate(p);
            if (result.IsValid)
            {
                p.ID = 1;
                var deger = db.Tbl_Login.Find(p.ID);
                deger.UserName = Encription.Encryption(p.UserName);
                deger.Password = Encription.Encryption(p.Password);
                db.SaveChanges();
                return RedirectToAction("List","CategoryCar");
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