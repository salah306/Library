namespace Library.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Library.DataLayer.LibraryDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Library.DataLayer.LibraryDbContext context)
        {
            context.Authors.AddOrUpdate(a => a.AuthorName, new Author { AuthorName = "Stephen Hawking" });
            context.Authors.AddOrUpdate(a => a.AuthorName, new Author { AuthorName = "Elisabeth Kübler-Ross" });
            context.Authors.AddOrUpdate(a => a.AuthorName, new Author { AuthorName = "Tony Crilly" });
            context.SaveChanges();
            context.Books.AddOrUpdate(a => a.BookName, new Book { BookName = "A brief history of time", AuthorId = context.Authors.Single(a => a.AuthorName == "Stephen Hawking").AuthorId });
            context.Books.AddOrUpdate(a => a.BookName, new Book { BookName = "Death: The Final Stage of Growth", AuthorId = context.Authors.Single(a => a.AuthorName == "Elisabeth Kübler-Ross").AuthorId });
            context.Books.AddOrUpdate(a => a.BookName, new Book { BookName = "50 Mathematical Ideas You Really Need to Know", AuthorId = context.Authors.Single(a => a.AuthorName == "Tony Crilly").AuthorId });
            context.Books.AddOrUpdate(a => a.BookName, new Book { BookName = "The Grand Design", AuthorId = context.Authors.Single(a => a.AuthorName == "Stephen Hawking").AuthorId });
        }
    }
}
