using System.Collections.Generic;
using BookLibraryApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookLibraryApi.Repository {
	public class BookRepository {
		List<Book> books = new List<Book> {
			new Book { Id = 1, Author = "Larson,Erik", Title = "Devil in the White City", Subcategory = Subcategory.True_Crime },
			new Book { Id = 2, Author = "Phillips,Christopher", Title = "Socrates Cafe", Subcategory = Subcategory.Philosophy },
			new Book { Id = 3, Author = "Obama,Michelle", Title = "Becoming", Subcategory = Subcategory.Biography },
			new Book { Id = 4, Author = "McCarthy,Cormac", Title = "All the Pretty Horses", Subcategory = Subcategory.Literature },
			new Book { Id = 5, Author = "Rothfuss,Patrick", Title = "Name of the Wind", Subcategory = Subcategory.Fantasy }
		};

		public IEnumerable<Book> GetAll () {
			return books;
		}

		public Book GetById (int id) {
			return books.Find (b => b.Id == id);
		}

		public void AddBook (Book book) {
			books.Add (book);
		}

		public void DeleteBook (Book book) {
			books.Remove (book);
		}

		public void UpdateBook (Book oldBook, Book newBook) {
			var book = books.Find (b => oldBook.Id == b.Id);
			book.Author = newBook.Author;
			book.Title = newBook.Title;
			book.Subcategory = newBook.Subcategory;
		}

	}
}