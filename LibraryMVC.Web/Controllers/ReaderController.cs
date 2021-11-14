using LibraryMVC.Application.Interfaces;
using LibraryMVC.Application.ViewModels.Reader;
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

        [HttpGet]
        public IActionResult Index()
        {
            var model = _readService.GetAllReadersForList(2, 1, "");
            return View(model);
        }

        [HttpPost]

        public IActionResult Index(int pageSize, int? pageNo, string searchString)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }

            if (searchString is null)
            {
                searchString = String.Empty;
            }

            var model = _readService.GetAllReadersForList(pageSize, pageNo.Value, searchString);
            return View(model);
        }
        public IActionResult ViewReader(int Id)
        {
            var readerModel = _readService.GetReaderDetails(Id);
            return View(readerModel);
        }

        [HttpGet]

        public IActionResult AddReader()
        {
            return View(new NewReaderVm());
        }

        [HttpPost]

        public IActionResult AddReader(NewReaderVm model)
        {
            var id = _readService.AddReader(model);
            return RedirectToAction("Index");
        }

        [HttpGet]

        public IActionResult EditReader(int id)
        {
            var reader = _readService.GetReaderForEdit(id);
            return View(reader);
        }

        [HttpPost]

        public IActionResult EditReader(NewReaderVm model)
        {
            _readService.UpdateReader(model);
            return RedirectToAction("Index");
        }


    }
}
