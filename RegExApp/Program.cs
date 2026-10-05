using System.Text.RegularExpressions;
namespace RegExApp;

internal class Program
{
    static void Main(string[] args)
    {
        string s = "I love coding";
        TestMatch(s);
    }

    public static bool TestStringPatter(string? s)
    {
        if (s == null) return false;

        string pattern = @"^coding$";  // @ row string - starts exactly with lower case and end with same word
        bool isMatch = Regex.IsMatch(s, pattern);  // regex class
        return isMatch;   // returns true or false - validation
    }

    public static void TestMatch(string? s)
    {
        if (s is null) return;    // is αντι για == για να μην υπερφορτωθεί
        string pattern = @"coding";
        Match match = Regex.Match(s, pattern);

        if (match.Success)
        {
            Console.WriteLine(match.Value);     // prints the first match value
        }
    }

    public static void TestMatches(string? s)
    {
        if (s is null) return;    
        string pattern = @"\d+";    // 1 or more digits

        MatchCollection matches = Regex.Matches(s, pattern);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }

   
}
