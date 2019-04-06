using System.Collections.Generic;

namespace BookLibraryApi.Models {
  public class Book {
    public int Id { get; set; }
    public string Author { get; set; }
    public string Title { get; set; }
    public Subcategory Subcategory { get; set; }
    public List<string> UpcCodes { get; set; }
  }
}