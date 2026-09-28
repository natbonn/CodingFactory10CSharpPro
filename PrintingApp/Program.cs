using System.Globalization;

namespace PrintingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 12_334_555;      // για readability
            double dNum = 100.1233456789765430;

            CultureInfo.CurrentCulture = new CultureInfo("en-US");      // Set culture for consistent (, αντί για .)
            Console.WriteLine("Int-Num = {0, -10:N0}, Double-Num = {1, -20:N2}", num, dNum);   // placeholder syntax
            Console.WriteLine($"Int-Num = {num, -10:N0}, Double-Num = {dNum, -20:N2}");        // interpolation syntax
        }
    }
}
