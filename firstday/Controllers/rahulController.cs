using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        public ActionResult deleteData(int id)
        {
            employee employees = db.employees.Find(id);
            db.employees.Remove(employees);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult edit(int id)
        {
            employee employee1 = db.employees.Find(id);
            return View(employee1);
        }
        public ActionResult updateData(employee employee1)
        { 
            db.Entry(employee1).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}