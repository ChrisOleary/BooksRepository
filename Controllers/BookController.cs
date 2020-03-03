using BooksRepository.DAL;
using BooksRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BooksRepository.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            //use LINQ to return data from repository
            var books = from book in _bookRepository.GetBooks()
                        select book;
            return View(books);
        }
        private IBookRepository _bookRepository;
        public BookController()
        {
            this._bookRepository = new BookRepository(new BookContext());
        }

        public ViewResult Details(int id)
        {
            Book student = _bookRepository.GetBookByID(id);
            return View(student);
        }

    }
}