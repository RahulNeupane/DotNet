using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using firstday.Models;

namespace firstday.Controllers
{
    public class rahulController : Controller
    {
        mainEntities db = new mainEntities();
        // GET: rahul
        public ActionResult Index()
        {
            List<employee> data = db.employees.ToList();
            return View(data);
        }

        public ActionResult create()
        {
            return View();
        }
        public ActionResult SaveData(employee employees)
        {
            db.employees.Add(employees);

            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}