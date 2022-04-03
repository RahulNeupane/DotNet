using firstday.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace firstday.Controllers
{
    public class teacherController : Controller
    {
        mainEntities database = new mainEntities();
        // GET: teacher
        public ActionResult Index()
        {
            List<teacher> tdata = database.teachers.ToList();
            return View(tdata);
        }

        public ActionResult create()
        {
            return View();
        }

        public ActionResult SaveData(teacher teachers)
        {
            database.teachers.Add(teachers);
            database.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult deleteData(int id)
        {
            teacher teacher1 = database.teachers.Find(id);
            database.teachers.Remove(teacher1);
            database.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public ActionResult edit(int id)
        {
            teacher teacher1 = database.teachers.Find(id);
            return View(teacher1);
        }
        public ActionResult updateData(teacher teacher1)
        {
            database.Entry(teacher1).State = EntityState.Modified;
            database.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}