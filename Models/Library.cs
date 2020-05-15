using System;
using System.Collections.Generic;

namespace console_library.Models
{
  public class Library
  {
private List<Book> Books {get; set;}


  public void PrintBooks()
  {
    for (int i = 0; i <Books.Count; i++)
    {
      Console.WriteLine($"{i+1} {Books[i].Title} - {Books[i].Author}");
    }
  }

  }
}