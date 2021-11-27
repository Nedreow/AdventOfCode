namespace AdventOfCodeConsole.Missions;

public class InputUtilities
{
    public static string[] ConvertInputToStringList(string input)
    {
        return input.Split(null).ToArray();
    }
    
    public static int[] ConvertInputToIntList(string input)
    {
        return ConvertInputToStringList(input).Select(Int32.Parse).ToArray();
    }
}