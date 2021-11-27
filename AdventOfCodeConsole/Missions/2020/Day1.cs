using AdventOfCodeConsole.Utilities;

namespace AdventOfCodeConsole.Missions._2020;

public class Day1
{
    public static string SolveMission1()
    {
        int[] input = InputUtilities.ConvertInputToIntList(InputUtilities.ReadFileToString(Path.GetFullPath(@"..\..\..\Missions\2020\Input\1-1.txt")));
        
        // Make a list that contains the values of the input subtracted from 2020
        int[] invert = Utilities2020.InvertIntList(input, 2020);
        
        // Find the value that is in both lists
        int solution = Utilities2020.FindCommonValue(input, invert);
        
        // Return that value multiplied by (2020-value)
        return (solution * (2020-solution)).ToString();
    }
}