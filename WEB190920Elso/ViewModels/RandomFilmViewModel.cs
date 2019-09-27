using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WEB190920Elso.Models;

namespace WEB190920Elso.ViewModels
{
    public class RandomFilmViewModel
    {
        public Film Film { get; set; }
        public List<Kolcsonzo> Kolcsonzok { get; set; }
    }
}