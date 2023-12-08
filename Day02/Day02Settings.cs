namespace AdventOfCode.Models;

public class Day02Settings
{
    public static readonly string Name = nameof(Day02Settings);

    public string InputFilePath { get; set; } = "./Content/02/input.txt";
    public int Red { get; set; } = 12;
    public int Green { get; set; } = 13;
    public int Blue { get; set; } = 14;
}