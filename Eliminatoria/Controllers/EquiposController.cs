﻿using Eliminatoria.Models;
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

        public ActionResult fecha() {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult registroFecha(fecha objfecha) {

            if (ModelState.IsValid)
            {
                db.fecha.Add(objfecha);
                db.SaveChanges();
                return RedirectToAction("detalle");
            }
            return View(objfecha);
        }
        public ActionResult detalle()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult registroDetalle(detalle objdetalle)
        {

            if (ModelState.IsValid)
            {
                db.detalle.Add(objdetalle);
                db.SaveChanges();
                return RedirectToAction("registro");
            }
            return View(objdetalle);
        }
    }
}