namespace NullableApp
{
    /// <summary>
    /// Demonstrates the use of nullable 
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            string? s = Console.ReadLine();

            if (s != null ) Console.WriteLine(s.Length);

            Console.WriteLine(s?.Length);      // Null conditional (safe)
            Console.WriteLine(s!.Length);      // null-forgiving operator (not safe)
            Console.WriteLine(s ?? "Default"); // null-coalescing operator (safe)


        }
    }
}
