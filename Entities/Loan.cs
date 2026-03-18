using System.Text;

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

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"ID: {Id} - Person: {Person.Name} - Book: {Book.Title}") ;

        sb.Append($"LoanDate: {LoanDate.ToString("dd/MM/yyyy")}");
        sb.Append($" ExpectedReturnDate: {ExpectedReturnDate.ToString("dd/MM/yyyy")}");
        sb.Append($" ReturnDate: {(ReturnDate != null ? ReturnDate : "")}");
        
        return sb.ToString();
    }
}