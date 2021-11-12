using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryMVC.Web.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            var model = bookService.GetAllBooksForList();
            return View(model);
        }

        [HttpGet]
        public IActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBook()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddNewWriterForBook(int bookId)
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewWriterForBook(WriterModel model)
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddNewTypeForBook(int bookId)
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewTypeForBook(TypeModel model)
        {
            return View();
        }

        public IActionResult ViewBook(int bookId)
        {
            var bookModel = bookService.GetBookDetails(bookId);
            return View(bookModel);
        }
    }
}
