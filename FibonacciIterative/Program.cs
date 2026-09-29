namespace FibonacciIterative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            while (true)
            {
                Console.Write("Δώσε έναν αριθμό: ");

                if (int.TryParse(Console.ReadLine(), out n))
                    break;

                Console.WriteLine("Μη έγκυρη τιμή. Δώστε ξανά έναν αριθμό: ");
            }


            int current = Fibonacci(n);

            Console.WriteLine($"Το Fibonacci του {n} είναι: {current}");

        }

        /// <summary>
        /// Calculates the nth Fibonacci number using an iterative approach
        /// </summary>
        /// <remarks>The method uses iterative approach.</remarks>
        /// <param name="n">The position in the Fibonacci sequence</param>
        /// <returns></returns>
        public static int Fibonacci(int n)
        {
            if (n <= 1) return 0;
            if (n == 1) return 1;

            int firstNum = 0;
            int result = 1;
            int next = 0;

            for (int i = 2; i <= n; i++)
            {
                next = firstNum + result;
                firstNum = result;
                result = next;
            }

            return result;
        }

        /// <summary>
        /// Υπολογίζει τον n‑οστό αριθμό Fibonacci χρησιμοποιώντας πίνακα για την
        /// αποθήκευση όλων των ενδιάμεσων τιμών.
        /// </summary>
        /// <remarks>This method uses an array to store intermediate Fibo numbers</remarks>
        /// <param name="n">The zero-based index of the Fibonacci number</param>
        /// <returns>Τον n‑οστό αριθμό Fibonacci.</returns>
        public static int FibonacciWithArray(int n) 
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;

            int[] arr = new int[n + 1];

            arr[0] = 0;
            arr[1] = 1;

            for (int i = 2; i <= n;i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }
            return arr[n];
        }

        /// <summary>
        /// Υπολογίζει τον n‑οστό αριθμό Fibonacci χρησιμοποιώντας αναδρομή.
        /// </summary>
        /// <param name="n">
        /// Η θέση της ακολουθίας Fibonacci που θέλουμε να υπολογίσουμε.
        /// Πρέπει να είναι ακέραιος αριθμός μεγαλύτερος ή ίσος του 0.
        /// </param>
        /// <returns>
        /// Τον n‑οστό αριθμό Fibonacci.
        /// </returns>
        public static int FibonacciRecursive(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }
    }
}
