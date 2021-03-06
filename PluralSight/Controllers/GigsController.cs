﻿using PluralSight.Models;
using PluralSight.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace PluralSight.Controllers
{
    public class GigsController : Controller
    {
        private ApplicationDbContext _context;

        public GigsController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Gigs
        public ActionResult Create()
        {

            var ViewModel = new GigFormViewModel {

                Genres = _context.Genres.ToList()
            };

            return View(ViewModel);
        }
    }
}