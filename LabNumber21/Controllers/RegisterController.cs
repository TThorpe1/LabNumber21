using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LabNumber21;
using LabNumber21.Models;

namespace LabNumber21.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Edit(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToRoute(new { controller = "AddUser", action = "Index" });

            }
            return View("Index", model);

            //return View("AddUser","Home");
        }
    }
}