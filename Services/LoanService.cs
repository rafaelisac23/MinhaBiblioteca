using MinhaBibliotexa.Entities;

namespace MinhaBibliotexa.Services;

public class LoanService
{
    public List<Loan> loans { get; private set; } = new List<Loan>();
    
    public void AddLoan(Loan loan)
    {
        loans.Add(loan);
    }
    
}