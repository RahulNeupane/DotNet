using firstday.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace firstday.Controllers
{
    public class bookController : Controller
    {
        mainEntities database = new mainEntities();
        // GET: book
        public ActionResult Index()
        {
            List<book> bookdata = database.books.ToList();
            return View(bookdata);
        }
        public ActionResult create()
        {
            return View();
        }

        public ActionResult SaveData(book books)
        {
            database.books.Add(books);
            database.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult deleteData(int id)
        {
            book book1 = database.books.Find(id);
            database.books.Remove(book1);
            database.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult edit(int id)
        {
            book book1 = database.books.Find(id);
            return View(book1);
        }
        public ActionResult updateData(book book1)
        {
            database.Entry(book1).State = EntityState.Modified;
            database.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}