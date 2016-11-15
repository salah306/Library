﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
    }
}