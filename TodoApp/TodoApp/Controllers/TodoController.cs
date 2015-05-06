using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TodoApp.Models;
namespace TodoApp.Controllers
{
    public class TodoController : Controller
    {
        TodoAppDataContext db = new TodoAppDataContext();
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
            if(Request.Cookies["UserId"] != null)
            {
                int userId = Convert.ToInt32(Request.Cookies["UserId"].Value);
                List<Todo> todos = db.Todos.Where(m => m.idUser == userId).ToList();
                ViewData["todo"] = todos;
                return View();
            }
            else
            {
                Response.Redirect("~/Home");
                return View();
            }
        }

        //
        // POST: /Todo/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                Todo todo = new Todo();
                todo.id = db.Todos.Count() + 1;
                todo.idUser = Convert.ToInt32(Request.Cookies["UserId"].Value);
                todo.description = collection["Description"];
                todo.date = DateTime.Now.AddDays(0);
                todo.status = "0";
                db.Todos.InsertOnSubmit(todo);
                db.SubmitChanges();
                return RedirectToAction("Create");
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
                int newId = db.Todos.Count() + 1;
                Todo hehe = new Todo();
                hehe.id = newId;
                hehe.description = "semoga cepet sehat";
                db.Todos.InsertOnSubmit(hehe);
                db.SubmitChanges();
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
