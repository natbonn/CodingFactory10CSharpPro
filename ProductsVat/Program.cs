namespace ProductsVat
{
    /// <summary>
    /// Read a product price from the console,
    /// calculates the VAT amount 24% and the total price,
    /// and prints the results formatted to 2 decimal places
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            const double VAT_RATE = 0.24;

            double productPrice = 0.0;
            double vatAmount = 0.0;
            double totalPrice = 0.0;

            Console.WriteLine("Enter the product price: ");
            if (!double.TryParse(Console.ReadLine(), out productPrice) || productPrice <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

            // Calculate VAT and total price
            vatAmount = productPrice * VAT_RATE;
            totalPrice = productPrice + vatAmount;

            // Print results
            Console.WriteLine($"Product price: {productPrice:F2}");
            Console.WriteLine($"VAT amount: {vatAmount:F2}");
            Console.WriteLine($"Total Price: {totalPrice:F2}");
        }
    }
}
