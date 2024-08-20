using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models; // Model dosyasını dahil etmeyi unutmayın

namespace WebApplication5.Controllers
{
    public class DepartmanController : Controller
    {
        public ActionResult Merhaba()
        {
            var departman = new Departman() { Id = 1, Ad = "Bilgi İşlem" };

            return View(departman);//view'a departman modeli parametre verildi
        }
        public ActionResult Test() {
            var departman = new Departman() { Id = 1, Ad = "Bilgi İşlem" };
            return RedirectToAction("Index", "Personel", new {SortBye="Maas"});
        }
    }
}
