using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using BookLibraryApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookLibraryApi.Controllers {
  public class BooksController : ControllerBase {
    Book[] books = new Book[] {
      new Book { Id = 1, Author = "Larson,Erik", Title = "Devil in the White City", Subcategory = Subcategory.True_Crime },
      new Book { Id = 2, Author = "Phillips,Christopher", Title = "Socrates Cafe", Subcategory = Subcategory.Philosophy },
      new Book { Id = 3, Author = "Obama,Michelle", Title = "Becoming", Subcategory = Subcategory.Biography }
    };

    public IEnumerable<Book> GetAllBooks () => books;

    public ActionResult<Book> GetProduct (int id) {
      var book = books.FirstOrDefault ((b) => b.Id == id);
      if (book == null) {
        return NotFound ();
      }
      return Ok (book);
    }

  }
}