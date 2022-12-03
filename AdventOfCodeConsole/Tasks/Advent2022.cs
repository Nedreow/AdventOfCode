using System.Collections;
using AdventOfCodeConsole.Utilities;
using AdventOfCodeConsole.Utilities._2021;

namespace AdventOfCodeConsole.Tasks;

public class Advent2022 : Advent
{
    public Advent2022() : base("2022") { }

    public override string? SolveTask1_1()
    {
        IEnumerable<int> input = InputUtilities.ConvertInputToIntList(InputUtilities.GetInput("2022", "1_1"), false);
        
        return Utilities2022.FindHighestCalorieTotal(input).ToString();
    }

    public override string? SolveTask1_2()
    {
        IEnumerable<int> input = InputUtilities.ConvertInputToIntList(InputUtilities.GetInput("2022", "1_1"), false);

        return Utilities2022.CountCaloriesPerInventory(input).OrderByDescending(x => x).Take(3).Sum().ToString();
    }

    public override string? SolveTask2_1()
    {
        IEnumerable<string> input = InputUtilities.ConvertInputToStringList(InputUtilities.GetInput("2022", "2_1"));
        return input.Sum(Utilities2022.ScoreRPSMatchFaulty).ToString();
    }

    public override string? SolveTask2_2()
    {
        IEnumerable<string> input = InputUtilities.ConvertInputToStringList(InputUtilities.GetInput("2022", "2_1"));
        return input.Sum(Utilities2022.ScoreRPSMatchValid).ToString();
    }
}