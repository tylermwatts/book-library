using System.Collections.Generic;
using BookLibraryApi.Models;

namespace BookLibraryApi.Repository {
  public interface IBookRepository {
    void AddBook (Book book);
    void DeleteBook (Book book);
    IEnumerable<Book> GetAll ();
    Book GetById (int id);
    void UpdateBook (Book oldBook, Book newBook);

  }
}