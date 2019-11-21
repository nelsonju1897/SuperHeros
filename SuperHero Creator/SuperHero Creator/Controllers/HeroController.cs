using SuperHero_Creator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperHero_Creator.Controllers
{
    public class HeroController : Controller
    {
        
        ApplicationDbContext db;
        public HeroController()
        {
            db = new ApplicationDbContext();
        }
        // GET: Hero
        public ActionResult Index()
        {
            var superheroList = db.Hero.ToList();
            
            return View(superheroList);
        }

        // GET: Hero/Details/5
        public ActionResult Details(int id)
        {
            SuperHero superhero = db.Hero.Where(s => s.Id == id).FirstOrDefault();
            return View(superhero);
        }

        // GET: Hero/Create
        public ActionResult Create()
        {
            SuperHero superhero = new SuperHero();
            return View(superhero);
        }

        // POST: Hero/Create
        [HttpPost]
        public ActionResult Create(SuperHero superhero)
        {
            try
            {
                // TODO: Add insert logic here
                db.Hero.Add(superhero);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Hero/Edit/5
        public ActionResult Edit(int id)
        {
            SuperHero superhero = db.Hero.Where(s => s.Id == id).FirstOrDefault();
            return View(superhero);
        }

        // POST: Hero/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, SuperHero superhero)
        {
            try
            {
                // TODO: Add update logic here
                SuperHero superherotoEdit = db.Hero.Where(s => s.Id == id).FirstOrDefault();
                superherotoEdit.superHeroName = superhero.superHeroName;
                superherotoEdit.alterEgo = superhero.alterEgo;
                superherotoEdit.primaryAbility = superhero.primaryAbility;
                superherotoEdit.secondaryAbility = superhero.secondaryAbility;
                superherotoEdit.catchphrase = superhero.catchphrase;
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Hero/Delete/5
        public ActionResult Delete(int id)
        {
            SuperHero superhero = db.Hero.Where(s => s.Id == id).FirstOrDefault();
            return View(superhero);
        }

        // POST: Hero/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, SuperHero superhero)
        {
            try
            {
                // TODO: Add delete logic here
                superhero = db.Hero.Where(s => s.Id == id).FirstOrDefault();
                db.Hero.Remove(superhero);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
