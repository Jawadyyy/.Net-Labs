using BlazorBookLibrary.Models;
using System.Collections.Generic;

namespace BlazorBookLibrary.Services {
    public class BookService {

        private readonly List<Book> _books = new ();

        public List<Book> GetBooks() => _books;

        public void IncBook(Book book) {
                book.Id = _books.Count + 1;
                _books.Add(book);
        }
    }
}