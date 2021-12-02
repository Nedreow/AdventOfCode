namespace AdventOfCodeConsole.Utilities._2021;

public class SimpleSubmarine
{
    protected Position Position;
    
    public int Distance => Position.Distance;
    public int Depth => Position.Depth;

    public SimpleSubmarine(int distance = 0, int depth = 0)
    {
        Position = new Position(distance, depth);
    }

    public void Move(IEnumerable<string> moveCommands)
    {
        foreach (var command in moveCommands)
        {
            string[] splitCommand = command.Split(' ');

            if (splitCommand[0] == "forward")
            {
                MoveForward(int.Parse(splitCommand[1]));
            }
            if (splitCommand[0] == "backward")
            {
                MoveBackward(int.Parse(splitCommand[1]));
            }
            if (splitCommand[0] == "down")
            {
                MoveDownward(int.Parse(splitCommand[1]));
            }
            if (splitCommand[0] == "up")
            {
                MoveUpward(int.Parse(splitCommand[1]));
            }
        }
    }

    protected virtual void MoveForward(int distance)
    {
        Position.Distance += distance;
    }

    protected virtual void MoveBackward(int distance)
    {
        Position.Distance -= distance;
    }

    protected virtual void MoveDownward(int distance)
    {
        Position.Depth += distance;
    }

    protected virtual void MoveUpward(int distance)
    {
        Position.Depth -= distance;
    }
}