using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        public ActionResult deleteData(int id)
        {
            student student1 = datab.students.Find(id);
            datab.students.Remove(student1);
            datab.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult edit(int id)
        {
            student student1 = datab.students.Find(id);
            return View(student1);
        }
        public ActionResult updateData(student student1)
        {   
            datab.Entry(student1).State = EntityState.Modified;
            datab.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}