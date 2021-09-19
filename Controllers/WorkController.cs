using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using University.Models;

namespace University.Controllers
{
    public class WorkController : Controller
    {
        // GET: Work
        public ActionResult Index()
        {
            using (DBModels db = new DBModels())
            {
                return View(db.Workers.ToList());
            }
        }

        // GET: Work/Details/5
        public ActionResult Details(int id)
        {
            using (DBModels db = new DBModels())
            {
                return View(db.Workers.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // GET: Work/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Work/Create
        [HttpPost]
        public ActionResult Create(Worker worker)
        {
            try
            {
                // TODO: Add insert logic here
                using (DBModels db = new DBModels())
                {
                    db.Workers.Add(worker);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Work/Edit/5
        public ActionResult Edit(int id)
        {
            using (DBModels db = new DBModels())
            {
                return View(db.Workers.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // POST: Work/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Worker worker)
        {
            try
            {
                // TODO: Add update logic here
                using (DBModels db = new DBModels())
                {
                    db.Entry(worker).State = EntityState.Modified;
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Work/Delete/5
        public ActionResult Delete(int id)
        {
            using (DBModels db = new DBModels())
            {
                return View(db.Workers.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // POST: Work/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Worker worker)
        {
            try
            {
                // TODO: Add delete logic here
                using (DBModels db = new DBModels())
                {
                    worker = db.Workers.Where(x => x.Id == id).FirstOrDefault();
                    db.Workers.Remove(worker);
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
