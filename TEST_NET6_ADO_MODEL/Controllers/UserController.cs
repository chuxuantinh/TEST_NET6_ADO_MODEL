using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TEST_NET6_ADO_MODEL.Models;


namespace TEST_NET6_ADO_MODEL.Controllers
{
    public class UserController : Controller
    {

        private readonly Entities _DbContext = new Entities();
        // GET: User
        public ActionResult Index()
        {
            var emp = _DbContext.Users.ToList();
            return View(emp);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FormCollection formCollection)
        {
            if (ModelState.IsValid)
            {
                User emp = new User();
                emp.Id = Convert.ToInt32(formCollection["Id"]);
                emp.UserName = formCollection["UserName"];
                emp.PassWord = formCollection["PassWord"];
                emp.FullName = formCollection["FullName"];
                emp.Email = formCollection["Email"];
                emp.PhoneNumber = formCollection["PhoneNumber"];
                emp.Address = formCollection["Address"];
                emp.Department = formCollection["Department"];
                emp.Position = formCollection["Position"];

                emp.RoleId = Convert.ToInt32(formCollection["RoleId"]);
                emp.Status = Convert.ToInt32(formCollection["Status"]);
               
                _DbContext.Users.Add(emp);
                _DbContext.SaveChanges();
                RedirectToAction("Index");
            }
            return View();
        }
    }
}