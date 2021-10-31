using LibraryMVC.Domain.Interface;
using LibraryMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = LibraryMVC.Domain.Model.Type;

namespace LibraryMVC.Infrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly Context _context;
        public BookRepository(Context context)
        {
            _context = context;
        }

        public void DeleteBook(int bookId)
        {
            var book = _context.Books.Find(bookId);

            if (book != null)
            {
                _context.Books.Remove(book);
                _context.SaveChanges();
            }
        }

        public int AddBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();

            return book.Id;
        }

        // Linq
        public IQueryable<Book> GetBooksByTypeId(int typeId)
        {
            var books = _context.Books.Where(i => i.TypeId == typeId);

            return books;
        }

        public Book GetBookById(int bookId)
        {
            var book = _context.Books.FirstOrDefault(i => i.Id == bookId);

            return book;
        }

        public IQueryable<Tag> GetAllTags()
        {
            var tags = _context.Tags;
            return tags;
        }

        public IQueryable<Type> GetAllTypes()
        {
            var types = _context.Types;
            return types;
        }
    }
}
