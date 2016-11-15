using Library.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Library.DataLayer
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext()
            : base("LibraryDbContext")
        {
        }


        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }


        public static LibraryDbContext Create()
        {
            return new LibraryDbContext();
        }
    }
}

