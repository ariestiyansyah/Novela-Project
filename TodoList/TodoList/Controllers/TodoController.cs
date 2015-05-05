using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TodoList.Controllers
{
    public class TodoController : Controller
    {
        //
        // GET: /Todo/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Todo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Todo/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Todo/Create
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

        //
        // GET: /Todo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Todo/Edit/5
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

        //
        // GET: /Todo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Todo/Delete/5
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
