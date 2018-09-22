using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShowRoom.Models;

namespace ShowRoom.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        public ActionResult Home()
        {
            DbEntities db = new DbEntities();

            List<Marque> marques = db.Marque.ToList();

            return View(marques);
        }
    }
}