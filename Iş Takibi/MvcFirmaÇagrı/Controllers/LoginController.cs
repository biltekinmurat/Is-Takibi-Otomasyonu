using MvcFirmaÇagrı.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcFirmaÇagrı.Controllers
{
    public class LoginController : Controller
    {
       
        DbişTakipEntities db = new DbişTakipEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(TblFirmalar p)
        {
            var bilgiler = db.TblFirmalar.FirstOrDefault(x => x.Mail == p.Mail && x.Sifre == p.Sifre);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.Mail, false);
                Session["Mail"] = bilgiler.Mail.ToString();    //session komutu  oturum yönetiminde  kullanılan
                                                               //kişinin bilgilerine ulaşıcağım komut
                return RedirectToAction("AktifCagrilar", "Default");
            }
            else
                return RedirectToAction("Index",p);
           
        }
    }
}