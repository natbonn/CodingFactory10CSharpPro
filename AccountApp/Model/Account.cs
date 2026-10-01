using AccountApp.Exceptions;

namespace AccountApp.Model;

internal class Account
{
    public int Id { get; set; }
    public  string? Iban { get; set; }
    public string? Firstname { get; set; }
    public string?  Lastname { get; set; }
    public string? Ssn { get; set; }
    public decimal Balance { get; set; }

    // Public API

    /// <summary>
    /// Deposit the specified amount into the account. 
    /// The amount must be greater than zero. 
    /// If the amount is less than or equal to zero, an exception will be thrown.
    /// </summary>
    /// <param name="amount">The amount to deposit.</param>
    public void Deposit(decimal amount)
    {
        try
        {
            if (amount <= 0)
            {
                throw new Exceptions.NegativeAmountException("Deposit amount cannot be negative.");
            }
            Balance += amount;
        }
        catch (NegativeAmountException ex)
        {
           Console.Error.WriteLine($"Error: {ex.Message}");     // Logging
            throw;                                              // Rethrow the exception to be handled by the caller
        }
    }

    public void Withdraw(decimal amount, string? ssn)
    {
        try
        {
            // sanity check for negative amount
            if (string.IsNullOrEmpty(ssn)) throw new InvalidSsvnException("SSN cannot be null or empty.");
            // check for ssn match
            if (ssn != Ssn) throw new InvalidSsvnException("SSN does not match the account holder's SSN.");
            if (amount < 0) throw new NegativeAmountException("Withdrawal amount cannot be negative.");
            if (amount > Balance) throw new NegativeAmountException("Insufficient funds for withdrawal.");

            Balance -= amount;
        }
        catch (Exception ex) when (ex is InvalidSsvnException      // we can catch multiple exception 
                                    or NegativeAmountException
                                    or InsufficientBalanceException)
        {
            Console.Error.WriteLine($"Error: {ex.Message}");     // Logging
            throw;                                              // Rethrow the exception to be handled by the caller
        }
        
    }
}
