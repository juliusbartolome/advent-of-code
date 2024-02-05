using System.Text.RegularExpressions;

namespace AdventOfCode.DayOneTribuchet;

public class PartOne
{
    public int Calculate(string[] puzzleInput)
    {
        var sum = 0;

        var regex = new Regex("[0-9]");
        for (var i = 0; i < puzzleInput.Length; i++)
        {
            var matches = regex.Matches(puzzleInput[i]);
            if (matches.Count == 0) continue;
            
            sum += int.Parse(matches[0].Value + matches[^1].Value);
        }

        return sum;
    }
}