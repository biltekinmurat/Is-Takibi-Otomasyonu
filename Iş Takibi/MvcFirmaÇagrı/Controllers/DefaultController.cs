using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Microsoft.Ajax.Utilities;
using MvcFirmaÇagrı.Models.Entity;
namespace MvcFirmaÇagrı.Controllers
{
    [Authorize]
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        DbişTakipEntities db = new DbişTakipEntities();

        public ActionResult AktifCagrilar()
        {
            var mail = (string)Session["Mail"];
            var id = db.TblFirmalar.Where(x => x.Mail == mail).Select(y => y.ID).FirstOrDefault();

            var cagrılar = db.TblCagrilar.Where(x => x.CagriFirma == id && x.Durum == true).ToList();
            ViewBag.m = cagrılar.Count();
            return View(cagrılar);

           
        }
        public ActionResult PasifCagrilar()
        {
            var mail = (string)Session["Mail"];
            var id = db.TblFirmalar.Where(x => x.Mail == mail).Select(y => y.ID).FirstOrDefault();

            var cagrılar = db.TblCagrilar.Where(x => x.Durum == false && x.CagriFirma == id).ToList();
            return View(cagrılar);
        }
        [HttpGet]  // sayfa yüklendiği zaman
        public ActionResult YeniCagri()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniCagri(TblCagrilar p)
        {
            var mail = (string)Session["Mail"];
            var id = db.TblFirmalar.Where(x => x.Mail == mail).Select(y => y.ID).FirstOrDefault();
            ViewBag.ids = id;
            p.Durum = true;
            p.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.CagriFirma = id;
            db.TblCagrilar.Add(p);
            db.SaveChanges();
            return RedirectToAction("AktifCagrilar");
        }
        public ActionResult CagriDetay(int id)
        {
            var cagri = db.TblCagriDetay.Where(x => x.Cagri == id).ToList();
            return View(cagri);
        }
        public ActionResult CagriGetir(int id)
        {
            var cagri = db.TblCagrilar.Find(id);
            return View("CagriGetir", cagri);
        }
        public ActionResult CagriDüzenle(TblCagrilar p)
        {
            var cagrı = db.TblCagrilar.Find(p.ID);
            cagrı.Konu = p.Konu;
            cagrı.Acıklama = p.Acıklama;
            db.SaveChanges();
            return RedirectToAction("AktifCagrilar", cagrı);
        }
        public ActionResult ProfilDüzenle()
        {
            var mail = (string)Session["Mail"];
            var id=db.TblFirmalar.Where(x=>x.Mail == mail).Select(y=>y.ID).FirstOrDefault();
            var profil=db.TblFirmalar.Where(x=>x.ID==id).FirstOrDefault();
            return View(profil);

        }
        public ActionResult AnaSayfa()
        {
            var mail = (string)Session["Mail"];
            var id = db.TblFirmalar.Where(x => x.Mail == mail).Select(y => y.ID).FirstOrDefault();

            var toplamçağrı = db.TblCagrilar.Where(x => x.CagriFirma == id).Count();
            ViewBag.c1 = toplamçağrı;

            var aktifçağrı = db.TblCagrilar.Where(x => x.CagriFirma == id && x.Durum==true).Count();
            ViewBag.c2 = aktifçağrı;
            var pasifçağrı = db.TblCagrilar.Where(x => x.CagriFirma == id && x.Durum == false).Count();
            ViewBag.c3 = pasifçağrı;

            var yetkili = db.TblFirmalar.Where(x => x.ID == id).Select(o=>o.Yetkili).FirstOrDefault();
            ViewBag.c4 =yetkili ;
            var sektörs = db.TblFirmalar.Where(x => x.ID == id).Select(o => o.Sektör).FirstOrDefault();
            ViewBag.c5 = sektörs;

            var firmaadi=db.TblFirmalar.Where(x=>x.ID==id).Select(y=>y.Ad).FirstOrDefault();
            ViewBag.c6 = firmaadi;

            var firmagörsel = db.TblFirmalar.Where(x => x.ID == id).Select(y => y.Gorsel).FirstOrDefault();
            ViewBag.c7 = firmagörsel;


            return View();
        }

        public PartialViewResult _Partial1()
        {
            var mail = (string)Session["Mail"];  // giriş yapılan kullanıcının mail'ini alır
            var id = db.TblFirmalar.Where(x => x.Mail == mail).Select(y => y.ID).FirstOrDefault();
            var mesaj = db.TblMesajlar.Where(x=>x.Alıcı==id&&x.Durum==true).ToList();

            var mesajsayısı=db.TblMesajlar.Where(x=>x.Alıcı==id && x.Durum==true).Count();
            ViewBag.m1 = mesajsayısı ;

            return PartialView(mesaj);
        }

        public PartialViewResult _Partial2()
        {
            var mail = (string)Session["Mail"];
            var id = db.TblFirmalar.Where(x => x.Mail == mail).Select(y => y.ID).FirstOrDefault();

            var cagri=db.TblCagrilar.Where(x=>x.CagriFirma==id&& x.Durum==true).ToList();
            var cagrisayisi= db.TblCagrilar.Where(x => x.CagriFirma == id && x.Durum==true).Count();
            ViewBag.cagri = cagrisayisi;
            return PartialView(cagri);
        }
        public PartialViewResult _Partial3()
        {
            return PartialView();
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index","Login");
        }
    }
}