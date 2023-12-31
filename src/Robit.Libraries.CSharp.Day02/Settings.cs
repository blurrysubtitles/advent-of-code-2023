namespace Robit.Libraries.CSharp.Day02;

public class Settings
{
    public static readonly string Name = nameof(Settings);

    public string InputFilePath { get; set; } = "./Content/02/input.txt";
    public int Red { get; set; } = 12;
    public int Green { get; set; } = 13;
    public int Blue { get; set; } = 14;
}