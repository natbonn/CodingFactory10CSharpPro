namespace PyramidChallenge
{
    /// <summary>
    /// Ο χρήστης εισάγει το ύψος της πυραμίδας και το
    /// πρόγραμμα εμφανίζει την πυραμίδα με αστεράκια
    /// ΠΧ αν ο χρήστης εισάγει 5 η έξοδος 8α είναι: 
    ///     *
    ///    ***
    ///  ********
    /// **********
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int height = 5;

            for (int i = 1; i <= height; i++) 
            {
                // Κενά
                for (int j = 1; j <= height - i; j++)
                    Console.Write(" ");

                // Αστεράκια
                for (int k = 1; k <= 2 * i - 1; k++)
                    Console.Write("*");

                // Νέα γραμμή
                Console.WriteLine();
            } 
        }
    }
}
