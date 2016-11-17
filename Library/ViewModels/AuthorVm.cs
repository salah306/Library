using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.ViewModels
{
    public class AuthorVm
    {
         public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public int BookCount { get; set; }
    }
}