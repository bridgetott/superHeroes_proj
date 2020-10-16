using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroesProj.Data;
using SuperHeroesProj.Models;

namespace SuperHeroesProj.Controllers
{
    public class SuperHeroesController : Controller
    {
        // GET: SuperHeroesController
        private ApplicationDbContext _db;
        public SuperHeroesController(ApplicationDbContext db)
        {
            db = _db;
        }


        
        public ActionResult Index()
        {
            return View();
        }

        // GET: SuperHeroesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SuperHeroesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SuperHeroesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SuperHero superHero)
        {
            try
            {
                _db.superHeroes.Add(superHero);
                _db.SaveChanges();                
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHeroesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SuperHeroesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, SuperHero superHero)
        {
            try
            {
               // _db.superHeroes.(superHero);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHeroesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SuperHeroesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
