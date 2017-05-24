using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhotoManager.Controllers
{
    public class KeywordsController : Controller
    {
        // GET: Keywords
        public ActionResult Index()
        {
            List<Models.Keyword> kw = null;
            kw = DB.Keywords.ToList();
            return View(kw);
        }

        // GET: Keywords/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Keywords/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Keywords/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Keywords/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Keywords/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Keywords/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Keywords/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
