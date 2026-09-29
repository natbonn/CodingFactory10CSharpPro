namespace IfUseCases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 20;
            string? firstname = "John";

            if (age >= 18)
            {
                Console.WriteLine("Ενήλικος");
            } else
            {
                Console.WriteLine("Ανήλικος");
            }

            // Ternary operator for conditional assigment
            var status = (age >= 18) ? "Ενήλικας" : "Ανήλικος";
            Console.WriteLine($"Status: {status}");

            // Null-coalescing operator for default value assigment
            var name = firstname ?? "Unknown"; 

            // Null-conditional operator for safe member access
            var nameLength = firstname?.Length ?? 0;  // (firstname is null) ? 0 : firstname.Length;
            Console.WriteLine($"Name Length: {nameLength}");


        }
    }
}
