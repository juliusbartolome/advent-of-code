using AdventOfCode.DayOneTribuchet;

var input = File.ReadAllLines("Puzzle.txt");

var partOne = new PartOne();
var partOneAnswer = partOne.Calculate(input);
Console.WriteLine($"Part One Answer: {partOneAnswer}");

var partTwo = new PartTwo();
var partTwoAnswer = partTwo.Calculate(input);
Console.WriteLine($"Part Two Answer: {partTwoAnswer}");
