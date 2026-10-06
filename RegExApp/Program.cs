using System.Text.RegularExpressions;
namespace RegExApp;

internal class Program
{
    static void Main(string[] args)
    {
        //string s = "I love coding";
        //TestMatch(s);

        string date = "12-30-2026";
        MapToGrDate(date);
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

    public static void TestGroups(string? s)
    {
        if (s is null) return;

        // mm-dd-yyyy (US format)
        string pattern = @"(\d{2})-(\d{2})-(\d{4})";

        MatchCollection matches = Regex.Matches(s, pattern);

        foreach (Match match in matches)
        {
            for (int i = 1; i < match.Groups.Count; i++)
            {
                Console.WriteLine($"Group {i}: {match.Groups[i].Value}");
            }
        }
    }

    public static void MapToGrDate(string? s)
    {
        if (s is null) return;

        // mm-dd-yyyy(US format)
        string pattern = @"(\d{2})-(\d{2})-(\d{4})";

        MatchCollection matches = Regex.Matches(s, pattern);

        foreach (Match match in matches)
        {
            string month = match.Groups[1].Value;
            string day = match.Groups[2].Value;
            string year = match.Groups[3].Value;
            string grDate = $"{day}/{month}/{year}";
            Console.WriteLine($"{match.Value} -> {grDate}");
        }
    }

    // Zero-length assertions
    public static bool TestStrongPassword(string? s)
    {
        return Regex.IsMatch(s, "^(?=.*[A-Z]).(?=.*[a-z]).(?=.*[0-9]).(?=.*[!@#$%^&*]).{12,}$");
    }
}
