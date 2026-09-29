namespace SwitchApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? dayOfWeek = "Monday";

            switch(dayOfWeek)
            {
                case "Monday":
                    Console.WriteLine("Today is Monday.");
                    break;
                case "Tuesday":
                    Console.WriteLine("Today is Tuesday.");
                    break;
                case "Wednesday":
                    Console.WriteLine("Today is Wednesday.");
                    break;
                case "Thursday":
                    Console.WriteLine("Today is Thursday.");
                    break;
                case "Friday":
                    Console.WriteLine("Today is Friday.");
                    break;
                case "Saturday":
                    Console.WriteLine("Today is Saturday.");
                    break;
                case "Sunday":
                    Console.WriteLine("Today is Sunday.");
                    break;
                default:
                    Console.WriteLine("Invalid day of the week.");
                    break;
            }

            // Switch expression 
            int day = 2;

            var dayName = day switch
            {
                1 => "Monday",
                2 => "Tuesday",
                3 => "Wednesday",
                _ => "Invalid day"
            };
            Console.WriteLine($"Day Name: {dayName}");

            // Switch expression with Pattern Matching
            int grade = 85;

            var letterGrade = grade switch
            {
                >= 90 => "A",
                >= 80 => "B",
                >= 70 => "C",
                >= 60 => "D",
                _ => "F"
            };
        }
    }
}
