using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB190920Elso.Models;

namespace WEB190920Elso.Controllers
{
    public class UgyfelekController : Controller
    {
        public ViewResult Index()
        {
            var ufk = GetData();
            return View(ufk);
        }

        public ActionResult Reszletek(int id)
        {
            var uf = GetData().SingleOrDefault(x => x.Id == id);

            if (uf is null) return HttpNotFound();
            else return View(uf);
        }

        private IEnumerable<Kolcsonzo> GetData()
        {
            return new List<Kolcsonzo>
            {
                new Kolcsonzo() { Id = 1, Nev = "Bogdán Barnabás"},
                new Kolcsonzo() { Id = 2, Nev = "Sándor Ramóna"},
                new Kolcsonzo() { Id = 3, Nev = "Szabó Ákos"},
                new Kolcsonzo() { Id = 4, Nev = "Bogdán Izabella"},
                new Kolcsonzo() { Id = 5, Nev = "Rácz Ábel"},
                new Kolcsonzo() { Id = 6, Nev = "Szűts Edina"},
                new Kolcsonzo() { Id = 7, Nev = "Király Gábor"},
                new Kolcsonzo() { Id = 8, Nev = "Oláh Kíra"},
            };


        }


    }
}