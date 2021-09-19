using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using University.Models;

namespace University.Controllers
{
    public class StudController : Controller
    {
        // GET: Stud
        public ActionResult Index()
        {
            using (DBModels db = new DBModels())
            {
                return View(db.Studs.ToList());
            }
        }

        // GET: Stud/Details/5
        public ActionResult Details(int id)
        {
            using (DBModels db = new DBModels())
            {
                return View(db.Studs.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // GET: Stud/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Stud/Create
        [HttpPost]
        public ActionResult Create(Stud stud)
        {
            try
            {
                // TODO: Add insert logic here
                using (DBModels db = new DBModels())
                {
                    db.Studs.Add(stud);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Stud/Edit/5
        public ActionResult Edit(int id)
        {
            using (DBModels db = new DBModels())
            {
                return View(db.Studs.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // POST: Stud/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Stud stud)
        {
            try
            {
                // TODO: Add update logic here
                using (DBModels db = new DBModels())
                {
                    db.Entry(stud).State = EntityState.Modified;
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Stud/Delete/5
        public ActionResult Delete(int id)
        {
            using (DBModels db = new DBModels())
            {
                return View(db.Studs.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // POST: Stud/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Stud stud)
        {
            try
            {
                // TODO: Add delete logic here
                using (DBModels db = new DBModels())
                {
                    stud= db.Studs.Where(x => x.Id == id).FirstOrDefault();
                    db.Studs.Remove(stud);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
