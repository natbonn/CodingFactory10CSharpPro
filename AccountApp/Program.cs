using AccountApp.Exceptions;
using AccountApp.Model;

namespace AccountApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new()
            {
                Id = 1,
                Iban = "GR123456789",
                Firstname = "John",
                Lastname = "Doe",
                Ssn = "123-45-6789",
                Balance = 1000.00m
            };

            try
            {
                account.Deposit(50.00m);
                Console.WriteLine($"Deposit successful. New balance: {account.Balance}");

                account.Withdraw(30.00m, "123-45-6789");

                // Fails
                account.Deposit(-20.00m);                   // NegativeAmountException
                account.Withdraw(100.00m, "12345");         // InvalidSsvnException
                account.Withdraw(2000.00m, "123-45-6789");  // InsufficientBalanceException
            }
            catch (Exception ex) when (ex is NegativeAmountException
                                       or InsufficientBalanceException
                                       or InvalidSsnException)
            {
                Console.WriteLine($"Transaction failed: {ex.GetType().Name}");
            }
        }
    }
}
