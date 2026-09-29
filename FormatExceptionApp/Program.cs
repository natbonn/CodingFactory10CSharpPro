namespace FormatExceptionApp
{
    /// <summary>
    /// Διαβάζει ένα string άπό την κονσόλα
    /// και προσπαθεί να το μετατρέψει σε ακέραιο με Parse
    /// και θα ελέγξει με try-catch για FormatException
    /// 
    /// Μη ξεχάσουμε στη C# δεν υπάρχουν checked & unchecked exceptions όπως στη Java
    /// Όπότε δε χρειάζεται να δηλώσετε throws FormatException στη μέθοδο Main. 
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            {int num = 0;

            while (true)
            {
                try
                    {
                        Console.WriteLine("Παρακαλώ εισάγετε έναν αριθμό: ");
                        num = int.Parse(Console.ReadLine()!);
                        Console.WriteLine($"Ο αριθμός που εισάγατε είναι: {num}");
                        if (num == 0) break;
                    }
                catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                    }
            }
        }
    }
}
