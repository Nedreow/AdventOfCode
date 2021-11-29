using AdventOfCodeConsole.Utilities;

namespace AdventOfCodeConsole.Tasks._2020;

public class Day1
{
    public static string SolveTask1()
    {
        int[] input = InputUtilities.ConvertInputToIntList(InputUtilities.ReadFileToString(Path.GetFullPath(@"..\..\..\Tasks\2020\Input\1-1.txt")));

        int[] totalNumbers = Utilities2020.FindNumberPairTotaling(input, 2020);
        
        // Return that value multiplied by (2020-value)
        return (totalNumbers[0] * totalNumbers[1]).ToString();
    }
}