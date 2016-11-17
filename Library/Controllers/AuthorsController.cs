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
    [Route("api/authors")]
    public class AuthorsController : ApiController
    {
        LibraryDbContext db = new LibraryDbContext();
        public IQueryable<AuthorVm> GetBooks()
        {
            var authors = from author in db.Authors
                          select new AuthorVm
                          {
                              AuthorId = author.AuthorId,
                              AuthorName = author.AuthorName,
                              BookCount = author.Books.Count()
                          };
            return authors;
        }
    }
}
