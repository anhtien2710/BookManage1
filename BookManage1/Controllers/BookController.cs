
using BookManage1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookManager.Controllers
{
    public class BookController : Controller
    {
        BookManageContext context = new BookManageContext();
        // GET: Book
        public ActionResult Index()
        {
            return RedirectToAction("ListBook");
        }

        public ActionResult ListBook()
        {
            List<Book> books = context.Books.ToList();
            return View(books);
        }

        [Authorize]
        public ActionResult Buy(int id)
        {
            Book book = context.Books.SingleOrDefault(x => x.ID == id);
            if (book == null)
            {
                return HttpNotFound();
            }

            return View(book);
        }

        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Create(Book book)
        {
            context.Books.AddOrUpdate(book);
            context.SaveChanges();
            return RedirectToAction("ListBook");
        }

        [Authorize]
        public ActionResult Edit(int id)
        {
            Book book = context.Books.FirstOrDefault(x => x.ID == id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Edit(Book book)
        {
            Book b = context.Books.FirstOrDefault(x => x.ID == book.ID);
            if (b == null)
            {
                return HttpNotFound();
            }
            context.Books.AddOrUpdate(book);
            context.SaveChanges();
            return RedirectToAction("ListBook");
        }

        [Authorize]
        public ActionResult Delete(int id)
        {
            Book book = context.Books.FirstOrDefault(x => x.ID == id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult DeleteItem(int id)
        {
            Book book = context.Books.FirstOrDefault(x => x.ID == id);
            if (book == null)
            {
                return HttpNotFound();
            }
            context.Books.Remove(book);
            context.SaveChanges();
            return RedirectToAction("ListBook");
        }

        [Authorize]
        public ActionResult Details(int id)
        {
            Book book = context.Books.FirstOrDefault(x => x.ID == id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }
    }
}