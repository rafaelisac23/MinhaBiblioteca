using MinhaBibliotexa.Entities;
using MinhaBibliotexa.Services;

namespace MinhaBibliotexa;
class Program
{
    static BookService books = new BookService();
    static void Main(string[] args)
    {
        ShowMenu();
    }

    static void  ShowMenu()
    {
        SetConfig();
        ShowQuad();
        ShowOptions();
        Console.SetCursorPosition(10,10);
        Console.WriteLine("Option: ");
        Console.SetCursorPosition(17,10);
        try
        {
            int option = int.Parse(Console.ReadLine());
            SelectAction(option);
        }
        catch (FormatException e)
        {
            Console.Clear();
            Console.WriteLine("The Option is not valid option.");
            Thread.Sleep(2000);
            Console.Clear();
            ShowMenu();
        }
       
        
    }
    static void SetConfig()
    {
        Console.Clear();
        Console.BackgroundColor= ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        
      
    }
    static void ShowQuad()
    {
        Console.Clear();
        Console.Write("┌");
        for (int i = 0; i < 78; i++)
        {
            Console.Write("─");
        }     
        Console.Write("┐");
        Console.WriteLine();
        
        for (int i = 0; i < 22; i++)
        {
            Console.Write("│");
            for (int j = 0; j < 78; j++)
            {
                Console.Write(" ");
            } 
            Console.WriteLine("│");
        }     
        Console.Write("└");
        for (int i = 0; i < 78; i++)
        {
            Console.Write("─");
        }     
        Console.Write("┘");
        
    }
    static void ShowOptions()
    {
        Console.SetCursorPosition(30,2);
        Console.WriteLine("1-Register Book");
        Console.SetCursorPosition(30,3);
        Console.WriteLine("2-Register Person");
        Console.SetCursorPosition(30,4);
        Console.WriteLine("3-Borrow Book");
        Console.SetCursorPosition(30,5);
        Console.WriteLine("4-Return Book");
        Console.SetCursorPosition(30,6);
        Console.WriteLine("5-List Books");
        Console.SetCursorPosition(30,7);
        Console.WriteLine("0-Exit");
     
    }
    static void SelectAction(int option)
    {
        switch (option)
        {
            case 1:
                ShowRegisterBookMenu();
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                ShowBooks();
                break;
            case 0:
                Console.Clear();
                break;
            default:
                Console.Clear();
                ShowMenu();
                break;
        }
    }
    static void ShowRegisterBookMenu()
    {
       
        
        ShowQuad();
        Console.SetCursorPosition(8,1);
        Console.WriteLine("1-Register Book");
        Console.SetCursorPosition(8,4);
        Console.WriteLine("Book Id: ");
        Console.SetCursorPosition(16,4);
        int id  = int.Parse(Console.ReadLine());
        Console.SetCursorPosition(8,6);
        Console.WriteLine("Book Title: ");
        Console.SetCursorPosition(19,6);
        string bookTitle  = Console.ReadLine();
        Console.SetCursorPosition(8,8);
        Console.WriteLine("Book Author: ");
        Console.SetCursorPosition(21,8);
        string bookAuthor  = Console.ReadLine();
        
        books.AddBook(new Book(id,bookTitle,bookAuthor));
        
        ShowMenu();
        
    }
    static void ShowBooks()
    {
        
        ShowQuad();
        Console.SetCursorPosition(3,2);
        foreach (Book book in books.books)
        {
            Console.WriteLine(book);
        }
        
        int r  = int.Parse(Console.ReadLine());
        
        
      
        
    }
   
}
