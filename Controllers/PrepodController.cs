using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using University.Models;

namespace University.Controllers
{
    public class PrepodController : Controller
    {
        // GET: Prepod
        public ActionResult Index()
        {
            using (DBModels db =new DBModels())
            {
                return View(db.Prepods.ToList());
            }

            
        }

        // GET: Prepod/Details/5
        public ActionResult Details(int id)
        {
            using (DBModels db = new DBModels())
            {
                return View(db.Prepods.Where(x => x.Id ==id).FirstOrDefault());
            }
            
        }

        // GET: Prepod/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Prepod/Create
        [HttpPost]
        public ActionResult Create(Prepod prepod)
        {
            try
            {
                // TODO: Add insert logic here
                using (DBModels db = new DBModels())
                {
                    db.Prepods.Add(prepod);
                    db.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Prepod/Edit/5
        public ActionResult Edit(int id)
        {
            using (DBModels db = new DBModels())
            {
                return View(db.Prepods.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // POST: Prepod/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Prepod prepod)
        {
            try
            {
                // TODO: Add update logic here
                using (DBModels db = new DBModels())
                {
                    db.Entry(prepod).State = EntityState.Modified;
                    db.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Prepod/Delete/5
        public ActionResult Delete(int id)
        {
            using (DBModels db = new DBModels())
            {
                return View(db.Prepods.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // POST: Prepod/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Prepod prepod)
        {
            try
            {
                // TODO: Add delete logic here
                using (DBModels db = new DBModels())
                {
                    prepod = db.Prepods.Where(x => x.Id == id).FirstOrDefault();
                    db.Prepods.Remove(prepod);
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
