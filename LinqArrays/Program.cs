namespace LinqArrays
{
    /// <summary>
    /// LINQ (Language Integrated Query) is powerful feauture in C#
    /// that allows you to query and manipulate data from various sources,
    /// including arrays, collections, databases and more.
    /// In this example, we will demonstrate how to use LINQ methods to 
    /// perform common operations on an array of integers.
    /// </summary>
   internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 3, 8, 9, 2, 12 };

            // Linq methods
            int min = arr.Min();
            int max = arr.Max();
            int sum = arr.Sum();
            double average = arr.Average();
            int count = arr.Count();    // int count = arr.Length; - also valid
            int countGT4 = arr.Count(x => x > 4);   // Count elements greater than 4

            // Filtering with where & lambda / var λειτουργεί σαν int[]
            var filtered = arr.Where(x => x > 4).ToArray();
            var doubled = arr.Select(x => x * 2).ToArray();   // Map each element to its double
            var sorted = arr.OrderBy(x => x).ToArray();     // Sort the array in asc order
            var sortedDesc = arr.OrderByDescending(x => x).ToArray();   // desc order
            bool any = arr.Any(x => x > 10);     // Check if any element is greater than 10
            bool all = arr.All(x => x > 0);      // Check if all elements are grater than 10
            int first = arr.First(x => x > 4);   // The first that (...)

        }
    }
}
