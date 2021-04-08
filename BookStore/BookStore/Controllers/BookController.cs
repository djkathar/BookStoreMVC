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

        public BookController()
        {
            _bookRepository = new BookRepository();
        }

        public ViewResult GetAllBooks()
        {
            var data= _bookRepository.GetAllBooks();
            return View();
        }

        public BookModel GetBook(int Id)
        {
            return _bookRepository.GetBookById(Id);
        }

        public List<BookModel> SearchBook(string Title, string Author)
        {
            return _bookRepository.SearchBook(Title, Author);
        }
    }
}