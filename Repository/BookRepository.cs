using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bookbookie.Models;

namespace bookbookie.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(String title, String authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
        }
        public List<BookModel> GetBookTitle(String title)
        {
            return DataSource().Where(x => x.Title.Contains(title)).ToList();
        }
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id = 1, Title = "Human Anatomy", Author = "Marieb Brady Mallatt", Description = "This is the description for Human Anatomy", Price ="$80.00", ISBN = "0135168058", ISBN13 = "9780135168059"},
                new BookModel(){Id = 2, Title = "Python", Author = "Paul Deitel, Harvey Deitel", Description = "This is the description for Python", Price ="$180.00", ISBN = "0135168058", ISBN13 = "9780135168059"},
                new BookModel(){Id = 3, Title = "Biology", Author = "Raven, Johnson, Mason, Losos, Duncan",Description = "This is the description for Biology", Price ="$280.00", ISBN = "0135168058", ISBN13 = "9780135168059"},
                new BookModel(){Id = 4, Title = "College Alegbra", Author = "Juile Miller, Donna Gerken", Description = "This is the description for College Alegbra", Price ="$75.00", ISBN = "0135168058", ISBN13 = "9780135168059"},
                new BookModel(){Id = 5, Title = "Abstract Alegbra", Author = "Joespeh J. Rotman", Description = "This is the description for Abstract Alegbra", Price ="$175.00", ISBN = "0135168058", ISBN13 = "9780135168059"},
                new BookModel(){Id = 6, Title = "Literature for childern", Author = "David L. Russel", Description = "This is the description for Literature for childern", Price ="$65.00", ISBN = "0135168058", ISBN13 = "9780135168059"},
                new BookModel(){Id = 7, Title = "Literature for childern", Author = "David L. Russel", Description = "This is the description for Literature for childern", Price ="$65.00", ISBN = "0135168058", ISBN13 = "9780135168059"},
                new BookModel(){Id = 8, Title = "Literature for childern", Author = "David L. Russel", Description = "This is the description for Literature for childern", Price ="$65.00", ISBN = "0135168058", ISBN13 = "9780135168059"},
                new BookModel(){Id = 9, Title = "Literature for childern", Author = "David L. Russel", Description = "This is the description for Literature for childern", Price ="$65.00", ISBN = "0135168058", ISBN13 = "9780135168059"},
                new BookModel(){Id = 10, Title = "Literature for childern", Author = "David L. Russel", Description = "This is the description for Literature for childern", Price ="$65.00", ISBN = "0135168058", ISBN13 = "9780135168059"},
                new BookModel(){Id = 11, Title = "Literature for childern", Author = "David L. Russel", Description = "This is the description for Literature for childern", Price ="$65.00", ISBN = "0135168058", ISBN13 = "9780135168059"},
                new BookModel(){Id = 12, Title = "Literature for childern", Author = "David L. Russel", Description = "This is the description for Literature for childern", Price ="$65.00", ISBN = "0135168058", ISBN13 = "9780135168059"},
                new BookModel(){Id = 13, Title = "Human Anatomy", Author = "Marieb Brady Mallatt", Description = "This is the description for Human Anatomy", Price ="$80.00", ISBN = "0135168058", ISBN13 = "9780135168059"},
                new BookModel(){Id = 14, Title = "Python", Author = "Paul Deitel, Harvey Deitel", Description = "This is the description for Python", Price ="$180.00", ISBN = "0135168058", ISBN13 = "9780135168059"},
                new BookModel(){Id = 15, Title = "Biology", Author = "Raven, Johnson, Mason, Losos, Duncan",Description = "This is the description for Biology", Price ="$280.00", ISBN = "0135168058", ISBN13 = "9780135168059"},
                new BookModel(){Id = 16, Title = "College Alegbra", Author = "Juile Miller, Donna Gerken", Description = "This is the description for College Alegbra", Price ="$75.00", ISBN = "0135168058", ISBN13 = "9780135168059"},
                new BookModel(){Id = 17, Title = "Abstract Alegbra", Author = "Joespeh J. Rotman", Description = "This is the description for Abstract Alegbra", Price ="$175.00", ISBN = "0135168058", ISBN13 = "9780135168059"},
                new BookModel(){Id = 18, Title = "Literature for childern", Author = "David L. Russel", Description = "This is the description for Literature for childern", Price ="$65.00", ISBN = "0135168058", ISBN13 = "9780135168059"},
                new BookModel(){Id = 19, Title = "Human Anatomy", Author = "Marieb Brady Mallatt", Description = "This is the description for Human Anatomy", Price ="$80.00", ISBN = "0135168058", ISBN13 = "9780135168059"},
                new BookModel(){Id = 20, Title = "Python", Author = "Paul Deitel, Harvey Deitel", Description = "This is the description for Python", Price ="$180.00", ISBN = "0135168058", ISBN13 = "9780135168059"},
                new BookModel(){Id = 21, Title = "Biology", Author = "Raven, Johnson, Mason, Losos, Duncan",Description = "This is the description for Biology", Price ="$280.00", ISBN = "0135168058", ISBN13 = "9780135168059"},
                new BookModel(){Id = 22, Title = "College Alegbra", Author = "Juile Miller, Donna Gerken", Description = "This is the description for College Alegbra", Price ="$75.00", ISBN = "0135168058", ISBN13 = "9780135168059"},
                new BookModel(){Id = 23, Title = "Abstract Alegbra", Author = "Joespeh J. Rotman", Description = "This is the description for Abstract Alegbra", Price ="$175.00", ISBN = "0135168058", ISBN13 = "9780135168059"},
                new BookModel(){Id = 24, Title = "Literature for childern", Author = "David L. Russel", Description = "This is the description for Literature for childern", Price ="$65.00", ISBN = "0135168058", ISBN13 = "9780135168059"},
                new BookModel(){Id = 25, Title = "Human Anatomy", Author = "Marieb Brady Mallatt", Description = "This is the description for Human Anatomy", Price ="$80.00", ISBN = "0135168058", ISBN13 = "9780135168059"},
                new BookModel(){Id = 26, Title = "Python", Author = "Paul Deitel, Harvey Deitel", Description = "This is the description for Python", Price ="$180.00", ISBN = "0135168058", ISBN13 = "9780135168059"},
                new BookModel(){Id = 27, Title = "Biology", Author = "Raven, Johnson, Mason, Losos, Duncan",Description = "This is the description for Biology", Price ="$280.00", ISBN = "0135168058", ISBN13 = "9780135168059"},
                new BookModel(){Id = 28, Title = "College Alegbra", Author = "Juile Miller, Donna Gerken", Description = "This is the description for College Alegbra", Price ="$75.00", ISBN = "0135168058", ISBN13 = "9780135168059"},
                new BookModel(){Id = 29, Title = "Abstract Alegbra", Author = "Joespeh J. Rotman", Description = "This is the description for Abstract Alegbra", Price ="$175.00", ISBN = "0135168058", ISBN13 = "9780135168059"},
                new BookModel(){Id = 30, Title = "Literature for childern", Author = "David L. Russel", Description = "This is the description for Literature for childern", Price ="$65.00", ISBN = "0135168058", ISBN13 = "9780135168059"},
            };
        }
    }
}
