namespace AdventOfCodeConsole.Utilities._2021;

public struct Position
{
    public Position(int distance, int depth)
    {
        Distance = distance;
        Depth = depth;
    }

    public int Distance { get; set; }
    public int Depth { get; set; }

    public override string ToString() => $"(The submarine is {Distance} away and {Depth} deep.)";
}