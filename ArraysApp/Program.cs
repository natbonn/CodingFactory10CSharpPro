namespace ArraysApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            arr[0] = 1;

            int[] arr2 = { 1, 2, 3, 4, 5 };

            int[] arr3;
            arr3 = new int[] { 1, 2, 3, 4, 5 };

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }

            foreach (var num in arr2)
            {
                Console.WriteLine(num);
            }

            // 2D array
            int[,] matrix = new int[2, 3];
            int[,] matrix2 = {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };

            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    Console.Write(matrix2[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Jagged array
            int[][] jaggedArray = new int[2][];
            jaggedArray[0] = new int[] { 1, 2, 3 };
            jaggedArray[1] = new int[] { 4, 5, 6 };

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }

            // Array methods
            int[] ints = { 5, 3, 8, 1, 2 };

            Array.Sort(ints);  // Sorts the array in ascending order - changes the original array
            Array.Reverse(ints);  // Reverses the array - changes the original array

            int elementToFind = 3;
            int index = Array.IndexOf(ints, elementToFind);  // Finds the index of the element
            if (index == -1)
            {
                Console.WriteLine($"Element {elementToFind} not found in the array.");
            }
            else
            {
                Console.WriteLine($"Element {elementToFind} found at index {index}.");
            }

            int[] copy = new int[ints.Length];
            Array.Copy(ints, copy, ints.Length);  // Copies the elements of the array to another array

        }

        // Get min position and max position
        public static int GetMinPosition(int[] arr)
        {
            int minPosition = 0;
            int min = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    minPosition = i;
                }
            }
            return minPosition;
        }

        public static int GetMaxPosition(int[] arr)
        {
            int maxPosition = 0;
            int max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    maxPosition = i;
                }
            }
            return maxPosition;
        }

        /// <summary>
        /// Checks if the given array is symmetric (palindromic).
        /// For example, [1, 2, 3, 2, 1] is symmetric, while [1, 2, 3] is not.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static bool IsSymmetric(int[] arr)
        {
            for (int i = 0, j = arr.Length - 1; i < j; i++, j--)
            {
                if (arr[i] != arr[j])
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Finds the best sum of a 2D matrix and returns 
        /// the sum along with its position (row and column) in the matrix.
        /// For example, if the matrix is:
        /// {
        ///     { 1, 2, 3 },
        ///     { 4, 5, 6 }
        /// }
        /// Best sum is 16 (2, 3, 5, 6) at position (0, 1) (0-based index).
        /// 
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static (long bestSum, int bestRow, int bestCol) FindBestSum(int[,] matrix) 
        {

        }
    }
}
