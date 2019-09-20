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
            { Cim = "Nincs ilyen" };

            return View(film);
        }
    }
}