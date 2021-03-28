using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bookbookie.Repository;
using bookbookie.Models;

namespace bookbookie.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRespository _bookRepository = null;

        public BookController()
        {
            _bookRepository = new BookRespository();
        }

       public ViewResult GetAllBooks()
        {
            var data = _bookRepository.GetallBooks();

            return View();
        }

        public BookModel GetBook(int id)
        {
            return _bookRepository.GetBookById(id);
        }

        public List<BookModel> SearchBooks(String bookName, String authorName)
        {
            return _bookRepository.SearchBook(bookName, authorName);
        }
    }
}
