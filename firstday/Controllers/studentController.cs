using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using firstday.Models;

namespace firstday.Controllers
{
    public class studentController : Controller
    {
        mainEntities datab = new mainEntities();
        // GET: student
        public ActionResult Index()
        {
            List<student> sdata = datab.students.ToList();
            return View(sdata);
        }
        public ActionResult create()
        {
            return View();
        }
        public ActionResult SaveData(student students)
        {
            datab.students.Add(students);
            datab.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}