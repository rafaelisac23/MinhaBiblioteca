namespace MinhaBibliotexa.Entities;

public class Loan
{
    public int Id  { get; set; }
    public Person Person { get; set; }
    public Book Book { get; set; }
    public DateTime LoanDate { get; set; }
    public DateTime? ReturnDate { get; set; }
    public  DateTime ExpectedReturnDate { get; set; }

    public Loan(int id, Person person, Book book)
    {
        Id = id;
        Person = person;
        Book = book;
        LoanDate = DateTime.Now;
        ExpectedReturnDate = LoanDate.AddDays(7);
        ReturnDate = null;
        
    }
}