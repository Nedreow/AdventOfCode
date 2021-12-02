namespace AdventOfCodeConsole.Utilities._2021;

public class AimedSubmarine : SimpleSubmarine
{
    private int _aim;

    public AimedSubmarine(int distance = 0, int depth = 0, int aim = 0) : base(distance, depth)
    {
        _aim = aim;
    }

    protected override void MoveForward(int distance)
    {
        Position.Distance += distance;
        Position.Depth = Depth + distance * _aim;
    }

    protected override void MoveBackward(int distance)
    {
        Position.Distance += distance;
        Position.Depth = Depth - distance * _aim;
    }

    protected override void MoveDownward(int distance)
    {
        _aim += distance;
    }

    protected override void MoveUpward(int distance)
    {
        _aim -= distance;
    }
}