using Eliminatoria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eliminatoria.Controllers
{
    public class EquiposController : Controller
    {
        private partidoDBEntities1 db = new Models.partidoDBEntities1();
        // GET: Equipos
        public ActionResult registro()
        {          
            return View(db.equipo.ToList());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult registro(equipo objequipo)
        {
            if (ModelState.IsValid)
            {
                db.equipo.Add(objequipo);
                db.SaveChanges();
                return RedirectToAction("registro");
            }
            return View(objequipo);
        }
    }
}