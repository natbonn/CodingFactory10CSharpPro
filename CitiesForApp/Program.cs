namespace CitiesForApp
{
    /// <summary>
    /// Όπως και στη Java
    /// For control structure
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "Athens", "Thessaloniki", "Patras", "Heraklion", "Larissa" };

            // όταν ξερουμε πόσα iteration θα κάνουμε
            for (int i = 0; i < cities.Length; i++)
            {
                if (cities[i] == "Patras")
                {
                    Console.WriteLine($"Found {cities[i]} at index {i}");
                    break; 
                }
            }

            // Safe way to iterate through the array using foreach
            foreach (string city in cities)
            {
                if (city == "Heraklion")
                {
                    Console.WriteLine($"Found {city} in the list.");
                    break;
                }
            }
        }
    }
}
