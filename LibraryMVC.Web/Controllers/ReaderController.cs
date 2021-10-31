using LibraryMVC.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryMVC.Web.Controllers
{
    public class ReaderController : Controller
    {
        private readonly IReaderService _readService;

        public ReaderController(IReaderService readService)
        {
            _readService = readService;
        }
        public IActionResult Index()
        {

            var model = _readService.GetAllReadersForList();
            return View(model);
        }

        public IActionResult ViewReader(int readerId)
        {
            var readerModel = _readService.GetReaderDetails(readerId);
            return View(readerModel);
        }

        [HttpGet]

        public IActionResult AddReader()
        {
            return View();
        }

        //[HttpPost]

        //public IActionResult AddReader (ReaderModel model)
        //{
        //    var id = _readService.AddReader(model);
        //    return View();
        //}
    }
}
