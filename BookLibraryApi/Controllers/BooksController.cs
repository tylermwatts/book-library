using System.Collections.Generic;
using BookLibraryApi.Models;
using BookLibraryApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BookLibraryApi.Controllers {
  [Route ("api/[controller]")]
  public class BooksController : ControllerBase {
    private readonly IBookRepository bookRepository;
    public BooksController (IBookRepository bookRepository) {
      this.bookRepository = bookRepository;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Book>> Get () {
      return Ok (bookRepository.GetAll ());
    }

    [HttpGet ("{id}")]
    public ActionResult<Book> Get (int id) {
      var book = bookRepository.GetById (id);
      if (book == null) {
        return NotFound ();
      }
      return Ok (book);
    }

    [HttpPost]
    public IActionResult Post ([FromBody] Book book) {
      bookRepository.AddBook (book);
      return Ok (book);
    }

    [HttpDelete ("{id}")]
    public IActionResult Delete (int id) {
      var book = bookRepository.GetById (id);
      if (book == null) {
        return NotFound ();
      }
      bookRepository.DeleteBook (book);
      return Ok ();
    }

    [HttpPut ("{id}")]
    public IActionResult Put (int id, [FromBody] Book newBook) {
      var book = bookRepository.GetById (id);
      if (book == null) {
        return NotFound ();
      }
      bookRepository.UpdateBook (book, newBook);
      return Ok ();
    }
  }
}