using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.ViewModels
{
    public class BookVm
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
    }
}