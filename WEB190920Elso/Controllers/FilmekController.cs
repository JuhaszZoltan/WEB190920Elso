using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB190920Elso.Models;

namespace WEB190920Elso.Controllers
{
    public class FilmekController : Controller
    {
        // GET: Filmek/Random
        public ActionResult Random()
        {
            var film = new Film()
            {
                Cim = "Kill Bill"
            };

            return View(film);
            //return Content("szeretem a cicákat! <3");
            //return HttpNotFound();
            //return RedirectToAction("Index", "Home", new { oldal = 1, rendezes = "cim" });
        }

        public ActionResult Szerkesztes(int id)
        {
            return Content($"id = {id}");
        }

        //xyz.hu/Filmek/oldal/rendezes
        //xyz.hu/Filmek/2/ev
        //xyz.hu/Filmek  -> //xyz.hu/Filmek/1/cim

        public ActionResult Index(int oldal = 1, string rendezes = "cim")
        {
            //if (!oldal.HasValue) oldal = 1;
            //if (string.IsNullOrWhiteSpace(rendezes)) rendezes = "cim";
            
            return Content($"oldalszám: {oldal} | rendezés: {rendezes}");
        }

        public ActionResult Megjelenes(int ev, int honap)
        {
            return Content($"év = {ev} | hónap = {honap}");
        }

        // /filmek/megjelenes/2015/02
    }
}