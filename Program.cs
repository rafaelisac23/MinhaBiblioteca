using MinhaBibliotexa.Entities;
using MinhaBibliotexa.Services;

namespace MinhaBibliotexa;
class Program
{
    static BookService books = new BookService();
    static PersonService persons = new PersonService();
    static LoanService loans = new LoanService();
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
        Console.WriteLine("1-Register Book");//ok
        Console.SetCursorPosition(30,3);
        Console.WriteLine("2-Register Person");//ok
        Console.SetCursorPosition(30,4);
        Console.WriteLine("3-Borrow Book");
        Console.SetCursorPosition(30,5);
        Console.WriteLine("4-Return Book");
        Console.SetCursorPosition(30,6);
        Console.WriteLine("5-List Books");//ok
        Console.SetCursorPosition(30,7);
        Console.WriteLine("6-List Persons");//ok
        Console.SetCursorPosition(30,8);
        Console.WriteLine("7-List Loans");//ok
        Console.SetCursorPosition(30,9);
        Console.WriteLine("0-Exit");//ok
     
    }
    static void SelectAction(int option)
    {
        switch (option)
        {
            case 1:
                ShowRegisterBookMenu();
                break;
            case 2:
                ShowRegisterPersonMenu();
                break;
            case 3:
                ShowBorrowBookMenu();
                break;
            case 4:
                break;
            case 5:
                ShowBooks();
                break;
            case 6:
                ShowPersons();
                break;
            case 7:
                ShowLoans();
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
    static void ShowRegisterPersonMenu()
    {
        ShowQuad();
        Console.SetCursorPosition(8,1);
        Console.WriteLine("2-Register Person");
        Console.SetCursorPosition(8,4);
        Console.WriteLine("Person Id: ");
        Console.SetCursorPosition(19,4);
        int id  = int.Parse(Console.ReadLine());
        Console.SetCursorPosition(8,6);
        Console.WriteLine("Person Name: ");
        Console.SetCursorPosition(21,6);
        string personName  = Console.ReadLine();
        Console.SetCursorPosition(8,8);
        Console.WriteLine("Person RG: ");
        Console.SetCursorPosition(19,8);
        int personRG  = int.Parse(Console.ReadLine());
        
        persons.AddPerson(new Person(id,personName,personRG));
        
        ShowMenu();
        
    }
    static void ShowBorrowBookMenu()
    {
        ShowQuad();
        try
        {
            Console.SetCursorPosition(8,1);
            Console.WriteLine("3-Borrow Book");
            Console.SetCursorPosition(8,4);
            Console.WriteLine("Loan id: ");
            Console.SetCursorPosition(17,4);
            int loanId  = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(8,6);
            Console.WriteLine("Person Id: ");
            Console.SetCursorPosition(21,6);
            int personId  = int.Parse(Console.ReadLine());
            Person p = VerifyPerson(personId);
            Console.SetCursorPosition(8,8);
            Console.WriteLine("Book Id: ");
            Console.SetCursorPosition(19,8);
            int bookId  = int.Parse(Console.ReadLine());
            var b = VerifyBook(bookId);
            loans.AddLoan(new Loan(loanId,p,b));

        }
        catch (ArgumentException e)
        {
            Console.Clear();
            ShowQuad();
            Console.SetCursorPosition(19,8);
            Console.WriteLine("An occurred a erro: ");
            Console.SetCursorPosition(19,9);
            Console.WriteLine(e.Message);
            Thread.Sleep(4000);
        }
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
        Console.SetCursorPosition(3,19);
        Console.WriteLine("Press enter to return menu");
        
        ConsoleKeyInfo key = Console.ReadKey(true);

        if (key.Key == ConsoleKey.Enter)
        {
            ShowMenu();
        }
        
    }
    static void ShowPersons()
    {
        ShowQuad();
        Console.SetCursorPosition(3,2);
        foreach (Person p in persons.persons)
        {
            Console.WriteLine(p);
        }
        
        Console.SetCursorPosition(3,19);
        Console.WriteLine("Press enter to return menu");
        
        ConsoleKeyInfo key = Console.ReadKey(true);

        if (key.Key == ConsoleKey.Enter)
        {
            ShowMenu();
        }
       
    }
    static void ShowLoans()
    {
        ShowQuad();
        Console.SetCursorPosition(3,2);
        foreach (Loan l in loans.loans)
        {
            Console.WriteLine(l);
        }
        
        Console.SetCursorPosition(3,19);
        Console.WriteLine("Press enter to return menu");
        
        ConsoleKeyInfo key = Console.ReadKey(true);

        if (key.Key == ConsoleKey.Enter)
        {
            ShowMenu();
        }
       
    }
    static Person VerifyPerson(int id)
    {

        if (persons.persons.Count == 0)
        {
            throw new ArgumentException("Person has no persons in your history");
        }
        
        Person person = persons.persons.Find(x => x.Id == id);
        var personInLoan = loans.loans.Find(l => l.Person.Id == id);

        if (person == null)
        {
            throw new ArgumentException("Person not found");
        }

        if (personInLoan != null)
        {
            throw new ArgumentException("Person have a loan in your history");
        }
        
        
        return person;

    }
    static Book VerifyBook(int id)
    {
        if (books.books.Count == 0)
        {
            throw new ArgumentException("No have book in books history");
        }
        Book book = books.books.Find(x => x.Id == id);
        var bookInLoan = loans.loans.Find(l => l.Book.Id == id);


        if (book == null)
        {
            throw new ArgumentException("Book not found");
        }

        if (bookInLoan != null)
        {
            throw new ArgumentException("Book have a loan in your history");
        }

        return book;
    }
  
    
   
}
