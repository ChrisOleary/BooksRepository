using BooksRepository.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BooksRepository.DAL
{
    public class BookRepository : IBookRepository
    {
        private BookContext _context;
        public BookRepository(BookContext bookContext)
        {
            this._context = bookContext;
        }

        //Get all books
        public IEnumerable<Book> GetBooks()
        {
            return _context.Books.ToList();
        }

        //Get book by id
        public Book GetBookByID(int id)
        {
            return _context.Books.Find(id);
        }

        //Insert book
        public void InsertBook(Book book)
        {
            _context.Books.Add(book);
        }

        //Delete book
        public void DeleteBook(int bookID)
        {
            Book book = _context.Books.Find(bookID);
            _context.Books.Remove(book);
        }

        //Update Book
        public void UpdateBook(Book book)
        {
            _context.Entry(book).State = EntityState.Modified;
        }

        //Save Changes
        public void Save()
        {
            _context.SaveChanges();
        }

        //Garbage collection - release unmanaged resources used by the application
        private bool disposed = false;

        //Garbage collection - release unmanaged resources used by the application
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        //Garbage collection - release unmanaged resources used by the application
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}