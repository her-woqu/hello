using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class BookController : Controller
    {
        //
        // GET: /Book/

        public ActionResult Index()
        {
            BookStoreEntities db = new BookStoreEntities();
            var data = db.Books;
            return View(data);
        }

        [HttpGet]
        public ActionResult AddBook()
        {
            return View();
        }


        [HttpPost]
        public ActionResult AddBook(int BookId, string AuthorName, string Title, Nullable<decimal> Price)
        {
            BookStoreEntities db = new BookStoreEntities();

            var book = db.Books.OrderBy(o => o.BookId).FirstOrDefault();
            var bookId = 1;
            if (book != null)
            {
                bookId = book.BookId + 1;
            }

            db.Books.Add(new Book
            {
                BookId = BookId,
                AuthorName = AuthorName,
                Title = Title,
                Price = Price
            });


            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}