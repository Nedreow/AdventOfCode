using AdventOfCodeConsole.Utilities;
using AdventOfCodeConsole.Utilities._2021;

namespace AdventOfCodeConsole.Tasks;

public class Advent2021 : Advent
{
    public Advent2021() : base("2021") { }

    public override string? SolveTask1_1()
    {
        IEnumerable<int> input = InputUtilities.ConvertInputToIntList(InputUtilities.GetInput("2021", "1_1"));
        
        return Utilities2021.CountIncreased(input).ToString();
    }

    public override string? SolveTask1_2()
    {
        IEnumerable<int> input = InputUtilities.ConvertInputToIntList(InputUtilities.GetInput("2021", "1_1"));
        
        return Utilities2021.CountIncreased(Utilities2021.SumSlices(input, 3)).ToString();
    }

    public override string? SolveTask2_1()
    {
        IEnumerable<string> input = InputUtilities.ConvertInputToStringList(InputUtilities.GetInput("2021", "2_1"));
        SimpleSubmarine sub = new SimpleSubmarine();
        
        sub.Move(input);

        return (sub.Distance * sub.Depth).ToString();
    }

    public override string? SolveTask2_2()
    {
        IEnumerable<string> input = InputUtilities.ConvertInputToStringList(InputUtilities.GetInput("2021", "2_1"));
        AimedSubmarine sub = new AimedSubmarine();
        
        sub.Move(input);

        return (sub.Distance * sub.Depth).ToString();
    }
}