using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bookbookie.Models;

namespace bookbookie.Repository
{
    public class BookRespository
    {
        public List<BookModel> GetallBooks()
        {
            return DataSource();
        }
        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(String title, String authorName)
        {
            return DataSource().Where(x => x.Title == title && x.Author == authorName).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id = 1, Title = "MVC", Author = "Mike"},
                new BookModel(){Id = 2, Title = "MVC", Author = "Mike"},
                new BookModel(){Id = 3, Title = "C#", Author = "Mike"},
                new BookModel(){Id = 4, Title = "Java", Author = "Mike"},
                new BookModel(){Id = 5, Title = "PHP", Author = "Mike"},
            };
        }
    }
}
