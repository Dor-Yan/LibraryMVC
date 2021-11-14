using LibraryMVC.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryMVC.Web.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }
        public IActionResult Index()
        {
            
            var model = _bookService.GetAllBooksForList();
            return View(model);
        }

        [HttpGet]
        public IActionResult AddBook()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult AddBook()
        //{
        //    return View();
        //}

        [HttpGet]
        public IActionResult AddNewWriterForBook(int bookId)
        {
            return View();
        }

        [HttpPost]
        //public IActionResult AddNewWriterForBook(WriterModel model)
        //{
        //    return View();
        //}

        [HttpGet]
        public IActionResult AddNewTypeForBook(int bookId)
        {
            return View();
        }

        [HttpPost]
        //public IActionResult AddNewTypeForBook(TypeModel model)
        //{
        //    return View();
        //}

        public IActionResult Details(int id)
        {
            var bookModel = _bookService.GetBookDetails(id);
            return View(bookModel);
        }
    }
}
