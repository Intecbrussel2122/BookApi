using BookApi.Data;
using BookApi.Model;
using System.Collections.Generic;
using System.Linq;

namespace BookApi.Services
{
    public class BookServices
    {
        private readonly ApplicationDbContext _context;
        public BookServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Book> GetAllBooks()
        {
            return _context.Books.ToList();
        }

        public void AddBook(BookVM book)
        {
            var _book = new Book()
            {
                Title = book.Title,
                Description = book.Description,
                IsRead = book.IsRead,
                DateRead = book.DateRead,
                Rate = book.Rate,
                Genre = book.Genre,
                Author = book.Author,
                DateAdded = book.DateAdded
            };
            _context.Books.Add(_book);
            _context.SaveChanges();
        }
    }
}
