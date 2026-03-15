using MinhaBibliotexa.Entities;

namespace MinhaBibliotexa.Services;

public class LibraryService
{
    public List<Loan> loans { get; private set; }= new List<Loan>();
}