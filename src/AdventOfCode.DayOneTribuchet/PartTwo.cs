using System.Text.RegularExpressions;

namespace AdventOfCode.DayOneTribuchet;

public class PartTwo
{
    public int Calculate(string[] puzzleInput)
    {
        var sum = 0;
        var numberNameRegex = new Regex("(?=(one|two|three|four|five|six|seven|eight|nine|[0-9]))");
        for (var i = 0; i < puzzleInput.Length; i++)
        {
            var matches = numberNameRegex.Matches(puzzleInput[i]);
            var num = matches.Count > 0 
                ? GetNumber(matches[0].Groups[1].Value) + GetNumber(matches[^1].Groups[1].Value) 
                : "0";
            
            Console.WriteLine($"{i + 1}: {num}");
            sum += int.Parse(num);
        }

        return sum;
    }

    private static string GetNumber(string value)
    {
        if (value.Length == 1) return value;
        
        return value switch
        {
            "one" => "1",
            "two" => "2",
            "three" => "3",
            "four" => "4",
            "five" => "5",
            "six" => "6",
            "seven" => "7",
            "eight" => "8",
            "nine" => "9",
            _ => string.Empty
        };
    }
}