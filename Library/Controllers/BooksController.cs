using Library.DataLayer;
using Library.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Library.Controllers
{
    [Route("api/books")]
    public class BooksController : ApiController
    {
        LibraryDbContext db = new LibraryDbContext();
        public IQueryable<BookVm> GetBooks()
        {
            var books = from book in db.Books
                        select new BookVm
                        {
                            BookId = book.BookId,
                            BookName = book.BookName,
                            AuthorId = book.AuthorId,
                            AuthorName = book.Author.AuthorName
                        };
            return books;
        }
    }
}
