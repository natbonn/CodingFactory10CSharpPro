namespace OOApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User alice = new User();
            User bob = new();         // C# 9.0 target-typed new expression
            var charlie = new User(); // C# 10.0 implicitly typed local variable

            Teacher teacher = new Teacher();
            Teacher teacher2 = new();     // C# 9.0 target-typed new expression
            var teacher3 = new Teacher(); // C# 10.0 implicitly typed local variable
            Teacher teacher4 = new Teacher(1, "John", "Doe");          // wants constructor with parameters
            Teacher tacher5 = new() { Id = 2, Firstname = "Jane", Lastname = "Smith" };  // wants setters and getters

            User dimis = new User()   // Object initializer syntax
            {
                Id = 1,               // Id from the User class Set
                Username = "dimis",
                Email = "dimis@example.com"
            };

            // setters
            alice.Id = 1;             
            alice.Username = "alice";
            alice.Email = "alice@example.com";

            // getters
            Console.WriteLine($"Alice: {alice.Username} ({alice.Email})");
            Console.WriteLine($"Dimis: {dimis.Username} ({dimis.Email})");

        }
    }
}
