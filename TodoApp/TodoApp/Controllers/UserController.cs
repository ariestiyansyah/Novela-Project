using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using TodoApp.Models;
using System.Web.WebPages;

namespace TodoApp.Controllers
{
    public class UserController : Controller
    {
        TodoAppDataContext db = new TodoAppDataContext();
        //
        // GET: /User/
        public ActionResult Index()
        {
            return View();
        }
        //
        // GET: /User/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /User/Create
        [HttpPost]
        public ActionResult Create(UserRegistration model)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    User register = new User();

                    register.id = db.Users.Count() + 1;
                    register.username = model.Username;
                    register.password = model.Password;                    
                    db.Users.InsertOnSubmit(register);
                    db.SubmitChanges();

                    TempData["message"] = "Registration Success";
                }

                return View();
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Login()
        {
            return View();
        }
        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }
        [HttpPost]
        public ActionResult Login(UserModels model)
        {
            if(ModelState.IsValid)
            {
                User user = db.Users.Where(u => u.username == model.Username && u.password == model.Password).FirstOrDefault();
                if (user != null)
                {
                    string id = user.id + "";
                    Response.Cookies["userId"].Value = id;
                    Response.Cookies["userName"].Value = model.Username;
                    Response.Redirect("~/Home");
                }
                else
                {
                    TempData["message"] = "Username or password invalid";
                    return View();
                }
            }
            return View();
        }
        public ActionResult Logout()
        {
            Response.Cookies["userId"].Expires = DateTime.Now.AddDays(-1);   
            Response.Redirect("~/Home");
            return View();
        }
        public ActionResult Success()
        {
            return View();
        }
    }
}
