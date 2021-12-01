using AdventOfCodeConsole.Utilities;

namespace AdventOfCodeConsole.Tasks;

public class Advent2021 : Advent
{
    public Advent2021() : base("2021") { }

    public override string? SolveTask1_1()
    {
        int[] input = InputUtilities.ConvertInputToIntList(InputUtilities.GetInput("2021", "1_1"));
        
        return Utilities2021.CountIncreased(input).ToString();
    }

    public override string? SolveTask1_2()
    {
        int[] input = InputUtilities.ConvertInputToIntList(InputUtilities.GetInput("2021", "1_1"));
        
        return Utilities2021.CountIncreased(Utilities2021.sumSlices(input, 3)).ToString();
    }
}