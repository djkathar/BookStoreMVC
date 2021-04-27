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
                new BookModel(){Id=1, Title="DotNet MVC",Author="Dj", Description="This book is for DotNet MVC, teaches you MVC", Category="MVC",Language="English",TotalPages=545},
                new BookModel(){Id=2, Title="Angular",Author="Bhaidya",Description="This book teaches you about front end programming",Category="Front End",Language="English",TotalPages=473 },
                new BookModel(){Id=3, Title="Enterprise Architecture",Author="Kedar",Description="This book if about Architecture and Enterprise Architecture, prepare for TOGAF",Category="Architecture",Language="English",TotalPages=600 },
                new BookModel(){Id=4, Title="Solution Architecture",Author="Avinash",Description="This book if about Architecture and Enterprise Architecture",Category="Architecture",Language="English",TotalPages=750 },
                new BookModel(){Id=5, Title="Project Management",Author="Sachin",Description="Get going with best practices of project management",Category="PM",Language="German",TotalPages=350 },
                new BookModel(){Id=6, Title="Javascript",Author="Dj",Description="The most commanly used front end language, it's at the heart of all the front end languages",Category="Front End",Language="French",TotalPages=1050 },
            };
        }
    }
}
