namespace AdventOfCodeConsole.Utilities;

public class InputUtilities
{
    public static string[] ConvertInputToStringList(string input)
    {
        return input.Split(null);
    }
    
    public static int[] ConvertInputToIntList(string input)
    {
        return ConvertInputToStringList(input).Select(Int32.Parse).ToArray();
    }
}