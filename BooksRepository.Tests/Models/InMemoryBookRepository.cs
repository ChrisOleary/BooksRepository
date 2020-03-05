using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BooksRepository.DAL;
using BooksRepository.Models;

namespace BooksRepository.Tests.Models
{
    class InMemoryBookRepository : IBookRepository
    {
        private List<Book> _db = new List<Book>();

        public Exception ExceptionToThrow { get; set; }

        //Get list of books
        public IEnumerable<Book> GetBooks()
        {
            return _db.ToList();
        }

        //Get book by ID
        public Book GetBookByID(int id)
        {
            //TODO
            return _db.Find(id);
        }

        //Update book
        public void UpdateBook(Book book)
        {
            _db.Add(book);
        }

        //Insert Book
        public void InsertBook(Book book)
        {
            if (ExceptionToThrow != null)
                throw ExceptionToThrow;

            _db.Add(book);
        }

        //Delete Book
        public void DeleteBook(int id)
        {
            _db.Remove(GetBookByID(id));
        }

        //Save changes
        public void Save()
        {
             //TODO
        }
        public void Dispose()
        {
            //TODO
        }
    }
}
