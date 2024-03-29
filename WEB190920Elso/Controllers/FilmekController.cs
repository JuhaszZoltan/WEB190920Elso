﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB190920Elso.Models;
using WEB190920Elso.ViewModels;

namespace WEB190920Elso.Controllers
{
    public class FilmekController : Controller
    {
        public ViewResult Index()
        {
            var flk = GetData();
            return View(flk);
        }

        private IEnumerable<Film> GetData()
        {
            return new List<Film>
            {
                new Film(){ Id = 1, Cim = "Matrix" },
                new Film(){ Id = 2, Cim = "Terminator" },
                new Film(){ Id = 3, Cim = "Cloud Atlas" },
                new Film(){ Id = 4, Cim = "True Love" },
                new Film(){ Id = 5, Cim = "Kill Bill" },
            };
        }

        public ViewResult Random()
        {
            var film = new Film()
            {
                Cim = "Kill Bill"
            };

            var kolcsonzok = new List<Kolcsonzo>()
            {
                new Kolcsonzo() { Nev = "Géza" },
                new Kolcsonzo() { Nev = "Lacika" },
                new Kolcsonzo() { Nev = "Lacika" },
                new Kolcsonzo() { Nev = "Lacika" },
                new Kolcsonzo() { Nev = "Lacika" },
                new Kolcsonzo() { Nev = "Lacika" },
                new Kolcsonzo() { Nev = "Lacika" },
                new Kolcsonzo() { Nev = "Zsuzsanna" }
            };

            var rfvm = new RandomFilmViewModel()
            {
                Film = film,
                Kolcsonzok = kolcsonzok
            };

            return View(rfvm);
        }

        //return Content("szeretem a cicákat! <3");
        //return HttpNotFound();
        //return RedirectToAction("Index", "Home", new { oldal = 1, rendezes = "cim" });

        //ViewData["Film"] = film;
        //ViewBag.Film = film;


        public ActionResult Szerkesztes(int id)
        {
            return Content($"id = {id}");
        }

        //xyz.hu/Filmek/oldal/rendezes
        //xyz.hu/Filmek/2/ev
        //xyz.hu/Filmek  -> //xyz.hu/Filmek/1/cim

        //public ActionResult Index(int oldal = 1, string rendezes = "cim")
        //{
        //    //if (!oldal.HasValue) oldal = 1;
        //    //if (string.IsNullOrWhiteSpace(rendezes)) rendezes = "cim";

        //    return Content($"oldalszám: {oldal} | rendezés: {rendezes}");
        //}

        [Route("Filmek/Megjelenes/{ev:regex(\\d{4})}/{honap:regex(\\d{2}):range(1, 12)}")]
        public ActionResult Megjelenes(int ev, int honap)
        {
            return Content($"év = {ev} | hónap = {honap}");
        }

        // /filmek/megjelenes/2015/02
    }
}