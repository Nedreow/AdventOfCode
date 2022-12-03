using System.Collections;
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
        IEnumerable<string> input = InputUtilities.ConvertInputToStringList(InputUtilities.GetInput("2021", "2_1.txt"));
        SimpleSubmarine sub = new SimpleSubmarine();
        
        sub.Move(input);

        return (sub.Distance * sub.Depth).ToString();
    }

    public override string? SolveTask2_2()
    {
        IEnumerable<string> input = InputUtilities.ConvertInputToStringList(InputUtilities.GetInput("2021", "2_1.txt"));
        AimedSubmarine sub = new AimedSubmarine();
        
        sub.Move(input);

        return (sub.Distance * sub.Depth).ToString();
    }

    public override string? SolveTask3_1()
    {
        List<string> input = InputUtilities.ConvertInputToStringList(InputUtilities.GetInput("2021", "3_1")).ToList();
        BitArray gamma = new BitArray(input.First().Length);
        BitArray epsilon = new BitArray(input.First().Length);
        
        List<string> columnStrings = Utilities2021.StringListRowToColumn(input);
        // ToNumeral places the most significant bit last, while the input puts it first
        columnStrings.Reverse();

        for (int i = 0; i < columnStrings.Count; i++)
        {
            int oneCount = Utilities2021.CountChar(columnStrings[i], '1');

            if (oneCount > columnStrings[i].Length / 2)
            {
                gamma[i] = true;
            } else {
                epsilon[i] = true;
            }
        }
        
        return (gamma.ToNumeral() * epsilon.ToNumeral()).ToString();
    }
}