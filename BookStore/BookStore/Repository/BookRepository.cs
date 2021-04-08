using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return Datasource();
        }

        public BookModel GetBookById(int Id)
        {
            return Datasource().Where(x => x.Id == Id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string bookTitle, string bookAuthor)
        {
            return Datasource().Where(x => x.Title.Contains(bookTitle) || x.Author.Contains(bookAuthor)).ToList();
        }

        private List<BookModel> Datasource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1, Title="DotNet MVC",Author="Dj" },
                new BookModel(){Id=2, Title="Angular",Author="Bhaidya" },
                new BookModel(){Id=3, Title="Enterprise Architecture",Author="Kedar" },
                new BookModel(){Id=4, Title="Solution Architecture",Author="Avinash" },
                new BookModel(){Id=5, Title="Project Management",Author="Sachin" },
                new BookModel(){Id=6, Title="Javascript",Author="Dj" },
            };
        }
    }
}
