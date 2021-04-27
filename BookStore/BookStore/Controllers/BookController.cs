using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;
using BookStore.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;

        [ViewData]
        public string Title { get; set; }
        public BookController()
        {
            _bookRepository = new BookRepository();
        }

        public ViewResult GetAllBooks()
        {
            var data= _bookRepository.GetAllBooks();
            return View(data);
        }

        public ViewResult GetBook(int Id, string NameOfBook)
        {            
            var data= _bookRepository.GetBookById(Id);
            return View(data);
        }

        [Route("search-book/{Title}",Name ="searchbookroute")]
        public List<BookModel> SearchBook(string bookTitle)
        {
            Title = "Search book";
            string Author = "Dj";
            return _bookRepository.SearchBook(bookTitle, Author);

        }

        public ViewResult AddBook()
        {
            Title = "Add New Book";
            return View();
        }

        [HttpPost]
        public ViewResult AddBook(BookModel newBook)
        {
            
            return View();
        }
    }
}