using MinhaBibliotexa.Entities;

namespace MinhaBibliotexa.Services;

public class BookService
{
    public List<Book> books { get; private set; } = new List<Book>();
    
    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void ListBooks()
    {
        foreach (Book book in books)
        {
            Console.WriteLine(book);
        }
    }
}