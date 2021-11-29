using AdventOfCodeConsole.Utilities;

namespace AdventOfCodeConsole.Missions._2020;

public class Day1
{
    public static string SolveMission1()
    {
        int[] input = InputUtilities.ConvertInputToIntList(InputUtilities.ReadFileToString(Path.GetFullPath(@"..\..\..\Missions\2020\Input\1-1.txt")));

        int[] totalNumbers = Utilities2020.FindNumberPairTotaling(input, 2020);
        
        // Return that value multiplied by (2020-value)
        return (totalNumbers[0] * totalNumbers[2]).ToString();
    }
}