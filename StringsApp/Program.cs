namespace StringsApp
{
    /// <summary>
    /// String are immutable and interned sequences of characters in C#
    /// This means that once a sttring is created, it cannot be changed.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            string? str1 = "Hello";
            string? str2 = "Hello";
            string? str3 = new string("Hello");    // new instance

            // indexer - έχει υπερφορτωθεί να δουλεύει με strings
            Console.WriteLine(str1[0]);
            Console.WriteLine(str2[0]);
            Console.WriteLine(str3[0]);

            // String equality
            Console.WriteLine(str1 == str2);  // True, beacuse strings are interned
            Console.WriteLine(str1.Equals(str2));  // same as previous with Equals method
            Console.WriteLine(str1 == str3);  // False, because str3 is a new instance

            // Reference equality
            Console.WriteLine(object.ReferenceEquals(str1, str2));   // True, because of string interning
            Console.WriteLine(object.ReferenceEquals(str1, str3));   // False, beacuse str3 is a new instance

            // Compare strings
            Console.WriteLine(string.Compare(str1, str2));    // 0, equal
            Console.WriteLine(str1.CompareTo(str2));          // 0, equal
            int resultEqualsIgnoreCase = string.Compare(str1, str2, StringComparison.OrdinalIgnoreCase);

            // concatenation - δεν συνίσταται καλύτερα με StringBuilder αν έχουμε πολλές συνενώσεις
            string str4 = str1 + "World";   // Concatenation using +
            string str5 = string.Concat(str1, "World");    // Concatenation using Concat method

            // toUpper and toLower
            string str6 = str1.ToUpper(); // "HELLO"
            string str7 = str1.ToLower(); // "hello"

            Console.WriteLine(str1.ToUpper() == str2.ToUpper());     //Normized comparison, True

            // Substring
            string str8 = str1.Substring(1, 3); // "ell"
            string str9 = str1.Substring(1);    // "ello"

            // C# 8.0 Introduces the concept or ranges and indices,
            // which can be used to extract substrings in a more concise way.
            // New better way more clean
            string? subStr = str1[..2];
            string? endStr = str1[2..];

            // indexOf and lastIndexOf
            int index = str1.IndexOf('l');
            if (index == -1)
            {
                Console.WriteLine("Character 'l' not found.");
            } else
            {
                Console.WriteLine($"Character 'l' found at index: {index}");
            }

            int lastIndex = str1.LastIndexOf('l');

            // trim
            string str10 = "    Hello World  ";
            string? trimmedStr = str10.Trim();  // "Hello World"

            string? str11 = "   Hello World  $#  ";
            char[] trimChars = { ' ', '$', '%', '#' };
            string? trimmedStr2 = str11.Trim(trimChars);     // "Hello World"



        }
    }
}
