using AdventOfCodeConsole.Utilities;

namespace AdventOfCodeConsole.Tasks;

public class Advent2021 : Advent
{
    public Advent2021() : base("2021")
    {
        
    }

    public new string SolveTask1_1()
    {
        int[] input = InputUtilities.ConvertInputToIntList(InputUtilities.GetInput("2020", "1_1"));

        int[] totalNumbers = Utilities2020.FindNumberPairTotaling(input, 2020);
        int solution = totalNumbers[0] * totalNumbers[1];

        return solution.ToString();
    }
}