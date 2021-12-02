namespace AdventOfCodeConsole.Utilities._2021;

public class Submarine
{
    private Position _position;
    
    public int Distance => _position.Distance;
    public int Depth => _position.Depth;

    public Submarine(int distance = 0, int depth = 0)
    {
        _position = new Position(distance, depth);
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

    private void MoveForward(int distance)
    {
        _position.Distance += distance;
    }

    private void MoveBackward(int distance)
    {
        _position.Distance -= distance;
    }

    private void MoveDownward(int distance)
    {
        _position.Depth += distance;
    }

    private void MoveUpward(int distance)
    {
        _position.Depth -= distance;
    }
}