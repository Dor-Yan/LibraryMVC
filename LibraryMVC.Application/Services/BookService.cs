using AutoMapper;
using AutoMapper.QueryableExtensions;
using LibraryMVC.Application.Interfaces;
using LibraryMVC.Application.ViewModels.Book;
using LibraryMVC.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVC.Application.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepo;
        private readonly IMapper _mapper;
        public int AddBook(NewBookVm book)
        {
            throw new NotImplementedException();
        }

        public ListBookForListVm GetAllBooksForList()
        {
            var books = _bookRepo.GetAllBooks().ProjectTo<BookForListVm>(_mapper.ConfigurationProvider).ToList();
            var bookList = new ListBookForListVm()
            {
                Books = books,
                Count = books.Count
            };

            return bookList;
        }

        public BookDetailsVm GetBookDetails(int bookId)
        {
            var book = _bookRepo.GetBookById(bookId);

            var bookVm = _mapper.Map<BookDetailsVm>(book);

            //bookVm.Types = new List<TypeForListVm>();
            //bookVm.Writers = new List<WriterForListVm>();

            return bookVm;
        }
    }
}
