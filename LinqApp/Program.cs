namespace LinqApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = [1, 2, 3, 4, 5];

            // LINQ query to filter even numbers
            IEnumerable<int> allNumbers = from num in numbers
                             select num;

            // για εκτέλεση θέλει foreach
            foreach (var num in allNumbers)
            {
                Console.WriteLine(num);
            }

            var evenNumbers = (from num in numbers
                               where num % 2 == 0
                               select num).ToList();

            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }

            // Mapping: LINQ query to square each number
            var squareNumbers = (from num in numbers
                                 select num + num).ToList();
        }
    }
}
