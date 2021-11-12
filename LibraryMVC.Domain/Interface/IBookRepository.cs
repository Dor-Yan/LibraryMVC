using LibraryMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = LibraryMVC.Domain.Model.Type;

namespace LibraryMVC.Domain.Interface
{
    public interface IBookRepository
    {
        void DeleteBook(int bookId);

        int AddBook(Book book);

        IQueryable<Book> GetBooksByTypeId(int typeId);
        IQueryable<Book> GetAllBooks();
        Book GetBookById(int bookId);   

        IQueryable<Tag> GetAllTags();

        IQueryable<Type> GetAllTypes();
        IQueryable<Writer> GetAllWriters();

    }
}
