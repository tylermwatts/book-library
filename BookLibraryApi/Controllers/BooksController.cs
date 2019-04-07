using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using BookLibraryApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookLibraryApi.Controllers {
  [Route ("api/[controller]")]
  public class BooksController : ControllerBase {
    List<Book> books = new List<Book> {
      new Book { Id = 1, Author = "Larson,Erik", Title = "Devil in the White City", Subcategory = Subcategory.True_Crime },
      new Book { Id = 2, Author = "Phillips,Christopher", Title = "Socrates Cafe", Subcategory = Subcategory.Philosophy },
      new Book { Id = 3, Author = "Obama,Michelle", Title = "Becoming", Subcategory = Subcategory.Biography }
    };
    [HttpGet]
    public ActionResult<IEnumerable<Book>> Get () {
      return books;
    }

    [HttpGet ("{id}")]
    public ActionResult<Book> Get (int id) {
      var book = books.FirstOrDefault (b => b.Id == id);
      if (book == null) {
        return NotFound ();
      }
      return book;
    }

  }
}