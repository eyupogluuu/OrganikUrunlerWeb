using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrganikUrunlerWeb.Models.entity;

namespace OrganikUrunlerWeb.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        organikbesinlerEntities db = new organikbesinlerEntities();
        public ActionResult Index()
        {
            
            var urunler = db.tbl_urunler.ToList();
            return View(urunler);
        }
    }
}