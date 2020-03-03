using BooksRepository.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BooksRepository.DAL
{
    public class BookContext : DbContext
    {
        public BookContext()
            : base("name=BooksRepositoryConnectionString")
        {

        }
        public DbSet<Book> Books { get; set; }
    }
}